using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Teams;

/// <summary>
/// RemoveCustomerFromWorkgroupResponse
/// </summary>
[DataContract]
public partial class RemoveCustomerFromWorkgroupResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="RemoveCustomerFromWorkgroupResponse" /> class.
	/// </summary>
	/// <param name="WorkgroupId">WorkgroupId.</param>
	/// <param name="CustomerRecordId">CustomerRecordId.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public RemoveCustomerFromWorkgroupResponse(string WorkgroupId, string CustomerRecordId, string errorCode, string errorMessage, bool? hasError, EnumHttpStatusCode HttpStatusCode)
	{
		this.WorkgroupId = WorkgroupId;
		this.CustomerRecordId = CustomerRecordId;
		this.ErrorCode = errorCode;
		this.ErrorMessage = errorMessage;
		this.HasError = hasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// WorkgroupId
	/// </summary>
	[DataMember(Name = "workgroupId", EmitDefaultValue = false)]
	public string WorkgroupId { get; set; }

	/// <summary>
	/// CustomerRecordId
	/// </summary>
	[DataMember(Name = "customerRecordId", EmitDefaultValue = false)]
	public string CustomerRecordId { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class TeamsRemoveCustomerFromWorkgroupResponse {\n");
		sb.Append("  WorkgroupId: ").Append(WorkgroupId).Append('\n');
		sb.Append("  CustomerRecordId: ").Append(CustomerRecordId).Append('\n');
		sb.Append("  ErrorCode: ").Append(ErrorCode).Append('\n');
		sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append('\n');
		sb.Append("  HasError: ").Append(HasError).Append('\n');
		sb.Append("  HttpStatusCode: ").Append(HttpStatusCode).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns true if RemoveCustomerFromWorkgroupResponse instances are equal
	/// </summary>
	/// <param name="other">Instance of RemoveCustomerFromWorkgroupResponse to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(RemoveCustomerFromWorkgroupResponse? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					WorkgroupId == other.WorkgroupId ||
					WorkgroupId != null &&
					WorkgroupId.Equals(other.WorkgroupId, StringComparison.Ordinal)
				) &&
				(
					CustomerRecordId == other.CustomerRecordId ||
					CustomerRecordId != null &&
					CustomerRecordId.Equals(other.CustomerRecordId, StringComparison.Ordinal)
				) &&
				(
					ErrorCode == other.ErrorCode ||
					ErrorCode != null &&
					ErrorCode.Equals(other.ErrorCode, StringComparison.Ordinal)
				) &&
				(
					ErrorMessage == other.ErrorMessage ||
					ErrorMessage != null &&
					ErrorMessage.Equals(other.ErrorMessage, StringComparison.Ordinal)
				) &&
				(
					HasError == other.HasError ||
					HasError != null &&
					HasError.Equals(other.HasError)
				) &&
				(
					HttpStatusCode == other.HttpStatusCode ||
					HttpStatusCode != null &&
					HttpStatusCode.Equals(other.HttpStatusCode)
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
			if (WorkgroupId != null)
			{
				hash = hash * 59 + WorkgroupId.GetHashCode();
			}

			if (CustomerRecordId != null)
			{
				hash = hash * 59 + CustomerRecordId.GetHashCode();
			}

			if (ErrorCode != null)
			{
				hash = hash * 59 + ErrorCode.GetHashCode();
			}

			if (ErrorMessage != null)
			{
				hash = hash * 59 + ErrorMessage.GetHashCode();
			}

			if (HasError != null)
			{
				hash = hash * 59 + HasError.GetHashCode();
			}

			if (HttpStatusCode != null)
			{
				hash = hash * 59 + HttpStatusCode.GetHashCode();
			}

			return hash;
		}
	}

	
}

