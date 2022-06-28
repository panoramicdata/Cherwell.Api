using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Core;

/// <summary>
/// CoreServiceInfoResponse
/// </summary>
[DataContract]
public partial class ServiceInfoResponse : Response
{ 
	/// <summary>
	/// Initializes a new instance of the <see cref="ServiceInfoResponse" /> class.
	/// </summary>
	/// <param name="ApiVersion">ApiVersion.</param>
	/// <param name="CsmCulture">CsmCulture.</param>
	/// <param name="CsmVersion">CsmVersion.</param>
	/// <param name="SystemDateTime">SystemDateTime.</param>
	/// <param name="TimeZone">TimeZone.</param>
	/// <param name="SystemUtcOffset">SystemUtcOffset.</param>
	public ServiceInfoResponse(string ApiVersion, string CsmCulture, string CsmVersion, DateTime? SystemDateTime, Object TimeZone, string SystemUtcOffset)
	{
		this.ApiVersion = ApiVersion;
		this.CsmCulture = CsmCulture;
		this.CsmVersion = CsmVersion;
		this.SystemDateTime = SystemDateTime;
		this.TimeZone = TimeZone;
		this.SystemUtcOffset = SystemUtcOffset;
	}

	/// <summary>
	/// ApiVersion
	/// </summary>
	[DataMember(Name = "apiVersion", EmitDefaultValue = false)]
	public string ApiVersion { get; set; }

	/// <summary>
	/// CsmCulture
	/// </summary>
	[DataMember(Name = "csmCulture", EmitDefaultValue = false)]
	public string CsmCulture { get; set; }

	/// <summary>
	/// CsmVersion
	/// </summary>
	[DataMember(Name = "csmVersion", EmitDefaultValue = false)]
	public string CsmVersion { get; set; }

	/// <summary>
	/// SystemDateTime
	/// </summary>
	[DataMember(Name = "systemDateTime", EmitDefaultValue = false)]
	public DateTime? SystemDateTime { get; set; }

	/// <summary>
	/// TimeZone
	/// </summary>
	[DataMember(Name = "timeZone", EmitDefaultValue = false)]
	public Object TimeZone { get; set; }

	/// <summary>
	/// SystemUtcOffset
	/// </summary>
	[DataMember(Name = "systemUtcOffset", EmitDefaultValue = false)]
	public string SystemUtcOffset { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class CoreServiceInfoResponse {\n");
		sb.Append("  ApiVersion: ").Append(ApiVersion).Append('\n');
		sb.Append("  CsmCulture: ").Append(CsmCulture).Append('\n');
		sb.Append("  CsmVersion: ").Append(CsmVersion).Append('\n');
		sb.Append("  SystemDateTime: ").Append(SystemDateTime).Append('\n');
		sb.Append("  TimeZone: ").Append(TimeZone).Append('\n');
		sb.Append("  SystemUtcOffset: ").Append(SystemUtcOffset).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns true if CoreServiceInfoResponse instances are equal
	/// </summary>
	/// <param name="other">Instance of CoreServiceInfoResponse to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(ServiceInfoResponse? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					ApiVersion == other.ApiVersion ||
					ApiVersion != null &&
					ApiVersion.Equals(other.ApiVersion, StringComparison.Ordinal)
				) &&
				(
					CsmCulture == other.CsmCulture ||
					CsmCulture != null &&
					CsmCulture.Equals(other.CsmCulture, StringComparison.Ordinal)
				) &&
				(
					CsmVersion == other.CsmVersion ||
					CsmVersion != null &&
					CsmVersion.Equals(other.CsmVersion, StringComparison.Ordinal)
				) &&
				(
					SystemDateTime == other.SystemDateTime ||
					SystemDateTime != null &&
					SystemDateTime.Equals(other.SystemDateTime)
				) &&
				(
					TimeZone == other.TimeZone ||
					TimeZone != null &&
					TimeZone.Equals(other.TimeZone)
				) &&
				(
					SystemUtcOffset == other.SystemUtcOffset ||
					SystemUtcOffset != null &&
					SystemUtcOffset.Equals(other.SystemUtcOffset, StringComparison.Ordinal)
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
			if (ApiVersion != null)
			{
				hash = hash * 59 + ApiVersion.GetHashCode();
			}

			if (CsmCulture != null)
			{
				hash = hash * 59 + CsmCulture.GetHashCode();
			}

			if (CsmVersion != null)
			{
				hash = hash * 59 + CsmVersion.GetHashCode();
			}

			if (SystemDateTime != null)
			{
				hash = hash * 59 + SystemDateTime.GetHashCode();
			}

			if (TimeZone != null)
			{
				hash = hash * 59 + TimeZone.GetHashCode();
			}

			if (SystemUtcOffset != null)
			{
				hash = hash * 59 + SystemUtcOffset.GetHashCode();
			}

			return hash;
		}
	}

	
}
