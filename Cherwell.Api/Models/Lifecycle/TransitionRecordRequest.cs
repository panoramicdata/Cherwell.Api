using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Lifecycle;

/// <summary>
/// LifecycleTransitionRecordRequest
/// </summary>
[DataContract]
public partial class TransitionRecordRequest
{
	/// <summary>
	/// Initializes a new instance of the <see cref="TransitionRecordRequest" /> class.
	/// </summary>
	/// <param name="TransitionOptionId">TransitionOptionId.</param>
	public TransitionRecordRequest(string TransitionOptionId)
	{
		this.TransitionOptionId = TransitionOptionId;
	}

	/// <summary>
	/// TransitionOptionId
	/// </summary>
	[DataMember(Name = "transitionOptionId", EmitDefaultValue = false)]
	public string TransitionOptionId { get; set; }







	
}
