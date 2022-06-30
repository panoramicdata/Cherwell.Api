using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Core;

/// <summary>
/// CoreView
/// </summary>
[DataContract]
public partial class View
{
	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string? Name { get; set; }

	/// <summary>
	/// ViewId
	/// </summary>
	[DataMember(Name = "viewId", EmitDefaultValue = false)]
	public string? ViewId { get; set; }

	/// <summary>
	/// Image
	/// </summary>
	[DataMember(Name = "image", EmitDefaultValue = false)]
	public string? Image { get; set; }
}
