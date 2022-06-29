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






		}
	}

	
}