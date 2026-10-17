using Cherwell.Api.Models.Core;
using Cherwell.Api.Models.Searches;

namespace Cherwell.Api.Test;

public class SearchFolderTests
{
	/// <summary>
	/// A SearchFolder with a typical set of values round-trips them.
	/// </summary>
	[Fact]
	public void Properties_SettingValues_ReadBack()
	{
		var folder = new SearchFolder
		{
			Association = "inc",
			ChildFolders = new List<SearchFolder>(),
			ChildItems = new List<SearchItem>(),
			FolderId = "folder",
			FolderName = "folder name",
			Links = new List<Link>
			{
				new() { Name = "self", Url = "https://c/self" }
			},
			LocalizedScopeName = "Scope FR",
			ParentFolderId = "parent",
			Scope = "global",
			ScopeOwner = "owner"
		};

		folder.Association.Should().Be("inc");
		folder.ChildFolders.Should().BeEmpty();
		folder.ChildItems.Should().BeEmpty();
		folder.FolderId.Should().Be("folder");
		folder.FolderName.Should().Be("folder name");
		folder.Links.Should().ContainSingle().Which.Name.Should().Be("self");
		folder.LocalizedScopeName.Should().Be("Scope FR");
		folder.ParentFolderId.Should().Be("parent");
		folder.Scope.Should().Be("global");
		folder.ScopeOwner.Should().Be("owner");
	}
}
