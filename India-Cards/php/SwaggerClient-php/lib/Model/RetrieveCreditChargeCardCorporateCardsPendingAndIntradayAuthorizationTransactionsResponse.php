<?php
/**
 * RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsResponse
 *
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

namespace Swagger\Client\Model;

use \ArrayAccess;
use \Swagger\Client\ObjectSerializer;

/**
 * RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsResponse Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsResponse implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsResponse';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'pending_authorization_transactions' => '\Swagger\Client\Model\PendingAuthorizationTransactions',
'history_and_intraday_transactions' => '\Swagger\Client\Model\HistoryAndIntradayTransactions'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'pending_authorization_transactions' => null,
'history_and_intraday_transactions' => null    ];

    /**
     * Array of property to type mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function swaggerTypes()
    {
        return self::$swaggerTypes;
    }

    /**
     * Array of property to format mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function swaggerFormats()
    {
        return self::$swaggerFormats;
    }

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @var string[]
     */
    protected static $attributeMap = [
        'pending_authorization_transactions' => 'pendingAuthorizationTransactions',
'history_and_intraday_transactions' => 'historyAndIntradayTransactions'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'pending_authorization_transactions' => 'setPendingAuthorizationTransactions',
'history_and_intraday_transactions' => 'setHistoryAndIntradayTransactions'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'pending_authorization_transactions' => 'getPendingAuthorizationTransactions',
'history_and_intraday_transactions' => 'getHistoryAndIntradayTransactions'    ];

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @return array
     */
    public static function attributeMap()
    {
        return self::$attributeMap;
    }

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @return array
     */
    public static function setters()
    {
        return self::$setters;
    }

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @return array
     */
    public static function getters()
    {
        return self::$getters;
    }

    /**
     * The original name of the model.
     *
     * @return string
     */
    public function getModelName()
    {
        return self::$swaggerModelName;
    }

    

    /**
     * Associative array for storing property values
     *
     * @var mixed[]
     */
    protected $container = [];

    /**
     * Constructor
     *
     * @param mixed[] $data Associated array of property values
     *                      initializing the model
     */
    public function __construct(array $data = null)
    {
        $this->container['pending_authorization_transactions'] = isset($data['pending_authorization_transactions']) ? $data['pending_authorization_transactions'] : null;
        $this->container['history_and_intraday_transactions'] = isset($data['history_and_intraday_transactions']) ? $data['history_and_intraday_transactions'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        return $invalidProperties;
    }

    /**
     * Validate all the properties in the model
     * return true if all passed
     *
     * @return bool True if all properties are valid
     */
    public function valid()
    {
        return count($this->listInvalidProperties()) === 0;
    }


    /**
     * Gets pending_authorization_transactions
     *
     * @return \Swagger\Client\Model\PendingAuthorizationTransactions
     */
    public function getPendingAuthorizationTransactions()
    {
        return $this->container['pending_authorization_transactions'];
    }

    /**
     * Sets pending_authorization_transactions
     *
     * @param \Swagger\Client\Model\PendingAuthorizationTransactions $pending_authorization_transactions pending_authorization_transactions
     *
     * @return $this
     */
    public function setPendingAuthorizationTransactions($pending_authorization_transactions)
    {
        $this->container['pending_authorization_transactions'] = $pending_authorization_transactions;

        return $this;
    }

    /**
     * Gets history_and_intraday_transactions
     *
     * @return \Swagger\Client\Model\HistoryAndIntradayTransactions
     */
    public function getHistoryAndIntradayTransactions()
    {
        return $this->container['history_and_intraday_transactions'];
    }

    /**
     * Sets history_and_intraday_transactions
     *
     * @param \Swagger\Client\Model\HistoryAndIntradayTransactions $history_and_intraday_transactions history_and_intraday_transactions
     *
     * @return $this
     */
    public function setHistoryAndIntradayTransactions($history_and_intraday_transactions)
    {
        $this->container['history_and_intraday_transactions'] = $history_and_intraday_transactions;

        return $this;
    }
    /**
     * Returns true if offset exists. False otherwise.
     *
     * @param integer $offset Offset
     *
     * @return boolean
     */
    public function offsetExists($offset)
    {
        return isset($this->container[$offset]);
    }

    /**
     * Gets offset.
     *
     * @param integer $offset Offset
     *
     * @return mixed
     */
    public function offsetGet($offset)
    {
        return isset($this->container[$offset]) ? $this->container[$offset] : null;
    }

    /**
     * Sets value based on offset.
     *
     * @param integer $offset Offset
     * @param mixed   $value  Value to be set
     *
     * @return void
     */
    public function offsetSet($offset, $value)
    {
        if (is_null($offset)) {
            $this->container[] = $value;
        } else {
            $this->container[$offset] = $value;
        }
    }

    /**
     * Unsets offset.
     *
     * @param integer $offset Offset
     *
     * @return void
     */
    public function offsetUnset($offset)
    {
        unset($this->container[$offset]);
    }

    /**
     * Gets the string presentation of the object
     *
     * @return string
     */
    public function __toString()
    {
        if (defined('JSON_PRETTY_PRINT')) { // use JSON pretty print
            return json_encode(
                ObjectSerializer::sanitizeForSerialization($this),
                JSON_PRETTY_PRINT
            );
        }

        return json_encode(ObjectSerializer::sanitizeForSerialization($this));
    }
}
