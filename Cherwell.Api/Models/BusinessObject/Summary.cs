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
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class BusinessObjectSummary {\n");
		sb.Append("  FirstRecIdField: ").Append(FirstRecIdField).Append('\n');
		sb.Append("  GroupSummaries: ").Append(GroupSummaries).Append('\n');
		sb.Append("  RecIdFields: ").Append(RecIdFields).Append('\n');
		sb.Append("  StateFieldId: ").Append(StateFieldId).Append('\n');
		sb.Append("  States: ").Append(States).Append('\n');
		sb.Append("  BusObId: ").Append(BusObId).Append('\n');
		sb.Append("  DisplayName: ").Append(DisplayName).Append('\n');
		sb.Append("  Group: ").Append(Group).Append('\n');
		sb.Append("  Lookup: ").Append(Lookup).Append('\n');
		sb.Append("  Major: ").Append(Major).Append('\n');
		sb.Append("  Name: ").Append(Name).Append('\n');
		sb.Append("  Supporting: ").Append(Supporting).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns true if BusinessObjectSummary instances are equal
	/// </summary>
	/// <param name="other">Instance of BusinessObjectSummary to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(Summary? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					FirstRecIdField == other.FirstRecIdField ||
					FirstRecIdField != null &&
					FirstRecIdField.Equals(other.FirstRecIdField, StringComparison.Ordinal)
				) &&
				(
					GroupSummaries == other.GroupSummaries ||
					GroupSummaries != null &&
					GroupSummaries.SequenceEqual(other.GroupSummaries)
				) &&
				(
					RecIdFields == other.RecIdFields ||
					RecIdFields != null &&
					RecIdFields.Equals(other.RecIdFields, StringComparison.Ordinal)
				) &&
				(
					StateFieldId == other.StateFieldId ||
					StateFieldId != null &&
					StateFieldId.Equals(other.StateFieldId, StringComparison.Ordinal)
				) &&
				(
					States == other.States ||
					States != null &&
					States.Equals(other.States, StringComparison.Ordinal)
				) &&
				(
					BusObId == other.BusObId ||
					BusObId != null &&
					BusObId.Equals(other.BusObId, StringComparison.Ordinal)
				) &&
				(
					DisplayName == other.DisplayName ||
					DisplayName != null &&
					DisplayName.Equals(other.DisplayName, StringComparison.Ordinal)
				) &&
				(
					Group == other.Group ||
					Group != null &&
					Group.Equals(other.Group)
				) &&
				(
					Lookup == other.Lookup ||
					Lookup != null &&
					Lookup.Equals(other.Lookup)
				) &&
				(
					Major == other.Major ||
					Major != null &&
					Major.Equals(other.Major)
				) &&
				(
					Name == other.Name ||
					Name != null &&
					Name.Equals(other.Name, StringComparison.Ordinal)
				) &&
				(
					Supporting == other.Supporting ||
					Supporting != null &&
					Supporting.Equals(other.Supporting)
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
			if (FirstRecIdField != null)
			{
				hash = hash * 59 + FirstRecIdField.GetHashCode();
			}

			if (GroupSummaries != null)
			{
				hash = hash * 59 + GroupSummaries.GetHashCode();
			}

			if (RecIdFields != null)
			{
				hash = hash * 59 + RecIdFields.GetHashCode();
			}

			if (StateFieldId != null)
			{
				hash = hash * 59 + StateFieldId.GetHashCode();
			}

			if (States != null)
			{
				hash = hash * 59 + States.GetHashCode();
			}

			if (BusObId != null)
			{
				hash = hash * 59 + BusObId.GetHashCode();
			}

			if (DisplayName != null)
			{
				hash = hash * 59 + DisplayName.GetHashCode();
			}

			if (Group != null)
			{
				hash = hash * 59 + Group.GetHashCode();
			}

			if (Lookup != null)
			{
				hash = hash * 59 + Lookup.GetHashCode();
			}

			if (Major != null)
			{
				hash = hash * 59 + Major.GetHashCode();
			}

			if (Name != null)
			{
				hash = hash * 59 + Name.GetHashCode();
			}

			if (Supporting != null)
			{
				hash = hash * 59 + Supporting.GetHashCode();
			}

			return hash;
		}
	}

	
}
