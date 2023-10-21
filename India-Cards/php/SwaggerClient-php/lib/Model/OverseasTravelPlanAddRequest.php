<?php
/**
 * OverseasTravelPlanAddRequest
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
 * OverseasTravelPlanAddRequest Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class OverseasTravelPlanAddRequest implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'OverseasTravelPlanAddRequest';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'country_codes' => '\Swagger\Client\Model\CountryCodes[]',
'travel_plan_start_date' => '\DateTime',
'travel_plan_end_date' => '\DateTime'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'country_codes' => null,
'travel_plan_start_date' => 'date',
'travel_plan_end_date' => 'date'    ];

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
        'country_codes' => 'countryCodes',
'travel_plan_start_date' => 'travelPlanStartDate',
'travel_plan_end_date' => 'travelPlanEndDate'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'country_codes' => 'setCountryCodes',
'travel_plan_start_date' => 'setTravelPlanStartDate',
'travel_plan_end_date' => 'setTravelPlanEndDate'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'country_codes' => 'getCountryCodes',
'travel_plan_start_date' => 'getTravelPlanStartDate',
'travel_plan_end_date' => 'getTravelPlanEndDate'    ];

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
        $this->container['country_codes'] = isset($data['country_codes']) ? $data['country_codes'] : null;
        $this->container['travel_plan_start_date'] = isset($data['travel_plan_start_date']) ? $data['travel_plan_start_date'] : null;
        $this->container['travel_plan_end_date'] = isset($data['travel_plan_end_date']) ? $data['travel_plan_end_date'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if ($this->container['travel_plan_start_date'] === null) {
            $invalidProperties[] = "'travel_plan_start_date' can't be null";
        }
        if ($this->container['travel_plan_end_date'] === null) {
            $invalidProperties[] = "'travel_plan_end_date' can't be null";
        }
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
     * Gets country_codes
     *
     * @return \Swagger\Client\Model\CountryCodes[]
     */
    public function getCountryCodes()
    {
        return $this->container['country_codes'];
    }

    /**
     * Sets country_codes
     *
     * @param \Swagger\Client\Model\CountryCodes[] $country_codes country_codes
     *
     * @return $this
     */
    public function setCountryCodes($country_codes)
    {
        $this->container['country_codes'] = $country_codes;

        return $this;
    }

    /**
     * Gets travel_plan_start_date
     *
     * @return \DateTime
     */
    public function getTravelPlanStartDate()
    {
        return $this->container['travel_plan_start_date'];
    }

    /**
     * Sets travel_plan_start_date
     *
     * @param \DateTime $travel_plan_start_date Travel plan start date in ISO 8601 date format YYYY-MM-DD
     *
     * @return $this
     */
    public function setTravelPlanStartDate($travel_plan_start_date)
    {
        $this->container['travel_plan_start_date'] = $travel_plan_start_date;

        return $this;
    }

    /**
     * Gets travel_plan_end_date
     *
     * @return \DateTime
     */
    public function getTravelPlanEndDate()
    {
        return $this->container['travel_plan_end_date'];
    }

    /**
     * Sets travel_plan_end_date
     *
     * @param \DateTime $travel_plan_end_date Travel plan end date in ISO 8601 date format YYYY-MM-DD
     *
     * @return $this
     */
    public function setTravelPlanEndDate($travel_plan_end_date)
    {
        $this->container['travel_plan_end_date'] = $travel_plan_end_date;

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
