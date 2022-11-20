using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Core;

/// <summary>
/// Location
/// </summary>
[DataContract]
public class Location
{
	/// <summary>
	/// Altitude
	/// </summary>
	[DataMember(Name = "altitude", EmitDefaultValue = false)]
	public double Altitude { get; set; }
	/// <summary>
	/// BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; } = null!;

	/// <summary>
	/// BusObRecId
	/// </summary>
	[DataMember(Name = "busObRecId", EmitDefaultValue = false)]
	public string BusObRecId { get; set; } = null!;

	/// <summary>
	/// Latitude
	/// </summary>
	[DataMember(Name = "latitude", EmitDefaultValue = false)]
	public double Latitude { get; set; }
	/// <summary>
	/// Longitude
	/// </summary>
	[DataMember(Name = "longitude", EmitDefaultValue = false)]
	public double Longitude { get; set; }
}
