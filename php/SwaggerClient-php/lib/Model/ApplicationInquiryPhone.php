<?php
/**
 * ApplicationInquiryPhone
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
 * ApplicationInquiryPhone Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class ApplicationInquiryPhone implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'ApplicationInquiryPhone';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'phone_type' => 'string',
'phone_country_code' => 'string',
'area_code' => 'string',
'phone_number' => 'string',
'extension' => 'string',
'ok_to_sms' => 'bool',
'ok_to_call' => 'bool'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'phone_type' => null,
'phone_country_code' => null,
'area_code' => null,
'phone_number' => null,
'extension' => null,
'ok_to_sms' => null,
'ok_to_call' => null    ];

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
        'phone_type' => 'phoneType',
'phone_country_code' => 'phoneCountryCode',
'area_code' => 'areaCode',
'phone_number' => 'phoneNumber',
'extension' => 'extension',
'ok_to_sms' => 'okToSms',
'ok_to_call' => 'okToCall'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'phone_type' => 'setPhoneType',
'phone_country_code' => 'setPhoneCountryCode',
'area_code' => 'setAreaCode',
'phone_number' => 'setPhoneNumber',
'extension' => 'setExtension',
'ok_to_sms' => 'setOkToSms',
'ok_to_call' => 'setOkToCall'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'phone_type' => 'getPhoneType',
'phone_country_code' => 'getPhoneCountryCode',
'area_code' => 'getAreaCode',
'phone_number' => 'getPhoneNumber',
'extension' => 'getExtension',
'ok_to_sms' => 'getOkToSms',
'ok_to_call' => 'getOkToCall'    ];

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
        $this->container['phone_type'] = isset($data['phone_type']) ? $data['phone_type'] : null;
        $this->container['phone_country_code'] = isset($data['phone_country_code']) ? $data['phone_country_code'] : null;
        $this->container['area_code'] = isset($data['area_code']) ? $data['area_code'] : null;
        $this->container['phone_number'] = isset($data['phone_number']) ? $data['phone_number'] : null;
        $this->container['extension'] = isset($data['extension']) ? $data['extension'] : null;
        $this->container['ok_to_sms'] = isset($data['ok_to_sms']) ? $data['ok_to_sms'] : null;
        $this->container['ok_to_call'] = isset($data['ok_to_call']) ? $data['ok_to_call'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if ($this->container['phone_type'] === null) {
            $invalidProperties[] = "'phone_type' can't be null";
        }
        if ($this->container['phone_country_code'] === null) {
            $invalidProperties[] = "'phone_country_code' can't be null";
        }
        if ($this->container['phone_number'] === null) {
            $invalidProperties[] = "'phone_number' can't be null";
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
     * Gets phone_type
     *
     * @return string
     */
    public function getPhoneType()
    {
        return $this->container['phone_type'];
    }

    /**
     * Sets phone_type
     *
     * @param string $phone_type The type of phone. Ex:OFFICE, HOME, MOBILE, PRIMARY_MOBILE, FAX. This is a reference data field. Please use /v1/apac/utilities/referenceData/{phoneType} resource to get valid value of this field with description. You can use phoneType field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setPhoneType($phone_type)
    {
        $this->container['phone_type'] = $phone_type;

        return $this;
    }

    /**
     * Gets phone_country_code
     *
     * @return string
     */
    public function getPhoneCountryCode()
    {
        return $this->container['phone_country_code'];
    }

    /**
     * Sets phone_country_code
     *
     * @param string $phone_country_code Country code of phone number
     *
     * @return $this
     */
    public function setPhoneCountryCode($phone_country_code)
    {
        $this->container['phone_country_code'] = $phone_country_code;

        return $this;
    }

    /**
     * Gets area_code
     *
     * @return string
     */
    public function getAreaCode()
    {
        return $this->container['area_code'];
    }

    /**
     * Sets area_code
     *
     * @param string $area_code The area code of phone number
     *
     * @return $this
     */
    public function setAreaCode($area_code)
    {
        $this->container['area_code'] = $area_code;

        return $this;
    }

    /**
     * Gets phone_number
     *
     * @return string
     */
    public function getPhoneNumber()
    {
        return $this->container['phone_number'];
    }

    /**
     * Sets phone_number
     *
     * @param string $phone_number Applicant's phone number
     *
     * @return $this
     */
    public function setPhoneNumber($phone_number)
    {
        $this->container['phone_number'] = $phone_number;

        return $this;
    }

    /**
     * Gets extension
     *
     * @return string
     */
    public function getExtension()
    {
        return $this->container['extension'];
    }

    /**
     * Sets extension
     *
     * @param string $extension Extension of telephone number
     *
     * @return $this
     */
    public function setExtension($extension)
    {
        $this->container['extension'] = $extension;

        return $this;
    }

    /**
     * Gets ok_to_sms
     *
     * @return bool
     */
    public function getOkToSms()
    {
        return $this->container['ok_to_sms'];
    }

    /**
     * Sets ok_to_sms
     *
     * @param bool $ok_to_sms Applicant's consent for receiving sms. This is applicable only if phone type is MOBILE. Valid values: true and false
     *
     * @return $this
     */
    public function setOkToSms($ok_to_sms)
    {
        $this->container['ok_to_sms'] = $ok_to_sms;

        return $this;
    }

    /**
     * Gets ok_to_call
     *
     * @return bool
     */
    public function getOkToCall()
    {
        return $this->container['ok_to_call'];
    }

    /**
     * Sets ok_to_call
     *
     * @param bool $ok_to_call Applicant's consent for receiving phone calls. Valid values: true and false
     *
     * @return $this
     */
    public function setOkToCall($ok_to_call)
    {
        $this->container['ok_to_call'] = $ok_to_call;

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
