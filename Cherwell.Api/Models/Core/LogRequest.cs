using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Core;

/// <summary>
/// CoreLogRequest
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
	public EnumLevel? Level { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="LogRequest" /> class.
	/// </summary>
	/// <param name="keyValueproperties">keyValueproperties.</param>
	/// <param name="Level">Level.</param>
	/// <param name="Message">Message.</param>
	public LogRequest(List<object> keyValueproperties, EnumLevel? Level, string Message)
	{
		this.keyValueproperties = keyValueproperties;
		this.Level = Level;
		this.Message = Message;
	}

	/// <summary>
	/// keyValueproperties
	/// </summary>
	[DataMember(Name = "keyValueproperties", EmitDefaultValue = false)]
	public List<object> keyValueproperties { get; set; }

	/// <summary>
	/// Message
	/// </summary>
	[DataMember(Name = "message", EmitDefaultValue = false)]
	public string Message { get; set; }







	/// <summary>
	/// Gets the hash code
	/// </summary>
	/// <returns>Hash code</returns>
	public override int GetHashCode()
	{
		// credit: http://stackoverflow.com/a/263416/677735
		unchecked // Overflow is fine, just wrap
		{
			int hash = 41;
			// Suitable nullity checks etc, of course :)
			return hash;
		}
	}

	
}
