using Cherwell.Api.Models.BusinessObject;
using Cherwell.Api.Models.Users;

namespace Cherwell.Api.Test;

public class UserSaveRequestTests
{
	/// <summary>
	/// A UserSaveRequest with a typical set of values round-trips them.
	/// </summary>
	[Fact]
	public void Properties_SettingValues_ReadBack()
	{
		var created = new DateTime(2024, 5, 6, 7, 8, 9, DateTimeKind.Utc);
		var request = new UserSaveRequest
		{
			AccountLocked = true,
			BusObId = "busob",
			BusObPublicId = "public",
			BusObRecId = "rec",
			DisplayName = "Display",
			Error = "err",
			LdapRequired = true,
			LoginId = "login",
			NextPasswordResetDate = created,
			Password = "p",
			PasswordNeverExpires = true,
			SecurityGroupId = "sec",
			UserCannotChangePassword = true,
			UserInfoFields = new List<FieldTemplateItem>(),
			UserMustChangePasswordAtNextLogin = true,
			WindowsUserId = "win"
		};

		request.AccountLocked.Should().BeTrue();
		request.BusObId.Should().Be("busob");
		request.BusObPublicId.Should().Be("public");
		request.BusObRecId.Should().Be("rec");
		request.DisplayName.Should().Be("Display");
		request.Error.Should().Be("err");
		request.LdapRequired.Should().BeTrue();
		request.LoginId.Should().Be("login");
		request.NextPasswordResetDate.Should().Be(created);
		request.Password.Should().Be("p");
		request.PasswordNeverExpires.Should().BeTrue();
		request.SecurityGroupId.Should().Be("sec");
		request.UserCannotChangePassword.Should().BeTrue();
		request.UserInfoFields.Should().BeEmpty();
		request.UserMustChangePasswordAtNextLogin.Should().BeTrue();
		request.WindowsUserId.Should().Be("win");
	}
}
