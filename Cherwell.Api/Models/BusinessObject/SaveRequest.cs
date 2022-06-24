using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectSaveRequest
/// </summary>
[DataContract]
public partial class SaveRequest : IEquatable<SaveRequest>, IValidatableObject
{
	/// <summary>
	/// Gets or Sets CacheScope
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnumCacheScope
	{

		/// <summary>
		/// Enum Tenant for "Tenant"
		/// </summary>
		[EnumMember(Value = "Tenant")]
		Tenant,

		/// <summary>
		/// Enum User for "User"
		/// </summary>
		[EnumMember(Value = "User")]
		User,

		/// <summary>
		/// Enum Session for "Session"
		/// </summary>
		[EnumMember(Value = "Session")]
		Session
	}

	/// <summary>
	/// Gets or Sets CacheScope
	/// </summary>
	[DataMember(Name = "cacheScope", EmitDefaultValue = false)]
	public EnumCacheScope? CacheScope { get; set; }
	/// <summary>
	/// Initializes a new instance of the <see cref="SaveRequest" /> class.
	/// </summary>
	/// <param name="BusObId">BusObId.</param>
	/// <param name="BusObPublicId">BusObPublicId.</param>
	/// <param name="BusObRecId">BusObRecId.</param>
	/// <param name="CacheKey">CacheKey.</param>
	/// <param name="CacheScope">CacheScope.</param>
	/// <param name="Fields">Fields.</param>
	/// <param name="Persist">Persist.</param>
	public SaveRequest(string BusObId, string BusObPublicId, string BusObRecId, string CacheKey, EnumCacheScope? CacheScope, List<FieldTemplateItem> Fields, bool? Persist)
	{
		this.BusObId = BusObId;
		this.BusObPublicId = BusObPublicId;
		this.BusObRecId = BusObRecId;
		this.CacheKey = CacheKey;
		this.CacheScope = CacheScope;
		this.Fields = Fields;
		this.Persist = Persist;
	}

	/// <summary>
	/// Gets or Sets BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; }
	/// <summary>
	/// Gets or Sets BusObPublicId
	/// </summary>
	[DataMember(Name = "busObPublicId", EmitDefaultValue = false)]
	public string BusObPublicId { get; set; }
	/// <summary>
	/// Gets or Sets BusObRecId
	/// </summary>
	[DataMember(Name = "busObRecId", EmitDefaultValue = false)]
	public string BusObRecId { get; set; }
	/// <summary>
	/// Gets or Sets CacheKey
	/// </summary>
	[DataMember(Name = "cacheKey", EmitDefaultValue = false)]
	public string CacheKey { get; set; }
	/// <summary>
	/// Gets or Sets Fields
	/// </summary>
	[DataMember(Name = "fields", EmitDefaultValue = false)]
	public List<FieldTemplateItem> Fields { get; set; }
	/// <summary>
	/// Gets or Sets Persist
	/// </summary>
	[DataMember(Name = "persist", EmitDefaultValue = false)]
	public bool? Persist { get; set; }
	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class BusinessObjectSaveRequest {\n");
		sb.Append("  BusObId: ").Append(BusObId).Append('\n');
		sb.Append("  BusObPublicId: ").Append(BusObPublicId).Append('\n');
		sb.Append("  BusObRecId: ").Append(BusObRecId).Append('\n');
		sb.Append("  CacheKey: ").Append(CacheKey).Append('\n');
		sb.Append("  CacheScope: ").Append(CacheScope).Append('\n');
		sb.Append("  Fields: ").Append(Fields).Append('\n');
		sb.Append("  Persist: ").Append(Persist).Append('\n');
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
		return this.Equals(obj as SaveRequest);
	}

	/// <summary>
	/// Returns true if BusinessObjectSaveRequest instances are equal
	/// </summary>
	/// <param name="other">Instance of BusinessObjectSaveRequest to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(SaveRequest? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					this.BusObId == other.BusObId ||
					this.BusObId != null &&
					this.BusObId.Equals(other.BusObId, StringComparison.Ordinal)
				) &&
				(
					this.BusObPublicId == other.BusObPublicId ||
					this.BusObPublicId != null &&
					this.BusObPublicId.Equals(other.BusObPublicId, StringComparison.Ordinal)
				) &&
				(
					this.BusObRecId == other.BusObRecId ||
					this.BusObRecId != null &&
					this.BusObRecId.Equals(other.BusObRecId, StringComparison.Ordinal)
				) &&
				(
					this.CacheKey == other.CacheKey ||
					this.CacheKey != null &&
					this.CacheKey.Equals(other.CacheKey, StringComparison.Ordinal)
				) &&
				(
					this.CacheScope == other.CacheScope ||
					this.CacheScope != null &&
					this.CacheScope.Equals(other.CacheScope)
				) &&
				(
					this.Fields == other.Fields ||
					this.Fields != null &&
					this.Fields.SequenceEqual(other.Fields)
				) &&
				(
					this.Persist == other.Persist ||
					this.Persist != null &&
					this.Persist.Equals(other.Persist)
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
			if (this.BusObId != null)
			{
				hash = hash * 59 + this.BusObId.GetHashCode();
			}

			if (this.BusObPublicId != null)
			{
				hash = hash * 59 + this.BusObPublicId.GetHashCode();
			}

			if (this.BusObRecId != null)
			{
				hash = hash * 59 + this.BusObRecId.GetHashCode();
			}

			if (this.CacheKey != null)
			{
				hash = hash * 59 + this.CacheKey.GetHashCode();
			}

			if (this.CacheScope != null)
			{
				hash = hash * 59 + this.CacheScope.GetHashCode();
			}

			if (this.Fields != null)
			{
				hash = hash * 59 + this.Fields.GetHashCode();
			}

			if (this.Persist != null)
			{
				hash = hash * 59 + this.Persist.GetHashCode();
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