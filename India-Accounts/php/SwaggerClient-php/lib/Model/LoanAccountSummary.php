<?php
/**
 * LoanAccountSummary
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
 * LoanAccountSummary Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class LoanAccountSummary implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'LoanAccountSummary';

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
'account_classification' => 'string',
'account_status' => 'string',
'original_principal_amount' => 'double',
'outstanding_balance' => 'double',
'next_payment_amount' => 'double',
'next_payment_date' => '\DateTime'    ];

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
'account_classification' => null,
'account_status' => null,
'original_principal_amount' => 'double',
'outstanding_balance' => 'double',
'next_payment_amount' => 'double',
'next_payment_date' => 'date'    ];

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
'account_classification' => 'accountClassification',
'account_status' => 'accountStatus',
'original_principal_amount' => 'originalPrincipalAmount',
'outstanding_balance' => 'outstandingBalance',
'next_payment_amount' => 'nextPaymentAmount',
'next_payment_date' => 'nextPaymentDate'    ];

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
'account_classification' => 'setAccountClassification',
'account_status' => 'setAccountStatus',
'original_principal_amount' => 'setOriginalPrincipalAmount',
'outstanding_balance' => 'setOutstandingBalance',
'next_payment_amount' => 'setNextPaymentAmount',
'next_payment_date' => 'setNextPaymentDate'    ];

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
'account_classification' => 'getAccountClassification',
'account_status' => 'getAccountStatus',
'original_principal_amount' => 'getOriginalPrincipalAmount',
'outstanding_balance' => 'getOutstandingBalance',
'next_payment_amount' => 'getNextPaymentAmount',
'next_payment_date' => 'getNextPaymentDate'    ];

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
        $this->container['account_classification'] = isset($data['account_classification']) ? $data['account_classification'] : null;
        $this->container['account_status'] = isset($data['account_status']) ? $data['account_status'] : null;
        $this->container['original_principal_amount'] = isset($data['original_principal_amount']) ? $data['original_principal_amount'] : null;
        $this->container['outstanding_balance'] = isset($data['outstanding_balance']) ? $data['outstanding_balance'] : null;
        $this->container['next_payment_amount'] = isset($data['next_payment_amount']) ? $data['next_payment_amount'] : null;
        $this->container['next_payment_date'] = isset($data['next_payment_date']) ? $data['next_payment_date'] : null;
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
     * Gets original_principal_amount
     *
     * @return double
     */
    public function getOriginalPrincipalAmount()
    {
        return $this->container['original_principal_amount'];
    }

    /**
     * Sets original_principal_amount
     *
     * @param double $original_principal_amount The amount borrowed
     *
     * @return $this
     */
    public function setOriginalPrincipalAmount($original_principal_amount)
    {
        $this->container['original_principal_amount'] = $original_principal_amount;

        return $this;
    }

    /**
     * Gets outstanding_balance
     *
     * @return double
     */
    public function getOutstandingBalance()
    {
        return $this->container['outstanding_balance'];
    }

    /**
     * Sets outstanding_balance
     *
     * @param double $outstanding_balance The amount of money owed.
     *
     * @return $this
     */
    public function setOutstandingBalance($outstanding_balance)
    {
        $this->container['outstanding_balance'] = $outstanding_balance;

        return $this;
    }

    /**
     * Gets next_payment_amount
     *
     * @return double
     */
    public function getNextPaymentAmount()
    {
        return $this->container['next_payment_amount'];
    }

    /**
     * Sets next_payment_amount
     *
     * @param double $next_payment_amount The next payment amount due
     *
     * @return $this
     */
    public function setNextPaymentAmount($next_payment_amount)
    {
        $this->container['next_payment_amount'] = $next_payment_amount;

        return $this;
    }

    /**
     * Gets next_payment_date
     *
     * @return \DateTime
     */
    public function getNextPaymentDate()
    {
        return $this->container['next_payment_date'];
    }

    /**
     * Sets next_payment_date
     *
     * @param \DateTime $next_payment_date The date of the next payment in ISO 8601 date format YYYY-MM-DD
     *
     * @return $this
     */
    public function setNextPaymentDate($next_payment_date)
    {
        $this->container['next_payment_date'] = $next_payment_date;

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