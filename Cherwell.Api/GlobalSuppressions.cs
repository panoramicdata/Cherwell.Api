// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Performance",
	"CA1848:Use the LoggerMessage delegates",
	Justification = "Additional performance not considered necessary in this scenario",
	Scope = "namespaceanddescendants",
	Target = "~N:Cherwell.Api")
]

[assembly: SuppressMessage(
	"Naming",
	"CA1711:Identifiers should not have incorrect suffix",
	Justification = "Model is correctly named",
	Scope = "type",
	Target = "~T:Cherwell.Api.Models.Security.BusinessObjectPermission")
]

[assembly: SuppressMessage(
	"Design",
	"CA1069:Enums values should not be duplicated",
	Justification = "When deserializing multiple values into one member, they should",
	Scope = "type",
	Target = "~T:Cherwell.Api.Models.EnumHttpStatusCode")
]
[assembly: SuppressMessage(
	"Style",
	"IDE1006:Naming Styles",
	Justification = "Pascal casing for error message text.",
	Scope = "namespaceanddescendants",
	Target = "~N:Cherwell.Api.Exceptions")
]
