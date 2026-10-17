using Cherwell.Api.Models.Searches;

namespace Cherwell.Api.Test;

public class SimpleResultsListItemTests
{
	/// <summary>
	/// A SimpleResultsListItem populated with a typical set of values round-trips them.
	/// </summary>
	[Fact]
	public void Properties_SettingValues_ReadBack()
	{
		var item = new SimpleResultsListItem
		{
			BusObId = "busob",
			BusObRecId = "rec",
			DocRepositoryItemId = "doc",
			GalleryImage = "gallery.png",
			Links = new List<Cherwell.Api.Models.Core.Link>
			{
				new() { Name = "self", Url = "https://c/self" }
			},
			PublicId = "public",
			Scope = "global",
			ScopeOwner = "owner",
			SubTitle = "sub",
			Text = "body",
			Title = "heading"
		};

		item.BusObId.Should().Be("busob");
		item.BusObRecId.Should().Be("rec");
		item.DocRepositoryItemId.Should().Be("doc");
		item.GalleryImage.Should().Be("gallery.png");
		item.Links.Should().ContainSingle().Which.Name.Should().Be("self");
		item.PublicId.Should().Be("public");
		item.Scope.Should().Be("global");
		item.ScopeOwner.Should().Be("owner");
		item.SubTitle.Should().Be("sub");
		item.Text.Should().Be("body");
		item.Title.Should().Be("heading");
	}
}
