using Cherwell.Api.Models.BusinessObject;

namespace Cherwell.Api.Test;

public class RelatedSaveResponseTests
{
	/// <summary>
	/// A RelatedSaveResponse with a typical set of values round-trips them.
	/// </summary>
	[Fact]
	public void Properties_SettingValues_ReadBack()
	{
		var response = new RelatedSaveResponse
		{
			ParentBusObId = "pbusob",
			ParentBusObPublicId = "ppublic",
			ParentBusObRecId = "prec",
			RelationshipId = "rel",
			BusObPublicId = "public",
			BusObRecId = "rec",
			CacheKey = "key",
			FieldValidationErrors = new List<FieldValidationError>(),
			NotificationTriggers = new List<NotificationTrigger>()
		};

		response.ParentBusObId.Should().Be("pbusob");
		response.ParentBusObPublicId.Should().Be("ppublic");
		response.ParentBusObRecId.Should().Be("prec");
		response.RelationshipId.Should().Be("rel");
		response.BusObPublicId.Should().Be("public");
		response.BusObRecId.Should().Be("rec");
		response.CacheKey.Should().Be("key");
		response.FieldValidationErrors.Should().BeEmpty();
		response.NotificationTriggers.Should().BeEmpty();
	}
}
