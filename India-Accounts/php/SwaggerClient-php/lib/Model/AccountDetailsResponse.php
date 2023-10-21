<?php
/**
 * AccountDetailsResponse
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
 * AccountDetailsResponse Class Doc Comment
 *
 * @category Class
 * @description Detailed account information
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class AccountDetailsResponse implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'AccountDetailsResponse';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'credit_card_account' => '\Swagger\Client\Model\CreditCardAccount',
'ready_credit_account' => '\Swagger\Client\Model\ReadyCreditAccount',
'checking_account' => '\Swagger\Client\Model\CheckingAccount',
'savings_account' => '\Swagger\Client\Model\SavingsAccount',
'time_deposit_account' => '\Swagger\Client\Model\TimeDepositAccount',
'loan_account' => '\Swagger\Client\Model\LoanAccount',
'mutual_fund_account' => '\Swagger\Client\Model\MutualFundAccount',
'securities_brokerage_account' => '\Swagger\Client\Model\SecuritiesBrokerageAccount',
'call_deposit_account' => '\Swagger\Client\Model\CallDepositAccount',
'premium_deposit_account' => '\Swagger\Client\Model\PremiumDepositAccount'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'credit_card_account' => null,
'ready_credit_account' => null,
'checking_account' => null,
'savings_account' => null,
'time_deposit_account' => null,
'loan_account' => null,
'mutual_fund_account' => null,
'securities_brokerage_account' => null,
'call_deposit_account' => null,
'premium_deposit_account' => null    ];

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
        'credit_card_account' => 'creditCardAccount',
'ready_credit_account' => 'readyCreditAccount',
'checking_account' => 'checkingAccount',
'savings_account' => 'savingsAccount',
'time_deposit_account' => 'timeDepositAccount',
'loan_account' => 'loanAccount',
'mutual_fund_account' => 'mutualFundAccount',
'securities_brokerage_account' => 'securitiesBrokerageAccount',
'call_deposit_account' => 'callDepositAccount',
'premium_deposit_account' => 'premiumDepositAccount'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'credit_card_account' => 'setCreditCardAccount',
'ready_credit_account' => 'setReadyCreditAccount',
'checking_account' => 'setCheckingAccount',
'savings_account' => 'setSavingsAccount',
'time_deposit_account' => 'setTimeDepositAccount',
'loan_account' => 'setLoanAccount',
'mutual_fund_account' => 'setMutualFundAccount',
'securities_brokerage_account' => 'setSecuritiesBrokerageAccount',
'call_deposit_account' => 'setCallDepositAccount',
'premium_deposit_account' => 'setPremiumDepositAccount'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'credit_card_account' => 'getCreditCardAccount',
'ready_credit_account' => 'getReadyCreditAccount',
'checking_account' => 'getCheckingAccount',
'savings_account' => 'getSavingsAccount',
'time_deposit_account' => 'getTimeDepositAccount',
'loan_account' => 'getLoanAccount',
'mutual_fund_account' => 'getMutualFundAccount',
'securities_brokerage_account' => 'getSecuritiesBrokerageAccount',
'call_deposit_account' => 'getCallDepositAccount',
'premium_deposit_account' => 'getPremiumDepositAccount'    ];

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
        $this->container['credit_card_account'] = isset($data['credit_card_account']) ? $data['credit_card_account'] : null;
        $this->container['ready_credit_account'] = isset($data['ready_credit_account']) ? $data['ready_credit_account'] : null;
        $this->container['checking_account'] = isset($data['checking_account']) ? $data['checking_account'] : null;
        $this->container['savings_account'] = isset($data['savings_account']) ? $data['savings_account'] : null;
        $this->container['time_deposit_account'] = isset($data['time_deposit_account']) ? $data['time_deposit_account'] : null;
        $this->container['loan_account'] = isset($data['loan_account']) ? $data['loan_account'] : null;
        $this->container['mutual_fund_account'] = isset($data['mutual_fund_account']) ? $data['mutual_fund_account'] : null;
        $this->container['securities_brokerage_account'] = isset($data['securities_brokerage_account']) ? $data['securities_brokerage_account'] : null;
        $this->container['call_deposit_account'] = isset($data['call_deposit_account']) ? $data['call_deposit_account'] : null;
        $this->container['premium_deposit_account'] = isset($data['premium_deposit_account']) ? $data['premium_deposit_account'] : null;
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
     * Gets credit_card_account
     *
     * @return \Swagger\Client\Model\CreditCardAccount
     */
    public function getCreditCardAccount()
    {
        return $this->container['credit_card_account'];
    }

    /**
     * Sets credit_card_account
     *
     * @param \Swagger\Client\Model\CreditCardAccount $credit_card_account credit_card_account
     *
     * @return $this
     */
    public function setCreditCardAccount($credit_card_account)
    {
        $this->container['credit_card_account'] = $credit_card_account;

        return $this;
    }

    /**
     * Gets ready_credit_account
     *
     * @return \Swagger\Client\Model\ReadyCreditAccount
     */
    public function getReadyCreditAccount()
    {
        return $this->container['ready_credit_account'];
    }

    /**
     * Sets ready_credit_account
     *
     * @param \Swagger\Client\Model\ReadyCreditAccount $ready_credit_account ready_credit_account
     *
     * @return $this
     */
    public function setReadyCreditAccount($ready_credit_account)
    {
        $this->container['ready_credit_account'] = $ready_credit_account;

        return $this;
    }

    /**
     * Gets checking_account
     *
     * @return \Swagger\Client\Model\CheckingAccount
     */
    public function getCheckingAccount()
    {
        return $this->container['checking_account'];
    }

    /**
     * Sets checking_account
     *
     * @param \Swagger\Client\Model\CheckingAccount $checking_account checking_account
     *
     * @return $this
     */
    public function setCheckingAccount($checking_account)
    {
        $this->container['checking_account'] = $checking_account;

        return $this;
    }

    /**
     * Gets savings_account
     *
     * @return \Swagger\Client\Model\SavingsAccount
     */
    public function getSavingsAccount()
    {
        return $this->container['savings_account'];
    }

    /**
     * Sets savings_account
     *
     * @param \Swagger\Client\Model\SavingsAccount $savings_account savings_account
     *
     * @return $this
     */
    public function setSavingsAccount($savings_account)
    {
        $this->container['savings_account'] = $savings_account;

        return $this;
    }

    /**
     * Gets time_deposit_account
     *
     * @return \Swagger\Client\Model\TimeDepositAccount
     */
    public function getTimeDepositAccount()
    {
        return $this->container['time_deposit_account'];
    }

    /**
     * Sets time_deposit_account
     *
     * @param \Swagger\Client\Model\TimeDepositAccount $time_deposit_account time_deposit_account
     *
     * @return $this
     */
    public function setTimeDepositAccount($time_deposit_account)
    {
        $this->container['time_deposit_account'] = $time_deposit_account;

        return $this;
    }

    /**
     * Gets loan_account
     *
     * @return \Swagger\Client\Model\LoanAccount
     */
    public function getLoanAccount()
    {
        return $this->container['loan_account'];
    }

    /**
     * Sets loan_account
     *
     * @param \Swagger\Client\Model\LoanAccount $loan_account loan_account
     *
     * @return $this
     */
    public function setLoanAccount($loan_account)
    {
        $this->container['loan_account'] = $loan_account;

        return $this;
    }

    /**
     * Gets mutual_fund_account
     *
     * @return \Swagger\Client\Model\MutualFundAccount
     */
    public function getMutualFundAccount()
    {
        return $this->container['mutual_fund_account'];
    }

    /**
     * Sets mutual_fund_account
     *
     * @param \Swagger\Client\Model\MutualFundAccount $mutual_fund_account mutual_fund_account
     *
     * @return $this
     */
    public function setMutualFundAccount($mutual_fund_account)
    {
        $this->container['mutual_fund_account'] = $mutual_fund_account;

        return $this;
    }

    /**
     * Gets securities_brokerage_account
     *
     * @return \Swagger\Client\Model\SecuritiesBrokerageAccount
     */
    public function getSecuritiesBrokerageAccount()
    {
        return $this->container['securities_brokerage_account'];
    }

    /**
     * Sets securities_brokerage_account
     *
     * @param \Swagger\Client\Model\SecuritiesBrokerageAccount $securities_brokerage_account securities_brokerage_account
     *
     * @return $this
     */
    public function setSecuritiesBrokerageAccount($securities_brokerage_account)
    {
        $this->container['securities_brokerage_account'] = $securities_brokerage_account;

        return $this;
    }

    /**
     * Gets call_deposit_account
     *
     * @return \Swagger\Client\Model\CallDepositAccount
     */
    public function getCallDepositAccount()
    {
        return $this->container['call_deposit_account'];
    }

    /**
     * Sets call_deposit_account
     *
     * @param \Swagger\Client\Model\CallDepositAccount $call_deposit_account call_deposit_account
     *
     * @return $this
     */
    public function setCallDepositAccount($call_deposit_account)
    {
        $this->container['call_deposit_account'] = $call_deposit_account;

        return $this;
    }

    /**
     * Gets premium_deposit_account
     *
     * @return \Swagger\Client\Model\PremiumDepositAccount
     */
    public function getPremiumDepositAccount()
    {
        return $this->container['premium_deposit_account'];
    }

    /**
     * Sets premium_deposit_account
     *
     * @param \Swagger\Client\Model\PremiumDepositAccount $premium_deposit_account premium_deposit_account
     *
     * @return $this
     */
    public function setPremiumDepositAccount($premium_deposit_account)
    {
        $this->container['premium_deposit_account'] = $premium_deposit_account;

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
