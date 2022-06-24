using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Core;

/// <summary>
/// CoreLocation
/// </summary>
[DataContract]
public partial class Location : IEquatable<Location>, IValidatableObject
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
	/// Gets or Sets Altitude
	/// </summary>
	[DataMember(Name = "altitude", EmitDefaultValue = false)]
	public double? Altitude { get; set; }
	/// <summary>
	/// Gets or Sets BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; }
	/// <summary>
	/// Gets or Sets BusObRecId
	/// </summary>
	[DataMember(Name = "busObRecId", EmitDefaultValue = false)]
	public string BusObRecId { get; set; }
	/// <summary>
	/// Gets or Sets Latitude
	/// </summary>
	[DataMember(Name = "latitude", EmitDefaultValue = false)]
	public double? Latitude { get; set; }
	/// <summary>
	/// Gets or Sets Longitude
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
	/// Returns the JSON string presentation of the object
	/// </summary>
	/// <returns>JSON string presentation of the object</returns>
	public string ToJson()
	{
		return JsonConvert.SerializeObject(this, Formatting.Indented);
	}

	/// <summary>
	/// Returns true if objects are equal
	/// </summary>
	/// <param name="obj">Object to be compared</param>
	/// <returns>Boolean</returns>
	public override bool Equals(object? obj)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		return this.Equals(obj as Location);
	}

	/// <summary>
	/// Returns true if CoreLocation instances are equal
	/// </summary>
	/// <param name="other">Instance of CoreLocation to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(Location? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					this.Altitude == other.Altitude ||
					this.Altitude != null &&
					this.Altitude.Equals(other.Altitude)
				) &&
				(
					this.BusObId == other.BusObId ||
					this.BusObId != null &&
					this.BusObId.Equals(other.BusObId, StringComparison.Ordinal)
				) &&
				(
					this.BusObRecId == other.BusObRecId ||
					this.BusObRecId != null &&
					this.BusObRecId.Equals(other.BusObRecId, StringComparison.Ordinal)
				) &&
				(
					this.Latitude == other.Latitude ||
					this.Latitude != null &&
					this.Latitude.Equals(other.Latitude)
				) &&
				(
					this.Longitude == other.Longitude ||
					this.Longitude != null &&
					this.Longitude.Equals(other.Longitude)
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
			if (this.Altitude != null)
			{
				hash = hash * 59 + this.Altitude.GetHashCode();
			}

			if (this.BusObId != null)
			{
				hash = hash * 59 + this.BusObId.GetHashCode();
			}

			if (this.BusObRecId != null)
			{
				hash = hash * 59 + this.BusObRecId.GetHashCode();
			}

			if (this.Latitude != null)
			{
				hash = hash * 59 + this.Latitude.GetHashCode();
			}

			if (this.Longitude != null)
			{
				hash = hash * 59 + this.Longitude.GetHashCode();
			}

			return hash;
		}
	}

	/// <summary>
	/// To validate all properties of the instance
	/// </summary>
	/// <param name="validationContext">Validation context</param>
	/// <returns>Validation Result</returns>
	IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
	{
		yield break;
	}
}
