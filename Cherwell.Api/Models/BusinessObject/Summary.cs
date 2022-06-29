using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectSummary
/// </summary>
[DataContract]
public partial class Summary
{
	/// <summary>
	/// Initializes a new instance of the <see cref="Summary" /> class.
	/// </summary>
	/// <param name="FirstRecIdField">FirstRecIdField.</param>
	/// <param name="GroupSummaries">GroupSummaries.</param>
	/// <param name="RecIdFields">RecIdFields.</param>
	/// <param name="StateFieldId">StateFieldId.</param>
	/// <param name="States">States.</param>
	/// <param name="BusObId">BusObId.</param>
	/// <param name="DisplayName">DisplayName.</param>
	/// <param name="Group">Group.</param>
	/// <param name="Lookup">Lookup.</param>
	/// <param name="Major">Major.</param>
	/// <param name="Name">Name.</param>
	/// <param name="Supporting">Supporting.</param>
	public Summary(string FirstRecIdField, List<Summary> GroupSummaries, string RecIdFields, string StateFieldId, string States, string BusObId, string DisplayName, bool? Group, bool? Lookup, bool? Major, string Name, bool? Supporting)
	{
		this.FirstRecIdField = FirstRecIdField;
		this.GroupSummaries = GroupSummaries;
		this.RecIdFields = RecIdFields;
		this.StateFieldId = StateFieldId;
		this.States = States;
		this.BusObId = BusObId;
		this.DisplayName = DisplayName;
		this.Group = Group;
		this.Lookup = Lookup;
		this.Major = Major;
		this.Name = Name;
		this.Supporting = Supporting;
	}

	/// <summary>
	/// FirstRecIdField
	/// </summary>
	[DataMember(Name = "firstRecIdField", EmitDefaultValue = false)]
	public string FirstRecIdField { get; set; }

	/// <summary>
	/// GroupSummaries
	/// </summary>
	[DataMember(Name = "groupSummaries", EmitDefaultValue = false)]
	public List<Summary> GroupSummaries { get; set; }

	/// <summary>
	/// RecIdFields
	/// </summary>
	[DataMember(Name = "recIdFields", EmitDefaultValue = false)]
	public string RecIdFields { get; set; }

	/// <summary>
	/// StateFieldId
	/// </summary>
	[DataMember(Name = "stateFieldId", EmitDefaultValue = false)]
	public string StateFieldId { get; set; }

	/// <summary>
	/// States
	/// </summary>
	[DataMember(Name = "states", EmitDefaultValue = false)]
	public string States { get; set; }

	/// <summary>
	/// BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; }

	/// <summary>
	/// DisplayName
	/// </summary>
	[DataMember(Name = "displayName", EmitDefaultValue = false)]
	public string DisplayName { get; set; }

	/// <summary>
	/// Group
	/// </summary>
	[DataMember(Name = "group", EmitDefaultValue = false)]
	public bool? Group { get; set; }

	/// <summary>
	/// Lookup
	/// </summary>
	[DataMember(Name = "lookup", EmitDefaultValue = false)]
	public bool? Lookup { get; set; }

	/// <summary>
	/// Major
	/// </summary>
	[DataMember(Name = "major", EmitDefaultValue = false)]
	public bool? Major { get; set; }

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; }

	/// <summary>
	/// Supporting
	/// </summary>
	[DataMember(Name = "supporting", EmitDefaultValue = false)]
	public bool? Supporting { get; set; }
















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
