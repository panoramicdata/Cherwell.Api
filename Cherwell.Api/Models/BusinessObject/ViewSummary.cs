using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectViewSummary
/// </summary>
[DataContract]
public partial class ViewSummary
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ViewSummary" /> class.
	/// </summary>
	/// <param name="GroupSummaries">GroupSummaries.</param>
	/// <param name="Image">Image.</param>
	/// <param name="IsPartOfView">IsPartOfView.</param>
	/// <param name="BusObId">BusObId.</param>
	/// <param name="DisplayName">DisplayName.</param>
	/// <param name="Group">Group.</param>
	/// <param name="Lookup">Lookup.</param>
	/// <param name="Major">Major.</param>
	/// <param name="Name">Name.</param>
	/// <param name="Supporting">Supporting.</param>
	public ViewSummary(List<ViewSummary> GroupSummaries, string Image, bool? IsPartOfView, string BusObId, string DisplayName, bool? Group, bool? Lookup, bool? Major, string Name, bool? Supporting)
	{
		this.GroupSummaries = GroupSummaries;
		this.Image = Image;
		this.IsPartOfView = IsPartOfView;
		this.BusObId = BusObId;
		this.DisplayName = DisplayName;
		this.Group = Group;
		this.Lookup = Lookup;
		this.Major = Major;
		this.Name = Name;
		this.Supporting = Supporting;
	}

	/// <summary>
	/// GroupSummaries
	/// </summary>
	[DataMember(Name = "groupSummaries", EmitDefaultValue = false)]
	public List<ViewSummary> GroupSummaries { get; set; }

	/// <summary>
	/// Image
	/// </summary>
	[DataMember(Name = "image", EmitDefaultValue = false)]
	public string Image { get; set; }

	/// <summary>
	/// IsPartOfView
	/// </summary>
	[DataMember(Name = "isPartOfView", EmitDefaultValue = false)]
	public bool? IsPartOfView { get; set; }

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
		sb.Append("class BusinessObjectViewSummary {\n");
		sb.Append("  GroupSummaries: ").Append(GroupSummaries).Append('\n');
		sb.Append("  Image: ").Append(Image).Append('\n');
		sb.Append("  IsPartOfView: ").Append(IsPartOfView).Append('\n');
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
	/// Returns true if BusinessObjectViewSummary instances are equal
	/// </summary>
	/// <param name="other">Instance of BusinessObjectViewSummary to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(ViewSummary? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					GroupSummaries == other.GroupSummaries ||
					GroupSummaries != null &&
					GroupSummaries.SequenceEqual(other.GroupSummaries)
				) &&
				(
					Image == other.Image ||
					Image != null &&
					Image.Equals(other.Image, StringComparison.Ordinal)
				) &&
				(
					IsPartOfView == other.IsPartOfView ||
					IsPartOfView != null &&
					IsPartOfView.Equals(other.IsPartOfView)
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
			if (GroupSummaries != null)
			{
				hash = hash * 59 + GroupSummaries.GetHashCode();
			}

			if (Image != null)
			{
				hash = hash * 59 + Image.GetHashCode();
			}

			if (IsPartOfView != null)
			{
				hash = hash * 59 + IsPartOfView.GetHashCode();
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