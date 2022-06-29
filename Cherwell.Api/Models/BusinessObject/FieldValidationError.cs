using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectFieldValidationError
/// </summary>
[DataContract]
public partial class FieldValidationError : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="FieldValidationError" /> class.
	/// </summary>
	/// <param name="Error">Error.</param>
	/// <param name="ErrorCode">ErrorCode.</param>
	/// <param name="FieldId">FieldId.</param>
	public FieldValidationError(string error, string errorCode, string FieldId)
	{
		this.Error = error;
		this.ErrorCode = errorCode;
		this.FieldId = FieldId;
	}

	/// <summary>
	/// Error
	/// </summary>
	[DataMember(Name = "error", EmitDefaultValue = false)]
	public string Error { get; set; }

	/// <summary>
	/// FieldId
	/// </summary>
	[DataMember(Name = "fieldId", EmitDefaultValue = false)]
	public string FieldId { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class BusinessObjectFieldValidationError {\n");
		sb.Append("  Error: ").Append(Error).Append('\n');
		sb.Append("  ErrorCode: ").Append(ErrorCode).Append('\n');
		sb.Append("  FieldId: ").Append(FieldId).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
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
			if (Error != null)
			{
				hash = hash * 59 + Error.GetHashCode();
			}

			if (ErrorCode != null)
			{
				hash = hash * 59 + ErrorCode.GetHashCode();
			}

			if (FieldId != null)
			{
				hash = hash * 59 + FieldId.GetHashCode();
			}

			return hash;
		}
	}

	
}