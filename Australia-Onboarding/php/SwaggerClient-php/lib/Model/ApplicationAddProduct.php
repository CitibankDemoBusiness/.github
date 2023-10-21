<?php
/**
 * ApplicationAddProduct
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
 * ApplicationAddProduct Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class ApplicationAddProduct implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'ApplicationAddProduct';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'credit_card_product' => '\Swagger\Client\Model\ApplicationAddCreditCardProduct',
'ready_credit_product' => '\Swagger\Client\Model\ApplicationAddReadyCreditProduct',
'unsecured_loan_product' => '\Swagger\Client\Model\ApplicationAddUnsecuredLoanProduct'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'credit_card_product' => null,
'ready_credit_product' => null,
'unsecured_loan_product' => null    ];

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
        'credit_card_product' => 'creditCardProduct',
'ready_credit_product' => 'readyCreditProduct',
'unsecured_loan_product' => 'unsecuredLoanProduct'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'credit_card_product' => 'setCreditCardProduct',
'ready_credit_product' => 'setReadyCreditProduct',
'unsecured_loan_product' => 'setUnsecuredLoanProduct'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'credit_card_product' => 'getCreditCardProduct',
'ready_credit_product' => 'getReadyCreditProduct',
'unsecured_loan_product' => 'getUnsecuredLoanProduct'    ];

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
        $this->container['credit_card_product'] = isset($data['credit_card_product']) ? $data['credit_card_product'] : null;
        $this->container['ready_credit_product'] = isset($data['ready_credit_product']) ? $data['ready_credit_product'] : null;
        $this->container['unsecured_loan_product'] = isset($data['unsecured_loan_product']) ? $data['unsecured_loan_product'] : null;
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
     * Gets credit_card_product
     *
     * @return \Swagger\Client\Model\ApplicationAddCreditCardProduct
     */
    public function getCreditCardProduct()
    {
        return $this->container['credit_card_product'];
    }

    /**
     * Sets credit_card_product
     *
     * @param \Swagger\Client\Model\ApplicationAddCreditCardProduct $credit_card_product credit_card_product
     *
     * @return $this
     */
    public function setCreditCardProduct($credit_card_product)
    {
        $this->container['credit_card_product'] = $credit_card_product;

        return $this;
    }

    /**
     * Gets ready_credit_product
     *
     * @return \Swagger\Client\Model\ApplicationAddReadyCreditProduct
     */
    public function getReadyCreditProduct()
    {
        return $this->container['ready_credit_product'];
    }

    /**
     * Sets ready_credit_product
     *
     * @param \Swagger\Client\Model\ApplicationAddReadyCreditProduct $ready_credit_product ready_credit_product
     *
     * @return $this
     */
    public function setReadyCreditProduct($ready_credit_product)
    {
        $this->container['ready_credit_product'] = $ready_credit_product;

        return $this;
    }

    /**
     * Gets unsecured_loan_product
     *
     * @return \Swagger\Client\Model\ApplicationAddUnsecuredLoanProduct
     */
    public function getUnsecuredLoanProduct()
    {
        return $this->container['unsecured_loan_product'];
    }

    /**
     * Sets unsecured_loan_product
     *
     * @param \Swagger\Client\Model\ApplicationAddUnsecuredLoanProduct $unsecured_loan_product unsecured_loan_product
     *
     * @return $this
     */
    public function setUnsecuredLoanProduct($unsecured_loan_product)
    {
        $this->container['unsecured_loan_product'] = $unsecured_loan_product;

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
