using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Lifecycle;

/// <summary>
/// LifecycleGetTransitionOptionsResponseTransition
/// </summary>
[DataContract]
public partial class GetTransitionOptionsResponseTransition : IEquatable<GetTransitionOptionsResponseTransition>, IValidatableObject
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
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class LifecycleGetTransitionOptionsResponseTransition {\n");
		sb.Append("  Name: ").Append(Name).Append('\n');
		sb.Append("  Id: ").Append(Id).Append('\n');
		sb.Append("  IsAvailable: ").Append(IsAvailable).Append('\n');
		sb.Append("  Criteria: ").Append(Criteria).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns the JSON string presentation of the object
	/// </summary>
	/// <returns>JSON string presentation of the object</returns>
	public string ToJson()
	{
		return JsonConvert.SerializeObject(this, Formatting.Indented);
	}

	/// <summary>
	/// Returns true if objects are equal
	/// </summary>
	/// <param name="obj">Object to be compared</param>
	/// <returns>Boolean</returns>
	public override bool Equals(object? obj)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		return Equals(obj as GetTransitionOptionsResponseTransition);
	}

	/// <summary>
	/// Returns true if LifecycleGetTransitionOptionsResponseTransition instances are equal
	/// </summary>
	/// <param name="other">Instance of LifecycleGetTransitionOptionsResponseTransition to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(GetTransitionOptionsResponseTransition? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					Name == other.Name ||
					Name != null &&
					Name.Equals(other.Name, StringComparison.Ordinal)
				) &&
				(
					Id == other.Id ||
					Id != null &&
					Id.Equals(other.Id, StringComparison.Ordinal)
				) &&
				(
					IsAvailable == other.IsAvailable ||
					IsAvailable != null &&
					IsAvailable.Equals(other.IsAvailable)
				) &&
				(
					Criteria == other.Criteria ||
					Criteria != null &&
					Criteria.SequenceEqual(other.Criteria)
				);
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
			if (Name != null)
			{
				hash = hash * 59 + Name.GetHashCode();
			}

			if (Id != null)
			{
				hash = hash * 59 + Id.GetHashCode();
			}

			if (IsAvailable != null)
			{
				hash = hash * 59 + IsAvailable.GetHashCode();
			}

			if (Criteria != null)
			{
				hash = hash * 59 + Criteria.GetHashCode();
			}

			return hash;
		}
	}

	/// <summary>
	/// To validate all properties of the instance
	/// </summary>
	/// <param name="validationContext">Validation context</param>
	/// <returns>Validation Result</returns>
	IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
	{
		yield break;
	}
}
