using Cherwell.Api.Models.BusinessObject;

namespace Cherwell.Api.Test;

public class RelatedSaveRequestTests
{
	/// <summary>
	/// A RelatedSaveRequest with a typical set of values round-trips them.
	/// </summary>
	[Fact]
	public void Properties_SettingValues_ReadBack()
	{
		var request = new RelatedSaveRequest
		{
			CacheScope = RelatedSaveRequest.EnumCacheScope.Session,
			ParentBusObId = "pbusob",
			ParentBusObPublicId = "ppublic",
			ParentBusObRecId = "prec",
			RelationshipId = "rel",
			BusObId = "busob",
			BusObPublicId = "public",
			BusObRecId = "rec",
			CacheKey = "key",
			Fields = new List<FieldTemplateItem>(),
			Persist = true
		};

		request.CacheScope.Should().Be(RelatedSaveRequest.EnumCacheScope.Session);
		request.ParentBusObId.Should().Be("pbusob");
		request.ParentBusObPublicId.Should().Be("ppublic");
		request.ParentBusObRecId.Should().Be("prec");
		request.RelationshipId.Should().Be("rel");
		request.BusObId.Should().Be("busob");
		request.BusObPublicId.Should().Be("public");
		request.BusObRecId.Should().Be("rec");
		request.CacheKey.Should().Be("key");
		request.Fields.Should().BeEmpty();
		request.Persist.Should().BeTrue();
	}
}
