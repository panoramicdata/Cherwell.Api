using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Core;

/// <summary>
/// LogRequest
/// </summary>
[DataContract]
public partial class LogRequest
{
	/// <summary>
	/// Level
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnumLevel
	{

		/// <summary>
		/// Enum Fatal for "Fatal"
		/// </summary>
		[EnumMember(Value = "Fatal")]
		Fatal,

		/// <summary>
		/// Enum Error for "Error"
		/// </summary>
		[EnumMember(Value = "Error")]
		Error,

		/// <summary>
		/// Enum Warning for "Warning"
		/// </summary>
		[EnumMember(Value = "Warning")]
		Warning,

		/// <summary>
		/// Enum Info for "Info"
		/// </summary>
		[EnumMember(Value = "Info")]
		Info,

		/// <summary>
		/// Enum Stats for "Stats"
		/// </summary>
		[EnumMember(Value = "Stats")]
		Stats,

		/// <summary>
		/// Enum Debug for "Debug"
		/// </summary>
		[EnumMember(Value = "Debug")]
		Debug
	}

	/// <summary>
	/// Level
	/// </summary>
	[DataMember(Name = "level", EmitDefaultValue = false)]
	public EnumLevel Level { get; set; }
	/// <summary>
	/// keyValueproperties
	/// </summary>
	[DataMember(Name = "keyValueproperties", EmitDefaultValue = false)]
	public List<object> keyValueproperties { get; set; } = null!;

	/// <summary>
	/// Message
	/// </summary>
	[DataMember(Name = "message", EmitDefaultValue = false)]
	public string Message { get; set; } = null!;
}
