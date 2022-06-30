using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesQuickSearchItem
/// </summary>
[DataContract]
public partial class QuickSearchItem
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
	public EnumChangedOption ChangedOption { get; set; }
	/// <summary>
	/// NonFinalStateOption
	/// </summary>
	[DataMember(Name = "nonFinalStateOption", EmitDefaultValue = false)]
	public EnumNonFinalStateOption NonFinalStateOption { get; set; }
	/// <summary>
	/// SearchAnyWordsOption
	/// </summary>
	[DataMember(Name = "searchAnyWordsOption", EmitDefaultValue = false)]
	public EnumSearchAnyWordsOption SearchAnyWordsOption { get; set; }
	/// <summary>
	/// SearchAttachmentsOption
	/// </summary>
	[DataMember(Name = "searchAttachmentsOption", EmitDefaultValue = false)]
	public EnumSearchAttachmentsOption SearchAttachmentsOption { get; set; }
	/// <summary>
	/// SearchRelatedOption
	/// </summary>
	[DataMember(Name = "searchRelatedOption", EmitDefaultValue = false)]
	public EnumSearchRelatedOption SearchRelatedOption { get; set; }
	/// <summary>
	/// SearchTargetType
	/// </summary>
	[DataMember(Name = "searchTargetType", EmitDefaultValue = false)]
	public EnumSearchTargetType SearchTargetType { get; set; }
	/// <summary>
	/// SortByOption
	/// </summary>
	[DataMember(Name = "sortByOption", EmitDefaultValue = false)]
	public EnumSortByOption SortByOption { get; set; }
	/// <summary>
	/// Ascending
	/// </summary>
	[DataMember(Name = "ascending", EmitDefaultValue = false)]
	public bool Ascending { get; set; }

	/// <summary>
	/// ChangedLimits
	/// </summary>
	[DataMember(Name = "changedLimits", EmitDefaultValue = false)]
	public List<ChangedLimit> ChangedLimits { get; set; } = null!;

	/// <summary>
	/// DisplayName
	/// </summary>
	[DataMember(Name = "displayName", EmitDefaultValue = false)]
	public string DisplayName { get; set; } = null!;

	/// <summary>
	/// GalleryImage
	/// </summary>
	[DataMember(Name = "galleryImage", EmitDefaultValue = false)]
	public string GalleryImage { get; set; } = null!;

	/// <summary>
	/// HasAnyOptions
	/// </summary>
	[DataMember(Name = "hasAnyOptions", EmitDefaultValue = false)]
	public bool HasAnyOptions { get; set; }

	/// <summary>
	/// SearchTargetId
	/// </summary>
	[DataMember(Name = "searchTargetId", EmitDefaultValue = false)]
	public string SearchTargetId { get; set; } = null!;

	/// <summary>
	/// SelectedChangedLimit
	/// </summary>
	[DataMember(Name = "selectedChangedLimit", EmitDefaultValue = false)]
	public ChangedLimit SelectedChangedLimit { get; set; } = null!;

	/// <summary>
	/// SelectedSortByFieldId
	/// </summary>
	[DataMember(Name = "selectedSortByFieldId", EmitDefaultValue = false)]
	public string SelectedSortByFieldId { get; set; } = null!;

	/// <summary>
	/// SortByFields
	/// </summary>
	[DataMember(Name = "sortByFields", EmitDefaultValue = false)]
	public Dictionary<string, string> SortByFields { get; set; } = null!;

	/// <summary>
	/// WatermarkText
	/// </summary>
	[DataMember(Name = "watermarkText", EmitDefaultValue = false)]
	public string WatermarkText { get; set; } = null!;
}
