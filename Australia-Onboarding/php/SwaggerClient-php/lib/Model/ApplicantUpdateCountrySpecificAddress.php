<?php
/**
 * ApplicantUpdateCountrySpecificAddress
 *
 * PHP version 5
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
 * Onboarding
 *
 * The Onboarding API allows you to initiate the basic account opening process for new customers. The resources allow you to present eligible products, send applications for screening and submit a new application for one or more products. The resources also allow you to submit supporting documents. Application status can be checked at any point in the process, with decisioning happening in real time.
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
 * ApplicantUpdateCountrySpecificAddress Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class ApplicantUpdateCountrySpecificAddress implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'ApplicantUpdateCountrySpecificAddress';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'unit_number' => 'string',
'floor_number' => 'string',
'block_number' => 'string',
'building_name' => 'string',
'estate_name' => 'string',
'street_number' => 'string',
'street_name' => 'string',
'street_type' => 'string'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'unit_number' => null,
'floor_number' => null,
'block_number' => null,
'building_name' => null,
'estate_name' => null,
'street_number' => null,
'street_name' => null,
'street_type' => null    ];

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
        'unit_number' => 'unitNumber',
'floor_number' => 'floorNumber',
'block_number' => 'blockNumber',
'building_name' => 'buildingName',
'estate_name' => 'estateName',
'street_number' => 'streetNumber',
'street_name' => 'streetName',
'street_type' => 'streetType'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'unit_number' => 'setUnitNumber',
'floor_number' => 'setFloorNumber',
'block_number' => 'setBlockNumber',
'building_name' => 'setBuildingName',
'estate_name' => 'setEstateName',
'street_number' => 'setStreetNumber',
'street_name' => 'setStreetName',
'street_type' => 'setStreetType'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'unit_number' => 'getUnitNumber',
'floor_number' => 'getFloorNumber',
'block_number' => 'getBlockNumber',
'building_name' => 'getBuildingName',
'estate_name' => 'getEstateName',
'street_number' => 'getStreetNumber',
'street_name' => 'getStreetName',
'street_type' => 'getStreetType'    ];

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
        $this->container['unit_number'] = isset($data['unit_number']) ? $data['unit_number'] : null;
        $this->container['floor_number'] = isset($data['floor_number']) ? $data['floor_number'] : null;
        $this->container['block_number'] = isset($data['block_number']) ? $data['block_number'] : null;
        $this->container['building_name'] = isset($data['building_name']) ? $data['building_name'] : null;
        $this->container['estate_name'] = isset($data['estate_name']) ? $data['estate_name'] : null;
        $this->container['street_number'] = isset($data['street_number']) ? $data['street_number'] : null;
        $this->container['street_name'] = isset($data['street_name']) ? $data['street_name'] : null;
        $this->container['street_type'] = isset($data['street_type']) ? $data['street_type'] : null;
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
     * Gets unit_number
     *
     * @return string
     */
    public function getUnitNumber()
    {
        return $this->container['unit_number'];
    }

    /**
     * Sets unit_number
     *
     * @param string $unit_number Applicant's unit number
     *
     * @return $this
     */
    public function setUnitNumber($unit_number)
    {
        $this->container['unit_number'] = $unit_number;

        return $this;
    }

    /**
     * Gets floor_number
     *
     * @return string
     */
    public function getFloorNumber()
    {
        return $this->container['floor_number'];
    }

    /**
     * Sets floor_number
     *
     * @param string $floor_number Applicant's floor number
     *
     * @return $this
     */
    public function setFloorNumber($floor_number)
    {
        $this->container['floor_number'] = $floor_number;

        return $this;
    }

    /**
     * Gets block_number
     *
     * @return string
     */
    public function getBlockNumber()
    {
        return $this->container['block_number'];
    }

    /**
     * Sets block_number
     *
     * @param string $block_number Applicant's block number
     *
     * @return $this
     */
    public function setBlockNumber($block_number)
    {
        $this->container['block_number'] = $block_number;

        return $this;
    }

    /**
     * Gets building_name
     *
     * @return string
     */
    public function getBuildingName()
    {
        return $this->container['building_name'];
    }

    /**
     * Sets building_name
     *
     * @param string $building_name Applicant's building name
     *
     * @return $this
     */
    public function setBuildingName($building_name)
    {
        $this->container['building_name'] = $building_name;

        return $this;
    }

    /**
     * Gets estate_name
     *
     * @return string
     */
    public function getEstateName()
    {
        return $this->container['estate_name'];
    }

    /**
     * Sets estate_name
     *
     * @param string $estate_name Applicant's estate name
     *
     * @return $this
     */
    public function setEstateName($estate_name)
    {
        $this->container['estate_name'] = $estate_name;

        return $this;
    }

    /**
     * Gets street_number
     *
     * @return string
     */
    public function getStreetNumber()
    {
        return $this->container['street_number'];
    }

    /**
     * Sets street_number
     *
     * @param string $street_number Applicant's street number
     *
     * @return $this
     */
    public function setStreetNumber($street_number)
    {
        $this->container['street_number'] = $street_number;

        return $this;
    }

    /**
     * Gets street_name
     *
     * @return string
     */
    public function getStreetName()
    {
        return $this->container['street_name'];
    }

    /**
     * Sets street_name
     *
     * @param string $street_name Applicant's street name
     *
     * @return $this
     */
    public function setStreetName($street_name)
    {
        $this->container['street_name'] = $street_name;

        return $this;
    }

    /**
     * Gets street_type
     *
     * @return string
     */
    public function getStreetType()
    {
        return $this->container['street_type'];
    }

    /**
     * Sets street_type
     *
     * @param string $street_type Applicant's street type.Please use /v1/apac/utilities/referenceData/{streetType} resource to get valid value of this field with description. You can use streetType field name as the referenceCode parameter to retrieve the values
     *
     * @return $this
     */
    public function setStreetType($street_type)
    {
        $this->container['street_type'] = $street_type;

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
