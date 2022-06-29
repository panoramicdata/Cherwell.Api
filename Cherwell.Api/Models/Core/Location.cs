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

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class CoreLocation {\n");
		sb.Append("  Altitude: ").Append(Altitude).Append('\n');
		sb.Append("  BusObId: ").Append(BusObId).Append('\n');
		sb.Append("  BusObRecId: ").Append(BusObRecId).Append('\n');
		sb.Append("  Latitude: ").Append(Latitude).Append('\n');
		sb.Append("  Longitude: ").Append(Longitude).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
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
			if (Altitude != null)
			{
				hash = hash * 59 + Altitude.GetHashCode();
			}

			if (BusObId != null)
			{
				hash = hash * 59 + BusObId.GetHashCode();
			}

			if (BusObRecId != null)
			{
				hash = hash * 59 + BusObRecId.GetHashCode();
			}

			if (Latitude != null)
			{
				hash = hash * 59 + Latitude.GetHashCode();
			}

			if (Longitude != null)
			{
				hash = hash * 59 + Longitude.GetHashCode();
			}

			return hash;
		}
	}

	
}
