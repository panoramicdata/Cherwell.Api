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