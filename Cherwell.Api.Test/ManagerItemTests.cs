using Cherwell.Api.Models.Core;

namespace Cherwell.Api.Test;

public class ManagerItemTests
{
	/// <summary>
	/// A ManagerItem populated with a typical set of values round-trips them.
	/// </summary>
	[Fact]
	public void Properties_SettingValues_ReadBack()
	{
		var item = new ManagerItem
		{
			Association = "inc",
			Description = "Incid",
			DisplayName = "Incident",
			GalleryImage = "gallery.png",
			Id = "inc-id",
			Links = new List<Link>
			{
				new() { Name = "self", Url = "https://c/self" }
			},
			LocalizedScopeName = "Scope FR",
			Name = "incident",
			ParentFolder = "folder-id",
			ParentIsScopeFolder = true,
			Scope = "global",
			ScopeOwner = "owner-id",
			StandInKey = "key"
		};

		item.Association.Should().Be("inc");
		item.Description.Should().Be("Incid");
		item.DisplayName.Should().Be("Incident");
		item.GalleryImage.Should().Be("gallery.png");
		item.Id.Should().Be("inc-id");
		item.Links.Should().ContainSingle().Which.Name.Should().Be("self");
		item.LocalizedScopeName.Should().Be("Scope FR");
		item.Name.Should().Be("incident");
		item.ParentFolder.Should().Be("folder-id");
		item.ParentIsScopeFolder.Should().BeTrue();
		item.Scope.Should().Be("global");
		item.ScopeOwner.Should().Be("owner-id");
		item.StandInKey.Should().Be("key");
	}
}
