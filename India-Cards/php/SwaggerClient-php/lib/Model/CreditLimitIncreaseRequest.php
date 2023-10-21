<?php
/**
 * CreditLimitIncreaseRequest
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
 * CreditLimitIncreaseRequest Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class CreditLimitIncreaseRequest implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'CreditLimitIncreaseRequest';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'permanent_credit_limit_increase' => '\Swagger\Client\Model\PermanentCreditLimitIncrease',
'temporary_credit_limit_increase' => '\Swagger\Client\Model\TemporaryCreditLimitIncrease'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'permanent_credit_limit_increase' => null,
'temporary_credit_limit_increase' => null    ];

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
        'permanent_credit_limit_increase' => 'permanentCreditLimitIncrease',
'temporary_credit_limit_increase' => 'temporaryCreditLimitIncrease'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'permanent_credit_limit_increase' => 'setPermanentCreditLimitIncrease',
'temporary_credit_limit_increase' => 'setTemporaryCreditLimitIncrease'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'permanent_credit_limit_increase' => 'getPermanentCreditLimitIncrease',
'temporary_credit_limit_increase' => 'getTemporaryCreditLimitIncrease'    ];

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
        $this->container['permanent_credit_limit_increase'] = isset($data['permanent_credit_limit_increase']) ? $data['permanent_credit_limit_increase'] : null;
        $this->container['temporary_credit_limit_increase'] = isset($data['temporary_credit_limit_increase']) ? $data['temporary_credit_limit_increase'] : null;
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
     * Gets permanent_credit_limit_increase
     *
     * @return \Swagger\Client\Model\PermanentCreditLimitIncrease
     */
    public function getPermanentCreditLimitIncrease()
    {
        return $this->container['permanent_credit_limit_increase'];
    }

    /**
     * Sets permanent_credit_limit_increase
     *
     * @param \Swagger\Client\Model\PermanentCreditLimitIncrease $permanent_credit_limit_increase permanent_credit_limit_increase
     *
     * @return $this
     */
    public function setPermanentCreditLimitIncrease($permanent_credit_limit_increase)
    {
        $this->container['permanent_credit_limit_increase'] = $permanent_credit_limit_increase;

        return $this;
    }

    /**
     * Gets temporary_credit_limit_increase
     *
     * @return \Swagger\Client\Model\TemporaryCreditLimitIncrease
     */
    public function getTemporaryCreditLimitIncrease()
    {
        return $this->container['temporary_credit_limit_increase'];
    }

    /**
     * Sets temporary_credit_limit_increase
     *
     * @param \Swagger\Client\Model\TemporaryCreditLimitIncrease $temporary_credit_limit_increase temporary_credit_limit_increase
     *
     * @return $this
     */
    public function setTemporaryCreditLimitIncrease($temporary_credit_limit_increase)
    {
        $this->container['temporary_credit_limit_increase'] = $temporary_credit_limit_increase;

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
