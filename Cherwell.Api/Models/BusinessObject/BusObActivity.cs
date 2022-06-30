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
	/// Id
	/// </summary>
	[DataMember(Name = "id", EmitDefaultValue = false)]
	public string? Id { get; set; }

	/// <summary>
	/// ParentBusObDefId
	/// </summary>
	[DataMember(Name = "parentBusObDefId", EmitDefaultValue = false)]
	public string? ParentBusObDefId { get; set; }

	/// <summary>
	/// ParentBusObRecId
	/// </summary>
	[DataMember(Name = "parentBusObRecId", EmitDefaultValue = false)]
	public string? ParentBusObRecId { get; set; }

	/// <summary>
	/// HistoryBusObDefId
	/// </summary>
	[DataMember(Name = "historyBusObDefId", EmitDefaultValue = false)]
	public string? HistoryBusObDefId { get; set; }

	/// <summary>
	/// HistoryBusObRecId
	/// </summary>
	[DataMember(Name = "historyBusObRecId", EmitDefaultValue = false)]
	public string? HistoryBusObRecId { get; set; }

	/// <summary>
	/// Type
	/// </summary>
	[DataMember(Name = "type", EmitDefaultValue = false)]
	public string? Type { get; set; }

	/// <summary>
	/// Title
	/// </summary>
	[DataMember(Name = "title", EmitDefaultValue = false)]
	public string? Title { get; set; }

	/// <summary>
	/// Body
	/// </summary>
	[DataMember(Name = "body", EmitDefaultValue = false)]
	public string? Body { get; set; }

	/// <summary>
	/// CreatedBy
	/// </summary>
	[DataMember(Name = "createdBy", EmitDefaultValue = false)]
	public string? CreatedBy { get; set; }

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
	public string? ModifiedBy { get; set; }
}