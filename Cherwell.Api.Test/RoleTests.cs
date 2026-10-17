using Cherwell.Api.Models.Security;

namespace Cherwell.Api.Test;

public class RoleTests
{
	/// <summary>
	/// A Role with a typical set of values round-trips them.
	/// </summary>
	[Fact]
	public void Properties_SettingValues_ReadBack()
	{
		var role = new Role
		{
			BrowserClientCustomViewId = "browser",
			BusinessObjectExcludeList = new List<string> { "excl" },
			Culture = "fr-FR",
			Description = "role description",
			MobileClientCustomViewId = "mobile",
			PrimaryBusObId = "busob",
			RoleId = "role",
			RoleName = "role name",
			SmartClientCustomViewId = "smart"
		};

		role.BrowserClientCustomViewId.Should().Be("browser");
		role.BusinessObjectExcludeList.Should().Contain("excl");
		role.Culture.Should().Be("fr-FR");
		role.Description.Should().Be("role description");
		role.MobileClientCustomViewId.Should().Be("mobile");
		role.PrimaryBusObId.Should().Be("busob");
		role.RoleId.Should().Be("role");
		role.RoleName.Should().Be("role name");
		role.SmartClientCustomViewId.Should().Be("smart");
	}
}
