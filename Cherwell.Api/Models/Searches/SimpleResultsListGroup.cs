using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesSimpleResultsListGroup
/// </summary>
[DataContract]
public partial class SimpleResultsListGroup : IEquatable<SimpleResultsListGroup>, IValidatableObject
{
	/// <summary>
	/// HttpStatusCode
	/// </summary>
	[DataMember(Name = "httpStatusCode", EmitDefaultValue = false)]
	public EnumHttpStatusCode? HttpStatusCode { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="SimpleResultsListGroup" /> class.
	/// </summary>
	/// <param name="IsBusObTarget">IsBusObTarget.</param>
	/// <param name="SimpleResultsListItems">SimpleResultsListItems.</param>
	/// <param name="SubTitle">SubTitle.</param>
	/// <param name="TargetId">TargetId.</param>
	/// <param name="Title">Title.</param>
	/// <param name="ErrorCode">ErrorCode.</param>
	/// <param name="ErrorMessage">ErrorMessage.</param>
	/// <param name="HasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public SimpleResultsListGroup(bool? IsBusObTarget, List<SimpleResultsListItem> SimpleResultsListItems, string SubTitle, string TargetId, string Title, string ErrorCode, string ErrorMessage, bool? HasError, EnumHttpStatusCode? HttpStatusCode)
	{
		this.IsBusObTarget = IsBusObTarget;
		this.SimpleResultsListItems = SimpleResultsListItems;
		this.SubTitle = SubTitle;
		this.TargetId = TargetId;
		this.Title = Title;
		this.ErrorCode = ErrorCode;
		this.ErrorMessage = ErrorMessage;
		this.HasError = HasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// IsBusObTarget
	/// </summary>
	[DataMember(Name = "isBusObTarget", EmitDefaultValue = false)]
	public bool? IsBusObTarget { get; set; }

	/// <summary>
	/// SimpleResultsListItems
	/// </summary>
	[DataMember(Name = "simpleResultsListItems", EmitDefaultValue = false)]
	public List<SimpleResultsListItem> SimpleResultsListItems { get; set; }

	/// <summary>
	/// SubTitle
	/// </summary>
	[DataMember(Name = "subTitle", EmitDefaultValue = false)]
	public string SubTitle { get; set; }

	/// <summary>
	/// TargetId
	/// </summary>
	[DataMember(Name = "targetId", EmitDefaultValue = false)]
	public string TargetId { get; set; }

	/// <summary>
	/// Title
	/// </summary>
	[DataMember(Name = "title", EmitDefaultValue = false)]
	public string Title { get; set; }

	/// <summary>
	/// ErrorCode
	/// </summary>
	[DataMember(Name = "errorCode", EmitDefaultValue = false)]
	public string ErrorCode { get; set; }

	/// <summary>
	/// ErrorMessage
	/// </summary>
	[DataMember(Name = "errorMessage", EmitDefaultValue = false)]
	public string ErrorMessage { get; set; }

	/// <summary>
	/// HasError
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
		sb.Append("class SearchesSimpleResultsListGroup {\n");
		sb.Append("  IsBusObTarget: ").Append(IsBusObTarget).Append('\n');
		sb.Append("  SimpleResultsListItems: ").Append(SimpleResultsListItems).Append('\n');
		sb.Append("  SubTitle: ").Append(SubTitle).Append('\n');
		sb.Append("  TargetId: ").Append(TargetId).Append('\n');
		sb.Append("  Title: ").Append(Title).Append('\n');
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
		return Equals(obj as SimpleResultsListGroup);
	}

	/// <summary>
	/// Returns true if SearchesSimpleResultsListGroup instances are equal
	/// </summary>
	/// <param name="other">Instance of SearchesSimpleResultsListGroup to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(SimpleResultsListGroup? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					IsBusObTarget == other.IsBusObTarget ||
					IsBusObTarget != null &&
					IsBusObTarget.Equals(other.IsBusObTarget)
				) &&
				(
					SimpleResultsListItems == other.SimpleResultsListItems ||
					SimpleResultsListItems != null &&
					SimpleResultsListItems.SequenceEqual(other.SimpleResultsListItems)
				) &&
				(
					SubTitle == other.SubTitle ||
					SubTitle != null &&
					SubTitle.Equals(other.SubTitle, StringComparison.Ordinal)
				) &&
				(
					TargetId == other.TargetId ||
					TargetId != null &&
					TargetId.Equals(other.TargetId, StringComparison.Ordinal)
				) &&
				(
					Title == other.Title ||
					Title != null &&
					Title.Equals(other.Title, StringComparison.Ordinal)
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
			if (IsBusObTarget != null)
			{
				hash = hash * 59 + IsBusObTarget.GetHashCode();
			}

			if (SimpleResultsListItems != null)
			{
				hash = hash * 59 + SimpleResultsListItems.GetHashCode();
			}

			if (SubTitle != null)
			{
				hash = hash * 59 + SubTitle.GetHashCode();
			}

			if (TargetId != null)
			{
				hash = hash * 59 + TargetId.GetHashCode();
			}

			if (Title != null)
			{
				hash = hash * 59 + Title.GetHashCode();
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
