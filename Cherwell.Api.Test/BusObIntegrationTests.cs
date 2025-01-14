﻿using Cherwell.Api.Exceptions;
using FluentAssertions;
using Xunit;

namespace Cherwell.Api.Test;

public class BusObIntegrationTests(CherwellClient testCherwellClient)
{
	private readonly CherwellClient _testCherwellClient = testCherwellClient;

	// DeleteBusinessObjectBatchAsync - unable to test, as we don't want to delete anything

	// DeleteBusinessObjectByPublicIdAsync - unable to test, as we don't want to delete anything

	// DeleteBusinessObjectByRecIdAsync - unable to test, as we don't want to delete anything

	// DeleteRelatedBusinessObjectByPublicIdAsync - unable to test, as we don't want to delete anything

	// DeleteRelatedBusinessObjectByRecIdAsync - unable to test, as we don't want to delete anything

	// BusinessObjectFieldValuesLookupAsync - unable to test, insufficient rights to add a business object

	[Fact]
	public async Task RetrieveActivities_Succeeds()
	{
		var cancellationToken = CancellationToken.None;

		var response = await _testCherwellClient
			.BusinessObject
			.GetActivitiesAsync("944e02d8537d17b3384143451180f87eda564c5798", "944e02da60578af7d7bc4644b6ae07ed4eb2648fc3", 1, null, null, cancellationToken)
			;

		response
			.Should()
			.NotBeNull();
	}

	// GetBusinessObjectAttachmentByAttachmentIdAsync - unable to test, as we don't have any attachmentIds to test with

	// GetBusinessObjectAttachmentsByIdAndRecIdAsync - unable to test, the business objects we're testing with don't have any attachment

	[Fact]
	public async Task BusOb_GetAttachmentsByIdAndRec_Error()
	{
		var cancellationToken = CancellationToken.None;

		await ((Func<Task>)(async () =>
		{
			_ = await _testCherwellClient
			.BusinessObject
			.GetBusinessObjectAttachmentsByIdAndRecIdAsync("93c5ca8e7dbd4cc21dead14df19c684298a78358dd", "93c5ca8e7d6f942534ba214e2787b6d38dba666dab", "File", "Imported", false, cancellationToken)
			;
		}))
		.Should()
		.ThrowAsync<CherwellApiException>()
		.WithMessage(Message.RecordNotFound)
		.Where(e =>
			e.Response != null && e.Response.ErrorCode == ErrorCode.RecordNotFound
			&& e.Response.HasError
		);
	}

	// GetBusinessObjectAttachmentsByNameAndPublicIdAsync - unable to test, as we don't have a publicId to test with

	[Fact]
	public async Task BusOb_GetAttachmentsByNameAndRec_Error()
	{
		var cancellationToken = CancellationToken.None;

		await ((Func<Task>)(async () =>
		{
			_ = await _testCherwellClient
			.BusinessObject
			.GetBusinessObjectAttachmentsByNameAndPublicIdAsync("Building", "93e8652ccb6ffc759c6b544437bfa25c2e60ca36f0", "File", "Imported", false, cancellationToken)
			;
		}))
		.Should()
		.ThrowAsync<CherwellApiException>()
		.WithMessage(Message.RecordNotFound)
		.Where(e =>
			e.Response != null && e.Response.ErrorCode == ErrorCode.RecordNotFound
			&& e.Response.HasError
		);
	}

	[Fact]
	public async Task BusOb_GetAttachments_Error()
	{
		var cancellationToken = CancellationToken.None;

		await ((Func<Task>)(async () =>
		{
			_ = await _testCherwellClient
			.BusinessObject
			.GetBusinessObjectAttachmentsAsync(
				new Models.BusinessObject.AttachmentsRequest
				{
					BusObId = "93e8652ccb6ffc759c6b544437bfa25c2e60ca36f0"
				}, cancellationToken)
			;
		}))
		.Should()
		.ThrowAsync<CherwellApiException>()
		.WithMessage(Message.RecordNotFound)
		.Where(e =>
			e.Response != null && e.Response.ErrorCode == ErrorCode.RecordNotFound
			&& e.Response.HasError
		);
	}

	[Fact]
	public async Task GetBusObBatch_Succeeds()
	{
		var cancellationToken = CancellationToken.None;

		var response = await _testCherwellClient
			.BusinessObject
			.GetBusinessObjectBatchAsync(
				new Models.BusinessObject.BatchReadRequest
				{
					ReadRequests = [
						new Models.BusinessObject.ReadRequest
						{
							BusObId = "9474671b302f46f59878e54249a1139bca30b2f21a",
							BusObRecId = "94746720483d08a3aa090740a6bf174ec536843461"
						}
					]
				},
				cancellationToken)
			;

		response
			.Should()
			.NotBeNull();
	}

	// GetBusinessObjectByPublicIdAsync - unable to test, we don't have a publicId to test with

	[Fact]
	public async Task BusOb_GetObjectByRecId_Error()
	{
		var cancellationToken = CancellationToken.None;

		await ((Func<Task>)(async () =>
		{
			_ = await _testCherwellClient
			.BusinessObject
			.GetBusinessObjectByRecIdAsync("944e0f0f214f53100758de4c81b78466866323bccf", "944e0f1424e236ce71b3c6484d875764a57ce45e51", cancellationToken)
			;
		}))
		.Should()
		.ThrowAsync<CherwellApiException>()
		.WithMessage(Message.RecordNotFound)
		.Where(e =>
			e.Response != null && e.Response.ErrorCode == ErrorCode.RecordNotFound
			&& e.Response.HasError
		);
	}

	// GetBusinessObjectByScanCodeBusObIdAsync - unable to test, we don't have a scanCode to test with

	// GetBusinessObjectByScanCodeBusObNameAsync - unable to test, we don't have a scanCode to test with

	[Fact]
	public async Task GetBusObSchema_Succeeds()
	{
		var cancellationToken = CancellationToken.None;

		var response = await _testCherwellClient
			.BusinessObject
			.GetBusinessObjectSchemaAsync("93c5ca8e7dbd4cc21dead14df19c684298a78358dd", true, cancellationToken)
			;

		response
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async Task GetBusObSummaries_Succeeds()
	{
		var cancellationToken = CancellationToken.None;

		var response = await _testCherwellClient
			.BusinessObject
			.GetBusinessObjectSummariesAsync("Major", cancellationToken)
			;

		response
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async Task GetBusObSummary_Succeeds()
	{
		var cancellationToken = CancellationToken.None;

		var response = await _testCherwellClient
			.BusinessObject
			.GetBusinessObjectSummaryByIdAsync("944e02d8537d17b3384143451180f87eda564c5798", cancellationToken)
			;

		response
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async Task GetBusObByName_Succeeds()
	{
		var cancellationToken = CancellationToken.None;

		var response = await _testCherwellClient
			.BusinessObject
			.GetBusinessObjectSummaryByNameAsync("Building", cancellationToken)
			;

		response
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async Task GetBusObTemplate_Succeeds()
	{
		var cancellationToken = CancellationToken.None;

		var response = await _testCherwellClient
			.BusinessObject
			.GetBusinessObjectTemplateAsync(
				new Models.BusinessObject.TemplateRequest
				{
					BusObId = "93c5ca8e7dbd4cc21dead14df19c684298a78358dd",
					FieldNames = ["Field1", "Field2"],
					FieldIds = ["Field1", "Field2"],
				}, cancellationToken)
			;

		response
			.Should()
			.NotBeNull();
	}

	// GetRelatedBusinessObjectByRequestAsync - unable to test, we don't have a relationship to test on

	// GetRelatedBusinessObjectAsync - unable to test, we don't have a relationship to test on

	// GetRelatedBusinessObjectWithCustomGridAsync - unable to test, we don't have a relationship to test on

	// LinkRelatedBusinessObjectByRecIdAsync - unable to test, we don't have a relationship to test on

	// LinkRelatedBusinessObjectByRecIdV2Async - unable to test, we don't have a relationship to test on

	// RemoveBusinessObjectAttachmentByIdAndPublicIdAsync - unable to test, we don't want to delete anything

	// RemoveBusinessObjectAttachmentByIdAndRecIdAsync - unable to test, we don't want to delete anything

	// RemoveBusinessObjectAttachmentByNameAndPublicIdAsync - unable to test, we don't want to delete anything

	// RemoveBusinessObjectAttachmentByNameAndRecIdAsync - unable to test, we don't want to delete anything

	// SaveBusinessObjectAttachmentBusObAsync - unable to test, we don't want to modify the business objects

	// SaveBusinessObjectAttachmentLinkAsync - unable to test, we don't want to modify the business objects

	// SaveBusinessObjectAttachmentUrlAsync - unable to test, we don't want to modify the business objects

	// SaveBusinessObjectBatchAsync - unable to test, we don't want to modify the business objects

	// SaveBusinessObjectAsync - unable to test, we don't want to modify the business objects

	// SaveRelatedBusinessObjectAsync - unable to test, we don't want to modify the business objects

	// UnLinkRelatedBusinessObjectByRecIdAsync - unable to test, we don't want to delete anything

	// UploadBusinessObjectAttachmentByIdAndPublicIdAsync - unable to test, we don't want to modify the business objects

	// UploadBusinessObjectAttachmentByIdAndRecIdAsync - unable to test, we don't want to modify the business objects

	// UploadBusinessObjectAttachmentByNameAndPublicIdAsync - unable to test, we don't want to modify the business objects

	// UploadBusinessObjectAttachmentByNameAndRecIdAsync - unable to test, we don't want to modify the business objects
}