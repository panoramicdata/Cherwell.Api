using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectBatchDeleteRequest
/// </summary>
[DataContract]
public partial class BatchDeleteRequest : IEquatable<BatchDeleteRequest>, IValidatableObject
{
	/// <summary>
	/// Initializes a new instance of the <see cref="BatchDeleteRequest" /> class.
	/// </summary>
	/// <param name="DeleteRequests">DeleteRequests.</param>
	/// <param name="StopOnError">StopOnError.</param>
	public BatchDeleteRequest(List<DeleteRequest> DeleteRequests, bool? StopOnError)
	{
		this.DeleteRequests = DeleteRequests;
		this.StopOnError = StopOnError;
	}

	/// <summary>
	/// DeleteRequests
	/// </summary>
	[DataMember(Name = "deleteRequests", EmitDefaultValue = false)]
	public List<DeleteRequest> DeleteRequests { get; set; }

	/// <summary>
	/// StopOnError
	/// </summary>
	[DataMember(Name = "stopOnError", EmitDefaultValue = false)]
	public bool? StopOnError { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class BusinessObjectBatchDeleteRequest {\n");
		sb.Append("  DeleteRequests: ").Append(DeleteRequests).Append('\n');
		sb.Append("  StopOnError: ").Append(StopOnError).Append('\n');
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
		return Equals(obj as BatchDeleteRequest);
	}

	/// <summary>
	/// Returns true if BusinessObjectBatchDeleteRequest instances are equal
	/// </summary>
	/// <param name="other">Instance of BusinessObjectBatchDeleteRequest to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(BatchDeleteRequest? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					DeleteRequests == other.DeleteRequests ||
					DeleteRequests != null &&
					DeleteRequests.SequenceEqual(other.DeleteRequests)
				) &&
				(
					StopOnError == other.StopOnError ||
					StopOnError != null &&
					StopOnError.Equals(other.StopOnError)
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
			if (DeleteRequests != null)
			{
				hash = hash * 59 + DeleteRequests.GetHashCode();
			}

			if (StopOnError != null)
			{
				hash = hash * 59 + StopOnError.GetHashCode();
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