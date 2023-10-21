<?php
/**
 * CreditCheckRequest
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
 * CreditCheckRequest Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class CreditCheckRequest implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'CreditCheckRequest';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'monthly_income' => 'double',
'total_monthly_secured_loan_repayment_amount' => 'double',
'total_monthly_unsecured_loan_repayment_amount' => 'double'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'monthly_income' => 'double',
'total_monthly_secured_loan_repayment_amount' => 'double',
'total_monthly_unsecured_loan_repayment_amount' => 'double'    ];

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
        'monthly_income' => 'monthlyIncome',
'total_monthly_secured_loan_repayment_amount' => 'totalMonthlySecuredLoanRepaymentAmount',
'total_monthly_unsecured_loan_repayment_amount' => 'totalMonthlyUnsecuredLoanRepaymentAmount'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'monthly_income' => 'setMonthlyIncome',
'total_monthly_secured_loan_repayment_amount' => 'setTotalMonthlySecuredLoanRepaymentAmount',
'total_monthly_unsecured_loan_repayment_amount' => 'setTotalMonthlyUnsecuredLoanRepaymentAmount'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'monthly_income' => 'getMonthlyIncome',
'total_monthly_secured_loan_repayment_amount' => 'getTotalMonthlySecuredLoanRepaymentAmount',
'total_monthly_unsecured_loan_repayment_amount' => 'getTotalMonthlyUnsecuredLoanRepaymentAmount'    ];

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
        $this->container['monthly_income'] = isset($data['monthly_income']) ? $data['monthly_income'] : null;
        $this->container['total_monthly_secured_loan_repayment_amount'] = isset($data['total_monthly_secured_loan_repayment_amount']) ? $data['total_monthly_secured_loan_repayment_amount'] : null;
        $this->container['total_monthly_unsecured_loan_repayment_amount'] = isset($data['total_monthly_unsecured_loan_repayment_amount']) ? $data['total_monthly_unsecured_loan_repayment_amount'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if ($this->container['monthly_income'] === null) {
            $invalidProperties[] = "'monthly_income' can't be null";
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
     * Gets monthly_income
     *
     * @return double
     */
    public function getMonthlyIncome()
    {
        return $this->container['monthly_income'];
    }

    /**
     * Sets monthly_income
     *
     * @param double $monthly_income This field is to indicate the monthly income of the customer.
     *
     * @return $this
     */
    public function setMonthlyIncome($monthly_income)
    {
        $this->container['monthly_income'] = $monthly_income;

        return $this;
    }

    /**
     * Gets total_monthly_secured_loan_repayment_amount
     *
     * @return double
     */
    public function getTotalMonthlySecuredLoanRepaymentAmount()
    {
        return $this->container['total_monthly_secured_loan_repayment_amount'];
    }

    /**
     * Sets total_monthly_secured_loan_repayment_amount
     *
     * @param double $total_monthly_secured_loan_repayment_amount Total monthly repayment amount outside of Citibank for mortgage installment, secured loans and all in-progress loan applications.
     *
     * @return $this
     */
    public function setTotalMonthlySecuredLoanRepaymentAmount($total_monthly_secured_loan_repayment_amount)
    {
        $this->container['total_monthly_secured_loan_repayment_amount'] = $total_monthly_secured_loan_repayment_amount;

        return $this;
    }

    /**
     * Gets total_monthly_unsecured_loan_repayment_amount
     *
     * @return double
     */
    public function getTotalMonthlyUnsecuredLoanRepaymentAmount()
    {
        return $this->container['total_monthly_unsecured_loan_repayment_amount'];
    }

    /**
     * Sets total_monthly_unsecured_loan_repayment_amount
     *
     * @param double $total_monthly_unsecured_loan_repayment_amount Total monthly repayment amount of unsecured loans in non-bank money lenders.
     *
     * @return $this
     */
    public function setTotalMonthlyUnsecuredLoanRepaymentAmount($total_monthly_unsecured_loan_repayment_amount)
    {
        $this->container['total_monthly_unsecured_loan_repayment_amount'] = $total_monthly_unsecured_loan_repayment_amount;

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
