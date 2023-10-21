<?php
/**
 * PresetAtmPinAddRequest
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
 * PresetAtmPinAddRequest Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class PresetAtmPinAddRequest implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'PresetAtmPinAddRequest';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'application_id' => 'string',
'control_flow_id' => 'string',
'encrypted_pin' => 'string',
'pin_registration_key' => 'string',
'pin_length' => 'int',
'key_device_id' => 'string',
'key_generation_id' => 'string'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'application_id' => null,
'control_flow_id' => null,
'encrypted_pin' => null,
'pin_registration_key' => null,
'pin_length' => 'int32',
'key_device_id' => null,
'key_generation_id' => null    ];

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
        'application_id' => 'applicationId',
'control_flow_id' => 'controlFlowId',
'encrypted_pin' => 'encryptedPin',
'pin_registration_key' => 'pinRegistrationKey',
'pin_length' => 'pinLength',
'key_device_id' => 'keyDeviceId',
'key_generation_id' => 'keyGenerationId'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'application_id' => 'setApplicationId',
'control_flow_id' => 'setControlFlowId',
'encrypted_pin' => 'setEncryptedPin',
'pin_registration_key' => 'setPinRegistrationKey',
'pin_length' => 'setPinLength',
'key_device_id' => 'setKeyDeviceId',
'key_generation_id' => 'setKeyGenerationId'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'application_id' => 'getApplicationId',
'control_flow_id' => 'getControlFlowId',
'encrypted_pin' => 'getEncryptedPin',
'pin_registration_key' => 'getPinRegistrationKey',
'pin_length' => 'getPinLength',
'key_device_id' => 'getKeyDeviceId',
'key_generation_id' => 'getKeyGenerationId'    ];

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
        $this->container['application_id'] = isset($data['application_id']) ? $data['application_id'] : null;
        $this->container['control_flow_id'] = isset($data['control_flow_id']) ? $data['control_flow_id'] : null;
        $this->container['encrypted_pin'] = isset($data['encrypted_pin']) ? $data['encrypted_pin'] : null;
        $this->container['pin_registration_key'] = isset($data['pin_registration_key']) ? $data['pin_registration_key'] : null;
        $this->container['pin_length'] = isset($data['pin_length']) ? $data['pin_length'] : null;
        $this->container['key_device_id'] = isset($data['key_device_id']) ? $data['key_device_id'] : null;
        $this->container['key_generation_id'] = isset($data['key_generation_id']) ? $data['key_generation_id'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if ($this->container['application_id'] === null) {
            $invalidProperties[] = "'application_id' can't be null";
        }
        if ($this->container['control_flow_id'] === null) {
            $invalidProperties[] = "'control_flow_id' can't be null";
        }
        if ($this->container['encrypted_pin'] === null) {
            $invalidProperties[] = "'encrypted_pin' can't be null";
        }
        if ($this->container['pin_registration_key'] === null) {
            $invalidProperties[] = "'pin_registration_key' can't be null";
        }
        if ($this->container['pin_length'] === null) {
            $invalidProperties[] = "'pin_length' can't be null";
        }
        if ($this->container['key_device_id'] === null) {
            $invalidProperties[] = "'key_device_id' can't be null";
        }
        if ($this->container['key_generation_id'] === null) {
            $invalidProperties[] = "'key_generation_id' can't be null";
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
     * Gets application_id
     *
     * @return string
     */
    public function getApplicationId()
    {
        return $this->container['application_id'];
    }

    /**
     * Sets application_id
     *
     * @param string $application_id The unique identifier of the application.
     *
     * @return $this
     */
    public function setApplicationId($application_id)
    {
        $this->container['application_id'] = $application_id;

        return $this;
    }

    /**
     * Gets control_flow_id
     *
     * @return string
     */
    public function getControlFlowId()
    {
        return $this->container['control_flow_id'];
    }

    /**
     * Sets control_flow_id
     *
     * @param string $control_flow_id Control flow id is used to control the flow for subsequent requests in the session.
     *
     * @return $this
     */
    public function setControlFlowId($control_flow_id)
    {
        $this->container['control_flow_id'] = $control_flow_id;

        return $this;
    }

    /**
     * Gets encrypted_pin
     *
     * @return string
     */
    public function getEncryptedPin()
    {
        return $this->container['encrypted_pin'];
    }

    /**
     * Sets encrypted_pin
     *
     * @param string $encrypted_pin Encrypted ATM PIN set by the customer
     *
     * @return $this
     */
    public function setEncryptedPin($encrypted_pin)
    {
        $this->container['encrypted_pin'] = $encrypted_pin;

        return $this;
    }

    /**
     * Gets pin_registration_key
     *
     * @return string
     */
    public function getPinRegistrationKey()
    {
        return $this->container['pin_registration_key'];
    }

    /**
     * Sets pin_registration_key
     *
     * @param string $pin_registration_key Unique key used for the registration of ATM PIN
     *
     * @return $this
     */
    public function setPinRegistrationKey($pin_registration_key)
    {
        $this->container['pin_registration_key'] = $pin_registration_key;

        return $this;
    }

    /**
     * Gets pin_length
     *
     * @return int
     */
    public function getPinLength()
    {
        return $this->container['pin_length'];
    }

    /**
     * Sets pin_length
     *
     * @param int $pin_length Length of the ATM  PIN
     *
     * @return $this
     */
    public function setPinLength($pin_length)
    {
        $this->container['pin_length'] = $pin_length;

        return $this;
    }

    /**
     * Gets key_device_id
     *
     * @return string
     */
    public function getKeyDeviceId()
    {
        return $this->container['key_device_id'];
    }

    /**
     * Sets key_device_id
     *
     * @param string $key_device_id Label to identify the HSM keys used to encrypt PIN
     *
     * @return $this
     */
    public function setKeyDeviceId($key_device_id)
    {
        $this->container['key_device_id'] = $key_device_id;

        return $this;
    }

    /**
     * Gets key_generation_id
     *
     * @return string
     */
    public function getKeyGenerationId()
    {
        return $this->container['key_generation_id'];
    }

    /**
     * Sets key_generation_id
     *
     * @param string $key_generation_id It is the generation ID of the HSM Keys referred for encryption for PIN
     *
     * @return $this
     */
    public function setKeyGenerationId($key_generation_id)
    {
        $this->container['key_generation_id'] = $key_generation_id;

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