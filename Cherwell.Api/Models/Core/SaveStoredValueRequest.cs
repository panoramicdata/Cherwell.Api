using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Core;

/// <summary>
/// CoreSaveStoredValueRequest
/// </summary>
[DataContract]
public partial class SaveStoredValueRequest
{
	/// <summary>
	/// StoredValueType
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnumStoredValueType
	{

		/// <summary>
		/// Enum Text for "Text"
		/// </summary>
		[EnumMember(Value = "Text")]
		Text,

		/// <summary>
		/// Enum Number for "Number"
		/// </summary>
		[EnumMember(Value = "Number")]
		Number,

		/// <summary>
		/// Enum DateTime for "DateTime"
		/// </summary>
		[EnumMember(Value = "DateTime")]
		DateTime,

		/// <summary>
		/// Enum Logical for "Logical"
		/// </summary>
		[EnumMember(Value = "Logical")]
		Logical,

		/// <summary>
		/// Enum Color for "Color"
		/// </summary>
		[EnumMember(Value = "Color")]
		Color,

		/// <summary>
		/// Enum Json for "Json"
		/// </summary>
		[EnumMember(Value = "Json")]
		Json,

		/// <summary>
		/// Enum JsonArray for "JsonArray"
		/// </summary>
		[EnumMember(Value = "JsonArray")]
		JsonArray,

		/// <summary>
		/// Enum Xml for "Xml"
		/// </summary>
		[EnumMember(Value = "Xml")]
		Xml,

		/// <summary>
		/// Enum XmlCollection for "XmlCollection"
		/// </summary>
		[EnumMember(Value = "XmlCollection")]
		XmlCollection
	}

	/// <summary>
	/// StoredValueType
	/// </summary>
	[DataMember(Name = "storedValueType", EmitDefaultValue = false)]
	public EnumStoredValueType? StoredValueType { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="SaveStoredValueRequest" /> class.
	/// </summary>
	/// <param name="Description">Description.</param>
	/// <param name="Folder">Folder.</param>
	/// <param name="Name">Name.</param>
	/// <param name="Scope">Scope.</param>
	/// <param name="ScopeOwner">ScopeOwner.</param>
	/// <param name="StandInKey">StandInKey.</param>
	/// <param name="StoredValueType">StoredValueType.</param>
	/// <param name="Value">Value.</param>
	public SaveStoredValueRequest(string Description, string Folder, string Name, string Scope, string ScopeOwner, string StandInKey, EnumStoredValueType? StoredValueType, string Value)
	{
		this.Description = Description;
		this.Folder = Folder;
		this.Name = Name;
		this.Scope = Scope;
		this.ScopeOwner = ScopeOwner;
		this.StandInKey = StandInKey;
		this.StoredValueType = StoredValueType;
		this.Value = Value;
	}

	/// <summary>
	/// Description
	/// </summary>
	[DataMember(Name = "description", EmitDefaultValue = false)]
	public string Description { get; set; }

	/// <summary>
	/// Folder
	/// </summary>
	[DataMember(Name = "folder", EmitDefaultValue = false)]
	public string Folder { get; set; }

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; }

	/// <summary>
	/// Scope
	/// </summary>
	[DataMember(Name = "scope", EmitDefaultValue = false)]
	public string Scope { get; set; }

	/// <summary>
	/// ScopeOwner
	/// </summary>
	[DataMember(Name = "scopeOwner", EmitDefaultValue = false)]
	public string ScopeOwner { get; set; }

	/// <summary>
	/// StandInKey
	/// </summary>
	[DataMember(Name = "standInKey", EmitDefaultValue = false)]
	public string StandInKey { get; set; }

	/// <summary>
	/// Value
	/// </summary>
	[DataMember(Name = "value", EmitDefaultValue = false)]
	public string Value { get; set; }












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




		}
	}

	
}
