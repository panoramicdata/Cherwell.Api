// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Performance",
	"CA1848:Use the LoggerMessage delegates",
	Justification = "Additional performance not considered necessary in this scenario",
	Scope = "member",
	Target = "~M:Cherwell.Api.AuthenticatedHttpClientHandler.GetAccessTokenAsync(System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.String}")
	]
[assembly: SuppressMessage(
	"Performance",
	"CA1848:Use the LoggerMessage delegates",
	Justification = "Additional performance not considered necessary in this scenario",
	Scope = "member",
	Target = "~M:Cherwell.Api.AuthenticatedHttpClientHandler.LogoutAsync~System.Threading.Tasks.Task")
	]
[assembly: SuppressMessage("Naming", "CA1711:Identifiers should not have incorrect suffix", Justification = "<Pending>", Scope = "type", Target = "~T:Cherwell.Api.Model.Security.BusinessObjectPermission")]
[assembly: SuppressMessage("Style", "IDE0044:Add readonly modifier", Justification = "<Pending>", Scope = "member", Target = "~F:Cherwell.Api.CherwellClient._disposedValue")]
