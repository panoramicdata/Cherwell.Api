using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectFieldValuesLookupRequest
/// </summary>
[DataContract]
public partial class FieldValuesLookupRequest
{
	/// <summary>
	/// Initializes a new instance of the <see cref="FieldValuesLookupRequest" /> class.
	/// </summary>
	/// <param name="BusbPublicId">BusbPublicId.</param>
	/// <param name="BusObId">BusObId.</param>
	/// <param name="BusObRecId">BusObRecId.</param>
	/// <param name="FieldId">FieldId.</param>
	/// <param name="FieldName">FieldName.</param>
	/// <param name="Fields">Fields.</param>
	public FieldValuesLookupRequest(string BusbPublicId, string BusObId, string BusObRecId, string FieldId, string FieldName, List<FieldTemplateItem> Fields)
	{
		this.BusbPublicId = BusbPublicId;
		this.BusObId = BusObId;
		this.BusObRecId = BusObRecId;
		this.FieldId = FieldId;
		this.FieldName = FieldName;
		this.Fields = Fields;
	}

	/// <summary>
	/// BusbPublicId
	/// </summary>
	[DataMember(Name = "busbPublicId", EmitDefaultValue = false)]
	public string BusbPublicId { get; set; }

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
	/// FieldId
	/// </summary>
	[DataMember(Name = "fieldId", EmitDefaultValue = false)]
	public string FieldId { get; set; }

	/// <summary>
	/// FieldName
	/// </summary>
	[DataMember(Name = "fieldName", EmitDefaultValue = false)]
	public string FieldName { get; set; }

	/// <summary>
	/// Fields
	/// </summary>
	[DataMember(Name = "fields", EmitDefaultValue = false)]
	public List<FieldTemplateItem> Fields { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class BusinessObjectFieldValuesLookupRequest {\n");
		sb.Append("  BusbPublicId: ").Append(BusbPublicId).Append('\n');
		sb.Append("  BusObId: ").Append(BusObId).Append('\n');
		sb.Append("  BusObRecId: ").Append(BusObRecId).Append('\n');
		sb.Append("  FieldId: ").Append(FieldId).Append('\n');
		sb.Append("  FieldName: ").Append(FieldName).Append('\n');
		sb.Append("  Fields: ").Append(Fields).Append('\n');
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
			if (BusbPublicId != null)
			{
				hash = hash * 59 + BusbPublicId.GetHashCode();
			}

			if (BusObId != null)
			{
				hash = hash * 59 + BusObId.GetHashCode();
			}

			if (BusObRecId != null)
			{
				hash = hash * 59 + BusObRecId.GetHashCode();
			}

			if (FieldId != null)
			{
				hash = hash * 59 + FieldId.GetHashCode();
			}

			if (FieldName != null)
			{
				hash = hash * 59 + FieldName.GetHashCode();
			}

			if (Fields != null)
			{
				hash = hash * 59 + Fields.GetHashCode();
			}

			return hash;
		}
	}

	
}