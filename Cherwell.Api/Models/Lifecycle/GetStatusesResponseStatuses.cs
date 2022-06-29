using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Lifecycle;

/// <summary>
/// LifecycleGetStatusesResponseStatuses
/// </summary>
[DataContract]
public partial class GetStatusesResponseStatuses
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GetStatusesResponseStatuses" /> class.
	/// </summary>
	/// <param name="Id">Id.</param>
	/// <param name="IsInitial">IsInitial.</param>
	/// <param name="Name">Name.</param>
	/// <param name="StageId">StageId.</param>
	public GetStatusesResponseStatuses(string Id, bool? IsInitial, string Name, string StageId)
	{
		this.Id = Id;
		this.IsInitial = IsInitial;
		this.Name = Name;
		this.StageId = StageId;
	}

	/// <summary>
	/// Id
	/// </summary>
	[DataMember(Name = "id", EmitDefaultValue = false)]
	public string Id { get; set; }

	/// <summary>
	/// IsInitial
	/// </summary>
	[DataMember(Name = "isInitial", EmitDefaultValue = false)]
	public bool? IsInitial { get; set; }

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; }

	/// <summary>
	/// StageId
	/// </summary>
	[DataMember(Name = "stageId", EmitDefaultValue = false)]
	public string StageId { get; set; }








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


		}
	}

	
}
