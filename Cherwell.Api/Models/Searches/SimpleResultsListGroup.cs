using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesSimpleResultsListGroup
/// </summary>
[DataContract]
public partial class SimpleResultsListGroup : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SimpleResultsListGroup" /> class.
	/// </summary>
	/// <param name="IsBusObTarget">IsBusObTarget.</param>
	/// <param name="SimpleResultsListItems">SimpleResultsListItems.</param>
	/// <param name="SubTitle">SubTitle.</param>
	/// <param name="TargetId">TargetId.</param>
	/// <param name="Title">Title.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public SimpleResultsListGroup(bool? IsBusObTarget, List<SimpleResultsListItem> SimpleResultsListItems, string SubTitle, string TargetId, string Title, string errorCode, string errorMessage, bool? hasError, EnumHttpStatusCode HttpStatusCode)
	{
		this.IsBusObTarget = IsBusObTarget;
		this.SimpleResultsListItems = SimpleResultsListItems;
		this.SubTitle = SubTitle;
		this.TargetId = TargetId;
		this.Title = Title;
		this.ErrorCode = errorCode;
		this.ErrorMessage = errorMessage;
		this.HasError = hasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// IsBusObTarget
	/// </summary>
	[DataMember(Name = "isBusObTarget", EmitDefaultValue = false)]
	public bool? IsBusObTarget { get; set; }

	/// <summary>
	/// SimpleResultsListItems
	/// </summary>
	[DataMember(Name = "simpleResultsListItems", EmitDefaultValue = false)]
	public List<SimpleResultsListItem> SimpleResultsListItems { get; set; }

	/// <summary>
	/// SubTitle
	/// </summary>
	[DataMember(Name = "subTitle", EmitDefaultValue = false)]
	public string SubTitle { get; set; }

	/// <summary>
	/// TargetId
	/// </summary>
	[DataMember(Name = "targetId", EmitDefaultValue = false)]
	public string TargetId { get; set; }

	/// <summary>
	/// Title
	/// </summary>
	[DataMember(Name = "title", EmitDefaultValue = false)]
	public string Title { get; set; }
}
