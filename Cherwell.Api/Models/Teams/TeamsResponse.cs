using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Teams;

/// <summary>
/// TeamsResponse
/// </summary>
[DataContract]
public partial class TeamsResponse : IEquatable<TeamsResponse>, IValidatableObject
{
	/// <summary>
	/// Initializes a new instance of the <see cref="TeamsResponse" /> class.
	/// </summary>
	/// <param name="Error">Error.</param>
	/// <param name="ErrorCode">ErrorCode.</param>
	/// <param name="HasError">HasError.</param>
	/// <param name="Teams">Teams.</param>
	public TeamsResponse(string Error, string ErrorCode, bool? HasError, List<Team> Teams)
	{
		this.Error = Error;
		this.ErrorCode = ErrorCode;
		this.HasError = HasError;
		this.Teams = Teams;
	}

	/// <summary>
	/// Gets or Sets Error
	/// </summary>
	[DataMember(Name = "error", EmitDefaultValue = false)]
	public string Error { get; set; }
	/// <summary>
	/// Gets or Sets ErrorCode
	/// </summary>
	[DataMember(Name = "errorCode", EmitDefaultValue = false)]
	public string ErrorCode { get; set; }
	/// <summary>
	/// Gets or Sets HasError
	/// </summary>
	[DataMember(Name = "hasError", EmitDefaultValue = false)]
	public bool? HasError { get; set; }
	/// <summary>
	/// Gets or Sets Teams
	/// </summary>
	[DataMember(Name = "teams", EmitDefaultValue = false)]
	public List<Team> Teams { get; set; }
	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class TeamsTeamsResponse {\n");
		sb.Append("  Error: ").Append(Error).Append('\n');
		sb.Append("  ErrorCode: ").Append(ErrorCode).Append('\n');
		sb.Append("  HasError: ").Append(HasError).Append('\n');
		sb.Append("  Teams: ").Append(Teams).Append('\n');
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
		return this.Equals(obj as TeamsResponse);
	}

	/// <summary>
	/// Returns true if TeamsResponse instances are equal
	/// </summary>
	/// <param name="other">Instance of TeamsResponse to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(TeamsResponse? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					this.Error == other.Error ||
					this.Error != null &&
					this.Error.Equals(other.Error, StringComparison.Ordinal)
				) &&
				(
					this.ErrorCode == other.ErrorCode ||
					this.ErrorCode != null &&
					this.ErrorCode.Equals(other.ErrorCode, StringComparison.Ordinal)
				) &&
				(
					this.HasError == other.HasError ||
					this.HasError != null &&
					this.HasError.Equals(other.HasError)
				) &&
				(
					this.Teams == other.Teams ||
					this.Teams != null &&
					this.Teams.SequenceEqual(other.Teams)
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
			if (this.Error != null)
			{
				hash = hash * 59 + this.Error.GetHashCode();
			}

			if (this.ErrorCode != null)
			{
				hash = hash * 59 + this.ErrorCode.GetHashCode();
			}

			if (this.HasError != null)
			{
				hash = hash * 59 + this.HasError.GetHashCode();
			}

			if (this.Teams != null)
			{
				hash = hash * 59 + this.Teams.GetHashCode();
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

