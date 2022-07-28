using Refit;

namespace Cherwell.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IBusinessObject
{
	/// <summary>
	/// Delete Business Objects in a batch
	/// </summary>
	/// <remarks>
	/// Operation to delete a batch of Business Objects.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="request">Specify an array of Business Object IDs and record IDs or public IDs. Use a flag to stop on error or continue on error.</param>
	/// <returns>Task of BusinessObjectBatchDeleteResponse</returns>
	[Post("/api/V1/deletebusinessobjectbatch")]
	Task<BatchDeleteResponse> DeleteBusinessObjectBatchAsync(
		[Body] BatchDeleteRequest request,
		[AliasAs("lang")] string? lang,
		[AliasAs("locale")] string? locale,
		CancellationToken cancellationToken);

	/// <summary>
	/// Delete a Business Object by public ID
	/// </summary>
	/// <remarks>
	/// Operation to delete a Business Object by Business Object ID.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="busobid">Specify the Business Object ID.</param>
	/// <param name="publicid">Specify the Business Object public ID.</param>
	/// <returns>Task of DeleteResponse</returns>
	[Delete("/api/V1/deletebusinessobject/busobid/{busobid}/publicid/{publicid}")]
	Task<DeleteResponse> DeleteBusinessObjectByPublicIdAsync(
		[AliasAs("busobid")] string busobid,
		[AliasAs("publicid")] string publicid,
		CancellationToken cancellationToken);

	/// <summary>
	/// Delete a Business Object by record ID
	/// </summary>
	/// <remarks>
	/// Operation to delete a single Business Object.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="busobid">Specify the Business Object ID.</param>
	/// <param name="busobrecid"> Specify the Business Object record ID.</param>
	/// <returns>Task of DeleteResponse</returns>
	[Delete("/api/V1/deletebusinessobject/busobid/{busobid}/busobrecid/{busobrecid}")]
	Task<DeleteResponse> DeleteBusinessObjectByRecIdAsync(
		[AliasAs("busobid")] string busobid,
		[AliasAs("busobrecid")] string busobrecid,
		CancellationToken cancellationToken);

	/// <summary>
	/// Delete a related Business Object by public ID
	/// </summary>
	/// <remarks>
	/// Operation to delete a related Business Object. (Use \&quot;Unlink Related Business Object\&quot; to unlink two Business Objects rather that deleting the related Business Object.)
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentbusobid">Specify the Business Object ID for the parent Business Object.</param>
	/// <param name="parentbusobrecid">Specify the record ID for the parent Business Object</param>
	/// <param name="relationshipid">Specify the Relationship ID for the related Business Object you want to delete.</param>
	/// <param name="publicid">Specify the public ID for the related Business Object you want to delete. Use only for Business Objects with unique public IDs. Use \&quot;Delete a related Business Object by record ID\&quot; when public IDs are not unique.</param>
	/// <returns>Task of SearchesRelatedBusinessObjectResponse</returns>
	[Delete("/api/V1/deleterelatedbusinessobject/parentbusobid/{parentbusobid}/parentbusobrecid/{parentbusobrecid}/relationshipid/{relationshipid}/publicid/{publicid}")]
	Task<RelatedBusinessObjectResponse> DeleteRelatedBusinessObjectByPublicIdAsync(
		[AliasAs("parentbusobid")] string parentbusobid,
		[AliasAs("parentbusobrecid")] string parentbusobrecid,
		[AliasAs("relationshipid")] string relationshipid,
		[AliasAs("publicid")] string publicid,
		CancellationToken cancellationToken);

	/// <summary>
	/// Delete a related Business Object by record ID
	/// </summary>
	/// <remarks>
	/// Operation to delete a related Business Object. (Use \&quot;Unlink Related Business Object\&quot; to unlink two Business Objects rather that deleting the related Business Object.)
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentbusobid">Specify the Business Object ID for the parent Business Object.</param>
	/// <param name="parentbusobrecid">Specify the record ID for the parent Business Object</param>
	/// <param name="relationshipid">Specify the Relationship ID for the related Business Object you want to delete.</param>
	/// <param name="busobrecid">Specify the record ID for the related Business Object you want to delete.</param>
	/// <returns>Task of SearchesRelatedBusinessObjectResponse</returns>
	[Delete("/api/V1/deleterelatedbusinessobject/parentbusobid/{parentbusobid}/parentbusobrecid/{parentbusobrecid}/relationshipid/{relationshipid}/busobrecid/{busobrecid}")]
	Task<RelatedBusinessObjectResponse> DeleteRelatedBusinessObjectByRecIdAsync(
		[AliasAs("parentbusobid")] string parentbusobid,
		[AliasAs("parentbusobrecid")] string parentbusobrecid,
		[AliasAs("relationshipid")] string relationshipid,
		[AliasAs("busobrecid")] string busobrecid,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get lookup values for Fields
	/// </summary>
	/// <remarks>
	/// Operation to get potentially valid values for Business Object Fields.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="request">Request object that specifies the Business Object and Fields for which values are to be returned.</param>
	/// <returns>Task of BusinessObjectFieldValuesLookupResponse</returns>
	[Post("/api/V1/fieldvalueslookup")]
	Task<FieldValuesLookupResponse> BusinessObjectFieldValuesLookupAsync(
		[Body] FieldValuesLookupRequest request,
		CancellationToken cancellationToken);

	/// <summary>
	/// Retrieve all activities for a business object
	/// </summary>
	/// <remarks>
	/// Operation to retrieve all activities for a business object. Activities are mapped to history tracking business objects.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="busobid">Specify the Business Object ID.</param>
	/// <param name="busobrecid">Specify the Business Object record ID.</param>
	/// <param name="pageSize">Specify the number of rows to return per page. Maximum value is 2000 per page.</param>
	/// <param name="pageNumber">Specify the page number of the result set to return. (optional)</param>
	/// <param name="activityType">The category of activities to retrieve. Will default to All if not specified. (optional)</param>
	/// <returns>Task of List&lt;BusinessObjectBusObActivity&gt;</returns>
	[Get("/api/V1/getactivities/busobid/{busobid}/busobrecid/{busobrecid}/pagesize/{pageSize}")]
	Task<List<BusObActivity>> GetActivitiesAsync(
		[AliasAs("busobid")] string busobid,
		[AliasAs("busobrecid")] string busobrecid,
		[AliasAs("pageSize")] int pageSize,
		[AliasAs("pageNumber")] int? pageNumber,
		[AliasAs("activityType")] string? activityType,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get an imported Business Object attachment
	/// </summary>
	/// <remarks>
	/// Operation to get a Business Object attachment that has been imported into the system.  HTTP Range Header can be used but is optional.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="attachmentid">Specify the internal ID of the attachment record that contains information about the imported file.</param>
	/// <param name="busobid">Specify the Business Object ID.</param>
	/// <param name="busobrecid">Specify the Business Object record ID.</param>
	/// <returns>Task of byte[]</returns>
	[Get("/api/V1/getbusinessobjectattachment/attachmentid/{attachmentid}/busobid/{busobid}/busobrecid/{busobrecid}")]
	Task<byte[]> GetBusinessObjectAttachmentByAttachmentIdAsync(
		[AliasAs("attachmentid")] string attachmentid,
		[AliasAs("busobid")] string busobid,
		[AliasAs("busobrecid")] string busobrecid,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get attachments by Business Object public ID
	/// </summary>
	/// <remarks>
	/// Operation to get attachments for a Business Object by Business Object ID and public ID.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="busobid">Specify the Business Object ID.</param>
	/// <param name="publicid">Specify the Business Object public ID for the record that contains the attachments.</param>
	/// <param name="type">Record attachment type: &lt;/br&gt; None - Not applicable to the REST API. &lt;/br&gt; File - Linked files. &lt;/br&gt; FileManagerFile - Imported files.&lt;/br&gt; BusOb - Attached Business Objects. &lt;/br&gt; History - Information about the attachment, if any is available. For example, an e-mail message may store the name of an attachment sent.&lt;/br&gt; Other - Not applicable to the REST API. &lt;/br&gt;</param>
	/// <param name="attachmenttype">For file types, select the type of attachment: &lt;/br&gt; Imported - Attachment was imported into database. &lt;/br&gt; Linked - Attachment is linked to an external file. &lt;/br&gt; URL - Attachment is a URL.</param>
	/// <param name="includelinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
	/// <returns>Task of AttachmentsResponse</returns>
	[Get("/api/V1/getbusinessobjectattachments/busobid/{busobid}/publicid/{publicid}/type/{type}/attachmenttype/{attachmenttype}")]
	Task<AttachmentsResponse> GetBusinessObjectAttachmentsByIdAndPublicIdAsync(
		[AliasAs("busobid")] string busobid,
		[AliasAs("publicid")] string publicid,
		[AliasAs("type")] string type,
		[AliasAs("attachmenttype")] string attachmenttype,
		[AliasAs("includelinks")] bool? includelinks,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get attachments by Business Object record ID
	/// </summary>
	/// <remarks>
	/// Operation to get attachments for a Business Object by Business Object ID and record ID.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="busobid">Specify the Business Object ID.</param>
	/// <param name="busobrecid">Specify the Business Object record ID.</param>
	/// <param name="type">Record attachment type: &lt;/br&gt; None - Not applicable to the REST API. &lt;/br&gt; File - Linked files. &lt;/br&gt; FileManagerFile - Imported files.&lt;/br&gt; BusOb - Attached Business Objects. &lt;/br&gt; History - Information about the attachment, if any is available. For example, an e-mail message may store the name of an attachment sent.&lt;/br&gt; Other - Not applicable to the REST API. &lt;/br&gt;</param>
	/// <param name="attachmenttype">For file types, select the type of attachment: &lt;/br&gt; Imported - Attachment was imported into database. &lt;/br&gt; Linked - Attachment is linked to an external file. &lt;/br&gt; URL - Attachment is a URL.</param>
	/// <param name="includelinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
	/// <returns>Task of AttachmentsResponse</returns>
	[Get("/api/V1/getbusinessobjectattachments/busobid/{busobid}/busobrecid/{busobrecid}/type/{type}/attachmenttype/{attachmenttype}")]
	Task<AttachmentsResponse> GetBusinessObjectAttachmentsByIdAndRecIdAsync(
		[AliasAs("busobid")] string busobid,
		[AliasAs("busobrecid")] string busobrecid,
		[AliasAs("type")] string type,
		[AliasAs("attachmenttype")] string attachmenttype,
		[AliasAs("includelinks")] bool? includelinks,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get attachments by Business Object name and public ID
	/// </summary>
	/// <remarks>
	/// Operation to get attachments for a Business Object by Business Object Name and public ID.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="busobname">Specify the Business Object name.</param>
	/// <param name="publicid">Specify the Business Object public ID for the record that contains the attachments.</param>
	/// <param name="type">Record attachment type: &lt;/br&gt; None - Not applicable to the REST API. &lt;/br&gt; File - Linked files. &lt;/br&gt; FileManagerFile - Imported files.&lt;/br&gt; BusOb - Attached Business Objects. &lt;/br&gt; History - Information about the attachment, if any is available. For example, an e-mail message may store the name of an attachment sent.&lt;/br&gt; Other - Not applicable to the REST API. &lt;/br&gt;</param>
	/// <param name="attachmenttype">For file types, select the type of attachment: &lt;/br&gt; Imported - Attachment was imported into database. &lt;/br&gt; Linked - Attachment is linked to an external file. &lt;/br&gt; URL - Attachment is a URL.</param>
	/// <param name="includelinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
	/// <returns>Task of AttachmentsResponse</returns>
	[Get("/api/V1/getbusinessobjectattachments/busobname/{busobname}/publicid/{publicid}/type/{type}/attachmenttype/{attachmenttype}")]
	Task<AttachmentsResponse> GetBusinessObjectAttachmentsByNameAndPublicIdAsync(
		[AliasAs("busobname")] string busobname,
		[AliasAs("publicid")] string publicid,
		[AliasAs("type")] string type,
		[AliasAs("attachmenttype")] string attachmenttype,
		[AliasAs("includelinks")] bool? includelinks,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get attachments by Business Object name and record ID
	/// </summary>
	/// <remarks>
	/// Operation to get attachments for a Business Object by name and record ID.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="busobname">Specify the Business Object name.</param>
	/// <param name="busobrecid">Specify the Business Object record ID.</param>
	/// <param name="type">Record attachment type: &lt;/br&gt; None - Not applicable to the REST API. &lt;/br&gt; File - Linked files. &lt;/br&gt; FileManagerFile - Imported files.&lt;/br&gt; BusOb - Attached Business Objects. &lt;/br&gt; History - Information about the attachment, if any is available. For example, an e-mail message may store the name of an attachment sent.&lt;/br&gt; Other - Not applicable to the REST API. &lt;/br&gt;</param>
	/// <param name="attachmenttype">For file types, select the type of attachment: &lt;/br&gt; Imported - Attachment was imported into database. &lt;/br&gt; Linked - Attachment is linked to an external file. &lt;/br&gt; URL - Attachment is a URL.</param>
	/// <param name="includelinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
	/// <returns>Task of AttachmentsResponse</returns>
	[Get("/api/V1/getbusinessobjectattachments/busobname/{busobname}/busobrecid/{busobrecid}/type/{type}/attachmenttype/{attachmenttype}")]
	Task<AttachmentsResponse> GetBusinessObjectAttachmentsByNameAndRecIdAsync(
		[AliasAs("busobname")] string busobname,
		[AliasAs("busobrecid")] string busobrecid,
		[AliasAs("type")] string type,
		[AliasAs("attachmenttype")] string attachmenttype,
		[AliasAs("includelinks")] bool? includelinks,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get Business Object attachments by request object
	/// </summary>
	/// <remarks>
	/// Operation to get attachments for a Business Object by attachments request object.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="attachmentsRequest">Object with all the parameters to request an attachments list. You can also request a list of types to get more than just one type at a time.</param>
	/// <returns>Task of AttachmentsResponse</returns>
	[Post("/api/V1/getbusinessobjectattachments")]
	Task<AttachmentsResponse> GetBusinessObjectAttachmentsAsync(
		[Body] AttachmentsRequest attachmentsRequest,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get a batch of Business Object records
	/// </summary>
	/// <remarks>
	/// Operation that returns a batch of Business Object records that includes a list of field record IDs, display names, and values for each record.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="request">Specify an array of Business Object IDs, record IDs, or public IDs. Use a flag to stop on error or continue on error.</param>
	/// <returns>Task of BatchReadResponse</returns>
	[Post("/api/V1/getbusinessobjectbatch")]
	Task<BatchReadResponse> GetBusinessObjectBatchAsync(
		[Body] BatchReadRequest request,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get a Business Object record
	/// </summary>
	/// <remarks>
	/// Operation that returns a Business Object record that includes a list of Fields and their record IDs, names, and set values.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="busobid">Specify the Business Object ID.</param>
	/// <param name="publicid">Specify the Business Object public ID.</param>
	/// <returns>Task of ReadResponse</returns>
	[Get("/api/V1/getbusinessobject/busobid/{busobid}/publicid/{publicid}")]
	Task<ReadResponse> GetBusinessObjectByPublicIdAsync(
		[AliasAs("busobid")] string busobid,
		[AliasAs("publicid")] string publicid,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get a Business Object record
	/// </summary>
	/// <remarks>
	/// Operation that returns a Business Object record that includes a list of Fields and their record IDs, names, and set values.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="busobid">Specify the Business Object ID.</param>
	/// <param name="busobrecid">Specify the Business Object record ID.</param>
	/// <returns>Task of ReadResponse</returns>
	[Get("/api/V1/getbusinessobject/busobid/{busobid}/busobrecid/{busobrecid}")]
	Task<ReadResponse> GetBusinessObjectByRecIdAsync(
		[AliasAs("busobid")] string busobid,
		[AliasAs("busobrecid")] string busobrecid,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get a Business Object by its scan code and Business Object ID
	/// </summary>
	/// <remarks>
	/// Operation to get a Business Object based on its associated scan code and Business Object ID.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="scanCode">The scan code for a Business Object record.</param>
	/// <param name="busobid">The Business Object ID.</param>
	/// <returns>Task of BarcodeLookupResponse</returns>
	[Get("/api/V1/getbusinessobject/scancode/{scanCode}/busobid/{busobid}")]
	Task<BarcodeLookupResponse> GetBusinessObjectByScanCodeBusObIdAsync(
		[AliasAs("scanCode")] string scanCode,
		[AliasAs("busobid")] string busobid,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get a Business Object by its scan code and Business Object name
	/// </summary>
	/// <remarks>
	/// Operation to get a Business Object based on its associated scan code and Business Object name.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="scanCode">The scan code for a Business Object record.</param>
	/// <param name="busobname">The Business Bbject name.</param>
	/// <returns>Task of BarcodeLookupResponse</returns>
	[Get("/api/V1/getbusinessobject/scancode/{scanCode}/busobname/{busobname}")]
	Task<BarcodeLookupResponse> GetBusinessObjectByScanCodeBusObNameAsync(
		[AliasAs("scanCode")] string scanCode,
		[AliasAs("busobname")] string busobname,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get a Business Object schema
	/// </summary>
	/// <remarks>
	/// Operation that returns the schema for a Business Object and, optionally, its related Business Objects.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="busobId">Specify the Business Object ID.</param>
	/// <param name="includerelationships">Flag to include schemas for related Business Object. Default is false. (optional)</param>
	/// <returns>Task of SchemaResponse</returns>
	[Get("/api/V1/getbusinessobjectschema/busobid/{busobId}")]
	Task<SchemaResponse> GetBusinessObjectSchemaAsync(
		[AliasAs("busobId")] string busobId,
		[AliasAs("includerelationships")] bool? includerelationships,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get Business Object summaries by type
	/// </summary>
	/// <remarks>
	/// Operation that returns a list of Business Object summaries by type (Major, Supporting, Lookup, Groups, and All). 
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="type">Use to show:&lt;br /&gt;All - All objects&lt;br /&gt;Major - Major objects only&lt;br /&gt;Supporting - Supporting objects only&lt;br /&gt;Lookup - Lookup objects only&lt;br /&gt;Groups - Groups only</param>
	/// <returns>Task of List&lt;Summary&gt;</returns>
	[Get("/api/V1/getbusinessobjectsummaries/type/{type}")]
	Task<List<Summary>> GetBusinessObjectSummariesAsync(
		[AliasAs("type")] string type,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get a Business Object summary by ID
	/// </summary>
	/// <remarks>
	/// Operation that returns a single Business Object summary by ID.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="busobid">Specify a Business Object ID to get its summary.</param>
	/// <returns>Task of List&lt;Summary&gt;</returns>
	[Get("/api/V1/getbusinessobjectsummary/busobid/{busobid}")]
	Task<List<Summary>> GetBusinessObjectSummaryByIdAsync(
		[AliasAs("busobid")] string busobid,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get a Business Object summary by name
	/// </summary>
	/// <remarks>
	/// Operation that returns a single Business Object summary by name.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="busobname">Specify a Business Object name to get its summary.</param>
	/// <returns>Task of List&lt;Summary&gt;</returns>
	[Get("/api/V1/getbusinessobjectsummary/busobname/{busobname}")]
	Task<List<Summary>> GetBusinessObjectSummaryByNameAsync(
		[AliasAs("busobname")] string busobname,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get Business Object templates for create
	/// </summary>
	/// <remarks>
	/// Operation that returns a template to create Business Objects.  The template includes placeholders for field values. You can then send the template with these values to the Business Object Save operation.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="request">Specify the Business Object ID. Use true to include all required Fields or all Fields. Specify an optional Fields list by adding field names in a comma-delimited list [\&quot;field1\&quot;, \&quot;field2\&quot;]. </param>
	/// <returns>Task of TemplateResponse</returns>
	[Post("/api/V1/getbusinessobjecttemplate")]
	Task<TemplateResponse> GetBusinessObjectTemplateAsync(
		[Body] TemplateRequest request,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get related Business Objects using a request object
	/// </summary>
	/// <remarks>
	/// Operation to get related Business Objects for a specific relationship. Specify a list of Fields to include in the response. The order of parameter usage and overrides is: all Fields set to true overrides default overrides;  custom grid overrides field list settings.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="relatedBusinessObjectRequest">Request object containing all the possible parameters to get related Business Objects.</param>
	/// <param name="includelinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
	/// <returns>Task of SearchesRelatedBusinessObjectResponse</returns>
	[Post("/api/V1/getrelatedbusinessobject")]
	Task<RelatedBusinessObjectResponse> GetRelatedBusinessObjectByRequestAsync(
		[Body] RelatedBusinessObjectRequest relatedBusinessObjectRequest,
		[AliasAs("includelinks")] bool? includelinks,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get related Business Objects by ID
	/// </summary>
	/// <remarks>
	/// Operation to get the related objects for a Business Object relationship specifying all Fields or default grid as the field to return.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentbusobid">Specify the Business Object ID for the parent Business Object.</param>
	/// <param name="parentbusobrecid">Specify the record ID for the parent Business Object.</param>
	/// <param name="relationshipid">Specify the Relationship ID for the related Business Object you want to return.</param>
	/// <param name="pageNumber">Specify the page number of the result set to return. (optional)</param>
	/// <param name="pageSize">Specify the number of rows to return per page. (optional)</param>
	/// <param name="allfields">Flag to include all related Business Object Fields.  Default is true if not supplied.  If true, then UseDefaultGrid is not used. (optional)</param>
	/// <param name="usedefaultgrid">Flag to trigger the use of the related Business Objects default grid for the list of Fields to return. (optional)</param>
	/// <param name="includelinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
	/// <returns>Task of SearchesRelatedBusinessObjectResponse</returns>
	[Get("/api/V1/getrelatedbusinessobject/parentbusobid/{parentbusobid}/parentbusobrecid/{parentbusobrecid}/relationshipid/{relationshipid}")]
	Task<RelatedBusinessObjectResponse> GetRelatedBusinessObjectAsync(
		[AliasAs("parentbusobid")] string parentbusobid,
		[AliasAs("parentbusobrecid")] string parentbusobrecid,
		[AliasAs("relationshipid")] string relationshipid,
		[AliasAs("pageNumber")] int? pageNumber,
		[AliasAs("pageSize")] int? pageSize,
		[AliasAs("allfields")] bool? allfields,
		[AliasAs("usedefaultgrid")] bool? usedefaultgrid,
		[AliasAs("includelinks")] bool? includelinks,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get related Business Objects custom grid
	/// </summary>
	/// <remarks>
	/// Operation to get related Business Objects for a specific relationship. Specify a custom grid ID as the Fields to return.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentbusobid">Specify the Business Object ID for the parent Business Object.</param>
	/// <param name="parentbusobrecid">Specify the record ID for the parent Business Object.</param>
	/// <param name="relationshipid">Specify the Relationship ID for the related Business Object you want to return.</param>
	/// <param name="gridid">Specify the ID for the custom grid that contains the field list.</param>
	/// <param name="pageNumber">Specify the page number of the result set to return. (optional)</param>
	/// <param name="pageSize">Specify the number of rows to return per page. (optional)</param>
	/// <param name="includelinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
	/// <returns>Task of SearchesRelatedBusinessObjectResponse</returns>
	[Get("/api/V1/getrelatedbusinessobject/parentbusobid/{parentbusobid}/parentbusobrecid/{parentbusobrecid}/relationshipid/{relationshipid}/gridid/{gridid}")]
	Task<RelatedBusinessObjectResponse> GetRelatedBusinessObjectWithCustomGridAsync(
		[AliasAs("parentbusobid")] string parentbusobid,
		[AliasAs("parentbusobrecid")] string parentbusobrecid,
		[AliasAs("relationshipid")] string relationshipid,
		[AliasAs("gridid")] string gridid,
		[AliasAs("pageNumber")] int? pageNumber,
		[AliasAs("pageSize")] int? pageSize,
		[AliasAs("includelinks")] bool? includelinks,
		CancellationToken cancellationToken);

	/// <summary>
	/// Link related Business Objects
	/// </summary>
	/// <remarks>
	/// Operation to link related Business Objects. 
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentbusobid">Specify the Business Object ID for the parent Business Object.</param>
	/// <param name="parentbusobrecid">Specify the record ID for the parent Business Object.</param>
	/// <param name="relationshipid">Specify the Relationship ID for the related Business Object you want to link.</param>
	/// <param name="busobid">Specify the Business Object ID of the Business Object to be linked.</param>
	/// <param name="busobrecid">Specify the Business Object record ID of the Business Object to be linked.</param>
	/// <returns>Task of SearchesRelatedBusinessObjectResponse</returns>
	[Get("/api/V1/linkrelatedbusinessobject/parentbusobid/{parentbusobid}/parentbusobrecid/{parentbusobrecid}/relationshipid/{relationshipid}/busobid/{busobid}/busobrecid/{busobrecid}")]
	Task<RelatedBusinessObjectResponse> LinkRelatedBusinessObjectByRecIdAsync(
		[AliasAs("parentbusobid")] string parentbusobid,
		[AliasAs("parentbusobrecid")] string parentbusobrecid,
		[AliasAs("relationshipid")] string relationshipid,
		[AliasAs("busobid")] string busobid,
		[AliasAs("busobrecid")] string busobrecid,
		CancellationToken cancellationToken);

	/// <summary>
	/// Link related Business Objects
	/// </summary>
	/// <remarks>
	/// Operation to link related Business Objects. 
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentbusobid">Specify the Business Object ID for the parent Business Object.</param>
	/// <param name="parentbusobrecid">Specify the record ID for the parent Business Object.</param>
	/// <param name="relationshipid">Specify the Relationship ID for the related Business Object you want to link.</param>
	/// <param name="busobid">Specify the Business Object ID of the Business Object to be linked.</param>
	/// <param name="busobrecid">Specify the Business Object record ID of the Business Object to be linked.</param>
	/// <returns>Task of ResponseBase</returns>
	[Get("/api/V2/linkrelatedbusinessobject/parentbusobid/{parentbusobid}/parentbusobrecid/{parentbusobrecid}/relationshipid/{relationshipid}/busobid/{busobid}/busobrecid/{busobrecid}")]
	Task<ResponseBase> LinkRelatedBusinessObjectByRecIdV2Async(
		[AliasAs("parentbusobid")] string parentbusobid,
		[AliasAs("parentbusobrecid")] string parentbusobrecid,
		[AliasAs("relationshipid")] string relationshipid,
		[AliasAs("busobid")] string busobid,
		[AliasAs("busobrecid")] string busobrecid,
		CancellationToken cancellationToken);

	/// <summary>
	/// Remove an attachment by Business Object ID and public ID
	/// </summary>
	/// <remarks>
	/// Operation to remove an attachment from a Business Object using the attachment record ID, Business Object ID, and Business Object public ID.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="attachmentid">Specify the internal ID of the attachment record.</param>
	/// <param name="busobid">Specify the Business Object ID.</param>
	/// <param name="publicid">Specify the Business Object public ID.</param>
	/// <returns>Task of void</returns>
	[Delete("/api/V1/removebusinessobjectattachment/attachmentid/{attachmentid}/busobid/{busobid}/publicid/{publicid}")]
	Task RemoveBusinessObjectAttachmentByIdAndPublicIdAsync(
		[AliasAs("attachmentid")] string attachmentid,
		[AliasAs("busobid")] string busobid,
		[AliasAs("publicid")] string publicid,
		CancellationToken cancellationToken);

	/// <summary>
	/// Remove an attachment by Business Object ID and record ID
	/// </summary>
	/// <remarks>
	/// Operation to remove an attachment from a Business Object using the attachment record ID, Business Object ID, and Business Object record ID.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="attachmentid">Specify the internal ID of the attachment record.</param>
	/// <param name="busobid">Specify the Business Object ID.</param>
	/// <param name="busobrecid">Specify the Business Object record ID.</param>
	/// <returns>Task of void</returns>
	[Delete("/api/V1/removebusinessobjectattachment/attachmentid/{attachmentid}/busobid/{busobid}/busobrecid/{busobrecid}")]
	Task RemoveBusinessObjectAttachmentByIdAndRecIdAsync(
		[AliasAs("attachmentid")] string attachmentid,
		[AliasAs("busobid")] string busobid,
		[AliasAs("busobrecid")] string busobrecid,
		CancellationToken cancellationToken);

	/// <summary>
	/// Remove an attachment by Business Object name and public ID
	/// </summary>
	/// <remarks>
	/// Operation to remove an attachment from a Business Object using the attachment record ID, Business Object name, and Business Object record ID.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="attachmentid">Specify the internal ID of the attachment record.</param>
	/// <param name="busobname">Specify the Business Object name.</param>
	/// <param name="publicid">Specify the Business Object public ID.</param>
	/// <returns>Task of void</returns>
	[Delete("/api/V1/removebusinessobjectattachment/attachmentid/{attachmentid}/busobname/{busobname}/publicid/{publicid}")]
	Task RemoveBusinessObjectAttachmentByNameAndPublicIdAsync(
		[AliasAs("attachmentid")] string attachmentid,
		[AliasAs("busobname")] string busobname,
		[AliasAs("publicid")] string publicid,
		CancellationToken cancellationToken);

	/// <summary>
	/// Remove an attachment by Business Object name and record ID
	/// </summary>
	/// <remarks>
	/// Operation to remove an attachment from a Business Object using the attachment record ID, Business Object name, and Business Object public ID.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="attachmentid">Specify the internal ID of the attachment record.</param>
	/// <param name="busobname">Specify the Business Object name.</param>
	/// <param name="busobrecid">Specify the Business Object record ID.</param>
	/// <returns>Task of void</returns>
	[Delete("/api/V1/removebusinessobjectattachment/attachmentid/{attachmentid}/busobname/{busobname}/busobrecid/{busobrecid}")]
	Task RemoveBusinessObjectAttachmentByNameAndRecIdAsync(
		[AliasAs("attachmentid")] string attachmentid,
		[AliasAs("busobname")] string busobname,
		[AliasAs("busobrecid")] string busobrecid,
		CancellationToken cancellationToken);

	/// <summary>
	/// Attach a Business Object to a Business Object
	/// </summary>
	/// <remarks>
	/// Operation to attach a Business Object to a Business Object. This links the Business Object but does not create a relationship between the two. (Use \&quot;Link Related Business Objects\&quot; to create a relationship.)
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="request">Request object used to specify the Business Objects to attach. You can use Business Object name or ID and Business Object record ID or public ID.</param>
	/// <returns>Task of AttachmentsResponse</returns>
	[Put("/api/V1/savebusinessobjectattachmentbusob")]
	Task<AttachmentsResponse> SaveBusinessObjectAttachmentBusObAsync(
		[Body] SaveBusObAttachmentRequest request,
		CancellationToken cancellationToken);

	/// <summary>
	/// Attach a file via UNC
	/// </summary>
	/// <remarks>
	/// Operation to attach a file to a Business Object via a path (UNC recommended).
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="request">Request object used to specify the file path (UNC recommended) and the Business Object. You can use Business Object name or ID and Business Object record ID or public ID.</param>
	/// <returns>Task of AttachmentsResponse</returns>
	[Put("/api/V1/savebusinessobjectattachmentlink")]
	Task<AttachmentsResponse> SaveBusinessObjectAttachmentLinkAsync(
		[Body] SaveLinkAttachmentRequest request,
		CancellationToken cancellationToken);

	/// <summary>
	/// Attach a URL path
	/// </summary>
	/// <remarks>
	/// Operation to attach a URL path to a Business Object.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="request">Request object used to specify the URL path and Business Object. You can use Business Object name or ID and Business Object record ID or public ID.</param>
	/// <returns>Task of AttachmentsResponse</returns>
	[Put("/api/V1/savebusinessobjectattachmenturl")]
	Task<AttachmentsResponse> SaveBusinessObjectAttachmentUrlAsync(
		[Body] SaveUrlAttachmentRequest request,
		CancellationToken cancellationToken);

	/// <summary>
	/// Create or update a batch of Business Objects
	/// </summary>
	/// <remarks>
	/// Operation that creates or updates an array of Business Objects in a batch. To update, specify record ID or public ID. To create, leave record ID and public ID empty.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="request">Specify the array of Business Object templates. </param>
	/// <returns>Task of BatchSaveResponse</returns>
	[Post("/api/V1/savebusinessobjectbatch")]
	Task<BatchSaveResponse> SaveBusinessObjectBatchAsync(
		[Body] BatchSaveRequest request,
		CancellationToken cancellationToken);

	/// <summary>
	/// Create or Update a Business Object
	/// </summary>
	/// <remarks>
	/// Operation that creates a new Business Object or updates an existing Business Object. To create, leave record ID and public ID empty. Upon creating or saving, a cache key is returned to use for subsequent requests. If the object is not found in the cache with said cache key, specify record ID or public ID to save and return a new cache key. Set persist &#x3D; true, to actually save the Business Object to disk, persist &#x3D; false will just cache it.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="request">Specify a list of Fields from a Business Object template. </param>
	/// <returns>Task of SaveResponse</returns>
	[Post("/api/V1/savebusinessobject")]
	Task<SaveResponse> SaveBusinessObjectAsync(
		[Body] SaveRequest request,
		CancellationToken cancellationToken);

	/// <summary>
	/// Create or update a related Business Object
	/// </summary>
	/// <remarks>
	/// Operation that creates or updates a related Business Object. To update, specify record ID or public ID. To create, leave record ID and public ID empty.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="request">Request object specifying the parent the Business Object, the Relationship, and field values for the Business Object to create or update. </param>
	/// <returns>Task of RelatedSaveResponse</returns>
	[Post("/api/V1/saverelatedbusinessobject")]
	Task<RelatedSaveResponse> SaveRelatedBusinessObjectAsync(
		[Body] RelatedSaveRequest request,
		CancellationToken cancellationToken);

	/// <summary>
	/// UnLink related Business Objects
	/// </summary>
	/// <remarks>
	/// Operation to unlink related Business Objects.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="parentbusobid">Specify the Business Object ID for the parent Business Object.</param>
	/// <param name="parentbusobrecid">Specify the record ID for the parent Business Object.</param>
	/// <param name="relationshipid">Specify the Relationship ID for the related Business Object you want to unlink.</param>
	/// <param name="busobid">Specify the Business Object ID of the Business Object to be unlinked.</param>
	/// <param name="busobrecid">Specify the Business Object record ID of the Business Object to be unlinked.</param>
	/// <returns>Task of SearchesRelatedBusinessObjectResponse</returns>
	[Delete("/api/V1/unlinkrelatedbusinessobject/parentbusobid/{parentbusobid}/parentbusobrecid/{parentbusobrecid}/relationshipid/{relationshipid}/busobid/{busobid}/busobrecid/{busobrecid}")]
	Task<RelatedBusinessObjectResponse> UnLinkRelatedBusinessObjectByRecIdAsync(
		[AliasAs("parentbusobid")] string parentbusobid,
		[AliasAs("parentbusobrecid")] string parentbusobrecid,
		[AliasAs("relationshipid")] string relationshipid,
		[AliasAs("busobid")] string busobid,
		[AliasAs("busobrecid")] string busobrecid,
		CancellationToken cancellationToken);

	/// <summary>
	/// Upload an attachment by Business Object ID and public ID
	/// </summary>
	/// <remarks>
	/// Operation to upload an attachment to a Business Object record using a Business Object ID and public ID. The body of the request is the byte array of the file part being uploaded.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="body"></param>
	/// <param name="filename">Specify the name of the file being uploaded. If no attachment name is provided, the file name is used.</param>
	/// <param name="busobid">Specify the Business Object ID.</param>
	/// <param name="publicid">Specify the Business Object public ID  to attach the file to.</param>
	/// <param name="offset">The offset is the starting index of the file part being uploaded.  If this is the first part then the offset will be zero.</param>
	/// <param name="totalsize">The entire file size in bytes.</param>
	/// <param name="attachmentid">Specify the attachment ID of an uploaded file to upload subsequent parts and ensure each part gets appended to the parts that have already been uploaded. (optional)</param>
	/// <param name="displaytext">Specify the attachment name, which is the display text for the attachment record. (optional)</param>
	/// <returns>Task of string</returns>
	[Post("/api/V1/uploadbusinessobjectattachment/filename/{filename}/busobid/{busobid}/publicid/{publicid}/offset/{offset}/totalsize/{totalsize}")]
	Task<string> UploadBusinessObjectAttachmentByIdAndPublicIdAsync(
		[Body] byte[] body,
		[AliasAs("filename")] string filename,
		[AliasAs("busobid")] string busobid,
		[AliasAs("publicid")] string publicid,
		[AliasAs("offset")] int? offset,
		[AliasAs("totalsize")] int? totalsize,
		[AliasAs("attachmentid")] string attachmentid,
		[AliasAs("displaytext")] string displaytext,
		CancellationToken cancellationToken);

	/// <summary>
	/// Upload an attachment by Business Object ID and record ID
	/// </summary>
	/// <remarks>
	/// Operation to upload an attachment to a Business Object record using a Business Object ID and record ID. The body of the request is the byte array of the file part being uploaded.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="body"></param>
	/// <param name="filename">Specify the name of the file being uploaded. If no attachment name is provided, the file name is used.</param>
	/// <param name="busobid">Specify the Business Object ID.</param>
	/// <param name="busobrecid">Specify the Business Object record ID to attach the file to.</param>
	/// <param name="offset">The offset is the starting index of the file part being uploaded.  If this is the first part then the offset will be zero.</param>
	/// <param name="totalsize">The entire file size in bytes.</param>
	/// <param name="attachmentid">Specify the attachment ID of an uploaded file to upload subsequent parts and ensure each part gets appended to the parts that have already been uploaded. (optional)</param>
	/// <param name="displaytext">Specify the attachment name, which is the display text for the attachment record. (optional)</param>
	/// <returns>Task of string</returns>
	[Post("/api/V1/uploadbusinessobjectattachment/filename/{filename}/busobid/{busobid}/busobrecid/{busobrecid}/offset/{offset}/totalsize/{totalsize}")]
	Task<string> UploadBusinessObjectAttachmentByIdAndRecIdAsync(
		[Body] byte[] body,
		[AliasAs("filename")] string filename,
		[AliasAs("busobid")] string busobid,
		[AliasAs("busobrecid")] string busobrecid,
		[AliasAs("offset")] int? offset,
		[AliasAs("totalsize")] int? totalsize,
		[AliasAs("attachmentid")] string attachmentid,
		[AliasAs("displaytext")] string displaytext,
		CancellationToken cancellationToken);

	/// <summary>
	/// Upload an attachment by Business Object name and public ID
	/// </summary>
	/// <remarks>
	/// Operation to upload an attachment to a Business Object record using a Business Object name and public ID. The body of the request is the byte array of the file part being uploaded.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="body"></param>
	/// <param name="filename">Specify the name of the file being uploaded. If no attachment name is provided, the file name is used.</param>
	/// <param name="busobname">Specify the Business Object name.</param>
	/// <param name="publicid">Specify the Business Object public ID  to attach the file to.</param>
	/// <param name="offset">The offset is the starting index of the file part being uploaded.  If this is the first part then the offset will be zero.</param>
	/// <param name="totalsize">The entire file size in bytes.</param>
	/// <param name="attachmentid">Specify the attachment ID of an uploaded file to upload subsequent parts and ensure each part gets appended to the parts that have already been uploaded. (optional)</param>
	/// <param name="displaytext">Specify the attachment name, which is the display text for the attachment record. (optional)</param>
	/// <returns>Task of string</returns>
	[Post("/api/V1/uploadbusinessobjectattachment/filename/{filename}/busobname/{busobname}/publicid/{publicid}/offset/{offset}/totalsize/{totalsize}")]
	Task<string> UploadBusinessObjectAttachmentByNameAndPublicIdAsync(
		[Body] byte[] body,
		[AliasAs("filename")] string filename,
		[AliasAs("busobname")] string busobname,
		[AliasAs("publicid")] string publicid,
		[AliasAs("offset")] int? offset,
		[AliasAs("totalsize")] int? totalsize,
		[AliasAs("attachmentid")] string attachmentid,
		[AliasAs("displaytext")] string displaytext,
		CancellationToken cancellationToken);

	/// <summary>
	/// Upload an attachment by Business Object name and record ID
	/// </summary>
	/// <remarks>
	/// Operation to upload an attachment to a Business Object record using a Business Object name and record ID. The body of the request is the byte array of the file part being uploaded.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="body"></param>
	/// <param name="filename">Specify the name of the file being uploaded. If no attachment name is provided, the file name is used.</param>
	/// <param name="busobname">Specify the Business Object name.</param>
	/// <param name="busobrecid">Specify the Business Object record ID to attach the file to.</param>
	/// <param name="offset">The offset is the starting index of the file part being uploaded.  If this is the first part then the offset will be zero.</param>
	/// <param name="totalsize">The entire file size in bytes.</param>
	/// <param name="attachmentid">Specify the attachment ID of an uploaded file to upload subsequent parts and ensure each part gets appended to the parts that have already been uploaded. (optional)</param>
	/// <param name="displaytext">Specify the attachment name, which is the display text for the attachment record. (optional)</param>
	/// <returns>Task of string</returns>
	[Post("/api/V1/uploadbusinessobjectattachment/filename/{filename}/busobname/{busobname}/busobrecid/{busobrecid}/offset/{offset}/totalsize/{totalsize}")]
	Task<string> UploadBusinessObjectAttachmentByNameAndRecIdAsync(
		[Body] byte[] body,
		[AliasAs("filename")] string filename,
		[AliasAs("busobname")] string busobname,
		[AliasAs("busobrecid")] string busobrecid,
		[AliasAs("offset")] int? offset,
		[AliasAs("totalsize")] int? totalsize,
		[AliasAs("attachmentid")] string attachmentid,
		[AliasAs("displaytext")] string displaytext,
		CancellationToken cancellationToken);
}
