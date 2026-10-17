using Cherwell.Api.Models.BusinessObject;

namespace Cherwell.Api.Test;

public class BusObActivityTests
{
	/// <summary>
	/// A BusObActivity with a typical set of values round-trips them.
	/// </summary>
	[Fact]
	public void Properties_SettingValues_ReadBack()
	{
		var created = new DateTime(2024, 5, 6, 7, 8, 9, DateTimeKind.Utc);
		var modified = new DateTime(2024, 5, 7, 7, 8, 9, DateTimeKind.Utc);
		var activity = new BusObActivity
		{
			Id = "activity",
			ParentBusObDefId = "def",
			ParentBusObRecId = "rec",
			HistoryBusObDefId = "hdef",
			HistoryBusObRecId = "hrec",
			Type = "comment",
			Title = "title",
			Body = "body",
			CreatedBy = "alice",
			Created = created,
			Modified = modified,
			ModifiedBy = "bob"
		};

		activity.Id.Should().Be("activity");
		activity.ParentBusObDefId.Should().Be("def");
		activity.ParentBusObRecId.Should().Be("rec");
		activity.HistoryBusObDefId.Should().Be("hdef");
		activity.HistoryBusObRecId.Should().Be("hrec");
		activity.Type.Should().Be("comment");
		activity.Title.Should().Be("title");
		activity.Body.Should().Be("body");
		activity.CreatedBy.Should().Be("alice");
		activity.Created.Should().Be(created);
		activity.Modified.Should().Be(modified);
		activity.ModifiedBy.Should().Be("bob");
	}
}
