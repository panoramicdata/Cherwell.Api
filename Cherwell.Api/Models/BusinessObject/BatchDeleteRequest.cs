using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectBatchDeleteRequest
/// </summary>
[DataContract]
public partial class BatchDeleteRequest
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

	
}