using Refit;

namespace Cherwell.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ISearches
{
	/// <summary>
	/// Get a Quick Search from a list of Business Object IDs
	/// </summary>
	/// <remarks>
	/// Operation to build a Quick Search configuration that you can use to execute a Quick Search for multiple Business Objects. The configuration includes supplied Business Object IDs and specific search items with the following options. Use the Option Key to determine if you can change the options.  &lt;/br&gt;&lt;/br&gt;ChangedOption&lt;/br&gt; NonFinalStateOption&lt;/br&gt; SearchAnyWordsOption&lt;/br&gt; SearchAttachmentsOption&lt;/br&gt; SearchRelatedOption&lt;/br&gt; SortByOption&lt;/br&gt; &lt;/br&gt;Option Key:&lt;/br&gt; 0 &#x3D; None (Not selected and cannot select.)&lt;/br&gt; 1 &#x3D; Use (Selected and cannot clear.)&lt;/br&gt; 2 &#x3D; Display (Not selected and can select.)&lt;/br&gt; 3 &#x3D; UseAndDisplay (Selected and can clear.)&lt;/br&gt;&lt;/br&gt; SearchTargetType:&lt;/br&gt; 0 &#x3D; BusOb (Business Object)&lt;/br&gt; 1 &#x3D; DocRepository (Document Repository)
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="dataRequest">Request containing the Business Object IDs list.</param>
	/// <returns>Task of QuickSearchConfigurationResponse</returns>
	[Post("/api/V1/getquicksearchconfigurationforbusobs")]
	Task<QuickSearchConfigurationResponse> GetQuickSearchConfigurationForBusObsAsync(
		[Body] QuickSearchConfigurationRequest dataRequest,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get a Quick Search by Business Objects with view rights
	/// </summary>
	/// <remarks>
	/// Operation to get a Quick Search configuration that you can use to execute a Quick Search based the current user&#39;s Business Object view rights. The configuration  includes supplied Business Object IDs and specific search items with the following options. Use the Option Key to determine if you can change the options.&lt;/br&gt;&lt;/br&gt;ChangedOption&lt;/br&gt; NonFinalStateOption&lt;/br&gt; SearchAnyWordsOption&lt;/br&gt; SearchAttachmentsOption&lt;/br&gt; SearchRelatedOption&lt;/br&gt; SortByOption&lt;/br&gt; &lt;/br&gt;Option Key:&lt;/br&gt; 0 &#x3D; None (Not selected and cannot select.)&lt;/br&gt; 1 &#x3D; Use (Selected and cannot clear.)&lt;/br&gt; 2 &#x3D; Display (Not selected and can select.)&lt;/br&gt; 3 &#x3D; UseAndDisplay (Selected and can clear.)&lt;/br&gt;&lt;/br&gt; SearchTargetType:&lt;/br&gt; 0 &#x3D; BusOb (Business Object)&lt;/br&gt; 1 &#x3D; DocRepository (Document Repository)
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of QuickSearchConfigurationResponse</returns>
	[Get("/api/V1/getquicksearchconfigurationforbusobswithviewrights")]
	Task<QuickSearchConfigurationResponse> GetQuickSearchConfigurationForBusObsWithViewRightsAsync(
		CancellationToken cancellationToken);

	/// <summary>
	/// Execute a Quick Search from a list of Business Object IDs and search text
	/// </summary>
	/// <remarks>
	/// Operation to execute a Quick Search using a list of Business Object IDs and search text.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="dataRequest">Request object listing Business Object IDs and search text. Leave out the entire Business Object IDs parameter and all configured quick search Business Objects will be searched.</param>
	/// <param name="includeLinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
	/// <returns>Task of SimpleResultsList</returns>
	[Post("/api/V1/getquicksearchresults")]
	Task<SimpleResultsList> GetQuickSearchResultsAsync(
		[Body] QuickSearchRequest dataRequest,
		[AliasAs("includeLinks")] bool? includeLinks,
		CancellationToken cancellationToken);

	/// <summary>
	/// Execute a Quick Search on a specific Business Object
	/// </summary>
	/// <remarks>
	/// Operation to execute a Quick Search for a specific Business Object ID. Use \&quot;Get a Quick Search from a list of Business Object IDs\&quot; to find values for specific search item options, such as NonFinalStateOption.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="dataRequest">Request object containing the parameters for specific Business Object Quick Search execution.</param>
	/// <param name="includeSchema">Flag to include the schema for the results. (optional)</param>
	/// <param name="includeLocationFields">Flag to include location Fields in the results. (optional)</param>
	/// <param name="includeLinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
	/// <returns>Task of SearchResultsTableResponse</returns>
	[Post("/api/V1/getquicksearchspecificresults")]
	Task<SearchResultsTableResponse> GetQuickSearchSpecificResultsAsync(
		[Body] QuickSearchSpecificRequest dataRequest,
		[AliasAs("includeSchema")] bool? includeSchema,
		[AliasAs("includeLocationFields")] bool? includeLocationFields,
		[AliasAs("includeLinks")] bool? includeLinks,
		CancellationToken cancellationToken);

	/// <summary>
	/// Execute a Quick Search on a specific Business Object
	/// </summary>
	/// <remarks>
	/// Operation to execute a Quick Search for a specific Business Object ID. Use \&quot;Get a Quick Search from a list of Business Object IDs\&quot; to find values for specific search item options, such as NonFinalStateOption.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="dataRequest">Request object containing the parameters for specific Business Object Quick Search execution.</param>
	/// <param name="includeSchema">Flag to include the schema for the results. (optional)</param>
	/// <param name="includeLocationFields">Flag to include location Fields in the results. (optional)</param>
	/// <param name="includeLinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
	/// <returns>Task of QuickSearchResponse</returns>
	[Post("/api/V2/getquicksearchspecificresults")]
	Task<QuickSearchResponse> GetQuickSearchSpecificResultsV2Async(
		[Body] QuickSearchSpecificRequest dataRequest,
		[AliasAs("includeSchema")] bool? includeSchema,
		[AliasAs("includeLocationFields")] bool? includeLocationFields,
		[AliasAs("includeLinks")] bool? includeLinks,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get all saved searches by Folder ID
	/// </summary>
	/// <remarks>
	/// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="association">Use to filter results by Business Object association ID.</param>
	/// <param name="scope">Use to filter results by scope name or ID.</param>
	/// <param name="scopeowner">Use to filter results by scope owner ID.</param>
	/// <param name="folder">Use to filter results by Search Group folder ID.</param>
	/// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
	/// <returns>Task of SearchItemResponse</returns>
	[Get("/api/V1/getsearchitems/association/{association}/scope/{scope}/scopeowner/{scopeowner}/folder/{folder}")]
	Task<SearchItemResponse> GetSearchItemsByAssociationScopeScopeOwnerFolderAsync(
		[AliasAs("association")] string association,
		[AliasAs("scope")] string scope,
		[AliasAs("scopeowner")] string scopeowner,
		[AliasAs("folder")] string folder,
		[AliasAs("links")] bool? links,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get all saved searches by Folder ID
	/// </summary>
	/// <remarks>
	/// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="association">Use to filter results by Business Object association ID.</param>
	/// <param name="scope">Use to filter results by scope name or ID.</param>
	/// <param name="scopeowner">Use to filter results by scope owner ID.</param>
	/// <param name="folder">Use to filter results by Search Group folder ID.</param>
	/// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
	/// <returns>Task of CoreManagerData</returns>
	[Get("/api/V2/getsearchitems/association/{association}/scope/{scope}/scopeowner/{scopeowner}/folder/{folder}")]
	Task<ManagerData> GetSearchItemsByAssociationScopeScopeOwnerFolderV2Async(
		[AliasAs("association")] string association,
		[AliasAs("scope")] string scope,
		[AliasAs("scopeowner")] string scopeowner,
		[AliasAs("folder")] string folder,
		[AliasAs("links")] bool? links,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get all saved searches by scope owner (sub scope)
	/// </summary>
	/// <remarks>
	/// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="association">Use to filter results by Business Object association ID.</param>
	/// <param name="scope">Use to filter results by scope name or ID.</param>
	/// <param name="scopeowner">Use to filter results by scope owner ID.</param>
	/// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
	/// <returns>Task of SearchItemResponse</returns>
	[Get("/api/V1/getsearchitems/association/{association}/scope/{scope}/scopeowner/{scopeowner}")]
	Task<SearchItemResponse> GetSearchItemsByAssociationScopeScopeOwnerAsync(
		[AliasAs("association")] string association,
		[AliasAs("scope")] string scope,
		[AliasAs("scopeowner")] string scopeowner,
		[AliasAs("links")] bool? links,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get all saved searches by scope owner (sub scope)
	/// </summary>
	/// <remarks>
	/// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="association">Use to filter results by Business Object association ID.</param>
	/// <param name="scope">Use to filter results by scope name or ID.</param>
	/// <param name="scopeowner">Use to filter results by scope owner ID.</param>
	/// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
	/// <returns>Task of CoreManagerData</returns>
	[Get("/api/V2/getsearchitems/association/{association}/scope/{scope}/scopeowner/{scopeowner}")]
	Task<ManagerData> GetSearchItemsByAssociationScopeScopeOwnerV2Async(
		[AliasAs("association")] string association,
		[AliasAs("scope")] string scope,
		[AliasAs("scopeowner")] string scopeowner,
		[AliasAs("links")] bool? links,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get all saved searches by scope
	/// </summary>
	/// <remarks>
	/// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="association">Use to filter results by Business Object association ID.</param>
	/// <param name="scope">Use to filter results by scope name or ID.</param>
	/// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
	/// <returns>Task of SearchItemResponse</returns>
	[Get("/api/V1/getsearchitems/association/{association}/scope/{scope}")]
	Task<SearchItemResponse> GetSearchItemsByAssociationScopeAsync(
		[AliasAs("association")] string association,
		[AliasAs("scope")] string scope,
		[AliasAs("links")] bool? links,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get all saved searches by scope
	/// </summary>
	/// <remarks>
	/// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="association">Use to filter results by Business Object association ID.</param>
	/// <param name="scope">Use to filter results by scope name or ID.</param>
	/// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
	/// <returns>Task of CoreManagerData</returns>
	[Get("/api/V2/getsearchitems/association/{association}/scope/{scope}")]
	Task<ManagerData> GetSearchItemsByAssociationScopeV2Async(
		[AliasAs("association")] string association,
		[AliasAs("scope")] string scope,
		[AliasAs("links")] bool? links,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get all saved searches by Business Object association
	/// </summary>
	/// <remarks>
	/// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="association">Use to filter results by Business Object association ID.</param>
	/// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
	/// <returns>Task of SearchItemResponse</returns>
	[Get("/api/V1/getsearchitems/association/{association}")]
	Task<SearchItemResponse> GetSearchItemsByAssociationAsync(
		[AliasAs("association")] string association,
		[AliasAs("links")] bool? links,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get all saved searches by Business Object association
	/// </summary>
	/// <remarks>
	/// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="association">Use to filter results by Business Object association ID.</param>
	/// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
	/// <returns>Task of CoreManagerData</returns>
	[Get("/api/V2/getsearchitems/association/{association}")]
	Task<ManagerData> GetSearchItemsByAssociationV2Async(
		[AliasAs("association")] string association,
		[AliasAs("links")] bool? links,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get all saved searches by default Business Object association
	/// </summary>
	/// <remarks>
	/// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
	/// <returns>Task of SearchItemResponse</returns>
	[Get("/api/V1/getsearchitems")]
	Task<SearchItemResponse> GetSearchItemsAsync(
		[AliasAs("links")] bool? links,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get all saved searches by default Business Object association
	/// </summary>
	/// <remarks>
	/// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
	/// <returns>Task of CoreManagerData</returns>
	[Get("/api/V2/getsearchitems")]
	Task<ManagerData> GetSearchItemsV2Async(
		[AliasAs("links")] bool? links,
		CancellationToken cancellationToken);

	/// <summary>
	/// Run an ad-hoc search
	/// </summary>
	/// <remarks>
	/// Operation that runs an ad-hoc Business Object search. To execute a search with Prompts, the PromptId and Value are required in the Prompt request object.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="dataRequest">Request object to specify search parameters.</param>
	/// <returns>Task of SearchResultsResponse</returns>
	[Post("/api/V1/getsearchresults")]
	Task<SearchResultsResponse> GetSearchResultsAdHocAsync(
		[Body] SearchResultsRequest dataRequest,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get results of a saved search
	/// </summary>
	/// <remarks>
	/// Operation that returns the results of a saved search in JSON format.&lt;/br&gt; This API is protected by a rate limiter and will reject any requests sent from an IP Address when a certain threshold of active concurrent requests has been hit.&lt;/br&gt; This value can be configured by the Max Concurrent Requests configuration value in the Web API config.&lt;/br&gt; Once this limit has been reached, all subsequent requests will receive a status code of 429 (Too Many Requests).&lt;/br&gt; This version is not subject to row limits and will return the entire result set of the stored search. 
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="searchRequest">Request object to specify search parameters.</param>
	/// <returns>Task of StoredSearchResults</returns>
	[Post("/api/V2/storedsearches")]
	Task<StoredSearchResults> GetSearchResultsAsStringByIdV2Async(
		[Body] StoredSearchRequest searchRequest,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get results of a saved search
	/// </summary>
	/// <remarks>
	/// Operation that returns the results of a saved search in JSON format.&lt;/br&gt;    This API is protected by a rate limiter and will reject any requests sent from an IP Address when a certain threshold of active concurrent requests has been hit.&lt;/br&gt;    This value can be configured by the Max Concurrent Requests configuration value in the Web API config.&lt;/br&gt;    Once this limit has been reached, all subsequent requests will receive a status code of 429 (Too Many Requests).  
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="scope">Specify the scope name for the saved search.</param>
	/// <param name="associationName">Specify the Business Object association Name for the saved search.</param>
	/// <param name="searchName">Specify the name of the saved search.</param>
	/// <param name="scopeOwner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists. (optional)</param>
	/// <returns>Task of List&lt;Dictionary&lt;string, string&gt;&gt;</returns>
	[Get("/api/V1/storedsearches/{scope}/{associationName}/{searchName}")]
	Task<List<Dictionary<string, string>>> GetSearchResultsAsStringByNameAsync(
		[AliasAs("scope")] string scope,
		[AliasAs("associationName")] string associationName,
		[AliasAs("searchName")] string searchName,
		[AliasAs("scopeOwner")] string scopeOwner,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get results of a saved search
	/// </summary>
	/// <remarks>
	/// Operation that returns the results of a saved search in JSON format.&lt;/br&gt; This API is protected by a rate limiter and will reject any requests sent from an IP Address when a certain threshold of active concurrent requests has been hit.&lt;/br&gt; This value can be configured by the Max Concurrent Requests configuration value in the Web API config.&lt;/br&gt; Once this limit has been reached, all subsequent requests will receive a status code of 429 (Too Many Requests).&lt;/br&gt; This version is not subject to row limits and will return the entire result set of the stored search. 
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="scope">Specify the scope name for the saved search.</param>
	/// <param name="associationName">Specify the Business Object association Name for the saved search.</param>
	/// <param name="searchName">Specify the name of the saved search.</param>
	/// <param name="scopeOwner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists. (optional)</param>
	/// <returns>Task of List&lt;Dictionary&lt;string, string&gt;&gt;</returns>
	[Get("/api/V2/storedsearches/{scope}/{associationName}/{searchName}")]
	Task<List<Dictionary<string, string>>> GetSearchResultsAsStringByNameV2Async(
		[AliasAs("scope")] string scope,
		[AliasAs("associationName")] string associationName,
		[AliasAs("searchName")] string searchName,
		[AliasAs("scopeOwner")] string scopeOwner,
		CancellationToken cancellationToken);

	/// <summary>
	/// Run a saved search by internal ID
	/// </summary>
	/// <remarks>
	/// Operation that returns the paged results of a saved search. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresults ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="association">Specify the Business Object association ID for the saved search.</param>
	/// <param name="scope">Specify the scope name or ID for the saved search.</param>
	/// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
	/// <param name="searchid">Specify the internal ID for the saved search. Use \&quot;Run a saved search by name\&quot; if you do not have the internal ID.</param>
	/// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
	/// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
	/// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
	/// <param name="includeschema">Use to include the table schema of the saved search. If false, results contain the fieldid and field value without field information. Default is false. (optional)</param>
	/// <param name="resultsAsSimpleResultsList">Indicates if the results should be returned in a simple results list format or a table format. Default is a table format. (optional)</param>
	/// <returns>Task of SearchResultsResponse</returns>
	[Get("/api/V1/getsearchresults/association/{association}/scope/{scope}/scopeowner/{scopeowner}/searchid/{searchid}")]
	Task<SearchResultsResponse> GetSearchResultsByIdAsync(
		[AliasAs("association")] string association,
		[AliasAs("scope")] string scope,
		[AliasAs("scopeowner")] string scopeowner,
		[AliasAs("searchid")] string searchid,
		[AliasAs("searchTerm")] string searchTerm,
		[AliasAs("pagenumber")] int? pagenumber,
		[AliasAs("pagesize")] int? pagesize,
		[AliasAs("includeschema")] bool? includeschema,
		[AliasAs("resultsAsSimpleResultsList")] bool? resultsAsSimpleResultsList,
		CancellationToken cancellationToken);

	/// <summary>
	/// Run a saved search by name
	/// </summary>
	/// <remarks>
	/// Operation that returns the paged results of a saved search. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresults ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="association">Specify the Business Object association ID for the saved search.</param>
	/// <param name="scope">Specify the scope name or ID for the saved search.</param>
	/// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
	/// <param name="searchname">Specify the name of the saved search.</param>
	/// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
	/// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
	/// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
	/// <param name="includeschema">Use to include the table schema of the saved search. If false, results contain the fieldid and field value without field information. Default is false. (optional)</param>
	/// <param name="resultsAsSimpleResultsList">Indicates if the results should be returned in a simple results list format or a table format. Default is a table format. (optional)</param>
	/// <returns>Task of SearchResultsResponse</returns>
	[Get("/api/V1/getsearchresults/association/{association}/scope/{scope}/scopeowner/{scopeowner}/searchname/{searchname}")]
	Task<SearchResultsResponse> GetSearchResultsByNameAsync(
		[AliasAs("association")] string association,
		[AliasAs("scope")] string scope,
		[AliasAs("scopeowner")] string scopeowner,
		[AliasAs("searchname")] string searchname,
		[AliasAs("searchTerm")] string searchTerm,
		[AliasAs("pagenumber")] int? pagenumber,
		[AliasAs("pagesize")] int? pagesize,
		[AliasAs("includeschema")] bool? includeschema,
		[AliasAs("resultsAsSimpleResultsList")] bool? resultsAsSimpleResultsList,
		CancellationToken cancellationToken);

	/// <summary>
	/// Export an ad-hoc search
	/// </summary>
	/// <remarks>
	/// Operation that returns an ad-hoc search in a specified export format: 0&#x3D;CSV, 1&#x3D;Excel, 2&#x3D;Tab, 3&#x3D;Word, 4&#x3D;Custom Separator, 5&#x3D;Simple JSON. To execute a search with Prompts, the PromptId and Value are required in the Prompt request object.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="dataRequest">Request object to specify search parameters and export format.</param>
	/// <returns>Task of string</returns>
	[Post("/api/V1/getsearchresultsexport")]
	Task<string> GetSearchResultsExportAdHocAsync(
		[Body] ExportSearchResultsRequest dataRequest,
		CancellationToken cancellationToken);

	/// <summary>
	/// Export a saved search by ID
	/// </summary>
	/// <remarks>
	/// Operation that returns the paged results of a saved search in a specified format. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresultsexport ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="association">Specify the Business Object association ID for the saved search.</param>
	/// <param name="scope">Specify the scope name or ID for the saved search.</param>
	/// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
	/// <param name="searchid">Specify the internal ID for the saved search. Use \&quot;Run a saved search by name\&quot; if you do not have the internal ID.</param>
	/// <param name="exportformat">Specify the format of the export</param>
	/// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
	/// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
	/// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
	/// <returns>Task of string</returns>
	[Get("/api/V1/getsearchresultsexport/association/{association}/scope/{scope}/scopeowner/{scopeowner}/searchid/{searchid}/exportformat/{exportformat}")]
	Task<string> GetSearchResultsExportByIdAsync(
		[AliasAs("association")] string association,
		[AliasAs("scope")] string scope,
		[AliasAs("scopeowner")] string scopeowner,
		[AliasAs("searchid")] string searchid,
		[AliasAs("exportformat")] string exportformat,
		[AliasAs("searchTerm")] string searchTerm,
		[AliasAs("pagenumber")] int? pagenumber,
		[AliasAs("pagesize")] int? pagesize,
		CancellationToken cancellationToken);

	/// <summary>
	/// Export a saved search by name
	/// </summary>
	/// <remarks>
	/// Operation that returns the paged results of a saved search in a specified format. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresultsexport ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="association">Specify the Business Object association ID for the saved search.</param>
	/// <param name="scope">Specify the scope name or ID for the saved search.</param>
	/// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
	/// <param name="searchname">Specify the name of the saved search.</param>
	/// <param name="exportformat">Specify the format of the export</param>
	/// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
	/// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
	/// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
	/// <returns>Task of string</returns>
	[Get("/api/V1/getsearchresultsexport/association/{association}/scope/{scope}/scopeowner/{scopeowner}/searchname/{searchname}/exportformat/{exportformat}")]
	Task<string> GetSearchResultsExportByNameAsync(
		[AliasAs("association")] string association,
		[AliasAs("scope")] string scope,
		[AliasAs("scopeowner")] string scopeowner,
		[AliasAs("searchname")] string searchname,
		[AliasAs("exportformat")] string exportformat,
		[AliasAs("searchTerm")] string searchTerm,
		[AliasAs("pagenumber")] int? pagenumber,
		[AliasAs("pagesize")] int? pagesize,
		CancellationToken cancellationToken);
}
