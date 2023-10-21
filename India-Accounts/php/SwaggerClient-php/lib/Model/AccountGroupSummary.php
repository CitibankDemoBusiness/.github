<?php
/**
 * AccountGroupSummary
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
 * AccountGroupSummary Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class AccountGroupSummary implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'AccountGroupSummary';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'account_group' => 'string',
'accounts' => '\Swagger\Client\Model\AccountSummary[]',
'insurance_policies' => '\Swagger\Client\Model\InsurancePolicySummary[]',
'total_current_balance' => '\Swagger\Client\Model\GroupBalance',
'total_available_balance' => '\Swagger\Client\Model\GroupBalance',
'total_outstanding_balance' => '\Swagger\Client\Model\GroupBalance'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'account_group' => null,
'accounts' => null,
'insurance_policies' => null,
'total_current_balance' => null,
'total_available_balance' => null,
'total_outstanding_balance' => null    ];

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
        'account_group' => 'accountGroup',
'accounts' => 'accounts',
'insurance_policies' => 'insurancePolicies',
'total_current_balance' => 'totalCurrentBalance',
'total_available_balance' => 'totalAvailableBalance',
'total_outstanding_balance' => 'totalOutstandingBalance'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'account_group' => 'setAccountGroup',
'accounts' => 'setAccounts',
'insurance_policies' => 'setInsurancePolicies',
'total_current_balance' => 'setTotalCurrentBalance',
'total_available_balance' => 'setTotalAvailableBalance',
'total_outstanding_balance' => 'setTotalOutstandingBalance'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'account_group' => 'getAccountGroup',
'accounts' => 'getAccounts',
'insurance_policies' => 'getInsurancePolicies',
'total_current_balance' => 'getTotalCurrentBalance',
'total_available_balance' => 'getTotalAvailableBalance',
'total_outstanding_balance' => 'getTotalOutstandingBalance'    ];

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
        $this->container['account_group'] = isset($data['account_group']) ? $data['account_group'] : null;
        $this->container['accounts'] = isset($data['accounts']) ? $data['accounts'] : null;
        $this->container['insurance_policies'] = isset($data['insurance_policies']) ? $data['insurance_policies'] : null;
        $this->container['total_current_balance'] = isset($data['total_current_balance']) ? $data['total_current_balance'] : null;
        $this->container['total_available_balance'] = isset($data['total_available_balance']) ? $data['total_available_balance'] : null;
        $this->container['total_outstanding_balance'] = isset($data['total_outstanding_balance']) ? $data['total_outstanding_balance'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if ($this->container['account_group'] === null) {
            $invalidProperties[] = "'account_group' can't be null";
        }
        if ($this->container['accounts'] === null) {
            $invalidProperties[] = "'accounts' can't be null";
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
     * Gets account_group
     *
     * @return string
     */
    public function getAccountGroup()
    {
        return $this->container['account_group'];
    }

    /**
     * Sets account_group
     *
     * @param string $account_group Account group is a classification of accounts according to their common characteristics. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountGroup} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setAccountGroup($account_group)
    {
        $this->container['account_group'] = $account_group;

        return $this;
    }

    /**
     * Gets accounts
     *
     * @return \Swagger\Client\Model\AccountSummary[]
     */
    public function getAccounts()
    {
        return $this->container['accounts'];
    }

    /**
     * Sets accounts
     *
     * @param \Swagger\Client\Model\AccountSummary[] $accounts Summarized list of each account type under a specific product group, held by customer
     *
     * @return $this
     */
    public function setAccounts($accounts)
    {
        $this->container['accounts'] = $accounts;

        return $this;
    }

    /**
     * Gets insurance_policies
     *
     * @return \Swagger\Client\Model\InsurancePolicySummary[]
     */
    public function getInsurancePolicies()
    {
        return $this->container['insurance_policies'];
    }

    /**
     * Sets insurance_policies
     *
     * @param \Swagger\Client\Model\InsurancePolicySummary[] $insurance_policies Summarized list of every insurance policy held by the customer.
     *
     * @return $this
     */
    public function setInsurancePolicies($insurance_policies)
    {
        $this->container['insurance_policies'] = $insurance_policies;

        return $this;
    }

    /**
     * Gets total_current_balance
     *
     * @return \Swagger\Client\Model\GroupBalance
     */
    public function getTotalCurrentBalance()
    {
        return $this->container['total_current_balance'];
    }

    /**
     * Sets total_current_balance
     *
     * @param \Swagger\Client\Model\GroupBalance $total_current_balance total_current_balance
     *
     * @return $this
     */
    public function setTotalCurrentBalance($total_current_balance)
    {
        $this->container['total_current_balance'] = $total_current_balance;

        return $this;
    }

    /**
     * Gets total_available_balance
     *
     * @return \Swagger\Client\Model\GroupBalance
     */
    public function getTotalAvailableBalance()
    {
        return $this->container['total_available_balance'];
    }

    /**
     * Sets total_available_balance
     *
     * @param \Swagger\Client\Model\GroupBalance $total_available_balance total_available_balance
     *
     * @return $this
     */
    public function setTotalAvailableBalance($total_available_balance)
    {
        $this->container['total_available_balance'] = $total_available_balance;

        return $this;
    }

    /**
     * Gets total_outstanding_balance
     *
     * @return \Swagger\Client\Model\GroupBalance
     */
    public function getTotalOutstandingBalance()
    {
        return $this->container['total_outstanding_balance'];
    }

    /**
     * Sets total_outstanding_balance
     *
     * @param \Swagger\Client\Model\GroupBalance $total_outstanding_balance total_outstanding_balance
     *
     * @return $this
     */
    public function setTotalOutstandingBalance($total_outstanding_balance)
    {
        $this->container['total_outstanding_balance'] = $total_outstanding_balance;

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
