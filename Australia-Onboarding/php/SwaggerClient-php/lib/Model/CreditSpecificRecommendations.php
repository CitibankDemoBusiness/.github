<?php
/**
 * CreditSpecificRecommendations
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
 * CreditSpecificRecommendations Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class CreditSpecificRecommendations implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'CreditSpecificRecommendations';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'recommended_credit_limit' => 'double',
'bt_maximum_loan_percentage' => 'double',
'bt_monthly_interest_rate' => 'double',
'epp_maximum_loan_percentage' => 'double',
'epp_monthly_interest_rate' => 'double',
'bt_campaign_id' => 'string',
'epp_promo_id' => 'string'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'recommended_credit_limit' => 'double',
'bt_maximum_loan_percentage' => 'double',
'bt_monthly_interest_rate' => 'double',
'epp_maximum_loan_percentage' => 'double',
'epp_monthly_interest_rate' => 'double',
'bt_campaign_id' => null,
'epp_promo_id' => null    ];

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
        'recommended_credit_limit' => 'recommendedCreditLimit',
'bt_maximum_loan_percentage' => 'btMaximumLoanPercentage',
'bt_monthly_interest_rate' => 'btMonthlyInterestRate',
'epp_maximum_loan_percentage' => 'eppMaximumLoanPercentage',
'epp_monthly_interest_rate' => 'eppMonthlyInterestRate',
'bt_campaign_id' => 'btCampaignId',
'epp_promo_id' => 'eppPromoId'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'recommended_credit_limit' => 'setRecommendedCreditLimit',
'bt_maximum_loan_percentage' => 'setBtMaximumLoanPercentage',
'bt_monthly_interest_rate' => 'setBtMonthlyInterestRate',
'epp_maximum_loan_percentage' => 'setEppMaximumLoanPercentage',
'epp_monthly_interest_rate' => 'setEppMonthlyInterestRate',
'bt_campaign_id' => 'setBtCampaignId',
'epp_promo_id' => 'setEppPromoId'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'recommended_credit_limit' => 'getRecommendedCreditLimit',
'bt_maximum_loan_percentage' => 'getBtMaximumLoanPercentage',
'bt_monthly_interest_rate' => 'getBtMonthlyInterestRate',
'epp_maximum_loan_percentage' => 'getEppMaximumLoanPercentage',
'epp_monthly_interest_rate' => 'getEppMonthlyInterestRate',
'bt_campaign_id' => 'getBtCampaignId',
'epp_promo_id' => 'getEppPromoId'    ];

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
        $this->container['recommended_credit_limit'] = isset($data['recommended_credit_limit']) ? $data['recommended_credit_limit'] : null;
        $this->container['bt_maximum_loan_percentage'] = isset($data['bt_maximum_loan_percentage']) ? $data['bt_maximum_loan_percentage'] : null;
        $this->container['bt_monthly_interest_rate'] = isset($data['bt_monthly_interest_rate']) ? $data['bt_monthly_interest_rate'] : null;
        $this->container['epp_maximum_loan_percentage'] = isset($data['epp_maximum_loan_percentage']) ? $data['epp_maximum_loan_percentage'] : null;
        $this->container['epp_monthly_interest_rate'] = isset($data['epp_monthly_interest_rate']) ? $data['epp_monthly_interest_rate'] : null;
        $this->container['bt_campaign_id'] = isset($data['bt_campaign_id']) ? $data['bt_campaign_id'] : null;
        $this->container['epp_promo_id'] = isset($data['epp_promo_id']) ? $data['epp_promo_id'] : null;
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
     * Gets recommended_credit_limit
     *
     * @return double
     */
    public function getRecommendedCreditLimit()
    {
        return $this->container['recommended_credit_limit'];
    }

    /**
     * Sets recommended_credit_limit
     *
     * @param double $recommended_credit_limit Eligible Credit limit
     *
     * @return $this
     */
    public function setRecommendedCreditLimit($recommended_credit_limit)
    {
        $this->container['recommended_credit_limit'] = $recommended_credit_limit;

        return $this;
    }

    /**
     * Gets bt_maximum_loan_percentage
     *
     * @return double
     */
    public function getBtMaximumLoanPercentage()
    {
        return $this->container['bt_maximum_loan_percentage'];
    }

    /**
     * Sets bt_maximum_loan_percentage
     *
     * @param double $bt_maximum_loan_percentage Balance transfer maximum loan percentage. Applicable to Counter and Cross-sell offers
     *
     * @return $this
     */
    public function setBtMaximumLoanPercentage($bt_maximum_loan_percentage)
    {
        $this->container['bt_maximum_loan_percentage'] = $bt_maximum_loan_percentage;

        return $this;
    }

    /**
     * Gets bt_monthly_interest_rate
     *
     * @return double
     */
    public function getBtMonthlyInterestRate()
    {
        return $this->container['bt_monthly_interest_rate'];
    }

    /**
     * Sets bt_monthly_interest_rate
     *
     * @param double $bt_monthly_interest_rate Balance transfer monthly interest rate. Applicable to Counter and Cross-sell offers
     *
     * @return $this
     */
    public function setBtMonthlyInterestRate($bt_monthly_interest_rate)
    {
        $this->container['bt_monthly_interest_rate'] = $bt_monthly_interest_rate;

        return $this;
    }

    /**
     * Gets epp_maximum_loan_percentage
     *
     * @return double
     */
    public function getEppMaximumLoanPercentage()
    {
        return $this->container['epp_maximum_loan_percentage'];
    }

    /**
     * Sets epp_maximum_loan_percentage
     *
     * @param double $epp_maximum_loan_percentage EPP(Equal Payment Plan) Max loan percentage. Applicable to counter and cross-sell offers.
     *
     * @return $this
     */
    public function setEppMaximumLoanPercentage($epp_maximum_loan_percentage)
    {
        $this->container['epp_maximum_loan_percentage'] = $epp_maximum_loan_percentage;

        return $this;
    }

    /**
     * Gets epp_monthly_interest_rate
     *
     * @return double
     */
    public function getEppMonthlyInterestRate()
    {
        return $this->container['epp_monthly_interest_rate'];
    }

    /**
     * Sets epp_monthly_interest_rate
     *
     * @param double $epp_monthly_interest_rate Equal payment plan monthly interest rate. Applicable to counter and cross-sell offers
     *
     * @return $this
     */
    public function setEppMonthlyInterestRate($epp_monthly_interest_rate)
    {
        $this->container['epp_monthly_interest_rate'] = $epp_monthly_interest_rate;

        return $this;
    }

    /**
     * Gets bt_campaign_id
     *
     * @return string
     */
    public function getBtCampaignId()
    {
        return $this->container['bt_campaign_id'];
    }

    /**
     * Sets bt_campaign_id
     *
     * @param string $bt_campaign_id Balance transfer campaignId. Applicable to counter and cross-sell offers.
     *
     * @return $this
     */
    public function setBtCampaignId($bt_campaign_id)
    {
        $this->container['bt_campaign_id'] = $bt_campaign_id;

        return $this;
    }

    /**
     * Gets epp_promo_id
     *
     * @return string
     */
    public function getEppPromoId()
    {
        return $this->container['epp_promo_id'];
    }

    /**
     * Sets epp_promo_id
     *
     * @param string $epp_promo_id PromoId of equal payment plan. Applicable for ready credit, Counter and cross-sell offers
     *
     * @return $this
     */
    public function setEppPromoId($epp_promo_id)
    {
        $this->container['epp_promo_id'] = $epp_promo_id;

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
