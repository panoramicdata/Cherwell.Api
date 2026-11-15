using System.Collections;
using System.Globalization;
using System.Reflection;
using System.Text.Json;

namespace Cherwell.Api.Test;

public class ModelRoundTripTests
{
	private static readonly Assembly ApiAssembly = typeof(CherwellClient).Assembly;

	public static TheoryData<Type> ModelTypes()
	{
		var data = new TheoryData<Type>();
		foreach (var type in ApiAssembly.GetExportedTypes()
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
		foreach (var property in WritableProperties(type))
		{
			var value = Sample(property.PropertyType, 0);
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
		var instance = Activator.CreateInstance(type)!;
		foreach (var property in WritableProperties(type))
		{
			property.SetValue(instance, Sample(property.PropertyType, 0));
		}

		var options = CherwellJson.CreateSerializerOptions();
		var json = JsonSerializer.Serialize(instance, type, options);
		var copy = JsonSerializer.Deserialize(json, type, options);

		copy.Should().NotBeNull();
		JsonSerializer.Serialize(copy, type, options).Should().Be(json);
	}

	private static IEnumerable<PropertyInfo> WritableProperties(Type type) => type
		.GetProperties(BindingFlags.Public | BindingFlags.Instance)
		.Where(p => p.CanRead && p.CanWrite && p.GetIndexParameters().Length == 0);

	private static object? Sample(Type type, int depth)
	{
		var target = Nullable.GetUnderlyingType(type) ?? type;
		return SimpleSample(target) ?? CollectionSample(target, depth) ?? ObjectSample(target, depth);
	}

	private static object? SimpleSample(Type type)
	{
		if (type == typeof(string) || type == typeof(object))
		{
			return "sample";
		}

		if (type.IsEnum)
		{
			return Enum.GetValues(type).Cast<object>().LastOrDefault();
		}

		if (type == typeof(bool))
		{
			return true;
		}

		if (type == typeof(DateTime))
		{
			return new DateTime(2024, 5, 6, 7, 8, 9, DateTimeKind.Utc);
		}

		if (type == typeof(Guid))
		{
			return new Guid("11111111-2222-3333-4444-555555555555");
		}

		return type.IsPrimitive || type == typeof(decimal)
			? Convert.ChangeType(7, type, CultureInfo.InvariantCulture)
			: null;
	}

	private static object? CollectionSample(Type type, int depth)
	{
		if (type.IsArray)
		{
			var array = Array.CreateInstance(type.GetElementType()!, 1);
			array.SetValue(Sample(type.GetElementType()!, depth + 1), 0);
			return array;
		}

		if (!type.IsGenericType)
		{
			return null;
		}

		var arguments = type.GetGenericArguments();
		var definition = type.GetGenericTypeDefinition();
		if (definition == typeof(List<>) || definition == typeof(IList<>) || definition == typeof(IEnumerable<>) || definition == typeof(ICollection<>))
		{
			var list = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(arguments[0]))!;
			if (depth < 2)
			{
				list.Add(Sample(arguments[0], depth + 1));
			}

			return list;
		}

		if (definition == typeof(Dictionary<,>) || definition == typeof(IDictionary<,>))
		{
			var dictionary = (IDictionary)Activator.CreateInstance(typeof(Dictionary<,>).MakeGenericType(arguments))!;
			dictionary.Add(Sample(arguments[0], depth + 1)!, Sample(arguments[1], depth + 1));
			return dictionary;
		}

		return null;
	}

	private static object? ObjectSample(Type type, int depth)
	{
		if (!type.IsClass || type.IsAbstract || depth >= 2 || type.GetConstructor(Type.EmptyTypes) is null)
		{
			return null;
		}

		var instance = Activator.CreateInstance(type)!;
		foreach (var property in WritableProperties(type))
		{
			property.SetValue(instance, Sample(property.PropertyType, depth + 1));
		}

		return instance;
	}
}
