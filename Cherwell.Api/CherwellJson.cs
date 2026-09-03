using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

namespace Cherwell.Api;

internal static class CherwellJson
{
	public static JsonSerializerOptions CreateSerializerOptions() => CreateSerializerOptions(false);

	public static JsonSerializerOptions CreateSerializerOptions(bool writeIndented)
	{
		var resolver = new DefaultJsonTypeInfoResolver();
		resolver.Modifiers.Add(ApplyDataMemberContract);
		return new JsonSerializerOptions(JsonSerializerDefaults.Web)
		{
			TypeInfoResolver = resolver,
			WriteIndented = writeIndented
		};
	}

	private static void ApplyDataMemberContract(JsonTypeInfo typeInfo)
	{
		foreach (var property in typeInfo.Properties)
		{
			var dataMember = property.AttributeProvider?
				.GetCustomAttributes(typeof(DataMemberAttribute), true)
				.OfType<DataMemberAttribute>()
				.SingleOrDefault();
			if (dataMember is null)
			{
				continue;
			}

			if (!string.IsNullOrWhiteSpace(dataMember.Name))
			{
				property.Name = dataMember.Name;
			}

			if (!dataMember.EmitDefaultValue)
			{
				var defaultValue = GetDefaultValue(property.AttributeProvider);
				property.ShouldSerialize = (_, value) => !Equals(value, defaultValue);
			}
		}
	}

	private static object? GetDefaultValue(ICustomAttributeProvider? attributeProvider)
	{
		var memberType = attributeProvider switch
		{
			PropertyInfo property => property.PropertyType,
			FieldInfo field => field.FieldType,
			_ => null
		};
		return memberType?.IsValueType is true ? Activator.CreateInstance(memberType) : null;
	}
}
