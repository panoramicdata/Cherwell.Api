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
	/// AcquireLicense
	/// </summary>
	[DataMember(Name = "acquireLicense", EmitDefaultValue = false)]
	public bool AcquireLicense { get; set; }

	/// <summary>
	/// BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; } = null!;

	/// <summary>
	/// BusObRecId
	/// </summary>
	[DataMember(Name = "busObRecId", EmitDefaultValue = false)]
	public string BusObRecId { get; set; } = null!;

	/// <summary>
	/// OneStepActionStandInKey
	/// </summary>
	[DataMember(Name = "oneStepActionStandInKey", EmitDefaultValue = false)]
	public string OneStepActionStandInKey { get; set; } = null!;

	/// <summary>
	/// PromptValues
	/// </summary>
	[DataMember(Name = "promptValues", EmitDefaultValue = false)]
	public List<SimplePromptValue> PromptValues { get; set; } = null!;
}
