using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.OneStepActions;

/// <summary>
/// OneStepActionsOneStepActionRequest
/// </summary>
[DataContract]
public partial class OneStepActionRequest
{
	/// <summary>
	/// Initializes a new instance of the <see cref="OneStepActionRequest" /> class.
	/// </summary>
	/// <param name="AcquireLicense">AcquireLicense.</param>
	/// <param name="BusObId">BusObId.</param>
	/// <param name="BusObRecId">BusObRecId.</param>
	/// <param name="OneStepActionStandInKey">OneStepActionStandInKey.</param>
	/// <param name="PromptValues">PromptValues.</param>
	public OneStepActionRequest(bool? AcquireLicense, string BusObId, string BusObRecId, string OneStepActionStandInKey, List<SimplePromptValue> PromptValues)
	{
		this.AcquireLicense = AcquireLicense;
		this.BusObId = BusObId;
		this.BusObRecId = BusObRecId;
		this.OneStepActionStandInKey = OneStepActionStandInKey;
		this.PromptValues = PromptValues;
	}

	/// <summary>
	/// AcquireLicense
	/// </summary>
	[DataMember(Name = "acquireLicense", EmitDefaultValue = false)]
	public bool? AcquireLicense { get; set; }

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
	/// OneStepActionStandInKey
	/// </summary>
	[DataMember(Name = "oneStepActionStandInKey", EmitDefaultValue = false)]
	public string OneStepActionStandInKey { get; set; }

	/// <summary>
	/// PromptValues
	/// </summary>
	[DataMember(Name = "promptValues", EmitDefaultValue = false)]
	public List<SimplePromptValue> PromptValues { get; set; }
}
