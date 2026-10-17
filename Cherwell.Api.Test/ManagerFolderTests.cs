using Cherwell.Api.Models.Core;

namespace Cherwell.Api.Test;

public class ManagerFolderTests
{
	/// <summary>
	/// A ManagerFolder with a typical set of values round-trips them.
	/// </summary>
	[Fact]
	public void Properties_SettingValues_ReadBack()
	{
		var folder = new ManagerFolder
		{
			Association = "inc",
			ChildFolders = new List<ManagerFolder>(),
			ChildItems = new List<ManagerItem>(),
			Id = "folder-id",
			Links = new List<Link>
			{
				new() { Name = "self", Url = "https://c/self" }
			},
			LocalizedScopeName = "Scope FR",
			Name = "folder name",
			ParentId = "parent",
			Scope = "global",
			ScopeOwner = "owner"
		};

		folder.Association.Should().Be("inc");
		folder.ChildFolders.Should().BeEmpty();
		folder.ChildItems.Should().BeEmpty();
		folder.Id.Should().Be("folder-id");
		folder.Links.Should().ContainSingle().Which.Name.Should().Be("self");
		folder.LocalizedScopeName.Should().Be("Scope FR");
		folder.Name.Should().Be("folder name");
		folder.ParentId.Should().Be("parent");
		folder.Scope.Should().Be("global");
		folder.ScopeOwner.Should().Be("owner");
	}
}
