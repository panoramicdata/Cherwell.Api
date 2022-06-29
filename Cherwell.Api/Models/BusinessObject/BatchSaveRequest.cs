using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectBatchSaveRequest
/// </summary>
[DataContract]
public partial class BatchSaveRequest
{
	/// <summary>
	/// Initializes a new instance of the <see cref="BatchSaveRequest" /> class.
	/// </summary>
	/// <param name="SaveRequests">SaveRequests.</param>
	/// <param name="StopOnError">StopOnError.</param>
	public BatchSaveRequest(List<SaveRequest> SaveRequests, bool? StopOnError)
	{
		this.SaveRequests = SaveRequests;
		this.StopOnError = StopOnError;
	}

	/// <summary>
	/// SaveRequests
	/// </summary>
	[DataMember(Name = "saveRequests", EmitDefaultValue = false)]
	public List<SaveRequest> SaveRequests { get; set; }

	/// <summary>
	/// StopOnError
	/// </summary>
	[DataMember(Name = "stopOnError", EmitDefaultValue = false)]
	public bool? StopOnError { get; set; }







}