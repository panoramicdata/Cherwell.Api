using System.Runtime.Serialization;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectReadRequest
/// </summary>
[DataContract]
public partial class ReadRequest
{
	/// <summary>
	/// Gets or Sets BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string? BusObId { get; set; }

	/// <summary>
	/// Gets or Sets BusObPublicId
	/// </summary>
	[DataMember(Name = "busObPublicId", EmitDefaultValue = false)]
	public string? BusObPublicId { get; set; }

	/// <summary>
	/// Gets or Sets BusObRecId
	/// </summary>
	[DataMember(Name = "busObRecId", EmitDefaultValue = false)]
	public string? BusObRecId { get; set; }
}