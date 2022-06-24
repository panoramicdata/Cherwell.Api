using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Teams;

/// <summary>
/// TeamResponse
/// </summary>
[DataContract]
public partial class TeamResponse : IEquatable<TeamResponse>, IValidatableObject
{
	/// <summary>
	/// Gets or Sets TeamType
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnumTeamType
	{

		/// <summary>
		/// Enum User for "User"
		/// </summary>
		[EnumMember(Value = "User")]
		User,

		/// <summary>
		/// Enum CustomerWorkgroup for "CustomerWorkgroup"
		/// </summary>
		[EnumMember(Value = "CustomerWorkgroup")]
		CustomerWorkgroup
	}

	/// <summary>
	/// Gets or Sets TeamType
	/// </summary>
	[DataMember(Name = "teamType", EmitDefaultValue = false)]
	public EnumTeamType? TeamType { get; set; }

	/// <summary>
	/// Gets or Sets HttpStatusCode
	/// </summary>
	[DataMember(Name = "httpStatusCode", EmitDefaultValue = false)]
	public EnumHttpStatusCode? HttpStatusCode { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="TeamResponse" /> class.
	/// </summary>
	/// <param name="Description">Description.</param>
	/// <param name="EmailAlias">EmailAlias.</param>
	/// <param name="Fields">Fields.</param>
	/// <param name="Image">Image.</param>
	/// <param name="Name">Name.</param>
	/// <param name="TeamId">TeamId.</param>
	/// <param name="TeamType">TeamType.</param>
	/// <param name="ErrorCode">ErrorCode.</param>
	/// <param name="ErrorMessage">ErrorMessage.</param>
	/// <param name="HasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public TeamResponse(string Description, string EmailAlias, List<FieldTemplateItem> Fields, string Image, string Name, string TeamId, EnumTeamType? TeamType, string ErrorCode, string ErrorMessage, bool? HasError, EnumHttpStatusCode? HttpStatusCode)
	{
		this.Description = Description;
		this.EmailAlias = EmailAlias;
		this.Fields = Fields;
		this.Image = Image;
		this.Name = Name;
		this.TeamId = TeamId;
		this.TeamType = TeamType;
		this.ErrorCode = ErrorCode;
		this.ErrorMessage = ErrorMessage;
		this.HasError = HasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// Gets or Sets Description
	/// </summary>
	[DataMember(Name = "description", EmitDefaultValue = false)]
	public string Description { get; set; }

	/// <summary>
	/// Gets or Sets EmailAlias
	/// </summary>
	[DataMember(Name = "emailAlias", EmitDefaultValue = false)]
	public string EmailAlias { get; set; }

	/// <summary>
	/// Gets or Sets Fields
	/// </summary>
	[DataMember(Name = "fields", EmitDefaultValue = false)]
	public List<FieldTemplateItem> Fields { get; set; }

	/// <summary>
	/// Gets or Sets Image
	/// </summary>
	[DataMember(Name = "image", EmitDefaultValue = false)]
	public string Image { get; set; }

	/// <summary>
	/// Gets or Sets Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; }

	/// <summary>
	/// Gets or Sets TeamId
	/// </summary>
	[DataMember(Name = "teamId", EmitDefaultValue = false)]
	public string TeamId { get; set; }

	/// <summary>
	/// Gets or Sets ErrorCode
	/// </summary>
	[DataMember(Name = "errorCode", EmitDefaultValue = false)]
	public string ErrorCode { get; set; }

	/// <summary>
	/// Gets or Sets ErrorMessage
	/// </summary>
	[DataMember(Name = "errorMessage", EmitDefaultValue = false)]
	public string ErrorMessage { get; set; }

	/// <summary>
	/// Gets or Sets HasError
	/// </summary>
	[DataMember(Name = "hasError", EmitDefaultValue = false)]
	public bool? HasError { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class TeamsTeamResponse {\n");
		sb.Append("  Description: ").Append(Description).Append('\n');
		sb.Append("  EmailAlias: ").Append(EmailAlias).Append('\n');
		sb.Append("  Fields: ").Append(Fields).Append('\n');
		sb.Append("  Image: ").Append(Image).Append('\n');
		sb.Append("  Name: ").Append(Name).Append('\n');
		sb.Append("  TeamId: ").Append(TeamId).Append('\n');
		sb.Append("  TeamType: ").Append(TeamType).Append('\n');
		sb.Append("  ErrorCode: ").Append(ErrorCode).Append('\n');
		sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append('\n');
		sb.Append("  HasError: ").Append(HasError).Append('\n');
		sb.Append("  HttpStatusCode: ").Append(HttpStatusCode).Append('\n');
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
		return Equals(obj as TeamResponse);
	}

	/// <summary>
	/// Returns true if TeamResponse instances are equal
	/// </summary>
	/// <param name="other">Instance of TeamResponse to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(TeamResponse? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					Description == other.Description ||
					Description != null &&
					Description.Equals(other.Description, StringComparison.Ordinal)
				) &&
				(
					EmailAlias == other.EmailAlias ||
					EmailAlias != null &&
					EmailAlias.Equals(other.EmailAlias, StringComparison.Ordinal)
				) &&
				(
					Fields == other.Fields ||
					Fields != null &&
					Fields.SequenceEqual(other.Fields)
				) &&
				(
					Image == other.Image ||
					Image != null &&
					Image.Equals(other.Image, StringComparison.Ordinal)
				) &&
				(
					Name == other.Name ||
					Name != null &&
					Name.Equals(other.Name, StringComparison.Ordinal)
				) &&
				(
					TeamId == other.TeamId ||
					TeamId != null &&
					TeamId.Equals(other.TeamId, StringComparison.Ordinal)
				) &&
				(
					TeamType == other.TeamType ||
					TeamType != null &&
					TeamType.Equals(other.TeamType)
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
			if (Description != null)
			{
				hash = hash * 59 + Description.GetHashCode();
			}

			if (EmailAlias != null)
			{
				hash = hash * 59 + EmailAlias.GetHashCode();
			}

			if (Fields != null)
			{
				hash = hash * 59 + Fields.GetHashCode();
			}

			if (Image != null)
			{
				hash = hash * 59 + Image.GetHashCode();
			}

			if (Name != null)
			{
				hash = hash * 59 + Name.GetHashCode();
			}

			if (TeamId != null)
			{
				hash = hash * 59 + TeamId.GetHashCode();
			}

			if (TeamType != null)
			{
				hash = hash * 59 + TeamType.GetHashCode();
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

