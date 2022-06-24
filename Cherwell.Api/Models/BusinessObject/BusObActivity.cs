using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectBusObActivity
/// </summary>
[DataContract]
public partial class BusObActivity : IEquatable<BusObActivity>, IValidatableObject
{
	/// <summary>
	/// Initializes a new instance of the <see cref="BusObActivity" /> class.
	/// </summary>
	/// <param name="Id">Id.</param>
	/// <param name="ParentBusObDefId">ParentBusObDefId.</param>
	/// <param name="ParentBusObRecId">ParentBusObRecId.</param>
	/// <param name="HistoryBusObDefId">HistoryBusObDefId.</param>
	/// <param name="HistoryBusObRecId">HistoryBusObRecId.</param>
	/// <param name="Type">Type.</param>
	/// <param name="Title">Title.</param>
	/// <param name="Body">Body.</param>
	/// <param name="CreatedBy">CreatedBy.</param>
	/// <param name="Created">Created.</param>
	/// <param name="Modified">Modified.</param>
	/// <param name="ModifiedBy">ModifiedBy.</param>
	public BusObActivity(string Id, string ParentBusObDefId, string ParentBusObRecId, string HistoryBusObDefId, string HistoryBusObRecId, string Type, string Title, string Body, string CreatedBy, DateTime? Created, DateTime? Modified, string ModifiedBy)
	{
		this.Id = Id;
		this.ParentBusObDefId = ParentBusObDefId;
		this.ParentBusObRecId = ParentBusObRecId;
		this.HistoryBusObDefId = HistoryBusObDefId;
		this.HistoryBusObRecId = HistoryBusObRecId;
		this.Type = Type;
		this.Title = Title;
		this.Body = Body;
		this.CreatedBy = CreatedBy;
		this.Created = Created;
		this.Modified = Modified;
		this.ModifiedBy = ModifiedBy;
	}

	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "id", EmitDefaultValue = false)]
	public string Id { get; set; }
	/// <summary>
	/// Gets or Sets ParentBusObDefId
	/// </summary>
	[DataMember(Name = "parentBusObDefId", EmitDefaultValue = false)]
	public string ParentBusObDefId { get; set; }
	/// <summary>
	/// Gets or Sets ParentBusObRecId
	/// </summary>
	[DataMember(Name = "parentBusObRecId", EmitDefaultValue = false)]
	public string ParentBusObRecId { get; set; }
	/// <summary>
	/// Gets or Sets HistoryBusObDefId
	/// </summary>
	[DataMember(Name = "historyBusObDefId", EmitDefaultValue = false)]
	public string HistoryBusObDefId { get; set; }
	/// <summary>
	/// Gets or Sets HistoryBusObRecId
	/// </summary>
	[DataMember(Name = "historyBusObRecId", EmitDefaultValue = false)]
	public string HistoryBusObRecId { get; set; }
	/// <summary>
	/// Gets or Sets Type
	/// </summary>
	[DataMember(Name = "type", EmitDefaultValue = false)]
	public string Type { get; set; }
	/// <summary>
	/// Gets or Sets Title
	/// </summary>
	[DataMember(Name = "title", EmitDefaultValue = false)]
	public string Title { get; set; }
	/// <summary>
	/// Gets or Sets Body
	/// </summary>
	[DataMember(Name = "body", EmitDefaultValue = false)]
	public string Body { get; set; }
	/// <summary>
	/// Gets or Sets CreatedBy
	/// </summary>
	[DataMember(Name = "createdBy", EmitDefaultValue = false)]
	public string CreatedBy { get; set; }
	/// <summary>
	/// Gets or Sets Created
	/// </summary>
	[DataMember(Name = "created", EmitDefaultValue = false)]
	public DateTime? Created { get; set; }
	/// <summary>
	/// Gets or Sets Modified
	/// </summary>
	[DataMember(Name = "modified", EmitDefaultValue = false)]
	public DateTime? Modified { get; set; }
	/// <summary>
	/// Gets or Sets ModifiedBy
	/// </summary>
	[DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
	public string ModifiedBy { get; set; }
	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class BusinessObjectBusObActivity {\n");
		sb.Append("  Id: ").Append(Id).Append('\n');
		sb.Append("  ParentBusObDefId: ").Append(ParentBusObDefId).Append('\n');
		sb.Append("  ParentBusObRecId: ").Append(ParentBusObRecId).Append('\n');
		sb.Append("  HistoryBusObDefId: ").Append(HistoryBusObDefId).Append('\n');
		sb.Append("  HistoryBusObRecId: ").Append(HistoryBusObRecId).Append('\n');
		sb.Append("  Type: ").Append(Type).Append('\n');
		sb.Append("  Title: ").Append(Title).Append('\n');
		sb.Append("  Body: ").Append(Body).Append('\n');
		sb.Append("  CreatedBy: ").Append(CreatedBy).Append('\n');
		sb.Append("  Created: ").Append(Created).Append('\n');
		sb.Append("  Modified: ").Append(Modified).Append('\n');
		sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append('\n');
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
		return Equals(obj as BusObActivity);
	}

	/// <summary>
	/// Returns true if BusinessObjectBusObActivity instances are equal
	/// </summary>
	/// <param name="other">Instance of BusinessObjectBusObActivity to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(BusObActivity? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					Id == other.Id ||
					Id != null &&
					Id.Equals(other.Id, StringComparison.Ordinal)
				) &&
				(
					ParentBusObDefId == other.ParentBusObDefId ||
					ParentBusObDefId != null &&
					ParentBusObDefId.Equals(other.ParentBusObDefId, StringComparison.Ordinal)
				) &&
				(
					ParentBusObRecId == other.ParentBusObRecId ||
					ParentBusObRecId != null &&
					ParentBusObRecId.Equals(other.ParentBusObRecId, StringComparison.Ordinal)
				) &&
				(
					HistoryBusObDefId == other.HistoryBusObDefId ||
					HistoryBusObDefId != null &&
					HistoryBusObDefId.Equals(other.HistoryBusObDefId, StringComparison.Ordinal)
				) &&
				(
					HistoryBusObRecId == other.HistoryBusObRecId ||
					HistoryBusObRecId != null &&
					HistoryBusObRecId.Equals(other.HistoryBusObRecId, StringComparison.Ordinal)
				) &&
				(
					Type == other.Type ||
					Type != null &&
					Type.Equals(other.Type, StringComparison.Ordinal)
				) &&
				(
					Title == other.Title ||
					Title != null &&
					Title.Equals(other.Title, StringComparison.Ordinal)
				) &&
				(
					Body == other.Body ||
					Body != null &&
					Body.Equals(other.Body, StringComparison.Ordinal)
				) &&
				(
					CreatedBy == other.CreatedBy ||
					CreatedBy != null &&
					CreatedBy.Equals(other.CreatedBy, StringComparison.Ordinal)
				) &&
				(
					Created == other.Created ||
					Created != null &&
					Created.Equals(other.Created)
				) &&
				(
					Modified == other.Modified ||
					Modified != null &&
					Modified.Equals(other.Modified)
				) &&
				(
					ModifiedBy == other.ModifiedBy ||
					ModifiedBy != null &&
					ModifiedBy.Equals(other.ModifiedBy, StringComparison.Ordinal)
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
			if (Id != null)
			{
				hash = hash * 59 + Id.GetHashCode();
			}

			if (ParentBusObDefId != null)
			{
				hash = hash * 59 + ParentBusObDefId.GetHashCode();
			}

			if (ParentBusObRecId != null)
			{
				hash = hash * 59 + ParentBusObRecId.GetHashCode();
			}

			if (HistoryBusObDefId != null)
			{
				hash = hash * 59 + HistoryBusObDefId.GetHashCode();
			}

			if (HistoryBusObRecId != null)
			{
				hash = hash * 59 + HistoryBusObRecId.GetHashCode();
			}

			if (Type != null)
			{
				hash = hash * 59 + Type.GetHashCode();
			}

			if (Title != null)
			{
				hash = hash * 59 + Title.GetHashCode();
			}

			if (Body != null)
			{
				hash = hash * 59 + Body.GetHashCode();
			}

			if (CreatedBy != null)
			{
				hash = hash * 59 + CreatedBy.GetHashCode();
			}

			if (Created != null)
			{
				hash = hash * 59 + Created.GetHashCode();
			}

			if (Modified != null)
			{
				hash = hash * 59 + Modified.GetHashCode();
			}

			if (ModifiedBy != null)
			{
				hash = hash * 59 + ModifiedBy.GetHashCode();
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