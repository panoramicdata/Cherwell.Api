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
public partial class SaveRequest
{
	/// <summary>
	/// CacheScope
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
	/// CacheScope
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
	/// BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; }

	/// <summary>
	/// BusObPublicId
	/// </summary>
	[DataMember(Name = "busObPublicId", EmitDefaultValue = false)]
	public string BusObPublicId { get; set; }

	/// <summary>
	/// BusObRecId
	/// </summary>
	[DataMember(Name = "busObRecId", EmitDefaultValue = false)]
	public string BusObRecId { get; set; }

	/// <summary>
	/// CacheKey
	/// </summary>
	[DataMember(Name = "cacheKey", EmitDefaultValue = false)]
	public string CacheKey { get; set; }

	/// <summary>
	/// Fields
	/// </summary>
	[DataMember(Name = "fields", EmitDefaultValue = false)]
	public List<FieldTemplateItem> Fields { get; set; }

	/// <summary>
	/// Persist
	/// </summary>
	[DataMember(Name = "persist", EmitDefaultValue = false)]
	public bool? Persist { get; set; }
}