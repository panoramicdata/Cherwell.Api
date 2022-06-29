using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.OneStepActions;

/// <summary>
/// OneStepActionsOneStepActionResponse
/// </summary>
[DataContract]
public partial class OneStepActionResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="OneStepActionResponse" /> class.
	/// </summary>
	/// <param name="Completed">Completed.</param>
	/// <param name="CurrentPrimaryBusObId">CurrentPrimaryBusObId.</param>
	/// <param name="CurrentPrimaryBusObRecId">CurrentPrimaryBusObRecId.</param>
	/// <param name="HasNewAccessToken">HasNewAccessToken.</param>
	/// <param name="NewAccessToken">NewAccessToken.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public OneStepActionResponse(bool? Completed, string CurrentPrimaryBusObId, string CurrentPrimaryBusObRecId, bool? HasNewAccessToken, string NewAccessToken, string errorCode, string errorMessage, bool? hasError, EnumHttpStatusCode HttpStatusCode)
	{
		this.Completed = Completed;
		this.CurrentPrimaryBusObId = CurrentPrimaryBusObId;
		this.CurrentPrimaryBusObRecId = CurrentPrimaryBusObRecId;
		this.HasNewAccessToken = HasNewAccessToken;
		this.NewAccessToken = NewAccessToken;
		this.ErrorCode = errorCode;
		this.ErrorMessage = errorMessage;
		this.HasError = hasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// Completed
	/// </summary>
	[DataMember(Name = "completed", EmitDefaultValue = false)]
	public bool? Completed { get; set; }

	/// <summary>
	/// CurrentPrimaryBusObId
	/// </summary>
	[DataMember(Name = "currentPrimaryBusObId", EmitDefaultValue = false)]
	public string CurrentPrimaryBusObId { get; set; }

	/// <summary>
	/// CurrentPrimaryBusObRecId
	/// </summary>
	[DataMember(Name = "currentPrimaryBusObRecId", EmitDefaultValue = false)]
	public string CurrentPrimaryBusObRecId { get; set; }

	/// <summary>
	/// HasNewAccessToken
	/// </summary>
	[DataMember(Name = "hasNewAccessToken", EmitDefaultValue = false)]
	public bool? HasNewAccessToken { get; set; }

	/// <summary>
	/// NewAccessToken
	/// </summary>
	[DataMember(Name = "newAccessToken", EmitDefaultValue = false)]
	public string NewAccessToken { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class OneStepActionsOneStepActionResponse {\n");
		sb.Append("  Completed: ").Append(Completed).Append('\n');
		sb.Append("  CurrentPrimaryBusObId: ").Append(CurrentPrimaryBusObId).Append('\n');
		sb.Append("  CurrentPrimaryBusObRecId: ").Append(CurrentPrimaryBusObRecId).Append('\n');
		sb.Append("  HasNewAccessToken: ").Append(HasNewAccessToken).Append('\n');
		sb.Append("  NewAccessToken: ").Append(NewAccessToken).Append('\n');
		sb.Append("  ErrorCode: ").Append(ErrorCode).Append('\n');
		sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append('\n');
		sb.Append("  HasError: ").Append(HasError).Append('\n');
		sb.Append("  HttpStatusCode: ").Append(HttpStatusCode).Append('\n');
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
			if (Completed != null)
			{
				hash = hash * 59 + Completed.GetHashCode();
			}

			if (CurrentPrimaryBusObId != null)
			{
				hash = hash * 59 + CurrentPrimaryBusObId.GetHashCode();
			}

			if (CurrentPrimaryBusObRecId != null)
			{
				hash = hash * 59 + CurrentPrimaryBusObRecId.GetHashCode();
			}

			if (HasNewAccessToken != null)
			{
				hash = hash * 59 + HasNewAccessToken.GetHashCode();
			}

			if (NewAccessToken != null)
			{
				hash = hash * 59 + NewAccessToken.GetHashCode();
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
