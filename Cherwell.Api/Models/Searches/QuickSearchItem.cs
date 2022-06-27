using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesQuickSearchItem
/// </summary>
[DataContract]
public partial class QuickSearchItem : IEquatable<QuickSearchItem>, IValidatableObject
{
	/// <summary>
	/// ChangedOption
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnumChangedOption
	{

		/// <summary>
		/// Enum None for "None"
		/// </summary>
		[EnumMember(Value = "None")]
		None,

		/// <summary>
		/// Enum Use for "Use"
		/// </summary>
		[EnumMember(Value = "Use")]
		Use,

		/// <summary>
		/// Enum Display for "Display"
		/// </summary>
		[EnumMember(Value = "Display")]
		Display,

		/// <summary>
		/// Enum UseAndDisplay for "UseAndDisplay"
		/// </summary>
		[EnumMember(Value = "UseAndDisplay")]
		UseAndDisplay
	}

	/// <summary>
	/// NonFinalStateOption
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnumNonFinalStateOption
	{

		/// <summary>
		/// Enum None for "None"
		/// </summary>
		[EnumMember(Value = "None")]
		None,

		/// <summary>
		/// Enum Use for "Use"
		/// </summary>
		[EnumMember(Value = "Use")]
		Use,

		/// <summary>
		/// Enum Display for "Display"
		/// </summary>
		[EnumMember(Value = "Display")]
		Display,

		/// <summary>
		/// Enum UseAndDisplay for "UseAndDisplay"
		/// </summary>
		[EnumMember(Value = "UseAndDisplay")]
		UseAndDisplay
	}

	/// <summary>
	/// SearchAnyWordsOption
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnumSearchAnyWordsOption
	{

		/// <summary>
		/// Enum None for "None"
		/// </summary>
		[EnumMember(Value = "None")]
		None,

		/// <summary>
		/// Enum Use for "Use"
		/// </summary>
		[EnumMember(Value = "Use")]
		Use,

		/// <summary>
		/// Enum Display for "Display"
		/// </summary>
		[EnumMember(Value = "Display")]
		Display,

		/// <summary>
		/// Enum UseAndDisplay for "UseAndDisplay"
		/// </summary>
		[EnumMember(Value = "UseAndDisplay")]
		UseAndDisplay
	}

	/// <summary>
	/// SearchAttachmentsOption
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnumSearchAttachmentsOption
	{

		/// <summary>
		/// Enum None for "None"
		/// </summary>
		[EnumMember(Value = "None")]
		None,

		/// <summary>
		/// Enum Use for "Use"
		/// </summary>
		[EnumMember(Value = "Use")]
		Use,

		/// <summary>
		/// Enum Display for "Display"
		/// </summary>
		[EnumMember(Value = "Display")]
		Display,

		/// <summary>
		/// Enum UseAndDisplay for "UseAndDisplay"
		/// </summary>
		[EnumMember(Value = "UseAndDisplay")]
		UseAndDisplay
	}

	/// <summary>
	/// SearchRelatedOption
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnumSearchRelatedOption
	{

		/// <summary>
		/// Enum None for "None"
		/// </summary>
		[EnumMember(Value = "None")]
		None,

		/// <summary>
		/// Enum Use for "Use"
		/// </summary>
		[EnumMember(Value = "Use")]
		Use,

		/// <summary>
		/// Enum Display for "Display"
		/// </summary>
		[EnumMember(Value = "Display")]
		Display,

		/// <summary>
		/// Enum UseAndDisplay for "UseAndDisplay"
		/// </summary>
		[EnumMember(Value = "UseAndDisplay")]
		UseAndDisplay
	}

	/// <summary>
	/// SearchTargetType
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnumSearchTargetType
	{

		/// <summary>
		/// Enum BusOb for "BusOb"
		/// </summary>
		[EnumMember(Value = "BusOb")]
		BusOb,

		/// <summary>
		/// Enum DocRepository for "DocRepository"
		/// </summary>
		[EnumMember(Value = "DocRepository")]
		DocRepository
	}

	/// <summary>
	/// SortByOption
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnumSortByOption
	{

		/// <summary>
		/// Enum None for "None"
		/// </summary>
		[EnumMember(Value = "None")]
		None,

		/// <summary>
		/// Enum Use for "Use"
		/// </summary>
		[EnumMember(Value = "Use")]
		Use,

		/// <summary>
		/// Enum Display for "Display"
		/// </summary>
		[EnumMember(Value = "Display")]
		Display,

		/// <summary>
		/// Enum UseAndDisplay for "UseAndDisplay"
		/// </summary>
		[EnumMember(Value = "UseAndDisplay")]
		UseAndDisplay
	}

	/// <summary>
	/// ChangedOption
	/// </summary>
	[DataMember(Name = "changedOption", EmitDefaultValue = false)]
	public EnumChangedOption? ChangedOption { get; set; }

	/// <summary>
	/// NonFinalStateOption
	/// </summary>
	[DataMember(Name = "nonFinalStateOption", EmitDefaultValue = false)]
	public EnumNonFinalStateOption? NonFinalStateOption { get; set; }

	/// <summary>
	/// SearchAnyWordsOption
	/// </summary>
	[DataMember(Name = "searchAnyWordsOption", EmitDefaultValue = false)]
	public EnumSearchAnyWordsOption? SearchAnyWordsOption { get; set; }

	/// <summary>
	/// SearchAttachmentsOption
	/// </summary>
	[DataMember(Name = "searchAttachmentsOption", EmitDefaultValue = false)]
	public EnumSearchAttachmentsOption? SearchAttachmentsOption { get; set; }

	/// <summary>
	/// SearchRelatedOption
	/// </summary>
	[DataMember(Name = "searchRelatedOption", EmitDefaultValue = false)]
	public EnumSearchRelatedOption? SearchRelatedOption { get; set; }

	/// <summary>
	/// SearchTargetType
	/// </summary>
	[DataMember(Name = "searchTargetType", EmitDefaultValue = false)]
	public EnumSearchTargetType? SearchTargetType { get; set; }

	/// <summary>
	/// SortByOption
	/// </summary>
	[DataMember(Name = "sortByOption", EmitDefaultValue = false)]
	public EnumSortByOption? SortByOption { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="QuickSearchItem" /> class.
	/// </summary>
	/// <param name="Ascending">Ascending.</param>
	/// <param name="ChangedLimits">ChangedLimits.</param>
	/// <param name="ChangedOption">ChangedOption.</param>
	/// <param name="DisplayName">DisplayName.</param>
	/// <param name="GalleryImage">GalleryImage.</param>
	/// <param name="HasAnyOptions">HasAnyOptions.</param>
	/// <param name="NonFinalStateOption">NonFinalStateOption.</param>
	/// <param name="SearchAnyWordsOption">SearchAnyWordsOption.</param>
	/// <param name="SearchAttachmentsOption">SearchAttachmentsOption.</param>
	/// <param name="SearchRelatedOption">SearchRelatedOption.</param>
	/// <param name="SearchTargetId">SearchTargetId.</param>
	/// <param name="SearchTargetType">SearchTargetType.</param>
	/// <param name="SelectedChangedLimit">SelectedChangedLimit.</param>
	/// <param name="SelectedSortByFieldId">SelectedSortByFieldId.</param>
	/// <param name="SortByFields">SortByFields.</param>
	/// <param name="SortByOption">SortByOption.</param>
	/// <param name="WatermarkText">WatermarkText.</param>
	public QuickSearchItem(bool? Ascending, List<ChangedLimit> ChangedLimits, EnumChangedOption? ChangedOption, string DisplayName, string GalleryImage, bool? HasAnyOptions, EnumNonFinalStateOption? NonFinalStateOption, EnumSearchAnyWordsOption? SearchAnyWordsOption, EnumSearchAttachmentsOption? SearchAttachmentsOption, EnumSearchRelatedOption? SearchRelatedOption, string SearchTargetId, EnumSearchTargetType? SearchTargetType, ChangedLimit SelectedChangedLimit, string SelectedSortByFieldId, Dictionary<string, string> SortByFields, EnumSortByOption? SortByOption, string WatermarkText)
	{
		this.Ascending = Ascending;
		this.ChangedLimits = ChangedLimits;
		this.ChangedOption = ChangedOption;
		this.DisplayName = DisplayName;
		this.GalleryImage = GalleryImage;
		this.HasAnyOptions = HasAnyOptions;
		this.NonFinalStateOption = NonFinalStateOption;
		this.SearchAnyWordsOption = SearchAnyWordsOption;
		this.SearchAttachmentsOption = SearchAttachmentsOption;
		this.SearchRelatedOption = SearchRelatedOption;
		this.SearchTargetId = SearchTargetId;
		this.SearchTargetType = SearchTargetType;
		this.SelectedChangedLimit = SelectedChangedLimit;
		this.SelectedSortByFieldId = SelectedSortByFieldId;
		this.SortByFields = SortByFields;
		this.SortByOption = SortByOption;
		this.WatermarkText = WatermarkText;
	}

	/// <summary>
	/// Ascending
	/// </summary>
	[DataMember(Name = "ascending", EmitDefaultValue = false)]
	public bool? Ascending { get; set; }

	/// <summary>
	/// ChangedLimits
	/// </summary>
	[DataMember(Name = "changedLimits", EmitDefaultValue = false)]
	public List<ChangedLimit> ChangedLimits { get; set; }

	/// <summary>
	/// DisplayName
	/// </summary>
	[DataMember(Name = "displayName", EmitDefaultValue = false)]
	public string DisplayName { get; set; }

	/// <summary>
	/// GalleryImage
	/// </summary>
	[DataMember(Name = "galleryImage", EmitDefaultValue = false)]
	public string GalleryImage { get; set; }

	/// <summary>
	/// HasAnyOptions
	/// </summary>
	[DataMember(Name = "hasAnyOptions", EmitDefaultValue = false)]
	public bool? HasAnyOptions { get; set; }

	/// <summary>
	/// SearchTargetId
	/// </summary>
	[DataMember(Name = "searchTargetId", EmitDefaultValue = false)]
	public string SearchTargetId { get; set; }

	/// <summary>
	/// SelectedChangedLimit
	/// </summary>
	[DataMember(Name = "selectedChangedLimit", EmitDefaultValue = false)]
	public ChangedLimit SelectedChangedLimit { get; set; }

	/// <summary>
	/// SelectedSortByFieldId
	/// </summary>
	[DataMember(Name = "selectedSortByFieldId", EmitDefaultValue = false)]
	public string SelectedSortByFieldId { get; set; }

	/// <summary>
	/// SortByFields
	/// </summary>
	[DataMember(Name = "sortByFields", EmitDefaultValue = false)]
	public Dictionary<string, string> SortByFields { get; set; }

	/// <summary>
	/// WatermarkText
	/// </summary>
	[DataMember(Name = "watermarkText", EmitDefaultValue = false)]
	public string WatermarkText { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SearchesQuickSearchItem {\n");
		sb.Append("  Ascending: ").Append(Ascending).Append('\n');
		sb.Append("  ChangedLimits: ").Append(ChangedLimits).Append('\n');
		sb.Append("  ChangedOption: ").Append(ChangedOption).Append('\n');
		sb.Append("  DisplayName: ").Append(DisplayName).Append('\n');
		sb.Append("  GalleryImage: ").Append(GalleryImage).Append('\n');
		sb.Append("  HasAnyOptions: ").Append(HasAnyOptions).Append('\n');
		sb.Append("  NonFinalStateOption: ").Append(NonFinalStateOption).Append('\n');
		sb.Append("  SearchAnyWordsOption: ").Append(SearchAnyWordsOption).Append('\n');
		sb.Append("  SearchAttachmentsOption: ").Append(SearchAttachmentsOption).Append('\n');
		sb.Append("  SearchRelatedOption: ").Append(SearchRelatedOption).Append('\n');
		sb.Append("  SearchTargetId: ").Append(SearchTargetId).Append('\n');
		sb.Append("  SearchTargetType: ").Append(SearchTargetType).Append('\n');
		sb.Append("  SelectedChangedLimit: ").Append(SelectedChangedLimit).Append('\n');
		sb.Append("  SelectedSortByFieldId: ").Append(SelectedSortByFieldId).Append('\n');
		sb.Append("  SortByFields: ").Append(SortByFields).Append('\n');
		sb.Append("  SortByOption: ").Append(SortByOption).Append('\n');
		sb.Append("  WatermarkText: ").Append(WatermarkText).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns true if objects are equal
	/// </summary>
	/// <param name="obj">Object to be compared</param>
	/// <returns>Boolean</returns>
	public override bool Equals(object? obj)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		return Equals(obj as QuickSearchItem);
	}

	/// <summary>
	/// Returns true if SearchesQuickSearchItem instances are equal
	/// </summary>
	/// <param name="other">Instance of SearchesQuickSearchItem to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(QuickSearchItem? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					Ascending == other.Ascending ||
					Ascending != null &&
					Ascending.Equals(other.Ascending)
				) &&
				(
					ChangedLimits == other.ChangedLimits ||
					ChangedLimits != null &&
					ChangedLimits.SequenceEqual(other.ChangedLimits)
				) &&
				(
					ChangedOption == other.ChangedOption ||
					ChangedOption != null &&
					ChangedOption.Equals(other.ChangedOption)
				) &&
				(
					DisplayName == other.DisplayName ||
					DisplayName != null &&
					DisplayName.Equals(other.DisplayName, StringComparison.Ordinal)
				) &&
				(
					GalleryImage == other.GalleryImage ||
					GalleryImage != null &&
					GalleryImage.Equals(other.GalleryImage, StringComparison.Ordinal)
				) &&
				(
					HasAnyOptions == other.HasAnyOptions ||
					HasAnyOptions != null &&
					HasAnyOptions.Equals(other.HasAnyOptions)
				) &&
				(
					NonFinalStateOption == other.NonFinalStateOption ||
					NonFinalStateOption != null &&
					NonFinalStateOption.Equals(other.NonFinalStateOption)
				) &&
				(
					SearchAnyWordsOption == other.SearchAnyWordsOption ||
					SearchAnyWordsOption != null &&
					SearchAnyWordsOption.Equals(other.SearchAnyWordsOption)
				) &&
				(
					SearchAttachmentsOption == other.SearchAttachmentsOption ||
					SearchAttachmentsOption != null &&
					SearchAttachmentsOption.Equals(other.SearchAttachmentsOption)
				) &&
				(
					SearchRelatedOption == other.SearchRelatedOption ||
					SearchRelatedOption != null &&
					SearchRelatedOption.Equals(other.SearchRelatedOption)
				) &&
				(
					SearchTargetId == other.SearchTargetId ||
					SearchTargetId != null &&
					SearchTargetId.Equals(other.SearchTargetId, StringComparison.Ordinal)
				) &&
				(
					SearchTargetType == other.SearchTargetType ||
					SearchTargetType != null &&
					SearchTargetType.Equals(other.SearchTargetType)
				) &&
				(
					SelectedChangedLimit == other.SelectedChangedLimit ||
					SelectedChangedLimit != null &&
					SelectedChangedLimit.Equals(other.SelectedChangedLimit)
				) &&
				(
					SelectedSortByFieldId == other.SelectedSortByFieldId ||
					SelectedSortByFieldId != null &&
					SelectedSortByFieldId.Equals(other.SelectedSortByFieldId, StringComparison.Ordinal)
				) &&
				(
					SortByFields == other.SortByFields ||
					SortByFields != null &&
					SortByFields.SequenceEqual(other.SortByFields)
				) &&
				(
					SortByOption == other.SortByOption ||
					SortByOption != null &&
					SortByOption.Equals(other.SortByOption)
				) &&
				(
					WatermarkText == other.WatermarkText ||
					WatermarkText != null &&
					WatermarkText.Equals(other.WatermarkText, StringComparison.Ordinal)
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
			if (Ascending != null)
			{
				hash = hash * 59 + Ascending.GetHashCode();
			}

			if (ChangedLimits != null)
			{
				hash = hash * 59 + ChangedLimits.GetHashCode();
			}

			if (ChangedOption != null)
			{
				hash = hash * 59 + ChangedOption.GetHashCode();
			}

			if (DisplayName != null)
			{
				hash = hash * 59 + DisplayName.GetHashCode();
			}

			if (GalleryImage != null)
			{
				hash = hash * 59 + GalleryImage.GetHashCode();
			}

			if (HasAnyOptions != null)
			{
				hash = hash * 59 + HasAnyOptions.GetHashCode();
			}

			if (NonFinalStateOption != null)
			{
				hash = hash * 59 + NonFinalStateOption.GetHashCode();
			}

			if (SearchAnyWordsOption != null)
			{
				hash = hash * 59 + SearchAnyWordsOption.GetHashCode();
			}

			if (SearchAttachmentsOption != null)
			{
				hash = hash * 59 + SearchAttachmentsOption.GetHashCode();
			}

			if (SearchRelatedOption != null)
			{
				hash = hash * 59 + SearchRelatedOption.GetHashCode();
			}

			if (SearchTargetId != null)
			{
				hash = hash * 59 + SearchTargetId.GetHashCode();
			}

			if (SearchTargetType != null)
			{
				hash = hash * 59 + SearchTargetType.GetHashCode();
			}

			if (SelectedChangedLimit != null)
			{
				hash = hash * 59 + SelectedChangedLimit.GetHashCode();
			}

			if (SelectedSortByFieldId != null)
			{
				hash = hash * 59 + SelectedSortByFieldId.GetHashCode();
			}

			if (SortByFields != null)
			{
				hash = hash * 59 + SortByFields.GetHashCode();
			}

			if (SortByOption != null)
			{
				hash = hash * 59 + SortByOption.GetHashCode();
			}

			if (WatermarkText != null)
			{
				hash = hash * 59 + WatermarkText.GetHashCode();
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
