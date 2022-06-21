using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Refit;
using Cherwell.Client;
using Cherwell.Model;

namespace Cherwell.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICoreApi
    {
        #region Asynchronous Operations

        /// <summary>
        /// Delete a gallery image
        /// </summary>
        /// <remarks>
        /// Endpoint to delete a gallery image.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="standinkey">The StandIn key for the gallery image to delete.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of void</returns>
        [Delete("/api/V1/deletegalleryimage/standinkey/{standinkey}")]
        Task CoreDeleteGalleryImageByStandInKeyV1([Header("UserAgent")] string userAgent, [AliasAs("standinkey")]string standinkey, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get built-in images
        /// </summary>
        /// <remarks>
        /// Operation that gets built-in images. If you are requesting an icon (.ico), you can specify width and height.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Image name and folder location in the Image Manager. Parameter must begin with \&quot;[PlugIn]Images;\&quot; and then a period-separated list of folders. Example: \&quot;[PlugIn]Images;Images.Common.Cherwell.ico\&quot;.</param>
        /// <param name="width">Specify the width (icons only). (optional)</param>
        /// <param name="height">Specify the height (icons only). (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of string</returns>
        [Get("/api/V1/getgalleryimage/name/{name}")]
        Task<string> CoreGetGalleryImageV1([Header("UserAgent")] string userAgent, [AliasAs("name")]string name, [AliasAs("width")]int? width = null, [AliasAs("height")]int? height = null, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get gallery images by scope, scopeowner, and folder
        /// </summary>
        /// <remarks>
        /// Get gallery images for the specified scope, scopeowner, and folder.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get gallery images for.</param>
        /// <param name="scopeowner">the scopeowner to get gallery images for.</param>
        /// <param name="folder">The folder to get gallery images for.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of CoreManagerData</returns>
        [Get("/api/V1/getgalleryimages/scope/{scope}/scopeowner/{scopeowner}/folder/{folder}")]
        Task<CoreManagerData> CoreGetGalleryImagesFolderV1([Header("UserAgent")] string userAgent, [AliasAs("scope")]string scope, [AliasAs("scopeowner")]string scopeowner, [AliasAs("folder")]string folder, [AliasAs("links")]bool? links = null, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get gallery images by scope and scopeowner
        /// </summary>
        /// <remarks>
        /// Get all gallery images for the specified scope and scope owner.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get gallery images for.</param>
        /// <param name="scopeowner">The scopeowner to get gallery images for.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of CoreManagerData</returns>
        [Get("/api/V1/getgalleryimages/scope/{scope}/scopeowner/{scopeowner}")]
        Task<CoreManagerData> CoreGetGalleryImagesScopeOwnerV1([Header("UserAgent")] string userAgent, [AliasAs("scope")]string scope, [AliasAs("scopeowner")]string scopeowner, [AliasAs("links")]bool? links = null, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get gallery images by scope
        /// </summary>
        /// <remarks>
        /// Get all gallery images for the specified scope.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get the images for.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of CoreManagerData</returns>
        [Get("/api/V1/getgalleryimages/scope/{scope}")]
        Task<CoreManagerData> CoreGetGalleryImagesScopeV1([Header("UserAgent")] string userAgent, [AliasAs("scope")]string scope, [AliasAs("links")]bool? links = null, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get all gallery images
        /// </summary>
        /// <remarks>
        /// Get all the gallery images in the system.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of CoreManagerData</returns>
        [Get("/api/V1/getgalleryimages")]
        Task<CoreManagerData> CoreGetGalleryImagesV1([Header("UserAgent")] string userAgent, [AliasAs("links")]bool? links = null, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get a  stored value
        /// </summary>
        /// <remarks>
        /// Get a stored value by its StandIn key.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="standInKey">The StandIn key for the Stored Value you would like to retrieve.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of CoreStoredValueResponse</returns>
        [Get("/api/V1/getstoredvalue/standinkey/{standInKey}")]
        Task<CoreStoredValueResponse> CoreGetStoredValueV1([Header("UserAgent")] string userAgent, [AliasAs("standInKey")]string standInKey, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get stored values by folder
        /// </summary>
        /// <remarks>
        /// Get stored values for the specified folder.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope for which to get stored values.</param>
        /// <param name="scopeowner">The scope owner for which to get stored values.</param>
        /// <param name="folder">The folder for which to get stored values.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of CoreManagerData</returns>
        [Get("/api/V1/storedvalues/scope/{scope}/scopeowner/{scopeowner}/folder/{folder}")]
        Task<CoreManagerData> CoreGetStoredValuesFolderV1([Header("UserAgent")] string userAgent, [AliasAs("scope")]string scope, [AliasAs("scopeowner")]string scopeowner, [AliasAs("folder")]string folder, [AliasAs("links")]bool? links = null, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get stored values by scope owner
        /// </summary>
        /// <remarks>
        /// Get stored values for the specified scope and scope owner.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope for which to get stored values.</param>
        /// <param name="scopeowner">The scope owner for which to get stored values.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of CoreManagerData</returns>
        [Get("/api/V1/storedvalues/scope/{scope}/scopeowner/{scopeowner}")]
        Task<CoreManagerData> CoreGetStoredValuesScopeOwnerV1([Header("UserAgent")] string userAgent, [AliasAs("scope")]string scope, [AliasAs("scopeowner")]string scopeowner, [AliasAs("links")]bool? links = null, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get stored values by scope
        /// </summary>
        /// <remarks>
        /// Get all the stored values for the specified scope.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope for which to get stored values.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of CoreManagerData</returns>
        [Get("/api/V1/storedvalues/scope/{scope}")]
        Task<CoreManagerData> CoreGetStoredValuesScopeV1([Header("UserAgent")] string userAgent, [AliasAs("scope")]string scope, [AliasAs("links")]bool? links = null, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Gets all the stored values in the system
        /// </summary>
        /// <remarks>
        /// Get all the stored values in the system.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of CoreManagerData</returns>
        [Get("/api/V1/storedvalues")]
        Task<CoreManagerData> CoreGetStoredValuesV1([Header("UserAgent")] string userAgent, [AliasAs("links")]bool? links = null, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get a list of the views
        /// </summary>
        /// <remarks>
        /// Operation to get a list of views that are configured in the system.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of CoreViewsResponse</returns>
        [Get("/api/V1/getviews")]
        Task<CoreViewsResponse> CoreGetViewsV1([Header("UserAgent")] string userAgent, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Create or update a gallery image
        /// </summary>
        /// <remarks>
        /// Endpoint to Create or update a gallery image. To create a new gallery image leave the StandIn key blank. To update a gallery image provide the StandIn key of the gallery image you want to update. There are three different ImageTypes allowed: Imported, Url, and File. To use the Imported image type, provide the filename in the Name property, with extension, and provide the image data in a Base64 encoded format in the Base64EncodedImageData property. The max file size is 512k. To use the Url image type,  provide the full network share path to the file in the Name property, ie: \&quot;\\\\\\\\\\\\\\\\networkshare\\\\\\somefolder\\\\\\somefile.jpg\&quot;. If the file is not accessible to all users it will not visible to all users. To use the File image type, provide the full path to the file in the Name property, ie: \&quot;C:\\\\\\somefolder\\\\\\somfile.jpg\&quot;. If the file is not accessible to all users it will not visible to all users. When creating or updating an image, Name and ImageType are always required, and if the image type is \&quot;Imported\&quot;, then the Base64EncodedImageData is also required.  scope, scopeowner, and folder can all be updated independently.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">To create a new gallery image leave the StandIn key blank. To update a gallery image provide the StandIn key of the gallery image you want to update. There are three different ImageTypes allowed: Imported, Url, and File. To use the Imported image type, provide the filename in the Name property, with extension, and provide the image data in a Base64 encoded format in the Base64EncodedImageData property. The max file size is 512k. To use the Url image type,  provide the full network share path to the file in the Name property, ie: \&quot;\\\\\\\\\\\\\\\\networkshare\\\\\\somefolder\\\\\\somefile.jpg\&quot;. If the file is not accessible to all users it will not visible to all users. To use the File image type, provide the full path to the file in the Name property, ie: \&quot;C:\\\\\\somefolder\\\\\\somfile.jpg\&quot;. If the file is not accessible to all users it will not visible to all users. When creating or updating an image, Name and ImageType are always required, and if the image type is \&quot;Imported\&quot;, then the Base64EncodedImageData is also required.  scope, scopeowner, and folder can all be updated independently.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of CoreSaveGalleryImageResponse</returns>
        [Post("/api/V1/savegalleryimage")]
        Task<CoreSaveGalleryImageResponse> CoreSaveGalleryImageV1([Header("UserAgent")] string userAgent, [Body]CoreSaveGalleryImageRequest request, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Create or update a stored value
        /// </summary>
        /// <remarks>
        /// Operation to create or update a stored value. To update, specify the StandIn key for the stored value to update. To create leave StandIn key blank, and provide a name, a scope, a type, and a value.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The stored value to create or update. To update include the StandIn key for the associated stored value. To create, name, scope, type, and value are required.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of CoreStoredValueResponse</returns>
        [Post("/api/V1/savestoredvalue")]
        Task<CoreStoredValueResponse> CoreSaveStoredValueV1([Header("UserAgent")] string userAgent, [Body]CoreSaveStoredValueRequest request, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Set the culture for the current user
        /// </summary>
        /// <remarks>
        /// Operation to update the current users culture by culture code. This returns a new access token that has the updated information in it.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="culturecode">The culture code to set for the current user.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of string</returns>
        [Put("/api/V1/setculture/culturecode/{culturecode}")]
        Task<string> CoreSetCultureV1([Header("UserAgent")] string userAgent, [AliasAs("culturecode")]string culturecode, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);
        #endregion Asynchronous Operations
    }
}
