<?php
/**
 * AccountBalancesSummaryInquiryResponse
 *
 * PHP version 5
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
 * Accounts
 *
 * The Accounts API allows you to retrieve account and transaction data for Citi Customers who have authorized your app. In most cases, you'll want to request a summary of all accounts first, which will return basic account information and accountIds. Once you have this information, you can request additional account details and/or transactions.
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
 * AccountBalancesSummaryInquiryResponse Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class AccountBalancesSummaryInquiryResponse implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'AccountBalancesSummaryInquiryResponse';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'credit_card_account_balance_summary' => '\Swagger\Client\Model\CreditCardAccountBalanceSummary',
'ready_credit_account_balance_summary' => '\Swagger\Client\Model\ReadyCreditAccountBalanceSummary'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'credit_card_account_balance_summary' => null,
'ready_credit_account_balance_summary' => null    ];

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
        'credit_card_account_balance_summary' => 'creditCardAccountBalanceSummary',
'ready_credit_account_balance_summary' => 'readyCreditAccountBalanceSummary'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'credit_card_account_balance_summary' => 'setCreditCardAccountBalanceSummary',
'ready_credit_account_balance_summary' => 'setReadyCreditAccountBalanceSummary'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'credit_card_account_balance_summary' => 'getCreditCardAccountBalanceSummary',
'ready_credit_account_balance_summary' => 'getReadyCreditAccountBalanceSummary'    ];

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
        $this->container['credit_card_account_balance_summary'] = isset($data['credit_card_account_balance_summary']) ? $data['credit_card_account_balance_summary'] : null;
        $this->container['ready_credit_account_balance_summary'] = isset($data['ready_credit_account_balance_summary']) ? $data['ready_credit_account_balance_summary'] : null;
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
     * Gets credit_card_account_balance_summary
     *
     * @return \Swagger\Client\Model\CreditCardAccountBalanceSummary
     */
    public function getCreditCardAccountBalanceSummary()
    {
        return $this->container['credit_card_account_balance_summary'];
    }

    /**
     * Sets credit_card_account_balance_summary
     *
     * @param \Swagger\Client\Model\CreditCardAccountBalanceSummary $credit_card_account_balance_summary credit_card_account_balance_summary
     *
     * @return $this
     */
    public function setCreditCardAccountBalanceSummary($credit_card_account_balance_summary)
    {
        $this->container['credit_card_account_balance_summary'] = $credit_card_account_balance_summary;

        return $this;
    }

    /**
     * Gets ready_credit_account_balance_summary
     *
     * @return \Swagger\Client\Model\ReadyCreditAccountBalanceSummary
     */
    public function getReadyCreditAccountBalanceSummary()
    {
        return $this->container['ready_credit_account_balance_summary'];
    }

    /**
     * Sets ready_credit_account_balance_summary
     *
     * @param \Swagger\Client\Model\ReadyCreditAccountBalanceSummary $ready_credit_account_balance_summary ready_credit_account_balance_summary
     *
     * @return $this
     */
    public function setReadyCreditAccountBalanceSummary($ready_credit_account_balance_summary)
    {
        $this->container['ready_credit_account_balance_summary'] = $ready_credit_account_balance_summary;

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