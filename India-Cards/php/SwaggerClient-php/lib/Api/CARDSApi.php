<?php
/**
 * CARDSApi
 * PHP version 5
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
 * Cards
 *
 * The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 * Swagger Codegen version: 3.0.29
 */
/**
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen
 * Do not edit the class manually.
 */

namespace Swagger\Client\Api;

use GuzzleHttp\Client;
use GuzzleHttp\ClientInterface;
use GuzzleHttp\Exception\RequestException;
use GuzzleHttp\Psr7\MultipartStream;
use GuzzleHttp\Psr7\Request;
use GuzzleHttp\RequestOptions;
use Swagger\Client\ApiException;
use Swagger\Client\Configuration;
use Swagger\Client\HeaderSelector;
use Swagger\Client\ObjectSerializer;

/**
 * CARDSApi Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class CARDSApi
{
    /**
     * @var ClientInterface
     */
    protected $client;

    /**
     * @var Configuration
     */
    protected $config;

    /**
     * @var HeaderSelector
     */
    protected $headerSelector;

    /**
     * @param ClientInterface $client
     * @param Configuration   $config
     * @param HeaderSelector  $selector
     */
    public function __construct(
        ClientInterface $client = null,
        Configuration $config = null,
        HeaderSelector $selector = null
    ) {
        $this->client = $client ?: new Client();
        $this->config = $config ?: new Configuration();
        $this->headerSelector = $selector ?: new HeaderSelector();
    }

    /**
     * @return Configuration
     */
    public function getConfig()
    {
        return $this->config;
    }

    /**
     * Operation notifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction
     *
     * This API will be triggered by partner(VISA) to notify the cardholder about authorisation transaction.
     *
     * @param  \Swagger\Client\Model\NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest $body NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest (required)
     * @param  string $authorization HTTP Basic authentication by passing base64 encoded value of the client id and client secret separated by colon (:).Example: Base64(client_id:client_secret) will be passed as Basic KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; (required)
     * @param  string $uuid 128 bit random UUID generated uniquely for every request. (required)
     * @param  string $accept Content-Type that are acceptable for the response. (required)
     * @param  string $content_type application/json (required)
     * @param  string $client_id Client ID generated during application registration. (optional)
     * @param  string $client_details This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)
     * @param  string $accept_language List of acceptable human languages for response. (optional)
     * @param  string $x_jws_signature This field is signature generated when partner sign API payload.This signature will be used to validate that the call is coming from a valid partner. This signature is a JWT token, which will be validated with partner’s JWK stored in DB (optional)
     *
     * @throws \Swagger\Client\ApiException on non-2xx response
     * @throws \InvalidArgumentException
     * @return void
     */
    public function notifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction($body, $authorization, $uuid, $accept, $content_type, $client_id = null, $client_details = null, $accept_language = null, $x_jws_signature = null)
    {
        $this->notifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionWithHttpInfo($body, $authorization, $uuid, $accept, $content_type, $client_id, $client_details, $accept_language, $x_jws_signature);
    }

    /**
     * Operation notifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionWithHttpInfo
     *
     * This API will be triggered by partner(VISA) to notify the cardholder about authorisation transaction.
     *
     * @param  \Swagger\Client\Model\NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest $body NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest (required)
     * @param  string $authorization HTTP Basic authentication by passing base64 encoded value of the client id and client secret separated by colon (:).Example: Base64(client_id:client_secret) will be passed as Basic KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; (required)
     * @param  string $uuid 128 bit random UUID generated uniquely for every request. (required)
     * @param  string $accept Content-Type that are acceptable for the response. (required)
     * @param  string $content_type application/json (required)
     * @param  string $client_id Client ID generated during application registration. (optional)
     * @param  string $client_details This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)
     * @param  string $accept_language List of acceptable human languages for response. (optional)
     * @param  string $x_jws_signature This field is signature generated when partner sign API payload.This signature will be used to validate that the call is coming from a valid partner. This signature is a JWT token, which will be validated with partner’s JWK stored in DB (optional)
     *
     * @throws \Swagger\Client\ApiException on non-2xx response
     * @throws \InvalidArgumentException
     * @return array of null, HTTP status code, HTTP response headers (array of strings)
     */
    public function notifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionWithHttpInfo($body, $authorization, $uuid, $accept, $content_type, $client_id = null, $client_details = null, $accept_language = null, $x_jws_signature = null)
    {
        $returnType = '';
        $request = $this->notifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest($body, $authorization, $uuid, $accept, $content_type, $client_id, $client_details, $accept_language, $x_jws_signature);

        try {
            $options = $this->createHttpClientOption();
            try {
                $response = $this->client->send($request, $options);
            } catch (RequestException $e) {
                throw new ApiException(
                    "[{$e->getCode()}] {$e->getMessage()}",
                    $e->getCode(),
                    $e->getResponse() ? $e->getResponse()->getHeaders() : null,
                    $e->getResponse() ? $e->getResponse()->getBody()->getContents() : null
                );
            }

            $statusCode = $response->getStatusCode();

            if ($statusCode < 200 || $statusCode > 299) {
                throw new ApiException(
                    sprintf(
                        '[%d] Error connecting to the API (%s)',
                        $statusCode,
                        $request->getUri()
                    ),
                    $statusCode,
                    $response->getHeaders(),
                    $response->getBody()
                );
            }

            return [null, $statusCode, $response->getHeaders()];

        } catch (ApiException $e) {
            switch ($e->getCode()) {
                case 400:
                    $data = ObjectSerializer::deserialize(
                        $e->getResponseBody(),
                        '\Swagger\Client\Model\ErrorResponse',
                        $e->getResponseHeaders()
                    );
                    $e->setResponseObject($data);
                    break;
                case 401:
                    $data = ObjectSerializer::deserialize(
                        $e->getResponseBody(),
                        '\Swagger\Client\Model\ErrorResponse',
                        $e->getResponseHeaders()
                    );
                    $e->setResponseObject($data);
                    break;
                case 403:
                    $data = ObjectSerializer::deserialize(
                        $e->getResponseBody(),
                        '\Swagger\Client\Model\ErrorResponse',
                        $e->getResponseHeaders()
                    );
                    $e->setResponseObject($data);
                    break;
                case 404:
                    $data = ObjectSerializer::deserialize(
                        $e->getResponseBody(),
                        '\Swagger\Client\Model\ErrorResponse',
                        $e->getResponseHeaders()
                    );
                    $e->setResponseObject($data);
                    break;
                case 422:
                    $data = ObjectSerializer::deserialize(
                        $e->getResponseBody(),
                        '\Swagger\Client\Model\ErrorResponse',
                        $e->getResponseHeaders()
                    );
                    $e->setResponseObject($data);
                    break;
                case 500:
                    $data = ObjectSerializer::deserialize(
                        $e->getResponseBody(),
                        '\Swagger\Client\Model\ErrorResponse',
                        $e->getResponseHeaders()
                    );
                    $e->setResponseObject($data);
                    break;
            }
            throw $e;
        }
    }

    /**
     * Operation notifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionAsync
     *
     * This API will be triggered by partner(VISA) to notify the cardholder about authorisation transaction.
     *
     * @param  \Swagger\Client\Model\NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest $body NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest (required)
     * @param  string $authorization HTTP Basic authentication by passing base64 encoded value of the client id and client secret separated by colon (:).Example: Base64(client_id:client_secret) will be passed as Basic KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; (required)
     * @param  string $uuid 128 bit random UUID generated uniquely for every request. (required)
     * @param  string $accept Content-Type that are acceptable for the response. (required)
     * @param  string $content_type application/json (required)
     * @param  string $client_id Client ID generated during application registration. (optional)
     * @param  string $client_details This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)
     * @param  string $accept_language List of acceptable human languages for response. (optional)
     * @param  string $x_jws_signature This field is signature generated when partner sign API payload.This signature will be used to validate that the call is coming from a valid partner. This signature is a JWT token, which will be validated with partner’s JWK stored in DB (optional)
     *
     * @throws \InvalidArgumentException
     * @return \GuzzleHttp\Promise\PromiseInterface
     */
    public function notifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionAsync($body, $authorization, $uuid, $accept, $content_type, $client_id = null, $client_details = null, $accept_language = null, $x_jws_signature = null)
    {
        return $this->notifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionAsyncWithHttpInfo($body, $authorization, $uuid, $accept, $content_type, $client_id, $client_details, $accept_language, $x_jws_signature)
            ->then(
                function ($response) {
                    return $response[0];
                }
            );
    }

    /**
     * Operation notifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionAsyncWithHttpInfo
     *
     * This API will be triggered by partner(VISA) to notify the cardholder about authorisation transaction.
     *
     * @param  \Swagger\Client\Model\NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest $body NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest (required)
     * @param  string $authorization HTTP Basic authentication by passing base64 encoded value of the client id and client secret separated by colon (:).Example: Base64(client_id:client_secret) will be passed as Basic KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; (required)
     * @param  string $uuid 128 bit random UUID generated uniquely for every request. (required)
     * @param  string $accept Content-Type that are acceptable for the response. (required)
     * @param  string $content_type application/json (required)
     * @param  string $client_id Client ID generated during application registration. (optional)
     * @param  string $client_details This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)
     * @param  string $accept_language List of acceptable human languages for response. (optional)
     * @param  string $x_jws_signature This field is signature generated when partner sign API payload.This signature will be used to validate that the call is coming from a valid partner. This signature is a JWT token, which will be validated with partner’s JWK stored in DB (optional)
     *
     * @throws \InvalidArgumentException
     * @return \GuzzleHttp\Promise\PromiseInterface
     */
    public function notifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionAsyncWithHttpInfo($body, $authorization, $uuid, $accept, $content_type, $client_id = null, $client_details = null, $accept_language = null, $x_jws_signature = null)
    {
        $returnType = '';
        $request = $this->notifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest($body, $authorization, $uuid, $accept, $content_type, $client_id, $client_details, $accept_language, $x_jws_signature);

        return $this->client
            ->sendAsync($request, $this->createHttpClientOption())
            ->then(
                function ($response) use ($returnType) {
                    return [null, $response->getStatusCode(), $response->getHeaders()];
                },
                function ($exception) {
                    $response = $exception->getResponse();
                    $statusCode = $response->getStatusCode();
                    throw new ApiException(
                        sprintf(
                            '[%d] Error connecting to the API (%s)',
                            $statusCode,
                            $exception->getRequest()->getUri()
                        ),
                        $statusCode,
                        $response->getHeaders(),
                        $response->getBody()
                    );
                }
            );
    }

    /**
     * Create request for operation 'notifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction'
     *
     * @param  \Swagger\Client\Model\NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest $body NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest (required)
     * @param  string $authorization HTTP Basic authentication by passing base64 encoded value of the client id and client secret separated by colon (:).Example: Base64(client_id:client_secret) will be passed as Basic KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; (required)
     * @param  string $uuid 128 bit random UUID generated uniquely for every request. (required)
     * @param  string $accept Content-Type that are acceptable for the response. (required)
     * @param  string $content_type application/json (required)
     * @param  string $client_id Client ID generated during application registration. (optional)
     * @param  string $client_details This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)
     * @param  string $accept_language List of acceptable human languages for response. (optional)
     * @param  string $x_jws_signature This field is signature generated when partner sign API payload.This signature will be used to validate that the call is coming from a valid partner. This signature is a JWT token, which will be validated with partner’s JWK stored in DB (optional)
     *
     * @throws \InvalidArgumentException
     * @return \GuzzleHttp\Psr7\Request
     */
    protected function notifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest($body, $authorization, $uuid, $accept, $content_type, $client_id = null, $client_details = null, $accept_language = null, $x_jws_signature = null)
    {
        // verify the required parameter 'body' is set
        if ($body === null || (is_array($body) && count($body) === 0)) {
            throw new \InvalidArgumentException(
                'Missing the required parameter $body when calling notifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction'
            );
        }
        // verify the required parameter 'authorization' is set
        if ($authorization === null || (is_array($authorization) && count($authorization) === 0)) {
            throw new \InvalidArgumentException(
                'Missing the required parameter $authorization when calling notifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction'
            );
        }
        // verify the required parameter 'uuid' is set
        if ($uuid === null || (is_array($uuid) && count($uuid) === 0)) {
            throw new \InvalidArgumentException(
                'Missing the required parameter $uuid when calling notifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction'
            );
        }
        // verify the required parameter 'accept' is set
        if ($accept === null || (is_array($accept) && count($accept) === 0)) {
            throw new \InvalidArgumentException(
                'Missing the required parameter $accept when calling notifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction'
            );
        }
        // verify the required parameter 'content_type' is set
        if ($content_type === null || (is_array($content_type) && count($content_type) === 0)) {
            throw new \InvalidArgumentException(
                'Missing the required parameter $content_type when calling notifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction'
            );
        }

        $resourcePath = '/partner/v1/creditChargeCard/transaction/authorised/notify';
        $formParams = [];
        $queryParams = [];
        $headerParams = [];
        $httpBody = '';
        $multipart = false;

        // header params
        if ($authorization !== null) {
            $headerParams['Authorization'] = ObjectSerializer::toHeaderValue($authorization);
        }
        // header params
        if ($uuid !== null) {
            $headerParams['uuid'] = ObjectSerializer::toHeaderValue($uuid);
        }
        // header params
        if ($accept !== null) {
            $headerParams['Accept'] = ObjectSerializer::toHeaderValue($accept);
        }
        // header params
        if ($client_id !== null) {
            $headerParams['client_id'] = ObjectSerializer::toHeaderValue($client_id);
        }
        // header params
        if ($content_type !== null) {
            $headerParams['Content-Type'] = ObjectSerializer::toHeaderValue($content_type);
        }
        // header params
        if ($client_details !== null) {
            $headerParams['clientDetails'] = ObjectSerializer::toHeaderValue($client_details);
        }
        // header params
        if ($accept_language !== null) {
            $headerParams['Accept-Language'] = ObjectSerializer::toHeaderValue($accept_language);
        }
        // header params
        if ($x_jws_signature !== null) {
            $headerParams['x-jws-signature'] = ObjectSerializer::toHeaderValue($x_jws_signature);
        }


        // body params
        $_tempBody = null;
        if (isset($body)) {
            $_tempBody = $body;
        }

        if ($multipart) {
            $headers = $this->headerSelector->selectHeadersForMultipart(
                ['application/json']
            );
        } else {
            $headers = $this->headerSelector->selectHeaders(
                ['application/json'],
                ['application/json']
            );
        }

        // for model (json/xml)
        if (isset($_tempBody)) {
            // $_tempBody is the method argument, if present
            $httpBody = $_tempBody;
            // \stdClass has no __toString(), so we should encode it manually
            if ($httpBody instanceof \stdClass && $headers['Content-Type'] === 'application/json') {
                $httpBody = \GuzzleHttp\json_encode($httpBody);
            }
        } elseif (count($formParams) > 0) {
            if ($multipart) {
                $multipartContents = [];
                foreach ($formParams as $formParamName => $formParamValue) {
                    $multipartContents[] = [
                        'name' => $formParamName,
                        'contents' => $formParamValue
                    ];
                }
                // for HTTP post (form)
                $httpBody = new MultipartStream($multipartContents);

            } elseif ($headers['Content-Type'] === 'application/json') {
                $httpBody = \GuzzleHttp\json_encode($formParams);

            } else {
                // for HTTP post (form)
                $httpBody = \GuzzleHttp\Psr7\build_query($formParams);
            }
        }


        $defaultHeaders = [];
        if ($this->config->getUserAgent()) {
            $defaultHeaders['User-Agent'] = $this->config->getUserAgent();
        }

        $headers = array_merge(
            $defaultHeaders,
            $headerParams,
            $headers
        );

        $query = \GuzzleHttp\Psr7\build_query($queryParams);
        return new Request(
            'POST',
            $this->config->getHost() . $resourcePath . ($query ? "?{$query}" : ''),
            $headers,
            $httpBody
        );
    }

    /**
     * Create http client option
     *
     * @throws \RuntimeException on file opening failure
     * @return array of http client options
     */
    protected function createHttpClientOption()
    {
        $options = [];
        if ($this->config->getDebug()) {
            $options[RequestOptions::DEBUG] = fopen($this->config->getDebugFile(), 'a');
            if (!$options[RequestOptions::DEBUG]) {
                throw new \RuntimeException('Failed to open the debug file: ' . $this->config->getDebugFile());
            }
        }

        return $options;
    }
}
