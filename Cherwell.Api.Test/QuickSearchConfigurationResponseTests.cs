using Cherwell.Api.Models.Searches;

namespace Cherwell.Api.Test;

public class QuickSearchConfigurationResponseTests
{
	/// <summary>
	/// A QuickSearchConfigurationResponse with a typical set of values round-trips them.
	/// </summary>
	[Fact]
	public void Properties_SettingValues_ReadBack()
	{
		var response = new QuickSearchConfigurationResponse
		{
			AllowQuickSearch = true,
			AllowSpecificSearch = true,
			DefaultToQuickSearch = true,
			DisplayName = "Display",
			GalleryImage = "gallery.png",
			History = new List<string> { "h1", "h2" },
			IncludeAvailableInSpecific = true,
			IncludeQuickSearchInSpecific = true,
			QuickSearchId = "qs",
			QuickSearchItems = new List<QuickSearchItem>(),
			QuickSearchWatermark = "watermark",
			SortByRelevance = true,
			ResolvedQuickSearchWatermark = "resolved",
			Scope = "global",
			ScopeOwner = "owner",
			SpecificSearchItems = new List<QuickSearchItem>()
		};

		response.AllowQuickSearch.Should().BeTrue();
		response.AllowSpecificSearch.Should().BeTrue();
		response.DefaultToQuickSearch.Should().BeTrue();
		response.DisplayName.Should().Be("Display");
		response.GalleryImage.Should().Be("gallery.png");
		response.History.Should().Contain("h1").And.Contain("h2");
		response.IncludeAvailableInSpecific.Should().BeTrue();
		response.IncludeQuickSearchInSpecific.Should().BeTrue();
		response.QuickSearchId.Should().Be("qs");
		response.QuickSearchItems.Should().BeEmpty();
		response.QuickSearchWatermark.Should().Be("watermark");
		response.SortByRelevance.Should().BeTrue();
		response.ResolvedQuickSearchWatermark.Should().Be("resolved");
		response.Scope.Should().Be("global");
		response.ScopeOwner.Should().Be("owner");
		response.SpecificSearchItems.Should().BeEmpty();
	}
}
