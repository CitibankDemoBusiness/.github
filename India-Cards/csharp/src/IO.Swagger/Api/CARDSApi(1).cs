/* 
 * Cards
 *
 * The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface ICARDSApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// This API will be triggered by partner(VISA) to notify the cardholder about authorisation transaction.
        /// </summary>
        /// <remarks>
        /// This API will be triggered by partner(VISA) to notify the cardholder about authorisation transaction.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest</param>
        /// <param name="authorization">HTTP Basic authentication by passing base64 encoded value of the client id and client secret separated by colon (:).Example: Base64(client_id:client_secret) will be passed as Basic KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;</param>
        /// <param name="uuid">128 bit random UUID generated uniquely for every request.</param>
        /// <param name="accept">Content-Type that are acceptable for the response.</param>
        /// <param name="contentType">application/json</param>
        /// <param name="clientId">Client ID generated during application registration. (optional)</param>
        /// <param name="clientDetails">This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)</param>
        /// <param name="acceptLanguage">List of acceptable human languages for response. (optional)</param>
        /// <param name="xJwsSignature">This field is signature generated when partner sign API payload.This signature will be used to validate that the call is coming from a valid partner. This signature is a JWT token, which will be validated with partner’s JWK stored in DB (optional)</param>
        /// <returns></returns>
        void NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction (NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest body, string authorization, string uuid, string accept, string contentType, string clientId = null, string clientDetails = null, string acceptLanguage = null, string xJwsSignature = null);

        /// <summary>
        /// This API will be triggered by partner(VISA) to notify the cardholder about authorisation transaction.
        /// </summary>
        /// <remarks>
        /// This API will be triggered by partner(VISA) to notify the cardholder about authorisation transaction.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest</param>
        /// <param name="authorization">HTTP Basic authentication by passing base64 encoded value of the client id and client secret separated by colon (:).Example: Base64(client_id:client_secret) will be passed as Basic KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;</param>
        /// <param name="uuid">128 bit random UUID generated uniquely for every request.</param>
        /// <param name="accept">Content-Type that are acceptable for the response.</param>
        /// <param name="contentType">application/json</param>
        /// <param name="clientId">Client ID generated during application registration. (optional)</param>
        /// <param name="clientDetails">This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)</param>
        /// <param name="acceptLanguage">List of acceptable human languages for response. (optional)</param>
        /// <param name="xJwsSignature">This field is signature generated when partner sign API payload.This signature will be used to validate that the call is coming from a valid partner. This signature is a JWT token, which will be validated with partner’s JWK stored in DB (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionWithHttpInfo (NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest body, string authorization, string uuid, string accept, string contentType, string clientId = null, string clientDetails = null, string acceptLanguage = null, string xJwsSignature = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// This API will be triggered by partner(VISA) to notify the cardholder about authorisation transaction.
        /// </summary>
        /// <remarks>
        /// This API will be triggered by partner(VISA) to notify the cardholder about authorisation transaction.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest</param>
        /// <param name="authorization">HTTP Basic authentication by passing base64 encoded value of the client id and client secret separated by colon (:).Example: Base64(client_id:client_secret) will be passed as Basic KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;</param>
        /// <param name="uuid">128 bit random UUID generated uniquely for every request.</param>
        /// <param name="accept">Content-Type that are acceptable for the response.</param>
        /// <param name="contentType">application/json</param>
        /// <param name="clientId">Client ID generated during application registration. (optional)</param>
        /// <param name="clientDetails">This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)</param>
        /// <param name="acceptLanguage">List of acceptable human languages for response. (optional)</param>
        /// <param name="xJwsSignature">This field is signature generated when partner sign API payload.This signature will be used to validate that the call is coming from a valid partner. This signature is a JWT token, which will be validated with partner’s JWK stored in DB (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionAsync (NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest body, string authorization, string uuid, string accept, string contentType, string clientId = null, string clientDetails = null, string acceptLanguage = null, string xJwsSignature = null);

        /// <summary>
        /// This API will be triggered by partner(VISA) to notify the cardholder about authorisation transaction.
        /// </summary>
        /// <remarks>
        /// This API will be triggered by partner(VISA) to notify the cardholder about authorisation transaction.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest</param>
        /// <param name="authorization">HTTP Basic authentication by passing base64 encoded value of the client id and client secret separated by colon (:).Example: Base64(client_id:client_secret) will be passed as Basic KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;</param>
        /// <param name="uuid">128 bit random UUID generated uniquely for every request.</param>
        /// <param name="accept">Content-Type that are acceptable for the response.</param>
        /// <param name="contentType">application/json</param>
        /// <param name="clientId">Client ID generated during application registration. (optional)</param>
        /// <param name="clientDetails">This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)</param>
        /// <param name="acceptLanguage">List of acceptable human languages for response. (optional)</param>
        /// <param name="xJwsSignature">This field is signature generated when partner sign API payload.This signature will be used to validate that the call is coming from a valid partner. This signature is a JWT token, which will be validated with partner’s JWK stored in DB (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionAsyncWithHttpInfo (NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest body, string authorization, string uuid, string accept, string contentType, string clientId = null, string clientDetails = null, string acceptLanguage = null, string xJwsSignature = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class CARDSApi : ICARDSApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CARDSApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CARDSApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CARDSApi"/> class
        /// </summary>
        /// <returns></returns>
        public CARDSApi()
        {
            this.Configuration = IO.Swagger.Client.Configuration.Default;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CARDSApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CARDSApi(IO.Swagger.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Swagger.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IO.Swagger.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// This API will be triggered by partner(VISA) to notify the cardholder about authorisation transaction. This API will be triggered by partner(VISA) to notify the cardholder about authorisation transaction.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest</param>
        /// <param name="authorization">HTTP Basic authentication by passing base64 encoded value of the client id and client secret separated by colon (:).Example: Base64(client_id:client_secret) will be passed as Basic KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;</param>
        /// <param name="uuid">128 bit random UUID generated uniquely for every request.</param>
        /// <param name="accept">Content-Type that are acceptable for the response.</param>
        /// <param name="contentType">application/json</param>
        /// <param name="clientId">Client ID generated during application registration. (optional)</param>
        /// <param name="clientDetails">This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)</param>
        /// <param name="acceptLanguage">List of acceptable human languages for response. (optional)</param>
        /// <param name="xJwsSignature">This field is signature generated when partner sign API payload.This signature will be used to validate that the call is coming from a valid partner. This signature is a JWT token, which will be validated with partner’s JWK stored in DB (optional)</param>
        /// <returns></returns>
        public void NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction (NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest body, string authorization, string uuid, string accept, string contentType, string clientId = null, string clientDetails = null, string acceptLanguage = null, string xJwsSignature = null)
        {
             NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionWithHttpInfo(body, authorization, uuid, accept, contentType, clientId, clientDetails, acceptLanguage, xJwsSignature);
        }

        /// <summary>
        /// This API will be triggered by partner(VISA) to notify the cardholder about authorisation transaction. This API will be triggered by partner(VISA) to notify the cardholder about authorisation transaction.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest</param>
        /// <param name="authorization">HTTP Basic authentication by passing base64 encoded value of the client id and client secret separated by colon (:).Example: Base64(client_id:client_secret) will be passed as Basic KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;</param>
        /// <param name="uuid">128 bit random UUID generated uniquely for every request.</param>
        /// <param name="accept">Content-Type that are acceptable for the response.</param>
        /// <param name="contentType">application/json</param>
        /// <param name="clientId">Client ID generated during application registration. (optional)</param>
        /// <param name="clientDetails">This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)</param>
        /// <param name="acceptLanguage">List of acceptable human languages for response. (optional)</param>
        /// <param name="xJwsSignature">This field is signature generated when partner sign API payload.This signature will be used to validate that the call is coming from a valid partner. This signature is a JWT token, which will be validated with partner’s JWK stored in DB (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionWithHttpInfo (NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest body, string authorization, string uuid, string accept, string contentType, string clientId = null, string clientDetails = null, string acceptLanguage = null, string xJwsSignature = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CARDSApi->NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction");
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling CARDSApi->NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction");
            // verify the required parameter 'uuid' is set
            if (uuid == null)
                throw new ApiException(400, "Missing required parameter 'uuid' when calling CARDSApi->NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling CARDSApi->NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling CARDSApi->NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction");

            var localVarPath = "/partner/v1/creditChargeCard/transaction/authorised/notify";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (authorization != null) localVarHeaderParams.Add("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            if (uuid != null) localVarHeaderParams.Add("uuid", this.Configuration.ApiClient.ParameterToString(uuid)); // header parameter
            if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter
            if (clientId != null) localVarHeaderParams.Add("client_id", this.Configuration.ApiClient.ParameterToString(clientId)); // header parameter
            if (contentType != null) localVarHeaderParams.Add("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            if (clientDetails != null) localVarHeaderParams.Add("clientDetails", this.Configuration.ApiClient.ParameterToString(clientDetails)); // header parameter
            if (acceptLanguage != null) localVarHeaderParams.Add("Accept-Language", this.Configuration.ApiClient.ParameterToString(acceptLanguage)); // header parameter
            if (xJwsSignature != null) localVarHeaderParams.Add("x-jws-signature", this.Configuration.ApiClient.ParameterToString(xJwsSignature)); // header parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// This API will be triggered by partner(VISA) to notify the cardholder about authorisation transaction. This API will be triggered by partner(VISA) to notify the cardholder about authorisation transaction.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest</param>
        /// <param name="authorization">HTTP Basic authentication by passing base64 encoded value of the client id and client secret separated by colon (:).Example: Base64(client_id:client_secret) will be passed as Basic KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;</param>
        /// <param name="uuid">128 bit random UUID generated uniquely for every request.</param>
        /// <param name="accept">Content-Type that are acceptable for the response.</param>
        /// <param name="contentType">application/json</param>
        /// <param name="clientId">Client ID generated during application registration. (optional)</param>
        /// <param name="clientDetails">This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)</param>
        /// <param name="acceptLanguage">List of acceptable human languages for response. (optional)</param>
        /// <param name="xJwsSignature">This field is signature generated when partner sign API payload.This signature will be used to validate that the call is coming from a valid partner. This signature is a JWT token, which will be validated with partner’s JWK stored in DB (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionAsync (NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest body, string authorization, string uuid, string accept, string contentType, string clientId = null, string clientDetails = null, string acceptLanguage = null, string xJwsSignature = null)
        {
             await NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionAsyncWithHttpInfo(body, authorization, uuid, accept, contentType, clientId, clientDetails, acceptLanguage, xJwsSignature);

        }

        /// <summary>
        /// This API will be triggered by partner(VISA) to notify the cardholder about authorisation transaction. This API will be triggered by partner(VISA) to notify the cardholder about authorisation transaction.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest</param>
        /// <param name="authorization">HTTP Basic authentication by passing base64 encoded value of the client id and client secret separated by colon (:).Example: Base64(client_id:client_secret) will be passed as Basic KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;</param>
        /// <param name="uuid">128 bit random UUID generated uniquely for every request.</param>
        /// <param name="accept">Content-Type that are acceptable for the response.</param>
        /// <param name="contentType">application/json</param>
        /// <param name="clientId">Client ID generated during application registration. (optional)</param>
        /// <param name="clientDetails">This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)</param>
        /// <param name="acceptLanguage">List of acceptable human languages for response. (optional)</param>
        /// <param name="xJwsSignature">This field is signature generated when partner sign API payload.This signature will be used to validate that the call is coming from a valid partner. This signature is a JWT token, which will be validated with partner’s JWK stored in DB (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionAsyncWithHttpInfo (NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest body, string authorization, string uuid, string accept, string contentType, string clientId = null, string clientDetails = null, string acceptLanguage = null, string xJwsSignature = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CARDSApi->NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction");
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling CARDSApi->NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction");
            // verify the required parameter 'uuid' is set
            if (uuid == null)
                throw new ApiException(400, "Missing required parameter 'uuid' when calling CARDSApi->NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling CARDSApi->NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling CARDSApi->NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction");

            var localVarPath = "/partner/v1/creditChargeCard/transaction/authorised/notify";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (authorization != null) localVarHeaderParams.Add("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            if (uuid != null) localVarHeaderParams.Add("uuid", this.Configuration.ApiClient.ParameterToString(uuid)); // header parameter
            if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter
            if (clientId != null) localVarHeaderParams.Add("client_id", this.Configuration.ApiClient.ParameterToString(clientId)); // header parameter
            if (contentType != null) localVarHeaderParams.Add("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            if (clientDetails != null) localVarHeaderParams.Add("clientDetails", this.Configuration.ApiClient.ParameterToString(clientDetails)); // header parameter
            if (acceptLanguage != null) localVarHeaderParams.Add("Accept-Language", this.Configuration.ApiClient.ParameterToString(acceptLanguage)); // header parameter
            if (xJwsSignature != null) localVarHeaderParams.Add("x-jws-signature", this.Configuration.ApiClient.ParameterToString(xJwsSignature)); // header parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

    }
}