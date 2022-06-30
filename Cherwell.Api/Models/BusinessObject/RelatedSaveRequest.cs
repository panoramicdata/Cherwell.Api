using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// RelatedSaveRequest
/// </summary>
[DataContract]
public partial class RelatedSaveRequest
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
	/// ParentBusObId
	/// </summary>
	[DataMember(Name = "parentBusObId", EmitDefaultValue = false)]
	public string? ParentBusObId { get; set; }

	/// <summary>
	/// ParentBusObPublicId
	/// </summary>
	[DataMember(Name = "parentBusObPublicId", EmitDefaultValue = false)]
	public string? ParentBusObPublicId { get; set; }

	/// <summary>
	/// ParentBusObRecId
	/// </summary>
	[DataMember(Name = "parentBusObRecId", EmitDefaultValue = false)]
	public string? ParentBusObRecId { get; set; }

	/// <summary>
	/// RelationshipId
	/// </summary>
	[DataMember(Name = "relationshipId", EmitDefaultValue = false)]
	public string? RelationshipId { get; set; }

	/// <summary>
	/// BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string? BusObId { get; set; }

	/// <summary>
	/// BusObPublicId
	/// </summary>
	[DataMember(Name = "busObPublicId", EmitDefaultValue = false)]
	public string? BusObPublicId { get; set; }

	/// <summary>
	/// BusObRecId
	/// </summary>
	[DataMember(Name = "busObRecId", EmitDefaultValue = false)]
	public string? BusObRecId { get; set; }

	/// <summary>
	/// CacheKey
	/// </summary>
	[DataMember(Name = "cacheKey", EmitDefaultValue = false)]
	public string? CacheKey { get; set; }

	/// <summary>
	/// Fields
	/// </summary>
	[DataMember(Name = "fields", EmitDefaultValue = false)]
	public List<FieldTemplateItem>? Fields { get; set; }

	/// <summary>
	/// Persist
	/// </summary>
	[DataMember(Name = "persist", EmitDefaultValue = false)]
	public bool? Persist { get; set; }
}