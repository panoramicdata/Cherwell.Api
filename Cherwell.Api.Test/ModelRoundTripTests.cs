using System.Reflection;
using System.Text.Json;

namespace Cherwell.Api.Test;

public class ModelRoundTripTests
{
	public static TheoryData<Type> ModelTypes()
	{
		var data = new TheoryData<Type>();
		foreach (var type in typeof(CherwellClient).Assembly.GetExportedTypes()
			.Where(t => t.IsClass && !t.IsAbstract && t.Namespace?.StartsWith("Cherwell.Api.Models", StringComparison.Ordinal) == true)
			.Where(t => t.GetConstructor(Type.EmptyTypes) is not null)
			.OrderBy(t => t.FullName, StringComparer.Ordinal))
		{
			data.Add(type);
		}

		return data;
	}

	/// <summary>
	/// Every writable property of a model reads back the value that was set.
	/// </summary>
	[Theory]
	[MemberData(nameof(ModelTypes))]
	public void Properties_SettingValues_ReadBack(Type type)
	{
		var instance = Activator.CreateInstance(type)!;
		var expected = new Dictionary<PropertyInfo, object?>();
		foreach (var property in SampleValues.WritableProperties(type))
		{
			var value = SampleValues.For(property.PropertyType, 0);
			property.SetValue(instance, value);
			expected[property] = value;
		}

		foreach (var (property, value) in expected)
		{
			property.GetValue(instance).Should().Be(value, $"{type.Name}.{property.Name}");
		}
	}

	/// <summary>
	/// A populated model survives serialisation with the client's options: serialising the copy gives the same JSON.
	/// </summary>
	[Theory]
	[MemberData(nameof(ModelTypes))]
	public void Json_RoundTrip_IsStable(Type type)
	{
		var instance = SampleValues.For(type, 0)!;
		var options = CherwellJson.CreateSerializerOptions();
		var json = JsonSerializer.Serialize(instance, type, options);
		var copy = JsonSerializer.Deserialize(json, type, options);

		copy.Should().NotBeNull();
		JsonSerializer.Serialize(copy, type, options).Should().Be(json);
	}
}
