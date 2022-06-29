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
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class LifecycleGetStagesResponseStages {\n");
		sb.Append("  Id: ").Append(Id).Append('\n');
		sb.Append("  IsFinal: ").Append(IsFinal).Append('\n');
		sb.Append("  Name: ").Append(Name).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

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
			if (Id != null)
			{
				hash = hash * 59 + Id.GetHashCode();
			}

			if (IsFinal != null)
			{
				hash = hash * 59 + IsFinal.GetHashCode();
			}

			if (Name != null)
			{
				hash = hash * 59 + Name.GetHashCode();
			}

			return hash;
		}
	}

	
}
