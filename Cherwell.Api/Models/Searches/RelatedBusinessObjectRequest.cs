using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesRelatedBusinessObjectRequest
/// </summary>
[DataContract]
public partial class RelatedBusinessObjectRequest
{
	/// <summary>
	/// Initializes a new instance of the <see cref="RelatedBusinessObjectRequest" /> class.
	/// </summary>
	/// <param name="AllFields">AllFields.</param>
	/// <param name="CustomGridId">CustomGridId.</param>
	/// <param name="FieldsList">FieldsList.</param>
	/// <param name="Filters">Filters.</param>
	/// <param name="PageNumber">PageNumber.</param>
	/// <param name="PageSize">PageSize.</param>
	/// <param name="ParentBusObId">ParentBusObId.</param>
	/// <param name="ParentBusObRecId">ParentBusObRecId.</param>
	/// <param name="RelationshipId">RelationshipId.</param>
	/// <param name="Sorting">Sorting.</param>
	/// <param name="UseDefaultGrid">UseDefaultGrid.</param>
	public RelatedBusinessObjectRequest(bool? AllFields, string CustomGridId, List<string> FieldsList, List<FilterInfo> Filters, int? PageNumber, int? PageSize, string ParentBusObId, string ParentBusObRecId, string RelationshipId, List<SortInfo> Sorting, bool? UseDefaultGrid)
	{
		this.AllFields = AllFields;
		this.CustomGridId = CustomGridId;
		this.FieldsList = FieldsList;
		this.Filters = Filters;
		this.PageNumber = PageNumber;
		this.PageSize = PageSize;
		this.ParentBusObId = ParentBusObId;
		this.ParentBusObRecId = ParentBusObRecId;
		this.RelationshipId = RelationshipId;
		this.Sorting = Sorting;
		this.UseDefaultGrid = UseDefaultGrid;
	}

	/// <summary>
	/// AllFields
	/// </summary>
	[DataMember(Name = "allFields", EmitDefaultValue = false)]
	public bool? AllFields { get; set; }

	/// <summary>
	/// CustomGridId
	/// </summary>
	[DataMember(Name = "customGridId", EmitDefaultValue = false)]
	public string CustomGridId { get; set; }

	/// <summary>
	/// FieldsList
	/// </summary>
	[DataMember(Name = "fieldsList", EmitDefaultValue = false)]
	public List<string> FieldsList { get; set; }

	/// <summary>
	/// Filters
	/// </summary>
	[DataMember(Name = "filters", EmitDefaultValue = false)]
	public List<FilterInfo> Filters { get; set; }

	/// <summary>
	/// PageNumber
	/// </summary>
	[DataMember(Name = "pageNumber", EmitDefaultValue = false)]
	public int? PageNumber { get; set; }

	/// <summary>
	/// PageSize
	/// </summary>
	[DataMember(Name = "pageSize", EmitDefaultValue = false)]
	public int? PageSize { get; set; }

	/// <summary>
	/// ParentBusObId
	/// </summary>
	[DataMember(Name = "parentBusObId", EmitDefaultValue = false)]
	public string ParentBusObId { get; set; }

	/// <summary>
	/// ParentBusObRecId
	/// </summary>
	[DataMember(Name = "parentBusObRecId", EmitDefaultValue = false)]
	public string ParentBusObRecId { get; set; }

	/// <summary>
	/// RelationshipId
	/// </summary>
	[DataMember(Name = "relationshipId", EmitDefaultValue = false)]
	public string RelationshipId { get; set; }

	/// <summary>
	/// Sorting
	/// </summary>
	[DataMember(Name = "sorting", EmitDefaultValue = false)]
	public List<SortInfo> Sorting { get; set; }

	/// <summary>
	/// UseDefaultGrid
	/// </summary>
	[DataMember(Name = "useDefaultGrid", EmitDefaultValue = false)]
	public bool? UseDefaultGrid { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SearchesRelatedBusinessObjectRequest {\n");
		sb.Append("  AllFields: ").Append(AllFields).Append('\n');
		sb.Append("  CustomGridId: ").Append(CustomGridId).Append('\n');
		sb.Append("  FieldsList: ").Append(FieldsList).Append('\n');
		sb.Append("  Filters: ").Append(Filters).Append('\n');
		sb.Append("  PageNumber: ").Append(PageNumber).Append('\n');
		sb.Append("  PageSize: ").Append(PageSize).Append('\n');
		sb.Append("  ParentBusObId: ").Append(ParentBusObId).Append('\n');
		sb.Append("  ParentBusObRecId: ").Append(ParentBusObRecId).Append('\n');
		sb.Append("  RelationshipId: ").Append(RelationshipId).Append('\n');
		sb.Append("  Sorting: ").Append(Sorting).Append('\n');
		sb.Append("  UseDefaultGrid: ").Append(UseDefaultGrid).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns true if SearchesRelatedBusinessObjectRequest instances are equal
	/// </summary>
	/// <param name="other">Instance of SearchesRelatedBusinessObjectRequest to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(RelatedBusinessObjectRequest? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					AllFields == other.AllFields ||
					AllFields != null &&
					AllFields.Equals(other.AllFields)
				) &&
				(
					CustomGridId == other.CustomGridId ||
					CustomGridId != null &&
					CustomGridId.Equals(other.CustomGridId, StringComparison.Ordinal)
				) &&
				(
					FieldsList == other.FieldsList ||
					FieldsList != null &&
					FieldsList.SequenceEqual(other.FieldsList)
				) &&
				(
					Filters == other.Filters ||
					Filters != null &&
					Filters.SequenceEqual(other.Filters)
				) &&
				(
					PageNumber == other.PageNumber ||
					PageNumber != null &&
					PageNumber.Equals(other.PageNumber)
				) &&
				(
					PageSize == other.PageSize ||
					PageSize != null &&
					PageSize.Equals(other.PageSize)
				) &&
				(
					ParentBusObId == other.ParentBusObId ||
					ParentBusObId != null &&
					ParentBusObId.Equals(other.ParentBusObId, StringComparison.Ordinal)
				) &&
				(
					ParentBusObRecId == other.ParentBusObRecId ||
					ParentBusObRecId != null &&
					ParentBusObRecId.Equals(other.ParentBusObRecId, StringComparison.Ordinal)
				) &&
				(
					RelationshipId == other.RelationshipId ||
					RelationshipId != null &&
					RelationshipId.Equals(other.RelationshipId, StringComparison.Ordinal)
				) &&
				(
					Sorting == other.Sorting ||
					Sorting != null &&
					Sorting.SequenceEqual(other.Sorting)
				) &&
				(
					UseDefaultGrid == other.UseDefaultGrid ||
					UseDefaultGrid != null &&
					UseDefaultGrid.Equals(other.UseDefaultGrid)
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
			if (AllFields != null)
			{
				hash = hash * 59 + AllFields.GetHashCode();
			}

			if (CustomGridId != null)
			{
				hash = hash * 59 + CustomGridId.GetHashCode();
			}

			if (FieldsList != null)
			{
				hash = hash * 59 + FieldsList.GetHashCode();
			}

			if (Filters != null)
			{
				hash = hash * 59 + Filters.GetHashCode();
			}

			if (PageNumber != null)
			{
				hash = hash * 59 + PageNumber.GetHashCode();
			}

			if (PageSize != null)
			{
				hash = hash * 59 + PageSize.GetHashCode();
			}

			if (ParentBusObId != null)
			{
				hash = hash * 59 + ParentBusObId.GetHashCode();
			}

			if (ParentBusObRecId != null)
			{
				hash = hash * 59 + ParentBusObRecId.GetHashCode();
			}

			if (RelationshipId != null)
			{
				hash = hash * 59 + RelationshipId.GetHashCode();
			}

			if (Sorting != null)
			{
				hash = hash * 59 + Sorting.GetHashCode();
			}

			if (UseDefaultGrid != null)
			{
				hash = hash * 59 + UseDefaultGrid.GetHashCode();
			}

			return hash;
		}
	}

	
}
