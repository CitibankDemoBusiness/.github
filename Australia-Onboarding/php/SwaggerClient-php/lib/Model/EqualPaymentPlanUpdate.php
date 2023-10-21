<?php
/**
 * EqualPaymentPlanUpdate
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
 * EqualPaymentPlanUpdate Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class EqualPaymentPlanUpdate implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'EqualPaymentPlanUpdate';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'tenor' => 'string',
'bank_code' => 'string',
'amount_to_transfer' => 'double',
'account_name' => 'string',
'campaign_code' => 'string',
'disbursement_type' => 'string',
'account_number' => 'string'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'tenor' => null,
'bank_code' => null,
'amount_to_transfer' => 'double',
'account_name' => null,
'campaign_code' => null,
'disbursement_type' => null,
'account_number' => null    ];

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
        'tenor' => 'tenor',
'bank_code' => 'bankCode',
'amount_to_transfer' => 'amountToTransfer',
'account_name' => 'accountName',
'campaign_code' => 'campaignCode',
'disbursement_type' => 'disbursementType',
'account_number' => 'accountNumber'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'tenor' => 'setTenor',
'bank_code' => 'setBankCode',
'amount_to_transfer' => 'setAmountToTransfer',
'account_name' => 'setAccountName',
'campaign_code' => 'setCampaignCode',
'disbursement_type' => 'setDisbursementType',
'account_number' => 'setAccountNumber'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'tenor' => 'getTenor',
'bank_code' => 'getBankCode',
'amount_to_transfer' => 'getAmountToTransfer',
'account_name' => 'getAccountName',
'campaign_code' => 'getCampaignCode',
'disbursement_type' => 'getDisbursementType',
'account_number' => 'getAccountNumber'    ];

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
        $this->container['tenor'] = isset($data['tenor']) ? $data['tenor'] : null;
        $this->container['bank_code'] = isset($data['bank_code']) ? $data['bank_code'] : null;
        $this->container['amount_to_transfer'] = isset($data['amount_to_transfer']) ? $data['amount_to_transfer'] : null;
        $this->container['account_name'] = isset($data['account_name']) ? $data['account_name'] : null;
        $this->container['campaign_code'] = isset($data['campaign_code']) ? $data['campaign_code'] : null;
        $this->container['disbursement_type'] = isset($data['disbursement_type']) ? $data['disbursement_type'] : null;
        $this->container['account_number'] = isset($data['account_number']) ? $data['account_number'] : null;
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
     * Gets tenor
     *
     * @return string
     */
    public function getTenor()
    {
        return $this->container['tenor'];
    }

    /**
     * Sets tenor
     *
     * @param string $tenor Tenure of loan. This is a reference data field. Please use /v1/utilities/referenceData/{tenor} resource to get valid value of this field with description.
     *
     * @return $this
     */
    public function setTenor($tenor)
    {
        $this->container['tenor'] = $tenor;

        return $this;
    }

    /**
     * Gets bank_code
     *
     * @return string
     */
    public function getBankCode()
    {
        return $this->container['bank_code'];
    }

    /**
     * Sets bank_code
     *
     * @param string $bank_code This field is to indicate the bank code to which the amount will be disbursed.
     *
     * @return $this
     */
    public function setBankCode($bank_code)
    {
        $this->container['bank_code'] = $bank_code;

        return $this;
    }

    /**
     * Gets amount_to_transfer
     *
     * @return double
     */
    public function getAmountToTransfer()
    {
        return $this->container['amount_to_transfer'];
    }

    /**
     * Sets amount_to_transfer
     *
     * @param double $amount_to_transfer Amount to Transfer
     *
     * @return $this
     */
    public function setAmountToTransfer($amount_to_transfer)
    {
        $this->container['amount_to_transfer'] = $amount_to_transfer;

        return $this;
    }

    /**
     * Gets account_name
     *
     * @return string
     */
    public function getAccountName()
    {
        return $this->container['account_name'];
    }

    /**
     * Sets account_name
     *
     * @param string $account_name Account name to which the amount will be disbursed
     *
     * @return $this
     */
    public function setAccountName($account_name)
    {
        $this->container['account_name'] = $account_name;

        return $this;
    }

    /**
     * Gets campaign_code
     *
     * @return string
     */
    public function getCampaignCode()
    {
        return $this->container['campaign_code'];
    }

    /**
     * Sets campaign_code
     *
     * @param string $campaign_code Code of the campaign offered to the channel.
     *
     * @return $this
     */
    public function setCampaignCode($campaign_code)
    {
        $this->container['campaign_code'] = $campaign_code;

        return $this;
    }

    /**
     * Gets disbursement_type
     *
     * @return string
     */
    public function getDisbursementType()
    {
        return $this->container['disbursement_type'];
    }

    /**
     * Sets disbursement_type
     *
     * @param string $disbursement_type DisbursementType . This is a reference data field. Please use /v1/utilities/referenceData/{DisbursementOptionGCG} resource to get valid value of this field with description.
     *
     * @return $this
     */
    public function setDisbursementType($disbursement_type)
    {
        $this->container['disbursement_type'] = $disbursement_type;

        return $this;
    }

    /**
     * Gets account_number
     *
     * @return string
     */
    public function getAccountNumber()
    {
        return $this->container['account_number'];
    }

    /**
     * Sets account_number
     *
     * @param string $account_number Account number or reference to which the amount will be disbursed
     *
     * @return $this
     */
    public function setAccountNumber($account_number)
    {
        $this->container['account_number'] = $account_number;

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
