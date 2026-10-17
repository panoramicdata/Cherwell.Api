using Cherwell.Api.Models.BusinessObject;
using Cherwell.Api.Models.Users;

namespace Cherwell.Api.Test;

public class UserSaveV2RequestTests
{
	/// <summary>
	/// A UserSaveV2Request with a typical set of values round-trips them.
	/// </summary>
	[Fact]
	public void Properties_SettingValues_ReadBack()
	{
		var created = new DateTime(2024, 5, 6, 7, 8, 9, DateTimeKind.Utc);
		var request = new UserSaveV2Request
		{
			AccountLocked = true,
			AllCultures = true,
			BusObId = "busob",
			BusObPublicId = "public",
			BusObRecId = "rec",
			DisplayName = "Display",
			LdapRequired = true,
			LoginId = "login",
			NextPasswordResetDate = created,
			Password = "p",
			PasswordNeverExpires = true,
			SecurityGroupId = "sec",
			SpecificCulture = "fr-FR",
			UserCannotChangePassword = true,
			UserInfoFields = new List<FieldTemplateItem>(),
			UserMustChangePasswordAtNextLogin = true,
			WindowsUserId = "win"
		};

		request.AccountLocked.Should().BeTrue();
		request.AllCultures.Should().BeTrue();
		request.BusObId.Should().Be("busob");
		request.BusObPublicId.Should().Be("public");
		request.BusObRecId.Should().Be("rec");
		request.DisplayName.Should().Be("Display");
		request.LdapRequired.Should().BeTrue();
		request.LoginId.Should().Be("login");
		request.NextPasswordResetDate.Should().Be(created);
		request.Password.Should().Be("p");
		request.PasswordNeverExpires.Should().BeTrue();
		request.SecurityGroupId.Should().Be("sec");
		request.SpecificCulture.Should().Be("fr-FR");
		request.UserCannotChangePassword.Should().BeTrue();
		request.UserInfoFields.Should().BeEmpty();
		request.UserMustChangePasswordAtNextLogin.Should().BeTrue();
		request.WindowsUserId.Should().Be("win");
	}
}
