<?php
/**
 * SecuritiesBrokerageAccountSummary
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
 * SecuritiesBrokerageAccountSummary Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class SecuritiesBrokerageAccountSummary implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'SecuritiesBrokerageAccountSummary';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'product_name' => 'string',
'product_code' => 'string',
'account_nickname' => 'string',
'display_account_number' => 'string',
'account_id' => 'string',
'currency_code' => 'string',
'account_status' => 'string',
'account_classification' => 'string',
'current_balance' => 'double'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'product_name' => null,
'product_code' => null,
'account_nickname' => null,
'display_account_number' => null,
'account_id' => null,
'currency_code' => null,
'account_status' => null,
'account_classification' => null,
'current_balance' => 'double'    ];

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
        'product_name' => 'productName',
'product_code' => 'productCode',
'account_nickname' => 'accountNickname',
'display_account_number' => 'displayAccountNumber',
'account_id' => 'accountId',
'currency_code' => 'currencyCode',
'account_status' => 'accountStatus',
'account_classification' => 'accountClassification',
'current_balance' => 'currentBalance'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'product_name' => 'setProductName',
'product_code' => 'setProductCode',
'account_nickname' => 'setAccountNickname',
'display_account_number' => 'setDisplayAccountNumber',
'account_id' => 'setAccountId',
'currency_code' => 'setCurrencyCode',
'account_status' => 'setAccountStatus',
'account_classification' => 'setAccountClassification',
'current_balance' => 'setCurrentBalance'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'product_name' => 'getProductName',
'product_code' => 'getProductCode',
'account_nickname' => 'getAccountNickname',
'display_account_number' => 'getDisplayAccountNumber',
'account_id' => 'getAccountId',
'currency_code' => 'getCurrencyCode',
'account_status' => 'getAccountStatus',
'account_classification' => 'getAccountClassification',
'current_balance' => 'getCurrentBalance'    ];

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
        $this->container['product_name'] = isset($data['product_name']) ? $data['product_name'] : null;
        $this->container['product_code'] = isset($data['product_code']) ? $data['product_code'] : null;
        $this->container['account_nickname'] = isset($data['account_nickname']) ? $data['account_nickname'] : null;
        $this->container['display_account_number'] = isset($data['display_account_number']) ? $data['display_account_number'] : null;
        $this->container['account_id'] = isset($data['account_id']) ? $data['account_id'] : null;
        $this->container['currency_code'] = isset($data['currency_code']) ? $data['currency_code'] : null;
        $this->container['account_status'] = isset($data['account_status']) ? $data['account_status'] : null;
        $this->container['account_classification'] = isset($data['account_classification']) ? $data['account_classification'] : null;
        $this->container['current_balance'] = isset($data['current_balance']) ? $data['current_balance'] : null;
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
     * Gets product_name
     *
     * @return string
     */
    public function getProductName()
    {
        return $this->container['product_name'];
    }

    /**
     * Sets product_name
     *
     * @param string $product_name The name of the product
     *
     * @return $this
     */
    public function setProductName($product_name)
    {
        $this->container['product_name'] = $product_name;

        return $this;
    }

    /**
     * Gets product_code
     *
     * @return string
     */
    public function getProductCode()
    {
        return $this->container['product_code'];
    }

    /**
     * Sets product_code
     *
     * @param string $product_code A unique code that identifies the product
     *
     * @return $this
     */
    public function setProductCode($product_code)
    {
        $this->container['product_code'] = $product_code;

        return $this;
    }

    /**
     * Gets account_nickname
     *
     * @return string
     */
    public function getAccountNickname()
    {
        return $this->container['account_nickname'];
    }

    /**
     * Sets account_nickname
     *
     * @param string $account_nickname The nickname of the account assigned by the customer
     *
     * @return $this
     */
    public function setAccountNickname($account_nickname)
    {
        $this->container['account_nickname'] = $account_nickname;

        return $this;
    }

    /**
     * Gets display_account_number
     *
     * @return string
     */
    public function getDisplayAccountNumber()
    {
        return $this->container['display_account_number'];
    }

    /**
     * Sets display_account_number
     *
     * @param string $display_account_number A masked account number that can be displayed to the customer
     *
     * @return $this
     */
    public function setDisplayAccountNumber($display_account_number)
    {
        $this->container['display_account_number'] = $display_account_number;

        return $this;
    }

    /**
     * Gets account_id
     *
     * @return string
     */
    public function getAccountId()
    {
        return $this->container['account_id'];
    }

    /**
     * Sets account_id
     *
     * @param string $account_id The customer account identifier in encrypted format.
     *
     * @return $this
     */
    public function setAccountId($account_id)
    {
        $this->container['account_id'] = $account_id;

        return $this;
    }

    /**
     * Gets currency_code
     *
     * @return string
     */
    public function getCurrencyCode()
    {
        return $this->container['currency_code'];
    }

    /**
     * Sets currency_code
     *
     * @param string $currency_code The currency code in ISO 4217 format
     *
     * @return $this
     */
    public function setCurrencyCode($currency_code)
    {
        $this->container['currency_code'] = $currency_code;

        return $this;
    }

    /**
     * Gets account_status
     *
     * @return string
     */
    public function getAccountStatus()
    {
        return $this->container['account_status'];
    }

    /**
     * Sets account_status
     *
     * @param string $account_status Status of the account. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setAccountStatus($account_status)
    {
        $this->container['account_status'] = $account_status;

        return $this;
    }

    /**
     * Gets account_classification
     *
     * @return string
     */
    public function getAccountClassification()
    {
        return $this->container['account_classification'];
    }

    /**
     * Sets account_classification
     *
     * @param string $account_classification Classification of account either as ASSET or LIABILITY. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountClassification} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setAccountClassification($account_classification)
    {
        $this->container['account_classification'] = $account_classification;

        return $this;
    }

    /**
     * Gets current_balance
     *
     * @return double
     */
    public function getCurrentBalance()
    {
        return $this->container['current_balance'];
    }

    /**
     * Sets current_balance
     *
     * @param double $current_balance Total fund value for the Investment brokerage account. It is the current market worth of investment
     *
     * @return $this
     */
    public function setCurrentBalance($current_balance)
    {
        $this->container['current_balance'] = $current_balance;

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
