using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Lifecycle;

/// <summary>
/// LifecycleGetTransitionsResponseTransition
/// </summary>
[DataContract]
public partial class GetTransitionsResponseTransition
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GetTransitionsResponseTransition" /> class.
	/// </summary>
	/// <param name="Id">Id.</param>
	/// <param name="Name">Name.</param>
	/// <param name="FromStatusId">FromStatusId.</param>
	/// <param name="ToStatusId">ToStatusId.</param>
	public GetTransitionsResponseTransition(string Id, string Name, string FromStatusId, string ToStatusId)
	{
		this.Id = Id;
		this.Name = Name;
		this.FromStatusId = FromStatusId;
		this.ToStatusId = ToStatusId;
	}

	/// <summary>
	/// Id
	/// </summary>
	[DataMember(Name = "id", EmitDefaultValue = false)]
	public string Id { get; set; }

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; }

	/// <summary>
	/// FromStatusId
	/// </summary>
	[DataMember(Name = "fromStatusId", EmitDefaultValue = false)]
	public string FromStatusId { get; set; }

	/// <summary>
	/// ToStatusId
	/// </summary>
	[DataMember(Name = "toStatusId", EmitDefaultValue = false)]
	public string ToStatusId { get; set; }








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
