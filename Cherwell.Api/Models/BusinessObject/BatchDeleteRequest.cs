using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectBatchDeleteRequest
/// </summary>
[DataContract]
public partial class BatchDeleteRequest
{
	/// <summary>
	/// Initializes a new instance of the <see cref="BatchDeleteRequest" /> class.
	/// </summary>
	/// <param name="DeleteRequests">DeleteRequests.</param>
	/// <param name="StopOnError">StopOnError.</param>
	public BatchDeleteRequest(List<DeleteRequest> DeleteRequests, bool? StopOnError)
	{
		this.DeleteRequests = DeleteRequests;
		this.StopOnError = StopOnError;
	}

	/// <summary>
	/// DeleteRequests
	/// </summary>
	[DataMember(Name = "deleteRequests", EmitDefaultValue = false)]
	public List<DeleteRequest> DeleteRequests { get; set; }

	/// <summary>
	/// StopOnError
	/// </summary>
	[DataMember(Name = "stopOnError", EmitDefaultValue = false)]
	public bool? StopOnError { get; set; }







}