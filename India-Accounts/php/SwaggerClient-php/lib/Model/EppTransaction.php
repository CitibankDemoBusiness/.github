<?php
/**
 * EppTransaction
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
 * EppTransaction Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class EppTransaction implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'EppTransaction';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'reference_id' => 'string',
'installment_amount' => 'double',
'principal_amount' => 'double',
'installment_interest_amount' => 'double',
'initial_interest_amount' => 'double',
'statement_unpaid_balance_amount' => 'double'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'reference_id' => null,
'installment_amount' => 'double',
'principal_amount' => 'double',
'installment_interest_amount' => 'double',
'initial_interest_amount' => 'double',
'statement_unpaid_balance_amount' => 'double'    ];

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
        'reference_id' => 'referenceId',
'installment_amount' => 'installmentAmount',
'principal_amount' => 'principalAmount',
'installment_interest_amount' => 'installmentInterestAmount',
'initial_interest_amount' => 'initialInterestAmount',
'statement_unpaid_balance_amount' => 'statementUnpaidBalanceAmount'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'reference_id' => 'setReferenceId',
'installment_amount' => 'setInstallmentAmount',
'principal_amount' => 'setPrincipalAmount',
'installment_interest_amount' => 'setInstallmentInterestAmount',
'initial_interest_amount' => 'setInitialInterestAmount',
'statement_unpaid_balance_amount' => 'setStatementUnpaidBalanceAmount'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'reference_id' => 'getReferenceId',
'installment_amount' => 'getInstallmentAmount',
'principal_amount' => 'getPrincipalAmount',
'installment_interest_amount' => 'getInstallmentInterestAmount',
'initial_interest_amount' => 'getInitialInterestAmount',
'statement_unpaid_balance_amount' => 'getStatementUnpaidBalanceAmount'    ];

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
        $this->container['reference_id'] = isset($data['reference_id']) ? $data['reference_id'] : null;
        $this->container['installment_amount'] = isset($data['installment_amount']) ? $data['installment_amount'] : null;
        $this->container['principal_amount'] = isset($data['principal_amount']) ? $data['principal_amount'] : null;
        $this->container['installment_interest_amount'] = isset($data['installment_interest_amount']) ? $data['installment_interest_amount'] : null;
        $this->container['initial_interest_amount'] = isset($data['initial_interest_amount']) ? $data['initial_interest_amount'] : null;
        $this->container['statement_unpaid_balance_amount'] = isset($data['statement_unpaid_balance_amount']) ? $data['statement_unpaid_balance_amount'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if ($this->container['reference_id'] === null) {
            $invalidProperties[] = "'reference_id' can't be null";
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
     * Gets reference_id
     *
     * @return string
     */
    public function getReferenceId()
    {
        return $this->container['reference_id'];
    }

    /**
     * Sets reference_id
     *
     * @param string $reference_id Reference Id to uniquely identify the loan.
     *
     * @return $this
     */
    public function setReferenceId($reference_id)
    {
        $this->container['reference_id'] = $reference_id;

        return $this;
    }

    /**
     * Gets installment_amount
     *
     * @return double
     */
    public function getInstallmentAmount()
    {
        return $this->container['installment_amount'];
    }

    /**
     * Sets installment_amount
     *
     * @param double $installment_amount Installment amount to be paid by customer in order to repay the loan.
     *
     * @return $this
     */
    public function setInstallmentAmount($installment_amount)
    {
        $this->container['installment_amount'] = $installment_amount;

        return $this;
    }

    /**
     * Gets principal_amount
     *
     * @return double
     */
    public function getPrincipalAmount()
    {
        return $this->container['principal_amount'];
    }

    /**
     * Sets principal_amount
     *
     * @param double $principal_amount The portion of the Principal Amount Paid for the loan.
     *
     * @return $this
     */
    public function setPrincipalAmount($principal_amount)
    {
        $this->container['principal_amount'] = $principal_amount;

        return $this;
    }

    /**
     * Gets installment_interest_amount
     *
     * @return double
     */
    public function getInstallmentInterestAmount()
    {
        return $this->container['installment_interest_amount'];
    }

    /**
     * Sets installment_interest_amount
     *
     * @param double $installment_interest_amount The interest  amount to be paid as installment.
     *
     * @return $this
     */
    public function setInstallmentInterestAmount($installment_interest_amount)
    {
        $this->container['installment_interest_amount'] = $installment_interest_amount;

        return $this;
    }

    /**
     * Gets initial_interest_amount
     *
     * @return double
     */
    public function getInitialInterestAmount()
    {
        return $this->container['initial_interest_amount'];
    }

    /**
     * Sets initial_interest_amount
     *
     * @param double $initial_interest_amount Initial interest amount charged to customer from the epp booking date to the first installment start date
     *
     * @return $this
     */
    public function setInitialInterestAmount($initial_interest_amount)
    {
        $this->container['initial_interest_amount'] = $initial_interest_amount;

        return $this;
    }

    /**
     * Gets statement_unpaid_balance_amount
     *
     * @return double
     */
    public function getStatementUnpaidBalanceAmount()
    {
        return $this->container['statement_unpaid_balance_amount'];
    }

    /**
     * Sets statement_unpaid_balance_amount
     *
     * @param double $statement_unpaid_balance_amount This field indicates the remaining statement balance amount that remains due and payable.
     *
     * @return $this
     */
    public function setStatementUnpaidBalanceAmount($statement_unpaid_balance_amount)
    {
        $this->container['statement_unpaid_balance_amount'] = $statement_unpaid_balance_amount;

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