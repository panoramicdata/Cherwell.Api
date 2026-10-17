using Cherwell.Api.Models.BusinessObject;

namespace Cherwell.Api.Test;

public class SaveBusObAttachmentRequestTests
{
	/// <summary>
	/// A SaveBusObAttachmentRequest with a typical set of values round-trips them.
	/// </summary>
	[Fact]
	public void Properties_SettingValues_ReadBack()
	{
		var request = new SaveBusObAttachmentRequest
		{
			AttachBusObId = "attach",
			AttachBusObName = "attach-name",
			AttachBusObPublicId = "attach-public",
			AttachBusObRecId = "attach-rec",
			BusObId = "busob",
			BusObName = "busob-name",
			BusObPublicId = "public",
			BusObRecId = "rec",
			Comment = "comment",
			IncludeLinks = true
		};

		request.AttachBusObId.Should().Be("attach");
		request.AttachBusObName.Should().Be("attach-name");
		request.AttachBusObPublicId.Should().Be("attach-public");
		request.AttachBusObRecId.Should().Be("attach-rec");
		request.BusObId.Should().Be("busob");
		request.BusObName.Should().Be("busob-name");
		request.BusObPublicId.Should().Be("public");
		request.BusObRecId.Should().Be("rec");
		request.Comment.Should().Be("comment");
		request.IncludeLinks.Should().BeTrue();
	}
}
