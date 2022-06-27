using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectBatchDeleteResponse
/// </summary>
[DataContract]
public partial class BatchDeleteResponse : Response, IEquatable<BatchDeleteResponse>, IValidatableObject
{
	/// <summary>
	/// Initializes a new instance of the <see cref="BatchDeleteResponse" /> class.
	/// </summary>
	/// <param name="Responses">Responses.</param>
	public BatchDeleteResponse(List<DeleteResponse> Responses)
	{
		this.Responses = Responses;
	}

	/// <summary>
	/// Responses
	/// </summary>
	[DataMember(Name = "responses", EmitDefaultValue = false)]
	public List<DeleteResponse> Responses { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class BusinessObjectBatchDeleteResponse {\n");
		sb.Append("  Responses: ").Append(Responses).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns true if objects are equal
	/// </summary>
	/// <param name="obj">Object to be compared</param>
	/// <returns>Boolean</returns>
	public override bool Equals(object? obj)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		return Equals(obj as BatchDeleteResponse);
	}

	/// <summary>
	/// Returns true if BusinessObjectBatchDeleteResponse instances are equal
	/// </summary>
	/// <param name="other">Instance of BusinessObjectBatchDeleteResponse to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(BatchDeleteResponse? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					Responses == other.Responses ||
					Responses != null &&
					Responses.SequenceEqual(other.Responses)
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
			if (Responses != null)
			{
				hash = hash * 59 + Responses.GetHashCode();
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