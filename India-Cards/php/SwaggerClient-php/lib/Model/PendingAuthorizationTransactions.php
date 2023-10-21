<?php
/**
 * PendingAuthorizationTransactions
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
 * PendingAuthorizationTransactions Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class PendingAuthorizationTransactions implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'PendingAuthorizationTransactions';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'number_of_transactions' => 'int',
'more_indicator' => 'string',
'next_start_index' => 'string',
'pending_authorization_transaction_records' => '\Swagger\Client\Model\PendingAuthorizationTransactionRecords[]'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'number_of_transactions' => 'int32',
'more_indicator' => null,
'next_start_index' => null,
'pending_authorization_transaction_records' => null    ];

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
        'number_of_transactions' => 'numberOfTransactions',
'more_indicator' => 'moreIndicator',
'next_start_index' => 'nextStartIndex',
'pending_authorization_transaction_records' => 'pendingAuthorizationTransactionRecords'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'number_of_transactions' => 'setNumberOfTransactions',
'more_indicator' => 'setMoreIndicator',
'next_start_index' => 'setNextStartIndex',
'pending_authorization_transaction_records' => 'setPendingAuthorizationTransactionRecords'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'number_of_transactions' => 'getNumberOfTransactions',
'more_indicator' => 'getMoreIndicator',
'next_start_index' => 'getNextStartIndex',
'pending_authorization_transaction_records' => 'getPendingAuthorizationTransactionRecords'    ];

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
        $this->container['number_of_transactions'] = isset($data['number_of_transactions']) ? $data['number_of_transactions'] : null;
        $this->container['more_indicator'] = isset($data['more_indicator']) ? $data['more_indicator'] : null;
        $this->container['next_start_index'] = isset($data['next_start_index']) ? $data['next_start_index'] : null;
        $this->container['pending_authorization_transaction_records'] = isset($data['pending_authorization_transaction_records']) ? $data['pending_authorization_transaction_records'] : null;
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
     * Gets number_of_transactions
     *
     * @return int
     */
    public function getNumberOfTransactions()
    {
        return $this->container['number_of_transactions'];
    }

    /**
     * Sets number_of_transactions
     *
     * @param int $number_of_transactions Total Number of Transactions
     *
     * @return $this
     */
    public function setNumberOfTransactions($number_of_transactions)
    {
        $this->container['number_of_transactions'] = $number_of_transactions;

        return $this;
    }

    /**
     * Gets more_indicator
     *
     * @return string
     */
    public function getMoreIndicator()
    {
        return $this->container['more_indicator'];
    }

    /**
     * Sets more_indicator
     *
     * @param string $more_indicator This field indicates that more records are available for retrieval. Y = more records are available for retrieval, N = no more records are available for retrieval
     *
     * @return $this
     */
    public function setMoreIndicator($more_indicator)
    {
        $this->container['more_indicator'] = $more_indicator;

        return $this;
    }

    /**
     * Gets next_start_index
     *
     * @return string
     */
    public function getNextStartIndex()
    {
        return $this->container['next_start_index'];
    }

    /**
     * Sets next_start_index
     *
     * @param string $next_start_index This field indicates the starting index for retrieving the next page/batch of records.
     *
     * @return $this
     */
    public function setNextStartIndex($next_start_index)
    {
        $this->container['next_start_index'] = $next_start_index;

        return $this;
    }

    /**
     * Gets pending_authorization_transaction_records
     *
     * @return \Swagger\Client\Model\PendingAuthorizationTransactionRecords[]
     */
    public function getPendingAuthorizationTransactionRecords()
    {
        return $this->container['pending_authorization_transaction_records'];
    }

    /**
     * Sets pending_authorization_transaction_records
     *
     * @param \Swagger\Client\Model\PendingAuthorizationTransactionRecords[] $pending_authorization_transaction_records pending_authorization_transaction_records
     *
     * @return $this
     */
    public function setPendingAuthorizationTransactionRecords($pending_authorization_transaction_records)
    {
        $this->container['pending_authorization_transaction_records'] = $pending_authorization_transaction_records;

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
