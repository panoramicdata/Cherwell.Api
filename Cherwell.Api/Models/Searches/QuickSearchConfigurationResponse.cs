using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesQuickSearchConfigurationResponse
/// </summary>
[DataContract]
public partial class QuickSearchConfigurationResponse : IEquatable<QuickSearchConfigurationResponse>, IValidatableObject
{
	/// <summary>
	/// Gets or Sets HttpStatusCode
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnumHttpStatusCode
	{

		/// <summary>
		/// Enum Continue for "Continue"
		/// </summary>
		[EnumMember(Value = "Continue")]
		Continue,

		/// <summary>
		/// Enum SwitchingProtocols for "SwitchingProtocols"
		/// </summary>
		[EnumMember(Value = "SwitchingProtocols")]
		SwitchingProtocols,

		/// <summary>
		/// Enum OK for "OK"
		/// </summary>
		[EnumMember(Value = "OK")]
		OK,

		/// <summary>
		/// Enum Created for "Created"
		/// </summary>
		[EnumMember(Value = "Created")]
		Created,

		/// <summary>
		/// Enum Accepted for "Accepted"
		/// </summary>
		[EnumMember(Value = "Accepted")]
		Accepted,

		/// <summary>
		/// Enum NonAuthoritativeInformation for "NonAuthoritativeInformation"
		/// </summary>
		[EnumMember(Value = "NonAuthoritativeInformation")]
		NonAuthoritativeInformation,

		/// <summary>
		/// Enum NoContent for "NoContent"
		/// </summary>
		[EnumMember(Value = "NoContent")]
		NoContent,

		/// <summary>
		/// Enum ResetContent for "ResetContent"
		/// </summary>
		[EnumMember(Value = "ResetContent")]
		ResetContent,

		/// <summary>
		/// Enum PartialContent for "PartialContent"
		/// </summary>
		[EnumMember(Value = "PartialContent")]
		PartialContent,

		/// <summary>
		/// Enum MultipleChoices for "MultipleChoices"
		/// </summary>
		[EnumMember(Value = "MultipleChoices")]
		MultipleChoices,

		/// <summary>
		/// Enum Ambiguous for "Ambiguous"
		/// </summary>
		[EnumMember(Value = "Ambiguous")]
		Ambiguous,

		/// <summary>
		/// Enum MovedPermanently for "MovedPermanently"
		/// </summary>
		[EnumMember(Value = "MovedPermanently")]
		MovedPermanently,

		/// <summary>
		/// Enum Moved for "Moved"
		/// </summary>
		[EnumMember(Value = "Moved")]
		Moved,

		/// <summary>
		/// Enum Found for "Found"
		/// </summary>
		[EnumMember(Value = "Found")]
		Found,

		/// <summary>
		/// Enum Redirect for "Redirect"
		/// </summary>
		[EnumMember(Value = "Redirect")]
		Redirect,

		/// <summary>
		/// Enum SeeOther for "SeeOther"
		/// </summary>
		[EnumMember(Value = "SeeOther")]
		SeeOther,

		/// <summary>
		/// Enum RedirectMethod for "RedirectMethod"
		/// </summary>
		[EnumMember(Value = "RedirectMethod")]
		RedirectMethod,

		/// <summary>
		/// Enum NotModified for "NotModified"
		/// </summary>
		[EnumMember(Value = "NotModified")]
		NotModified,

		/// <summary>
		/// Enum UseProxy for "UseProxy"
		/// </summary>
		[EnumMember(Value = "UseProxy")]
		UseProxy,

		/// <summary>
		/// Enum Unused for "Unused"
		/// </summary>
		[EnumMember(Value = "Unused")]
		Unused,

		/// <summary>
		/// Enum TemporaryRedirect for "TemporaryRedirect"
		/// </summary>
		[EnumMember(Value = "TemporaryRedirect")]
		TemporaryRedirect,

		/// <summary>
		/// Enum RedirectKeepVerb for "RedirectKeepVerb"
		/// </summary>
		[EnumMember(Value = "RedirectKeepVerb")]
		RedirectKeepVerb,

		/// <summary>
		/// Enum BadRequest for "BadRequest"
		/// </summary>
		[EnumMember(Value = "BadRequest")]
		BadRequest,

		/// <summary>
		/// Enum Unauthorized for "Unauthorized"
		/// </summary>
		[EnumMember(Value = "Unauthorized")]
		Unauthorized,

		/// <summary>
		/// Enum PaymentRequired for "PaymentRequired"
		/// </summary>
		[EnumMember(Value = "PaymentRequired")]
		PaymentRequired,

		/// <summary>
		/// Enum Forbidden for "Forbidden"
		/// </summary>
		[EnumMember(Value = "Forbidden")]
		Forbidden,

		/// <summary>
		/// Enum NotFound for "NotFound"
		/// </summary>
		[EnumMember(Value = "NotFound")]
		NotFound,

		/// <summary>
		/// Enum MethodNotAllowed for "MethodNotAllowed"
		/// </summary>
		[EnumMember(Value = "MethodNotAllowed")]
		MethodNotAllowed,

		/// <summary>
		/// Enum NotAcceptable for "NotAcceptable"
		/// </summary>
		[EnumMember(Value = "NotAcceptable")]
		NotAcceptable,

		/// <summary>
		/// Enum ProxyAuthenticationRequired for "ProxyAuthenticationRequired"
		/// </summary>
		[EnumMember(Value = "ProxyAuthenticationRequired")]
		ProxyAuthenticationRequired,

		/// <summary>
		/// Enum RequestTimeout for "RequestTimeout"
		/// </summary>
		[EnumMember(Value = "RequestTimeout")]
		RequestTimeout,

		/// <summary>
		/// Enum Conflict for "Conflict"
		/// </summary>
		[EnumMember(Value = "Conflict")]
		Conflict,

		/// <summary>
		/// Enum Gone for "Gone"
		/// </summary>
		[EnumMember(Value = "Gone")]
		Gone,

		/// <summary>
		/// Enum LengthRequired for "LengthRequired"
		/// </summary>
		[EnumMember(Value = "LengthRequired")]
		LengthRequired,

		/// <summary>
		/// Enum PreconditionFailed for "PreconditionFailed"
		/// </summary>
		[EnumMember(Value = "PreconditionFailed")]
		PreconditionFailed,

		/// <summary>
		/// Enum RequestEntityTooLarge for "RequestEntityTooLarge"
		/// </summary>
		[EnumMember(Value = "RequestEntityTooLarge")]
		RequestEntityTooLarge,

		/// <summary>
		/// Enum RequestUriTooLong for "RequestUriTooLong"
		/// </summary>
		[EnumMember(Value = "RequestUriTooLong")]
		RequestUriTooLong,

		/// <summary>
		/// Enum UnsupportedMediaType for "UnsupportedMediaType"
		/// </summary>
		[EnumMember(Value = "UnsupportedMediaType")]
		UnsupportedMediaType,

		/// <summary>
		/// Enum RequestedRangeNotSatisfiable for "RequestedRangeNotSatisfiable"
		/// </summary>
		[EnumMember(Value = "RequestedRangeNotSatisfiable")]
		RequestedRangeNotSatisfiable,

		/// <summary>
		/// Enum ExpectationFailed for "ExpectationFailed"
		/// </summary>
		[EnumMember(Value = "ExpectationFailed")]
		ExpectationFailed,

		/// <summary>
		/// Enum UpgradeRequired for "UpgradeRequired"
		/// </summary>
		[EnumMember(Value = "UpgradeRequired")]
		UpgradeRequired,

		/// <summary>
		/// Enum InternalServerError for "InternalServerError"
		/// </summary>
		[EnumMember(Value = "InternalServerError")]
		InternalServerError,

		/// <summary>
		/// Enum NotImplemented for "NotImplemented"
		/// </summary>
		[EnumMember(Value = "NotImplemented")]
		NotImplemented,

		/// <summary>
		/// Enum BadGateway for "BadGateway"
		/// </summary>
		[EnumMember(Value = "BadGateway")]
		BadGateway,

		/// <summary>
		/// Enum ServiceUnavailable for "ServiceUnavailable"
		/// </summary>
		[EnumMember(Value = "ServiceUnavailable")]
		ServiceUnavailable,

		/// <summary>
		/// Enum GatewayTimeout for "GatewayTimeout"
		/// </summary>
		[EnumMember(Value = "GatewayTimeout")]
		GatewayTimeout,

		/// <summary>
		/// Enum HttpVersionNotSupported for "HttpVersionNotSupported"
		/// </summary>
		[EnumMember(Value = "HttpVersionNotSupported")]
		HttpVersionNotSupported
	}

	/// <summary>
	/// Gets or Sets HttpStatusCode
	/// </summary>
	[DataMember(Name = "httpStatusCode", EmitDefaultValue = false)]
	public EnumHttpStatusCode? HttpStatusCode { get; set; }
	/// <summary>
	/// Initializes a new instance of the <see cref="QuickSearchConfigurationResponse" /> class.
	/// </summary>
	/// <param name="AllowQuickSearch">AllowQuickSearch.</param>
	/// <param name="AllowSpecificSearch">AllowSpecificSearch.</param>
	/// <param name="DefaultToQuickSearch">DefaultToQuickSearch.</param>
	/// <param name="DisplayName">DisplayName.</param>
	/// <param name="GalleryImage">GalleryImage.</param>
	/// <param name="History">History.</param>
	/// <param name="IncludeAvailableInSpecific">IncludeAvailableInSpecific.</param>
	/// <param name="IncludeQuickSearchInSpecific">IncludeQuickSearchInSpecific.</param>
	/// <param name="QuickSearchId">QuickSearchId.</param>
	/// <param name="QuickSearchItems">QuickSearchItems.</param>
	/// <param name="QuickSearchWatermark">QuickSearchWatermark.</param>
	/// <param name="SortByRelevance">SortByRelevance.</param>
	/// <param name="ResolvedQuickSearchWatermark">ResolvedQuickSearchWatermark.</param>
	/// <param name="Scope">Scope.</param>
	/// <param name="ScopeOwner">ScopeOwner.</param>
	/// <param name="SpecificSearchItems">SpecificSearchItems.</param>
	/// <param name="ErrorCode">ErrorCode.</param>
	/// <param name="ErrorMessage">ErrorMessage.</param>
	/// <param name="HasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public QuickSearchConfigurationResponse(bool? AllowQuickSearch, bool? AllowSpecificSearch, bool? DefaultToQuickSearch, string DisplayName, string GalleryImage, List<string> History, bool? IncludeAvailableInSpecific, bool? IncludeQuickSearchInSpecific, string QuickSearchId, List<QuickSearchItem> QuickSearchItems, string QuickSearchWatermark, bool? SortByRelevance, string ResolvedQuickSearchWatermark, string Scope, string ScopeOwner, List<QuickSearchItem> SpecificSearchItems, string ErrorCode, string ErrorMessage, bool? HasError, EnumHttpStatusCode? HttpStatusCode)
	{
		this.AllowQuickSearch = AllowQuickSearch;
		this.AllowSpecificSearch = AllowSpecificSearch;
		this.DefaultToQuickSearch = DefaultToQuickSearch;
		this.DisplayName = DisplayName;
		this.GalleryImage = GalleryImage;
		this.History = History;
		this.IncludeAvailableInSpecific = IncludeAvailableInSpecific;
		this.IncludeQuickSearchInSpecific = IncludeQuickSearchInSpecific;
		this.QuickSearchId = QuickSearchId;
		this.QuickSearchItems = QuickSearchItems;
		this.QuickSearchWatermark = QuickSearchWatermark;
		this.SortByRelevance = SortByRelevance;
		this.ResolvedQuickSearchWatermark = ResolvedQuickSearchWatermark;
		this.Scope = Scope;
		this.ScopeOwner = ScopeOwner;
		this.SpecificSearchItems = SpecificSearchItems;
		this.ErrorCode = ErrorCode;
		this.ErrorMessage = ErrorMessage;
		this.HasError = HasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// Gets or Sets AllowQuickSearch
	/// </summary>
	[DataMember(Name = "allowQuickSearch", EmitDefaultValue = false)]
	public bool? AllowQuickSearch { get; set; }
	/// <summary>
	/// Gets or Sets AllowSpecificSearch
	/// </summary>
	[DataMember(Name = "allowSpecificSearch", EmitDefaultValue = false)]
	public bool? AllowSpecificSearch { get; set; }
	/// <summary>
	/// Gets or Sets DefaultToQuickSearch
	/// </summary>
	[DataMember(Name = "defaultToQuickSearch", EmitDefaultValue = false)]
	public bool? DefaultToQuickSearch { get; set; }
	/// <summary>
	/// Gets or Sets DisplayName
	/// </summary>
	[DataMember(Name = "displayName", EmitDefaultValue = false)]
	public string DisplayName { get; set; }
	/// <summary>
	/// Gets or Sets GalleryImage
	/// </summary>
	[DataMember(Name = "galleryImage", EmitDefaultValue = false)]
	public string GalleryImage { get; set; }
	/// <summary>
	/// Gets or Sets History
	/// </summary>
	[DataMember(Name = "history", EmitDefaultValue = false)]
	public List<string> History { get; set; }
	/// <summary>
	/// Gets or Sets IncludeAvailableInSpecific
	/// </summary>
	[DataMember(Name = "includeAvailableInSpecific", EmitDefaultValue = false)]
	public bool? IncludeAvailableInSpecific { get; set; }
	/// <summary>
	/// Gets or Sets IncludeQuickSearchInSpecific
	/// </summary>
	[DataMember(Name = "includeQuickSearchInSpecific", EmitDefaultValue = false)]
	public bool? IncludeQuickSearchInSpecific { get; set; }
	/// <summary>
	/// Gets or Sets QuickSearchId
	/// </summary>
	[DataMember(Name = "quickSearchId", EmitDefaultValue = false)]
	public string QuickSearchId { get; set; }
	/// <summary>
	/// Gets or Sets QuickSearchItems
	/// </summary>
	[DataMember(Name = "quickSearchItems", EmitDefaultValue = false)]
	public List<QuickSearchItem> QuickSearchItems { get; set; }
	/// <summary>
	/// Gets or Sets QuickSearchWatermark
	/// </summary>
	[DataMember(Name = "quickSearchWatermark", EmitDefaultValue = false)]
	public string QuickSearchWatermark { get; set; }
	/// <summary>
	/// Gets or Sets SortByRelevance
	/// </summary>
	[DataMember(Name = "sortByRelevance", EmitDefaultValue = false)]
	public bool? SortByRelevance { get; set; }
	/// <summary>
	/// Gets or Sets ResolvedQuickSearchWatermark
	/// </summary>
	[DataMember(Name = "resolvedQuickSearchWatermark", EmitDefaultValue = false)]
	public string ResolvedQuickSearchWatermark { get; set; }
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
	/// Gets or Sets SpecificSearchItems
	/// </summary>
	[DataMember(Name = "specificSearchItems", EmitDefaultValue = false)]
	public List<QuickSearchItem> SpecificSearchItems { get; set; }
	/// <summary>
	/// Gets or Sets ErrorCode
	/// </summary>
	[DataMember(Name = "errorCode", EmitDefaultValue = false)]
	public string ErrorCode { get; set; }
	/// <summary>
	/// Gets or Sets ErrorMessage
	/// </summary>
	[DataMember(Name = "errorMessage", EmitDefaultValue = false)]
	public string ErrorMessage { get; set; }
	/// <summary>
	/// Gets or Sets HasError
	/// </summary>
	[DataMember(Name = "hasError", EmitDefaultValue = false)]
	public bool? HasError { get; set; }
	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SearchesQuickSearchConfigurationResponse {\n");
		sb.Append("  AllowQuickSearch: ").Append(AllowQuickSearch).Append('\n');
		sb.Append("  AllowSpecificSearch: ").Append(AllowSpecificSearch).Append('\n');
		sb.Append("  DefaultToQuickSearch: ").Append(DefaultToQuickSearch).Append('\n');
		sb.Append("  DisplayName: ").Append(DisplayName).Append('\n');
		sb.Append("  GalleryImage: ").Append(GalleryImage).Append('\n');
		sb.Append("  History: ").Append(History).Append('\n');
		sb.Append("  IncludeAvailableInSpecific: ").Append(IncludeAvailableInSpecific).Append('\n');
		sb.Append("  IncludeQuickSearchInSpecific: ").Append(IncludeQuickSearchInSpecific).Append('\n');
		sb.Append("  QuickSearchId: ").Append(QuickSearchId).Append('\n');
		sb.Append("  QuickSearchItems: ").Append(QuickSearchItems).Append('\n');
		sb.Append("  QuickSearchWatermark: ").Append(QuickSearchWatermark).Append('\n');
		sb.Append("  SortByRelevance: ").Append(SortByRelevance).Append('\n');
		sb.Append("  ResolvedQuickSearchWatermark: ").Append(ResolvedQuickSearchWatermark).Append('\n');
		sb.Append("  Scope: ").Append(Scope).Append('\n');
		sb.Append("  ScopeOwner: ").Append(ScopeOwner).Append('\n');
		sb.Append("  SpecificSearchItems: ").Append(SpecificSearchItems).Append('\n');
		sb.Append("  ErrorCode: ").Append(ErrorCode).Append('\n');
		sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append('\n');
		sb.Append("  HasError: ").Append(HasError).Append('\n');
		sb.Append("  HttpStatusCode: ").Append(HttpStatusCode).Append('\n');
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
		return Equals(obj as QuickSearchConfigurationResponse);
	}

	/// <summary>
	/// Returns true if SearchesQuickSearchConfigurationResponse instances are equal
	/// </summary>
	/// <param name="other">Instance of SearchesQuickSearchConfigurationResponse to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(QuickSearchConfigurationResponse? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					AllowQuickSearch == other.AllowQuickSearch ||
					AllowQuickSearch != null &&
					AllowQuickSearch.Equals(other.AllowQuickSearch)
				) &&
				(
					AllowSpecificSearch == other.AllowSpecificSearch ||
					AllowSpecificSearch != null &&
					AllowSpecificSearch.Equals(other.AllowSpecificSearch)
				) &&
				(
					DefaultToQuickSearch == other.DefaultToQuickSearch ||
					DefaultToQuickSearch != null &&
					DefaultToQuickSearch.Equals(other.DefaultToQuickSearch)
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
					History == other.History ||
					History != null &&
					History.SequenceEqual(other.History)
				) &&
				(
					IncludeAvailableInSpecific == other.IncludeAvailableInSpecific ||
					IncludeAvailableInSpecific != null &&
					IncludeAvailableInSpecific.Equals(other.IncludeAvailableInSpecific)
				) &&
				(
					IncludeQuickSearchInSpecific == other.IncludeQuickSearchInSpecific ||
					IncludeQuickSearchInSpecific != null &&
					IncludeQuickSearchInSpecific.Equals(other.IncludeQuickSearchInSpecific)
				) &&
				(
					QuickSearchId == other.QuickSearchId ||
					QuickSearchId != null &&
					QuickSearchId.Equals(other.QuickSearchId, StringComparison.Ordinal)
				) &&
				(
					QuickSearchItems == other.QuickSearchItems ||
					QuickSearchItems != null &&
					QuickSearchItems.SequenceEqual(other.QuickSearchItems)
				) &&
				(
					QuickSearchWatermark == other.QuickSearchWatermark ||
					QuickSearchWatermark != null &&
					QuickSearchWatermark.Equals(other.QuickSearchWatermark, StringComparison.Ordinal)
				) &&
				(
					SortByRelevance == other.SortByRelevance ||
					SortByRelevance != null &&
					SortByRelevance.Equals(other.SortByRelevance)
				) &&
				(
					ResolvedQuickSearchWatermark == other.ResolvedQuickSearchWatermark ||
					ResolvedQuickSearchWatermark != null &&
					ResolvedQuickSearchWatermark.Equals(other.ResolvedQuickSearchWatermark, StringComparison.Ordinal)
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
					SpecificSearchItems == other.SpecificSearchItems ||
					SpecificSearchItems != null &&
					SpecificSearchItems.SequenceEqual(other.SpecificSearchItems)
				) &&
				(
					ErrorCode == other.ErrorCode ||
					ErrorCode != null &&
					ErrorCode.Equals(other.ErrorCode, StringComparison.Ordinal)
				) &&
				(
					ErrorMessage == other.ErrorMessage ||
					ErrorMessage != null &&
					ErrorMessage.Equals(other.ErrorMessage, StringComparison.Ordinal)
				) &&
				(
					HasError == other.HasError ||
					HasError != null &&
					HasError.Equals(other.HasError)
				) &&
				(
					HttpStatusCode == other.HttpStatusCode ||
					HttpStatusCode != null &&
					HttpStatusCode.Equals(other.HttpStatusCode)
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
			if (AllowQuickSearch != null)
			{
				hash = hash * 59 + AllowQuickSearch.GetHashCode();
			}

			if (AllowSpecificSearch != null)
			{
				hash = hash * 59 + AllowSpecificSearch.GetHashCode();
			}

			if (DefaultToQuickSearch != null)
			{
				hash = hash * 59 + DefaultToQuickSearch.GetHashCode();
			}

			if (DisplayName != null)
			{
				hash = hash * 59 + DisplayName.GetHashCode();
			}

			if (GalleryImage != null)
			{
				hash = hash * 59 + GalleryImage.GetHashCode();
			}

			if (History != null)
			{
				hash = hash * 59 + History.GetHashCode();
			}

			if (IncludeAvailableInSpecific != null)
			{
				hash = hash * 59 + IncludeAvailableInSpecific.GetHashCode();
			}

			if (IncludeQuickSearchInSpecific != null)
			{
				hash = hash * 59 + IncludeQuickSearchInSpecific.GetHashCode();
			}

			if (QuickSearchId != null)
			{
				hash = hash * 59 + QuickSearchId.GetHashCode();
			}

			if (QuickSearchItems != null)
			{
				hash = hash * 59 + QuickSearchItems.GetHashCode();
			}

			if (QuickSearchWatermark != null)
			{
				hash = hash * 59 + QuickSearchWatermark.GetHashCode();
			}

			if (SortByRelevance != null)
			{
				hash = hash * 59 + SortByRelevance.GetHashCode();
			}

			if (ResolvedQuickSearchWatermark != null)
			{
				hash = hash * 59 + ResolvedQuickSearchWatermark.GetHashCode();
			}

			if (Scope != null)
			{
				hash = hash * 59 + Scope.GetHashCode();
			}

			if (ScopeOwner != null)
			{
				hash = hash * 59 + ScopeOwner.GetHashCode();
			}

			if (SpecificSearchItems != null)
			{
				hash = hash * 59 + SpecificSearchItems.GetHashCode();
			}

			if (ErrorCode != null)
			{
				hash = hash * 59 + ErrorCode.GetHashCode();
			}

			if (ErrorMessage != null)
			{
				hash = hash * 59 + ErrorMessage.GetHashCode();
			}

			if (HasError != null)
			{
				hash = hash * 59 + HasError.GetHashCode();
			}

			if (HttpStatusCode != null)
			{
				hash = hash * 59 + HttpStatusCode.GetHashCode();
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
