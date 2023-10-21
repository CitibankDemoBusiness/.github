<?php
/**
 * ApplicationUpdateCreditCardProduct
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
 * ApplicationUpdateCreditCardProduct Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class ApplicationUpdateCreditCardProduct implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'ApplicationUpdateCreditCardProduct';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'product_code' => 'string',
'source_code' => 'string',
'organization' => 'string',
'logo' => 'string',
'request_credit_shield' => 'bool',
'emboss_name' => 'string',
'billing_address' => 'string',
'card_delivery_address' => 'string',
'pin_delivery_address' => 'string',
'gift_code' => 'string',
'credit_limit_increase_indicator' => 'bool',
'balance_transfer_details' => '\Swagger\Client\Model\ApplicationUpdateBalanceTransferDetails[]'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'product_code' => null,
'source_code' => null,
'organization' => null,
'logo' => null,
'request_credit_shield' => null,
'emboss_name' => null,
'billing_address' => null,
'card_delivery_address' => null,
'pin_delivery_address' => null,
'gift_code' => null,
'credit_limit_increase_indicator' => null,
'balance_transfer_details' => null    ];

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
        'product_code' => 'productCode',
'source_code' => 'sourceCode',
'organization' => 'organization',
'logo' => 'logo',
'request_credit_shield' => 'requestCreditShield',
'emboss_name' => 'embossName',
'billing_address' => 'billingAddress',
'card_delivery_address' => 'cardDeliveryAddress',
'pin_delivery_address' => 'pinDeliveryAddress',
'gift_code' => 'giftCode',
'credit_limit_increase_indicator' => 'creditLimitIncreaseIndicator',
'balance_transfer_details' => 'balanceTransferDetails'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'product_code' => 'setProductCode',
'source_code' => 'setSourceCode',
'organization' => 'setOrganization',
'logo' => 'setLogo',
'request_credit_shield' => 'setRequestCreditShield',
'emboss_name' => 'setEmbossName',
'billing_address' => 'setBillingAddress',
'card_delivery_address' => 'setCardDeliveryAddress',
'pin_delivery_address' => 'setPinDeliveryAddress',
'gift_code' => 'setGiftCode',
'credit_limit_increase_indicator' => 'setCreditLimitIncreaseIndicator',
'balance_transfer_details' => 'setBalanceTransferDetails'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'product_code' => 'getProductCode',
'source_code' => 'getSourceCode',
'organization' => 'getOrganization',
'logo' => 'getLogo',
'request_credit_shield' => 'getRequestCreditShield',
'emboss_name' => 'getEmbossName',
'billing_address' => 'getBillingAddress',
'card_delivery_address' => 'getCardDeliveryAddress',
'pin_delivery_address' => 'getPinDeliveryAddress',
'gift_code' => 'getGiftCode',
'credit_limit_increase_indicator' => 'getCreditLimitIncreaseIndicator',
'balance_transfer_details' => 'getBalanceTransferDetails'    ];

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
        $this->container['product_code'] = isset($data['product_code']) ? $data['product_code'] : null;
        $this->container['source_code'] = isset($data['source_code']) ? $data['source_code'] : null;
        $this->container['organization'] = isset($data['organization']) ? $data['organization'] : null;
        $this->container['logo'] = isset($data['logo']) ? $data['logo'] : null;
        $this->container['request_credit_shield'] = isset($data['request_credit_shield']) ? $data['request_credit_shield'] : null;
        $this->container['emboss_name'] = isset($data['emboss_name']) ? $data['emboss_name'] : null;
        $this->container['billing_address'] = isset($data['billing_address']) ? $data['billing_address'] : null;
        $this->container['card_delivery_address'] = isset($data['card_delivery_address']) ? $data['card_delivery_address'] : null;
        $this->container['pin_delivery_address'] = isset($data['pin_delivery_address']) ? $data['pin_delivery_address'] : null;
        $this->container['gift_code'] = isset($data['gift_code']) ? $data['gift_code'] : null;
        $this->container['credit_limit_increase_indicator'] = isset($data['credit_limit_increase_indicator']) ? $data['credit_limit_increase_indicator'] : null;
        $this->container['balance_transfer_details'] = isset($data['balance_transfer_details']) ? $data['balance_transfer_details'] : null;
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
     * @param string $product_code A unique code that identifies the product.
     *
     * @return $this
     */
    public function setProductCode($product_code)
    {
        $this->container['product_code'] = $product_code;

        return $this;
    }

    /**
     * Gets source_code
     *
     * @return string
     */
    public function getSourceCode()
    {
        return $this->container['source_code'];
    }

    /**
     * Sets source_code
     *
     * @param string $source_code A source code to identify the product
     *
     * @return $this
     */
    public function setSourceCode($source_code)
    {
        $this->container['source_code'] = $source_code;

        return $this;
    }

    /**
     * Gets organization
     *
     * @return string
     */
    public function getOrganization()
    {
        return $this->container['organization'];
    }

    /**
     * Sets organization
     *
     * @param string $organization Card issuing organization name
     *
     * @return $this
     */
    public function setOrganization($organization)
    {
        $this->container['organization'] = $organization;

        return $this;
    }

    /**
     * Gets logo
     *
     * @return string
     */
    public function getLogo()
    {
        return $this->container['logo'];
    }

    /**
     * Sets logo
     *
     * @param string $logo Product logo to identify the product
     *
     * @return $this
     */
    public function setLogo($logo)
    {
        $this->container['logo'] = $logo;

        return $this;
    }

    /**
     * Gets request_credit_shield
     *
     * @return bool
     */
    public function getRequestCreditShield()
    {
        return $this->container['request_credit_shield'];
    }

    /**
     * Sets request_credit_shield
     *
     * @param bool $request_credit_shield Insurance enrolment for outstanding balance on the card. Valid values: true and false
     *
     * @return $this
     */
    public function setRequestCreditShield($request_credit_shield)
    {
        $this->container['request_credit_shield'] = $request_credit_shield;

        return $this;
    }

    /**
     * Gets emboss_name
     *
     * @return string
     */
    public function getEmbossName()
    {
        return $this->container['emboss_name'];
    }

    /**
     * Sets emboss_name
     *
     * @param string $emboss_name Name to be embossed on card.If blank, bank will assign automatically based on the market norms.
     *
     * @return $this
     */
    public function setEmbossName($emboss_name)
    {
        $this->container['emboss_name'] = $emboss_name;

        return $this;
    }

    /**
     * Gets billing_address
     *
     * @return string
     */
    public function getBillingAddress()
    {
        return $this->container['billing_address'];
    }

    /**
     * Sets billing_address
     *
     * @param string $billing_address Billing address of applicant. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setBillingAddress($billing_address)
    {
        $this->container['billing_address'] = $billing_address;

        return $this;
    }

    /**
     * Gets card_delivery_address
     *
     * @return string
     */
    public function getCardDeliveryAddress()
    {
        return $this->container['card_delivery_address'];
    }

    /**
     * Sets card_delivery_address
     *
     * @param string $card_delivery_address Card delivery address of applicant. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setCardDeliveryAddress($card_delivery_address)
    {
        $this->container['card_delivery_address'] = $card_delivery_address;

        return $this;
    }

    /**
     * Gets pin_delivery_address
     *
     * @return string
     */
    public function getPinDeliveryAddress()
    {
        return $this->container['pin_delivery_address'];
    }

    /**
     * Sets pin_delivery_address
     *
     * @param string $pin_delivery_address Delivery address  for card pin of applicant. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setPinDeliveryAddress($pin_delivery_address)
    {
        $this->container['pin_delivery_address'] = $pin_delivery_address;

        return $this;
    }

    /**
     * Gets gift_code
     *
     * @return string
     */
    public function getGiftCode()
    {
        return $this->container['gift_code'];
    }

    /**
     * Sets gift_code
     *
     * @param string $gift_code A  unique code that identifies the gift offered along with the product
     *
     * @return $this
     */
    public function setGiftCode($gift_code)
    {
        $this->container['gift_code'] = $gift_code;

        return $this;
    }

    /**
     * Gets credit_limit_increase_indicator
     *
     * @return bool
     */
    public function getCreditLimitIncreaseIndicator()
    {
        return $this->container['credit_limit_increase_indicator'];
    }

    /**
     * Sets credit_limit_increase_indicator
     *
     * @param bool $credit_limit_increase_indicator Option  to review the credit limit in the future.Valid values: true and false
     *
     * @return $this
     */
    public function setCreditLimitIncreaseIndicator($credit_limit_increase_indicator)
    {
        $this->container['credit_limit_increase_indicator'] = $credit_limit_increase_indicator;

        return $this;
    }

    /**
     * Gets balance_transfer_details
     *
     * @return \Swagger\Client\Model\ApplicationUpdateBalanceTransferDetails[]
     */
    public function getBalanceTransferDetails()
    {
        return $this->container['balance_transfer_details'];
    }

    /**
     * Sets balance_transfer_details
     *
     * @param \Swagger\Client\Model\ApplicationUpdateBalanceTransferDetails[] $balance_transfer_details balance_transfer_details
     *
     * @return $this
     */
    public function setBalanceTransferDetails($balance_transfer_details)
    {
        $this->container['balance_transfer_details'] = $balance_transfer_details;

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
