using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectSaveUrlAttachmentRequest
/// </summary>
[DataContract]
public partial class SaveUrlAttachmentRequest : IEquatable<SaveUrlAttachmentRequest>, IValidatableObject
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SaveUrlAttachmentRequest" /> class.
	/// </summary>
	/// <param name="BusObId">BusObId.</param>
	/// <param name="BusObName">BusObName.</param>
	/// <param name="BusObPublicId">BusObPublicId.</param>
	/// <param name="BusObRecId">BusObRecId.</param>
	/// <param name="Comment">Comment.</param>
	/// <param name="DisplayText">DisplayText.</param>
	/// <param name="IncludeLinks">IncludeLinks.</param>
	/// <param name="Url">Url.</param>
	public SaveUrlAttachmentRequest(string BusObId, string BusObName, string BusObPublicId, string BusObRecId, string Comment, string DisplayText, bool? IncludeLinks, string Url)
	{
		this.BusObId = BusObId;
		this.BusObName = BusObName;
		this.BusObPublicId = BusObPublicId;
		this.BusObRecId = BusObRecId;
		this.Comment = Comment;
		this.DisplayText = DisplayText;
		this.IncludeLinks = IncludeLinks;
		this.Url = Url;
	}

	/// <summary>
	/// BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; }

	/// <summary>
	/// BusObName
	/// </summary>
	[DataMember(Name = "busObName", EmitDefaultValue = false)]
	public string BusObName { get; set; }

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
	/// Comment
	/// </summary>
	[DataMember(Name = "comment", EmitDefaultValue = false)]
	public string Comment { get; set; }

	/// <summary>
	/// DisplayText
	/// </summary>
	[DataMember(Name = "displayText", EmitDefaultValue = false)]
	public string DisplayText { get; set; }

	/// <summary>
	/// IncludeLinks
	/// </summary>
	[DataMember(Name = "includeLinks", EmitDefaultValue = false)]
	public bool? IncludeLinks { get; set; }

	/// <summary>
	/// Url
	/// </summary>
	[DataMember(Name = "url", EmitDefaultValue = false)]
	public string Url { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class BusinessObjectSaveUrlAttachmentRequest {\n");
		sb.Append("  BusObId: ").Append(BusObId).Append('\n');
		sb.Append("  BusObName: ").Append(BusObName).Append('\n');
		sb.Append("  BusObPublicId: ").Append(BusObPublicId).Append('\n');
		sb.Append("  BusObRecId: ").Append(BusObRecId).Append('\n');
		sb.Append("  Comment: ").Append(Comment).Append('\n');
		sb.Append("  DisplayText: ").Append(DisplayText).Append('\n');
		sb.Append("  IncludeLinks: ").Append(IncludeLinks).Append('\n');
		sb.Append("  Url: ").Append(Url).Append('\n');
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
		return Equals(obj as SaveUrlAttachmentRequest);
	}

	/// <summary>
	/// Returns true if BusinessObjectSaveUrlAttachmentRequest instances are equal
	/// </summary>
	/// <param name="other">Instance of BusinessObjectSaveUrlAttachmentRequest to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(SaveUrlAttachmentRequest? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					BusObId == other.BusObId ||
					BusObId != null &&
					BusObId.Equals(other.BusObId, StringComparison.Ordinal)
				) &&
				(
					BusObName == other.BusObName ||
					BusObName != null &&
					BusObName.Equals(other.BusObName, StringComparison.Ordinal)
				) &&
				(
					BusObPublicId == other.BusObPublicId ||
					BusObPublicId != null &&
					BusObPublicId.Equals(other.BusObPublicId, StringComparison.Ordinal)
				) &&
				(
					BusObRecId == other.BusObRecId ||
					BusObRecId != null &&
					BusObRecId.Equals(other.BusObRecId, StringComparison.Ordinal)
				) &&
				(
					Comment == other.Comment ||
					Comment != null &&
					Comment.Equals(other.Comment, StringComparison.Ordinal)
				) &&
				(
					DisplayText == other.DisplayText ||
					DisplayText != null &&
					DisplayText.Equals(other.DisplayText, StringComparison.Ordinal)
				) &&
				(
					IncludeLinks == other.IncludeLinks ||
					IncludeLinks != null &&
					IncludeLinks.Equals(other.IncludeLinks)
				) &&
				(
					Url == other.Url ||
					Url != null &&
					Url.Equals(other.Url, StringComparison.Ordinal)
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
			if (BusObId != null)
			{
				hash = hash * 59 + BusObId.GetHashCode();
			}

			if (BusObName != null)
			{
				hash = hash * 59 + BusObName.GetHashCode();
			}

			if (BusObPublicId != null)
			{
				hash = hash * 59 + BusObPublicId.GetHashCode();
			}

			if (BusObRecId != null)
			{
				hash = hash * 59 + BusObRecId.GetHashCode();
			}

			if (Comment != null)
			{
				hash = hash * 59 + Comment.GetHashCode();
			}

			if (DisplayText != null)
			{
				hash = hash * 59 + DisplayText.GetHashCode();
			}

			if (IncludeLinks != null)
			{
				hash = hash * 59 + IncludeLinks.GetHashCode();
			}

			if (Url != null)
			{
				hash = hash * 59 + Url.GetHashCode();
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