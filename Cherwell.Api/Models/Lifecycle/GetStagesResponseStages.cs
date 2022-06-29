using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Lifecycle;

/// <summary>
/// LifecycleGetStagesResponseStages
/// </summary>
[DataContract]
public partial class GetStagesResponseStages
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GetStagesResponseStages" /> class.
	/// </summary>
	/// <param name="Id">Id.</param>
	/// <param name="IsFinal">IsFinal.</param>
	/// <param name="Name">Name.</param>
	public GetStagesResponseStages(string Id, bool? IsFinal, string Name)
	{
		this.Id = Id;
		this.IsFinal = IsFinal;
		this.Name = Name;
	}

	/// <summary>
	/// Id
	/// </summary>
	[DataMember(Name = "id", EmitDefaultValue = false)]
	public string Id { get; set; }

	/// <summary>
	/// IsFinal
	/// </summary>
	[DataMember(Name = "isFinal", EmitDefaultValue = false)]
	public bool? IsFinal { get; set; }

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; }







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
			return hash;
		}
	}

	
}
