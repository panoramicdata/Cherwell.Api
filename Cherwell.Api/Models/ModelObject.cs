using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models;

/// <summary>
/// ModelObject
/// </summary>
[DataContract]
public partial class ModelObject
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ModelObject" /> class.
	/// </summary>
	[JsonConstructor]
	public ModelObject()
	{
	}
}