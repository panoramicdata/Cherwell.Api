using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Approval;

/// <summary>
/// ApprovalApprovalReadResponse
/// </summary>
[DataContract]
public partial class ApprovalReadResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ApprovalReadResponse" /> class.
	/// </summary>
	/// <param name="properties">properties.</param>
	/// <param name="links">Links.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="httpStatusCode">HttpStatusCode.</param>
	public ApprovalReadResponse(
		Dictionary<string, object> properties,
		List<Link> links,
		string errorCode,
		string errorMessage,
		bool? hasError = default,
		EnumHttpStatusCode? httpStatusCode = default)
	{
		Properties = properties;
		Links = links;
		ErrorCode = errorCode;
		ErrorMessage = errorMessage;
		HasError = hasError;
		HttpStatusCode = httpStatusCode;
	}

	/// <summary>
	/// properties
	/// </summary>
	[DataMember(Name = "properties", EmitDefaultValue = false)]
	public Dictionary<string, object> Properties { get; set; }

	/// <summary>
	/// Links
	/// </summary>
	[DataMember(Name = "links", EmitDefaultValue = false)]
	public List<Link> Links { get; set; }

	/// <summary>
	/// Returns true if ApprovalApprovalReadResponse instances are equal
	/// </summary>
	/// <param name="other">Instance of ApprovalApprovalReadResponse to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(ApprovalReadResponse? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					Properties == other.Properties ||
					Properties != null &&
					Properties.SequenceEqual(other.Properties)
				) &&
				(
					Links == other.Links ||
					Links != null &&
					Links.SequenceEqual(other.Links)
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
			if (Properties != null)
			{
				hash = hash * 59 + Properties.GetHashCode();
			}

			if (Links != null)
			{
				hash = hash * 59 + Links.GetHashCode();
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
