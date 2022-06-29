using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Lifecycle;

/// <summary>
/// LifecycleGetTransitionOptionsResponseTransition
/// </summary>
[DataContract]
public partial class GetTransitionOptionsResponseTransition
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GetTransitionOptionsResponseTransition" /> class.
	/// </summary>
	/// <param name="Name">Name.</param>
	/// <param name="Id">Id.</param>
	/// <param name="IsAvailable">IsAvailable.</param>
	/// <param name="Criteria">Criteria.</param>
	public GetTransitionOptionsResponseTransition(string Name, string Id, bool? IsAvailable, List<string> Criteria)
	{
		this.Name = Name;
		this.Id = Id;
		this.IsAvailable = IsAvailable;
		this.Criteria = Criteria;
	}

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; }

	/// <summary>
	/// Id
	/// </summary>
	[DataMember(Name = "id", EmitDefaultValue = false)]
	public string Id { get; set; }

	/// <summary>
	/// IsAvailable
	/// </summary>
	[DataMember(Name = "isAvailable", EmitDefaultValue = false)]
	public bool? IsAvailable { get; set; }

	/// <summary>
	/// Criteria
	/// </summary>
	[DataMember(Name = "criteria", EmitDefaultValue = false)]
	public List<string> Criteria { get; set; }








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
