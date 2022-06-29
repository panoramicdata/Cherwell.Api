using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectBusObActivity
/// </summary>
[DataContract]
public partial class BusObActivity
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
	/// Id
	/// </summary>
	[DataMember(Name = "id", EmitDefaultValue = false)]
	public string Id { get; set; }

	/// <summary>
	/// ParentBusObDefId
	/// </summary>
	[DataMember(Name = "parentBusObDefId", EmitDefaultValue = false)]
	public string ParentBusObDefId { get; set; }

	/// <summary>
	/// ParentBusObRecId
	/// </summary>
	[DataMember(Name = "parentBusObRecId", EmitDefaultValue = false)]
	public string ParentBusObRecId { get; set; }

	/// <summary>
	/// HistoryBusObDefId
	/// </summary>
	[DataMember(Name = "historyBusObDefId", EmitDefaultValue = false)]
	public string HistoryBusObDefId { get; set; }

	/// <summary>
	/// HistoryBusObRecId
	/// </summary>
	[DataMember(Name = "historyBusObRecId", EmitDefaultValue = false)]
	public string HistoryBusObRecId { get; set; }

	/// <summary>
	/// Type
	/// </summary>
	[DataMember(Name = "type", EmitDefaultValue = false)]
	public string Type { get; set; }

	/// <summary>
	/// Title
	/// </summary>
	[DataMember(Name = "title", EmitDefaultValue = false)]
	public string Title { get; set; }

	/// <summary>
	/// Body
	/// </summary>
	[DataMember(Name = "body", EmitDefaultValue = false)]
	public string Body { get; set; }

	/// <summary>
	/// CreatedBy
	/// </summary>
	[DataMember(Name = "createdBy", EmitDefaultValue = false)]
	public string CreatedBy { get; set; }

	/// <summary>
	/// Created
	/// </summary>
	[DataMember(Name = "created", EmitDefaultValue = false)]
	public DateTime? Created { get; set; }

	/// <summary>
	/// Modified
	/// </summary>
	[DataMember(Name = "modified", EmitDefaultValue = false)]
	public DateTime? Modified { get; set; }

	/// <summary>
	/// ModifiedBy
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

	
}