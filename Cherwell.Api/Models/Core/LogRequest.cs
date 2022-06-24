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
public partial class LogRequest : IEquatable<LogRequest>, IValidatableObject
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
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class CoreLogRequest {\n");
		sb.Append("  keyValueproperties: ").Append(keyValueproperties).Append('\n');
		sb.Append("  Level: ").Append(Level).Append('\n');
		sb.Append("  Message: ").Append(Message).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns the JSON string presentation of the object
	/// </summary>
	/// <returns>JSON string presentation of the object</returns>
	public string ToJson()
	{
		return JsonConvert.SerializeObject(this, Formatting.Indented);
	}

	/// <summary>
	/// Returns true if objects are equal
	/// </summary>
	/// <param name="obj">Object to be compared</param>
	/// <returns>Boolean</returns>
	public override bool Equals(object? obj)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		return Equals(obj as LogRequest);
	}

	/// <summary>
	/// Returns true if CoreLogRequest instances are equal
	/// </summary>
	/// <param name="other">Instance of CoreLogRequest to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(LogRequest? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					keyValueproperties == other.keyValueproperties ||
					keyValueproperties != null &&
					keyValueproperties.SequenceEqual(other.keyValueproperties)
				) &&
				(
					Level == other.Level ||
					Level != null &&
					Level.Equals(other.Level)
				) &&
				(
					Message == other.Message ||
					Message != null &&
					Message.Equals(other.Message, StringComparison.Ordinal)
				);
	}

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
			if (keyValueproperties != null)
			{
				hash = hash * 59 + keyValueproperties.GetHashCode();
			}

			if (Level != null)
			{
				hash = hash * 59 + Level.GetHashCode();
			}

			if (Message != null)
			{
				hash = hash * 59 + Message.GetHashCode();
			}

			return hash;
		}
	}

	/// <summary>
	/// To validate all properties of the instance
	/// </summary>
	/// <param name="validationContext">Validation context</param>
	/// <returns>Validation Result</returns>
	IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
	{
		yield break;
	}
}
