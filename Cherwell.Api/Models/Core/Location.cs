using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Core;

/// <summary>
/// CoreLocation
/// </summary>
[DataContract]
public partial class Location
{
	/// <summary>
	/// Initializes a new instance of the <see cref="Location" /> class.
	/// </summary>
	/// <param name="Altitude">Altitude.</param>
	/// <param name="BusObId">BusObId.</param>
	/// <param name="BusObRecId">BusObRecId.</param>
	/// <param name="Latitude">Latitude.</param>
	/// <param name="Longitude">Longitude.</param>
	public Location(double? Altitude, string BusObId, string BusObRecId, double? Latitude, double? Longitude)
	{
		this.Altitude = Altitude;
		this.BusObId = BusObId;
		this.BusObRecId = BusObRecId;
		this.Latitude = Latitude;
		this.Longitude = Longitude;
	}

	/// <summary>
	/// Altitude
	/// </summary>
	[DataMember(Name = "altitude", EmitDefaultValue = false)]
	public double? Altitude { get; set; }

	/// <summary>
	/// BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; }

	/// <summary>
	/// BusObRecId
	/// </summary>
	[DataMember(Name = "busObRecId", EmitDefaultValue = false)]
	public string BusObRecId { get; set; }

	/// <summary>
	/// Latitude
	/// </summary>
	[DataMember(Name = "latitude", EmitDefaultValue = false)]
	public double? Latitude { get; set; }

	/// <summary>
	/// Longitude
	/// </summary>
	[DataMember(Name = "longitude", EmitDefaultValue = false)]
	public double? Longitude { get; set; }
}
