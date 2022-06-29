using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Users;

/// <summary>
/// UserSaveResponse
/// </summary>
[DataContract]
public partial class UserSaveResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="UserSaveResponse" /> class.
	/// </summary>
	/// <param name="BusObPublicId">BusObPublicId.</param>
	/// <param name="BusObRecId">BusObRecId.</param>
	/// <param name="Error">Error.</param>
	/// <param name="ErrorCode">ErrorCode.</param>
	/// <param name="HasError">HasError.</param>
	public UserSaveResponse(string BusObPublicId, string BusObRecId, string error, string errorCode, bool? hasError)
	{
		this.BusObPublicId = BusObPublicId;
		this.BusObRecId = BusObRecId;
		this.Error = error;
		this.ErrorCode = errorCode;
		this.HasError = hasError;
	}

	/// <summary>
	/// BusObPublicId
	/// </summary>
	[DataMember(Name = "busObPublicId", EmitDefaultValue = false)]
	public string BusObPublicId { get; set; }

	/// <summary>
	/// BusObRecId
	/// </summary>
	[DataMember(Name = "busObRecId", EmitDefaultValue = false)]
	public string BusObRecId { get; set; }

	/// <summary>
	/// Error
	/// </summary>
	[DataMember(Name = "error", EmitDefaultValue = false)]
	public string Error { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class UserSaveResponse {\n");
		sb.Append("  BusObPublicId: ").Append(BusObPublicId).Append('\n');
		sb.Append("  BusObRecId: ").Append(BusObRecId).Append('\n');
		sb.Append("  Error: ").Append(Error).Append('\n');
		sb.Append("  ErrorCode: ").Append(ErrorCode).Append('\n');
		sb.Append("  HasError: ").Append(HasError).Append('\n');
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
			if (BusObPublicId != null)
			{
				hash = hash * 59 + BusObPublicId.GetHashCode();
			}

			if (BusObRecId != null)
			{
				hash = hash * 59 + BusObRecId.GetHashCode();
			}

			if (Error != null)
			{
				hash = hash * 59 + Error.GetHashCode();
			}

			if (ErrorCode != null)
			{
				hash = hash * 59 + ErrorCode.GetHashCode();
			}

			if (HasError != null)
			{
				hash = hash * 59 + HasError.GetHashCode();
			}

			return hash;
		}
	}

	
}