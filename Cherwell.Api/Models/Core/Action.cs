using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Core;

/// <summary>
/// Action
/// </summary>
[DataContract]
public class Action
{
	/// <summary>
	/// ActionType
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnumActionType
	{

		/// <summary>
		/// Enum None for "None"
		/// </summary>
		[EnumMember(Value = "None")]
		None,

		/// <summary>
		/// Enum OneStep for "OneStep"
		/// </summary>
		[EnumMember(Value = "OneStep")]
		OneStep,

		/// <summary>
		/// Enum Command for "Command"
		/// </summary>
		[EnumMember(Value = "Command")]
		Command,

		/// <summary>
		/// Enum BuiltIn for "BuiltIn"
		/// </summary>
		[EnumMember(Value = "BuiltIn")]
		BuiltIn,

		/// <summary>
		/// Enum Category for "Category"
		/// </summary>
		[EnumMember(Value = "Category")]
		Category,

		/// <summary>
		/// Enum SearchGrp for "SearchGrp"
		/// </summary>
		[EnumMember(Value = "SearchGrp")]
		SearchGrp,

		/// <summary>
		/// Enum Report for "Report"
		/// </summary>
		[EnumMember(Value = "Report")]
		Report,

		/// <summary>
		/// Enum Dashboard for "Dashboard"
		/// </summary>
		[EnumMember(Value = "Dashboard")]
		Dashboard,

		/// <summary>
		/// Enum Calendar for "Calendar"
		/// </summary>
		[EnumMember(Value = "Calendar")]
		Calendar,

		/// <summary>
		/// Enum Visualization for "Visualization"
		/// </summary>
		[EnumMember(Value = "Visualization")]
		Visualization,

		/// <summary>
		/// Enum Group for "Group"
		/// </summary>
		[EnumMember(Value = "Group")]
		Group,

		/// <summary>
		/// Enum Page for "Page"
		/// </summary>
		[EnumMember(Value = "Page")]
		Page,

		/// <summary>
		/// Enum DocRepository for "DocRepository"
		/// </summary>
		[EnumMember(Value = "DocRepository")]
		DocRepository,

		/// <summary>
		/// Enum PortalCommand for "PortalCommand"
		/// </summary>
		[EnumMember(Value = "PortalCommand")]
		PortalCommand,

		/// <summary>
		/// Enum ActionCatalog for "ActionCatalog"
		/// </summary>
		[EnumMember(Value = "ActionCatalog")]
		ActionCatalog,

		/// <summary>
		/// Enum OneStepForRecord for "OneStepForRecord"
		/// </summary>
		[EnumMember(Value = "OneStepForRecord")]
		OneStepForRecord
	}

	/// <summary>
	/// LoginEnabledMode
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnumLoginEnabledMode
	{

		/// <summary>
		/// Enum Anonymous for "Anonymous"
		/// </summary>
		[EnumMember(Value = "Anonymous")]
		Anonymous,

		/// <summary>
		/// Enum LoggedIn for "LoggedIn"
		/// </summary>
		[EnumMember(Value = "LoggedIn")]
		LoggedIn,

		/// <summary>
		/// Enum Both for "Both"
		/// </summary>
		[EnumMember(Value = "Both")]
		Both
	}

	/// <summary>
	/// LoginVisibilityMode
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnumLoginVisibilityMode
	{

		/// <summary>
		/// Enum Anonymous for "Anonymous"
		/// </summary>
		[EnumMember(Value = "Anonymous")]
		Anonymous,

		/// <summary>
		/// Enum LoggedIn for "LoggedIn"
		/// </summary>
		[EnumMember(Value = "LoggedIn")]
		LoggedIn,

		/// <summary>
		/// Enum Both for "Both"
		/// </summary>
		[EnumMember(Value = "Both")]
		Both
	}

	/// <summary>
	/// ActionType
	/// </summary>
	[DataMember(Name = "actionType", EmitDefaultValue = false)]
	public EnumActionType ActionType { get; set; }

	/// <summary>
	/// LoginEnabledMode
	/// </summary>
	[DataMember(Name = "loginEnabledMode", EmitDefaultValue = false)]
	public EnumLoginEnabledMode LoginEnabledMode { get; set; }

	/// <summary>
	/// LoginVisibilityMode
	/// </summary>
	[DataMember(Name = "loginVisibilityMode", EmitDefaultValue = false)]
	public EnumLoginVisibilityMode LoginVisibilityMode { get; set; }

	/// <summary>
	/// ActionCommand
	/// </summary>
	[DataMember(Name = "actionCommand", EmitDefaultValue = false)]
	public string ActionCommand { get; set; } = null!;

	/// <summary>
	/// AlwaysTextAndImage
	/// </summary>
	[DataMember(Name = "alwaysTextAndImage", EmitDefaultValue = false)]
	public bool AlwaysTextAndImage { get; set; }

	/// <summary>
	/// BeginGroup
	/// </summary>
	[DataMember(Name = "beginGroup", EmitDefaultValue = false)]
	public bool BeginGroup { get; set; }

	/// <summary>
	/// ChildActions
	/// </summary>
	[DataMember(Name = "childActions", EmitDefaultValue = false)]
	public List<Action> ChildActions { get; set; } = null!;

	/// <summary>
	/// Dependencies
	/// </summary>
	[DataMember(Name = "dependencies", EmitDefaultValue = false)]
	public List<string> Dependencies { get; set; } = null!;

	/// <summary>
	/// DisplayText
	/// </summary>
	[DataMember(Name = "displayText", EmitDefaultValue = false)]
	public string DisplayText { get; set; } = null!;

	/// <summary>
	/// Enabled
	/// </summary>
	[DataMember(Name = "enabled", EmitDefaultValue = false)]
	public bool Enabled { get; set; }

	/// <summary>
	/// GalleryImage
	/// </summary>
	[DataMember(Name = "galleryImage", EmitDefaultValue = false)]
	public string GalleryImage { get; set; } = null!;

	/// <summary>
	/// HelpText
	/// </summary>
	[DataMember(Name = "helpText", EmitDefaultValue = false)]
	public string HelpText { get; set; } = null!;

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; } = null!;

	/// <summary>
	/// Parameters
	/// </summary>
	[DataMember(Name = "parameters", EmitDefaultValue = false)]
	public Dictionary<string, string> Parameters { get; set; } = null!;

	/// <summary>
	/// Visible
	/// </summary>
	[DataMember(Name = "visible", EmitDefaultValue = false)]
	public bool Visible { get; set; }
}
