using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Core;

/// <summary>
/// SaveGalleryImageResponse
/// </summary>
[DataContract]
public class SaveGalleryImageResponse : Response
{
	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; } = null!;

	/// <summary>
	/// StandInKey
	/// </summary>
	[DataMember(Name = "standInKey", EmitDefaultValue = false)]
	public string StandInKey { get; set; } = null!;
}
