using Cherwell.Api.Models.BusinessObject;

namespace Cherwell.Api.Test;

public class AttachmentTests
{
	/// <summary>
	/// An Attachment with a typical set of values round-trips them.
	/// </summary>
	[Fact]
	public void Properties_SettingValues_ReadBack()
	{
		var created = new DateTime(2024, 5, 6, 7, 8, 9, DateTimeKind.Utc);
		var attachment = new Attachment
		{
			AttachmentType = Attachment.EnumAttachmentType.Imported,
			Scope = Attachment.AttachmentScope.User,
			Type = Attachment.ObjectType.File,
			AttachedBusObId = "attached-busob",
			AttachedBusObRecId = "attached-rec",
			AttachmentFileId = "file",
			AttachmentFileName = "notes.txt",
			AttachmentFileType = "text/plain",
			AttachmentId = "attachment",
			BusObId = "busob",
			BusObRecId = "rec",
			Comment = "comment",
			Created = created,
			DisplayText = "display",
			Links = new List<Cherwell.Api.Models.Core.Link>
			{
				new() { Name = "self", Url = "https://c/self" }
			},
			Owner = "owner",
			ScopeOwner = "scope-owner"
		};

		attachment.AttachmentType.Should().Be(Attachment.EnumAttachmentType.Imported);
		attachment.Scope.Should().Be(Attachment.AttachmentScope.User);
		attachment.Type.Should().Be(Attachment.ObjectType.File);
		attachment.AttachedBusObId.Should().Be("attached-busob");
		attachment.AttachedBusObRecId.Should().Be("attached-rec");
		attachment.AttachmentFileId.Should().Be("file");
		attachment.AttachmentFileName.Should().Be("notes.txt");
		attachment.AttachmentFileType.Should().Be("text/plain");
		attachment.AttachmentId.Should().Be("attachment");
		attachment.BusObId.Should().Be("busob");
		attachment.BusObRecId.Should().Be("rec");
		attachment.Comment.Should().Be("comment");
		attachment.Created.Should().Be(created);
		attachment.DisplayText.Should().Be("display");
		attachment.Links.Should().ContainSingle().Which.Name.Should().Be("self");
		attachment.Owner.Should().Be("owner");
		attachment.ScopeOwner.Should().Be("scope-owner");
	}
}
