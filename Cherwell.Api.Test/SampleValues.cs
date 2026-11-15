using System.Collections;
using System.Globalization;
using System.Reflection;

namespace Cherwell.Api.Test;

internal static class SampleValues
{
	private const int MaxDepth = 2;

	public static IEnumerable<PropertyInfo> WritableProperties(Type type) => type
		.GetProperties(BindingFlags.Public | BindingFlags.Instance)
		.Where(p => p.CanRead && p.CanWrite && p.GetIndexParameters().Length == 0);

	public static object? For(Type type, int depth)
	{
		var target = Nullable.GetUnderlyingType(type) ?? type;
		return Scalar(target) ?? Array(target, depth) ?? Generic(target, depth) ?? Instance(target, depth);
	}

	private static object? Scalar(Type type)
	{
		if (type == typeof(string) || type == typeof(object))
		{
			return "sample";
		}

		if (type.IsEnum)
		{
			return Enum.GetValues(type).Cast<object>().LastOrDefault();
		}

		return Known(type) ?? Numeric(type);
	}

	private static object? Known(Type type) => type switch
	{
		_ when type == typeof(bool) => true,
		_ when type == typeof(DateTime) => new DateTime(2024, 5, 6, 7, 8, 9, DateTimeKind.Utc),
		_ when type == typeof(Guid) => new Guid("11111111-2222-3333-4444-555555555555"),
		_ => null
	};

	private static object? Numeric(Type type) => type.IsPrimitive || type == typeof(decimal)
		? Convert.ChangeType(7, type, CultureInfo.InvariantCulture)
		: null;

	private static System.Array? Array(Type type, int depth)
	{
		if (!type.IsArray)
		{
			return null;
		}

		var element = type.GetElementType()!;
		var array = System.Array.CreateInstance(element, 1);
		array.SetValue(For(element, depth + 1), 0);
		return array;
	}

	private static object? Generic(Type type, int depth)
	{
		if (!type.IsGenericType)
		{
			return null;
		}

		var arguments = type.GetGenericArguments();
		return type.GetGenericTypeDefinition().Name switch
		{
			"List`1" or "IList`1" or "IEnumerable`1" or "ICollection`1" => ListOf(arguments[0], depth),
			"Dictionary`2" or "IDictionary`2" => DictionaryOf(arguments, depth),
			_ => null
		};
	}

	private static IList ListOf(Type element, int depth)
	{
		var list = (IList)Create(typeof(List<>).MakeGenericType(element));
		if (depth < MaxDepth)
		{
			list.Add(For(element, depth + 1));
		}

		return list;
	}

	private static IDictionary DictionaryOf(Type[] arguments, int depth)
	{
		var dictionary = (IDictionary)Create(typeof(Dictionary<,>).MakeGenericType(arguments));
		dictionary.Add(For(arguments[0], depth + 1)!, For(arguments[1], depth + 1));
		return dictionary;
	}

	private static object? Instance(Type type, int depth)
	{
		if (!type.IsClass || type.IsAbstract || depth >= MaxDepth || type.GetConstructor(Type.EmptyTypes) is null)
		{
			return null;
		}

		var instance = Create(type);
		foreach (var property in WritableProperties(type))
		{
			property.SetValue(instance, For(property.PropertyType, depth + 1));
		}

		return instance;
	}

	private static object Create(Type type) => Activator.CreateInstance(type)
		?? throw new InvalidOperationException($"Could not create {type}.");
}
