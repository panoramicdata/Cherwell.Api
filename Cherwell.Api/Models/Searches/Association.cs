using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// Searches Association
/// </summary>
[DataContract]
public partial class Association
{
	/// <summary>
	/// BusOb Id
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; } = null!;

	/// <summary>
	/// BusOb Name
	/// </summary>
	[DataMember(Name = "busObName", EmitDefaultValue = false)]
	public string BusObName { get; set; } = null!;
}
