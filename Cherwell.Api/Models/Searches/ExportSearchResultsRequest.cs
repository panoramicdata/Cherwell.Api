using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesExportSearchResultsRequest
/// </summary>
[DataContract]
public partial class ExportSearchResultsRequest : IEquatable<ExportSearchResultsRequest>, IValidatableObject
{
	/// <summary>
	/// Gets or Sets ExportFormat
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnumExportFormat
	{

		/// <summary>
		/// Enum CSV for "CSV"
		/// </summary>
		[EnumMember(Value = "CSV")]
		CSV,

		/// <summary>
		/// Enum Excel for "Excel"
		/// </summary>
		[EnumMember(Value = "Excel")]
		Excel,

		/// <summary>
		/// Enum Tab for "Tab"
		/// </summary>
		[EnumMember(Value = "Tab")]
		Tab,

		/// <summary>
		/// Enum Word for "Word"
		/// </summary>
		[EnumMember(Value = "Word")]
		Word,

		/// <summary>
		/// Enum CustomSeparator for "CustomSeparator"
		/// </summary>
		[EnumMember(Value = "CustomSeparator")]
		CustomSeparator,

		/// <summary>
		/// Enum Json for "Json"
		/// </summary>
		[EnumMember(Value = "Json")]
		Json
	}

	/// <summary>
	/// Gets or Sets ExportFormat
	/// </summary>
	[DataMember(Name = "exportFormat", EmitDefaultValue = false)]
	public EnumExportFormat? ExportFormat { get; set; }
	/// <summary>
	/// Initializes a new instance of the <see cref="ExportSearchResultsRequest" /> class.
	/// </summary>
	/// <param name="CustomSeparator">CustomSeparator.</param>
	/// <param name="ExportFormat">ExportFormat.</param>
	/// <param name="ExportTitle">ExportTitle.</param>
	/// <param name="Association">Association.</param>
	/// <param name="AssociationName">AssociationName.</param>
	/// <param name="BusObId">BusObId.</param>
	/// <param name="CustomGridDefId">CustomGridDefId.</param>
	/// <param name="DateTimeFormatting">DateTimeFormatting.</param>
	/// <param name="FieldId">FieldId.</param>
	/// <param name="Fields">Fields.</param>
	/// <param name="Filters">Filters.</param>
	/// <param name="IncludeAllFields">IncludeAllFields.</param>
	/// <param name="IncludeSchema">IncludeSchema.</param>
	/// <param name="PageNumber">PageNumber.</param>
	/// <param name="PageSize">PageSize.</param>
	/// <param name="Scope">Scope.</param>
	/// <param name="ScopeOwner">ScopeOwner.</param>
	/// <param name="SearchId">SearchId.</param>
	/// <param name="SearchName">SearchName.</param>
	/// <param name="SearchText">SearchText.</param>
	/// <param name="Sorting">Sorting.</param>
	/// <param name="PromptValues">PromptValues.</param>
	public ExportSearchResultsRequest(string CustomSeparator, EnumExportFormat? ExportFormat, string ExportTitle, string Association, string AssociationName, string BusObId, string CustomGridDefId, string DateTimeFormatting, string FieldId, List<string> Fields, List<FilterInfo> Filters, bool? IncludeAllFields, bool? IncludeSchema, int? PageNumber, int? PageSize, string Scope, string ScopeOwner, string SearchId, string SearchName, string SearchText, List<SortInfo> Sorting, List<PromptValue> PromptValues)
	{
		this.CustomSeparator = CustomSeparator;
		this.ExportFormat = ExportFormat;
		this.ExportTitle = ExportTitle;
		this.Association = Association;
		this.AssociationName = AssociationName;
		this.BusObId = BusObId;
		this.CustomGridDefId = CustomGridDefId;
		this.DateTimeFormatting = DateTimeFormatting;
		this.FieldId = FieldId;
		this.Fields = Fields;
		this.Filters = Filters;
		this.IncludeAllFields = IncludeAllFields;
		this.IncludeSchema = IncludeSchema;
		this.PageNumber = PageNumber;
		this.PageSize = PageSize;
		this.Scope = Scope;
		this.ScopeOwner = ScopeOwner;
		this.SearchId = SearchId;
		this.SearchName = SearchName;
		this.SearchText = SearchText;
		this.Sorting = Sorting;
		this.PromptValues = PromptValues;
	}

	/// <summary>
	/// Gets or Sets CustomSeparator
	/// </summary>
	[DataMember(Name = "customSeparator", EmitDefaultValue = false)]
	public string CustomSeparator { get; set; }
	/// <summary>
	/// Gets or Sets ExportTitle
	/// </summary>
	[DataMember(Name = "exportTitle", EmitDefaultValue = false)]
	public string ExportTitle { get; set; }
	/// <summary>
	/// Gets or Sets Association
	/// </summary>
	[DataMember(Name = "association", EmitDefaultValue = false)]
	public string Association { get; set; }
	/// <summary>
	/// Gets or Sets AssociationName
	/// </summary>
	[DataMember(Name = "associationName", EmitDefaultValue = false)]
	public string AssociationName { get; set; }
	/// <summary>
	/// Gets or Sets BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; }
	/// <summary>
	/// Gets or Sets CustomGridDefId
	/// </summary>
	[DataMember(Name = "customGridDefId", EmitDefaultValue = false)]
	public string CustomGridDefId { get; set; }
	/// <summary>
	/// Gets or Sets DateTimeFormatting
	/// </summary>
	[DataMember(Name = "dateTimeFormatting", EmitDefaultValue = false)]
	public string DateTimeFormatting { get; set; }
	/// <summary>
	/// Gets or Sets FieldId
	/// </summary>
	[DataMember(Name = "fieldId", EmitDefaultValue = false)]
	public string FieldId { get; set; }
	/// <summary>
	/// Gets or Sets Fields
	/// </summary>
	[DataMember(Name = "fields", EmitDefaultValue = false)]
	public List<string> Fields { get; set; }
	/// <summary>
	/// Gets or Sets Filters
	/// </summary>
	[DataMember(Name = "filters", EmitDefaultValue = false)]
	public List<FilterInfo> Filters { get; set; }
	/// <summary>
	/// Gets or Sets IncludeAllFields
	/// </summary>
	[DataMember(Name = "includeAllFields", EmitDefaultValue = false)]
	public bool? IncludeAllFields { get; set; }
	/// <summary>
	/// Gets or Sets IncludeSchema
	/// </summary>
	[DataMember(Name = "includeSchema", EmitDefaultValue = false)]
	public bool? IncludeSchema { get; set; }
	/// <summary>
	/// Gets or Sets PageNumber
	/// </summary>
	[DataMember(Name = "pageNumber", EmitDefaultValue = false)]
	public int? PageNumber { get; set; }
	/// <summary>
	/// Gets or Sets PageSize
	/// </summary>
	[DataMember(Name = "pageSize", EmitDefaultValue = false)]
	public int? PageSize { get; set; }
	/// <summary>
	/// Gets or Sets Scope
	/// </summary>
	[DataMember(Name = "scope", EmitDefaultValue = false)]
	public string Scope { get; set; }
	/// <summary>
	/// Gets or Sets ScopeOwner
	/// </summary>
	[DataMember(Name = "scopeOwner", EmitDefaultValue = false)]
	public string ScopeOwner { get; set; }
	/// <summary>
	/// Gets or Sets SearchId
	/// </summary>
	[DataMember(Name = "searchId", EmitDefaultValue = false)]
	public string SearchId { get; set; }
	/// <summary>
	/// Gets or Sets SearchName
	/// </summary>
	[DataMember(Name = "searchName", EmitDefaultValue = false)]
	public string SearchName { get; set; }
	/// <summary>
	/// Gets or Sets SearchText
	/// </summary>
	[DataMember(Name = "searchText", EmitDefaultValue = false)]
	public string SearchText { get; set; }
	/// <summary>
	/// Gets or Sets Sorting
	/// </summary>
	[DataMember(Name = "sorting", EmitDefaultValue = false)]
	public List<SortInfo> Sorting { get; set; }
	/// <summary>
	/// Gets or Sets PromptValues
	/// </summary>
	[DataMember(Name = "promptValues", EmitDefaultValue = false)]
	public List<PromptValue> PromptValues { get; set; }
	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SearchesExportSearchResultsRequest {\n");
		sb.Append("  CustomSeparator: ").Append(CustomSeparator).Append('\n');
		sb.Append("  ExportFormat: ").Append(ExportFormat).Append('\n');
		sb.Append("  ExportTitle: ").Append(ExportTitle).Append('\n');
		sb.Append("  Association: ").Append(Association).Append('\n');
		sb.Append("  AssociationName: ").Append(AssociationName).Append('\n');
		sb.Append("  BusObId: ").Append(BusObId).Append('\n');
		sb.Append("  CustomGridDefId: ").Append(CustomGridDefId).Append('\n');
		sb.Append("  DateTimeFormatting: ").Append(DateTimeFormatting).Append('\n');
		sb.Append("  FieldId: ").Append(FieldId).Append('\n');
		sb.Append("  Fields: ").Append(Fields).Append('\n');
		sb.Append("  Filters: ").Append(Filters).Append('\n');
		sb.Append("  IncludeAllFields: ").Append(IncludeAllFields).Append('\n');
		sb.Append("  IncludeSchema: ").Append(IncludeSchema).Append('\n');
		sb.Append("  PageNumber: ").Append(PageNumber).Append('\n');
		sb.Append("  PageSize: ").Append(PageSize).Append('\n');
		sb.Append("  Scope: ").Append(Scope).Append('\n');
		sb.Append("  ScopeOwner: ").Append(ScopeOwner).Append('\n');
		sb.Append("  SearchId: ").Append(SearchId).Append('\n');
		sb.Append("  SearchName: ").Append(SearchName).Append('\n');
		sb.Append("  SearchText: ").Append(SearchText).Append('\n');
		sb.Append("  Sorting: ").Append(Sorting).Append('\n');
		sb.Append("  PromptValues: ").Append(PromptValues).Append('\n');
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
		return Equals(obj as ExportSearchResultsRequest);
	}

	/// <summary>
	/// Returns true if SearchesExportSearchResultsRequest instances are equal
	/// </summary>
	/// <param name="other">Instance of SearchesExportSearchResultsRequest to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(ExportSearchResultsRequest? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					CustomSeparator == other.CustomSeparator ||
					CustomSeparator != null &&
					CustomSeparator.Equals(other.CustomSeparator, StringComparison.Ordinal)
				) &&
				(
					ExportFormat == other.ExportFormat ||
					ExportFormat != null &&
					ExportFormat.Equals(other.ExportFormat)
				) &&
				(
					ExportTitle == other.ExportTitle ||
					ExportTitle != null &&
					ExportTitle.Equals(other.ExportTitle, StringComparison.Ordinal)
				) &&
				(
					Association == other.Association ||
					Association != null &&
					Association.Equals(other.Association, StringComparison.Ordinal)
				) &&
				(
					AssociationName == other.AssociationName ||
					AssociationName != null &&
					AssociationName.Equals(other.AssociationName, StringComparison.Ordinal)
				) &&
				(
					BusObId == other.BusObId ||
					BusObId != null &&
					BusObId.Equals(other.BusObId, StringComparison.Ordinal)
				) &&
				(
					CustomGridDefId == other.CustomGridDefId ||
					CustomGridDefId != null &&
					CustomGridDefId.Equals(other.CustomGridDefId, StringComparison.Ordinal)
				) &&
				(
					DateTimeFormatting == other.DateTimeFormatting ||
					DateTimeFormatting != null &&
					DateTimeFormatting.Equals(other.DateTimeFormatting, StringComparison.Ordinal)
				) &&
				(
					FieldId == other.FieldId ||
					FieldId != null &&
					FieldId.Equals(other.FieldId, StringComparison.Ordinal)
				) &&
				(
					Fields == other.Fields ||
					Fields != null &&
					Fields.SequenceEqual(other.Fields)
				) &&
				(
					Filters == other.Filters ||
					Filters != null &&
					Filters.SequenceEqual(other.Filters)
				) &&
				(
					IncludeAllFields == other.IncludeAllFields ||
					IncludeAllFields != null &&
					IncludeAllFields.Equals(other.IncludeAllFields)
				) &&
				(
					IncludeSchema == other.IncludeSchema ||
					IncludeSchema != null &&
					IncludeSchema.Equals(other.IncludeSchema)
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
					Scope == other.Scope ||
					Scope != null &&
					Scope.Equals(other.Scope, StringComparison.Ordinal)
				) &&
				(
					ScopeOwner == other.ScopeOwner ||
					ScopeOwner != null &&
					ScopeOwner.Equals(other.ScopeOwner, StringComparison.Ordinal)
				) &&
				(
					SearchId == other.SearchId ||
					SearchId != null &&
					SearchId.Equals(other.SearchId, StringComparison.Ordinal)
				) &&
				(
					SearchName == other.SearchName ||
					SearchName != null &&
					SearchName.Equals(other.SearchName, StringComparison.Ordinal)
				) &&
				(
					SearchText == other.SearchText ||
					SearchText != null &&
					SearchText.Equals(other.SearchText, StringComparison.Ordinal)
				) &&
				(
					Sorting == other.Sorting ||
					Sorting != null &&
					Sorting.SequenceEqual(other.Sorting)
				) &&
				(
					PromptValues == other.PromptValues ||
					PromptValues != null &&
					PromptValues.SequenceEqual(other.PromptValues)
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
			if (CustomSeparator != null)
			{
				hash = hash * 59 + CustomSeparator.GetHashCode();
			}

			if (ExportFormat != null)
			{
				hash = hash * 59 + ExportFormat.GetHashCode();
			}

			if (ExportTitle != null)
			{
				hash = hash * 59 + ExportTitle.GetHashCode();
			}

			if (Association != null)
			{
				hash = hash * 59 + Association.GetHashCode();
			}

			if (AssociationName != null)
			{
				hash = hash * 59 + AssociationName.GetHashCode();
			}

			if (BusObId != null)
			{
				hash = hash * 59 + BusObId.GetHashCode();
			}

			if (CustomGridDefId != null)
			{
				hash = hash * 59 + CustomGridDefId.GetHashCode();
			}

			if (DateTimeFormatting != null)
			{
				hash = hash * 59 + DateTimeFormatting.GetHashCode();
			}

			if (FieldId != null)
			{
				hash = hash * 59 + FieldId.GetHashCode();
			}

			if (Fields != null)
			{
				hash = hash * 59 + Fields.GetHashCode();
			}

			if (Filters != null)
			{
				hash = hash * 59 + Filters.GetHashCode();
			}

			if (IncludeAllFields != null)
			{
				hash = hash * 59 + IncludeAllFields.GetHashCode();
			}

			if (IncludeSchema != null)
			{
				hash = hash * 59 + IncludeSchema.GetHashCode();
			}

			if (PageNumber != null)
			{
				hash = hash * 59 + PageNumber.GetHashCode();
			}

			if (PageSize != null)
			{
				hash = hash * 59 + PageSize.GetHashCode();
			}

			if (Scope != null)
			{
				hash = hash * 59 + Scope.GetHashCode();
			}

			if (ScopeOwner != null)
			{
				hash = hash * 59 + ScopeOwner.GetHashCode();
			}

			if (SearchId != null)
			{
				hash = hash * 59 + SearchId.GetHashCode();
			}

			if (SearchName != null)
			{
				hash = hash * 59 + SearchName.GetHashCode();
			}

			if (SearchText != null)
			{
				hash = hash * 59 + SearchText.GetHashCode();
			}

			if (Sorting != null)
			{
				hash = hash * 59 + Sorting.GetHashCode();
			}

			if (PromptValues != null)
			{
				hash = hash * 59 + PromptValues.GetHashCode();
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
