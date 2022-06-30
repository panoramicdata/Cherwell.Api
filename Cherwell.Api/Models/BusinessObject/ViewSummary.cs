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
	/// GroupSummaries
	/// </summary>
	[DataMember(Name = "groupSummaries", EmitDefaultValue = false)]
	public List<ViewSummary>? GroupSummaries { get; set; }

	/// <summary>
	/// Image
	/// </summary>
	[DataMember(Name = "image", EmitDefaultValue = false)]
	public string? Image { get; set; }

	/// <summary>
	/// IsPartOfView
	/// </summary>
	[DataMember(Name = "isPartOfView", EmitDefaultValue = false)]
	public bool? IsPartOfView { get; set; }

	/// <summary>
	/// BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string? BusObId { get; set; }

	/// <summary>
	/// DisplayName
	/// </summary>
	[DataMember(Name = "displayName", EmitDefaultValue = false)]
	public string? DisplayName { get; set; }

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
	public string? Name { get; set; }

	/// <summary>
	/// Supporting
	/// </summary>
	[DataMember(Name = "supporting", EmitDefaultValue = false)]
	public bool? Supporting { get; set; }
}