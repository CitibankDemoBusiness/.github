<?php
/**
 * CardDetails
 *
 * PHP version 5
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
 * Cards
 *
 * The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.
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
 * CardDetails Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class CardDetails implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'CardDetails';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'card_id' => 'string',
'display_card_number' => 'string',
'local_card_activation_indicator' => 'string',
'overseas_card_activation_indicator' => 'string',
'perpetual_activation_flag' => 'bool',
'overseas_card_activation_start_date' => '\DateTime',
'overseas_card_activation_end_date' => '\DateTime',
'current_credit_limit_amount' => 'double',
'maximum_permanent_credit_limit_amount' => 'double',
'maximum_temporary_credit_limit_amount' => 'double',
'sub_card_type' => 'string',
'card_holder_type' => 'string',
'card_issue_reason' => 'string',
'card_functions_allowed' => '\Swagger\Client\Model\CardFunctionsAllowed[]'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'card_id' => null,
'display_card_number' => null,
'local_card_activation_indicator' => null,
'overseas_card_activation_indicator' => null,
'perpetual_activation_flag' => null,
'overseas_card_activation_start_date' => 'date',
'overseas_card_activation_end_date' => 'date',
'current_credit_limit_amount' => 'double',
'maximum_permanent_credit_limit_amount' => 'double',
'maximum_temporary_credit_limit_amount' => 'double',
'sub_card_type' => null,
'card_holder_type' => null,
'card_issue_reason' => null,
'card_functions_allowed' => null    ];

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
        'card_id' => 'cardId',
'display_card_number' => 'displayCardNumber',
'local_card_activation_indicator' => 'localCardActivationIndicator',
'overseas_card_activation_indicator' => 'overseasCardActivationIndicator',
'perpetual_activation_flag' => 'perpetualActivationFlag',
'overseas_card_activation_start_date' => 'overseasCardActivationStartDate',
'overseas_card_activation_end_date' => 'overseasCardActivationEndDate',
'current_credit_limit_amount' => 'currentCreditLimitAmount',
'maximum_permanent_credit_limit_amount' => 'maximumPermanentCreditLimitAmount',
'maximum_temporary_credit_limit_amount' => 'maximumTemporaryCreditLimitAmount',
'sub_card_type' => 'subCardType',
'card_holder_type' => 'cardHolderType',
'card_issue_reason' => 'cardIssueReason',
'card_functions_allowed' => 'cardFunctionsAllowed'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'card_id' => 'setCardId',
'display_card_number' => 'setDisplayCardNumber',
'local_card_activation_indicator' => 'setLocalCardActivationIndicator',
'overseas_card_activation_indicator' => 'setOverseasCardActivationIndicator',
'perpetual_activation_flag' => 'setPerpetualActivationFlag',
'overseas_card_activation_start_date' => 'setOverseasCardActivationStartDate',
'overseas_card_activation_end_date' => 'setOverseasCardActivationEndDate',
'current_credit_limit_amount' => 'setCurrentCreditLimitAmount',
'maximum_permanent_credit_limit_amount' => 'setMaximumPermanentCreditLimitAmount',
'maximum_temporary_credit_limit_amount' => 'setMaximumTemporaryCreditLimitAmount',
'sub_card_type' => 'setSubCardType',
'card_holder_type' => 'setCardHolderType',
'card_issue_reason' => 'setCardIssueReason',
'card_functions_allowed' => 'setCardFunctionsAllowed'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'card_id' => 'getCardId',
'display_card_number' => 'getDisplayCardNumber',
'local_card_activation_indicator' => 'getLocalCardActivationIndicator',
'overseas_card_activation_indicator' => 'getOverseasCardActivationIndicator',
'perpetual_activation_flag' => 'getPerpetualActivationFlag',
'overseas_card_activation_start_date' => 'getOverseasCardActivationStartDate',
'overseas_card_activation_end_date' => 'getOverseasCardActivationEndDate',
'current_credit_limit_amount' => 'getCurrentCreditLimitAmount',
'maximum_permanent_credit_limit_amount' => 'getMaximumPermanentCreditLimitAmount',
'maximum_temporary_credit_limit_amount' => 'getMaximumTemporaryCreditLimitAmount',
'sub_card_type' => 'getSubCardType',
'card_holder_type' => 'getCardHolderType',
'card_issue_reason' => 'getCardIssueReason',
'card_functions_allowed' => 'getCardFunctionsAllowed'    ];

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
        $this->container['card_id'] = isset($data['card_id']) ? $data['card_id'] : null;
        $this->container['display_card_number'] = isset($data['display_card_number']) ? $data['display_card_number'] : null;
        $this->container['local_card_activation_indicator'] = isset($data['local_card_activation_indicator']) ? $data['local_card_activation_indicator'] : null;
        $this->container['overseas_card_activation_indicator'] = isset($data['overseas_card_activation_indicator']) ? $data['overseas_card_activation_indicator'] : null;
        $this->container['perpetual_activation_flag'] = isset($data['perpetual_activation_flag']) ? $data['perpetual_activation_flag'] : null;
        $this->container['overseas_card_activation_start_date'] = isset($data['overseas_card_activation_start_date']) ? $data['overseas_card_activation_start_date'] : null;
        $this->container['overseas_card_activation_end_date'] = isset($data['overseas_card_activation_end_date']) ? $data['overseas_card_activation_end_date'] : null;
        $this->container['current_credit_limit_amount'] = isset($data['current_credit_limit_amount']) ? $data['current_credit_limit_amount'] : null;
        $this->container['maximum_permanent_credit_limit_amount'] = isset($data['maximum_permanent_credit_limit_amount']) ? $data['maximum_permanent_credit_limit_amount'] : null;
        $this->container['maximum_temporary_credit_limit_amount'] = isset($data['maximum_temporary_credit_limit_amount']) ? $data['maximum_temporary_credit_limit_amount'] : null;
        $this->container['sub_card_type'] = isset($data['sub_card_type']) ? $data['sub_card_type'] : null;
        $this->container['card_holder_type'] = isset($data['card_holder_type']) ? $data['card_holder_type'] : null;
        $this->container['card_issue_reason'] = isset($data['card_issue_reason']) ? $data['card_issue_reason'] : null;
        $this->container['card_functions_allowed'] = isset($data['card_functions_allowed']) ? $data['card_functions_allowed'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if ($this->container['card_id'] === null) {
            $invalidProperties[] = "'card_id' can't be null";
        }
        if ($this->container['local_card_activation_indicator'] === null) {
            $invalidProperties[] = "'local_card_activation_indicator' can't be null";
        }
        if ($this->container['current_credit_limit_amount'] === null) {
            $invalidProperties[] = "'current_credit_limit_amount' can't be null";
        }
        if ($this->container['sub_card_type'] === null) {
            $invalidProperties[] = "'sub_card_type' can't be null";
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
     * Gets card_id
     *
     * @return string
     */
    public function getCardId()
    {
        return $this->container['card_id'];
    }

    /**
     * Sets card_id
     *
     * @param string $card_id The card id  in encrypted format
     *
     * @return $this
     */
    public function setCardId($card_id)
    {
        $this->container['card_id'] = $card_id;

        return $this;
    }

    /**
     * Gets display_card_number
     *
     * @return string
     */
    public function getDisplayCardNumber()
    {
        return $this->container['display_card_number'];
    }

    /**
     * Sets display_card_number
     *
     * @param string $display_card_number A masked card number that can be displayed to the customer.
     *
     * @return $this
     */
    public function setDisplayCardNumber($display_card_number)
    {
        $this->container['display_card_number'] = $display_card_number;

        return $this;
    }

    /**
     * Gets local_card_activation_indicator
     *
     * @return string
     */
    public function getLocalCardActivationIndicator()
    {
        return $this->container['local_card_activation_indicator'];
    }

    /**
     * Sets local_card_activation_indicator
     *
     * @param string $local_card_activation_indicator The card activation indicator for local usage. This is a reference data field. Please use /v1/apac/utilities/referenceData/{localCardActivationIndicator} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setLocalCardActivationIndicator($local_card_activation_indicator)
    {
        $this->container['local_card_activation_indicator'] = $local_card_activation_indicator;

        return $this;
    }

    /**
     * Gets overseas_card_activation_indicator
     *
     * @return string
     */
    public function getOverseasCardActivationIndicator()
    {
        return $this->container['overseas_card_activation_indicator'];
    }

    /**
     * Sets overseas_card_activation_indicator
     *
     * @param string $overseas_card_activation_indicator The card activation indicator for overseas usage. This is a reference data field. Please use /v1/apac/utilities/referenceData/{overseasCardActivationIndicator} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setOverseasCardActivationIndicator($overseas_card_activation_indicator)
    {
        $this->container['overseas_card_activation_indicator'] = $overseas_card_activation_indicator;

        return $this;
    }

    /**
     * Gets perpetual_activation_flag
     *
     * @return bool
     */
    public function getPerpetualActivationFlag()
    {
        return $this->container['perpetual_activation_flag'];
    }

    /**
     * Sets perpetual_activation_flag
     *
     * @param bool $perpetual_activation_flag Flag to specify whether the card is activated perpetually, till card expiration
     *
     * @return $this
     */
    public function setPerpetualActivationFlag($perpetual_activation_flag)
    {
        $this->container['perpetual_activation_flag'] = $perpetual_activation_flag;

        return $this;
    }

    /**
     * Gets overseas_card_activation_start_date
     *
     * @return \DateTime
     */
    public function getOverseasCardActivationStartDate()
    {
        return $this->container['overseas_card_activation_start_date'];
    }

    /**
     * Sets overseas_card_activation_start_date
     *
     * @param \DateTime $overseas_card_activation_start_date Card activation start date in ISO 8601 date format YYYY-MM-DD for overseas usage.
     *
     * @return $this
     */
    public function setOverseasCardActivationStartDate($overseas_card_activation_start_date)
    {
        $this->container['overseas_card_activation_start_date'] = $overseas_card_activation_start_date;

        return $this;
    }

    /**
     * Gets overseas_card_activation_end_date
     *
     * @return \DateTime
     */
    public function getOverseasCardActivationEndDate()
    {
        return $this->container['overseas_card_activation_end_date'];
    }

    /**
     * Sets overseas_card_activation_end_date
     *
     * @param \DateTime $overseas_card_activation_end_date Card activation end date in ISO 8601 date format YYYY-MM-DD for overseas usage. For perpetual activation, value is card expiry date
     *
     * @return $this
     */
    public function setOverseasCardActivationEndDate($overseas_card_activation_end_date)
    {
        $this->container['overseas_card_activation_end_date'] = $overseas_card_activation_end_date;

        return $this;
    }

    /**
     * Gets current_credit_limit_amount
     *
     * @return double
     */
    public function getCurrentCreditLimitAmount()
    {
        return $this->container['current_credit_limit_amount'];
    }

    /**
     * Sets current_credit_limit_amount
     *
     * @param double $current_credit_limit_amount Current credit limit amount on the credit card
     *
     * @return $this
     */
    public function setCurrentCreditLimitAmount($current_credit_limit_amount)
    {
        $this->container['current_credit_limit_amount'] = $current_credit_limit_amount;

        return $this;
    }

    /**
     * Gets maximum_permanent_credit_limit_amount
     *
     * @return double
     */
    public function getMaximumPermanentCreditLimitAmount()
    {
        return $this->container['maximum_permanent_credit_limit_amount'];
    }

    /**
     * Sets maximum_permanent_credit_limit_amount
     *
     * @param double $maximum_permanent_credit_limit_amount Maximum permanent credit limit amount allowed on the credit card
     *
     * @return $this
     */
    public function setMaximumPermanentCreditLimitAmount($maximum_permanent_credit_limit_amount)
    {
        $this->container['maximum_permanent_credit_limit_amount'] = $maximum_permanent_credit_limit_amount;

        return $this;
    }

    /**
     * Gets maximum_temporary_credit_limit_amount
     *
     * @return double
     */
    public function getMaximumTemporaryCreditLimitAmount()
    {
        return $this->container['maximum_temporary_credit_limit_amount'];
    }

    /**
     * Sets maximum_temporary_credit_limit_amount
     *
     * @param double $maximum_temporary_credit_limit_amount Maximum temporary credit limit amount allowed on the credit card
     *
     * @return $this
     */
    public function setMaximumTemporaryCreditLimitAmount($maximum_temporary_credit_limit_amount)
    {
        $this->container['maximum_temporary_credit_limit_amount'] = $maximum_temporary_credit_limit_amount;

        return $this;
    }

    /**
     * Gets sub_card_type
     *
     * @return string
     */
    public function getSubCardType()
    {
        return $this->container['sub_card_type'];
    }

    /**
     * Sets sub_card_type
     *
     * @param string $sub_card_type Type of the card. Debit or Credit.This is a reference data field. Please use /v1/apac/utilities/referenceData/{subCardType} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setSubCardType($sub_card_type)
    {
        $this->container['sub_card_type'] = $sub_card_type;

        return $this;
    }

    /**
     * Gets card_holder_type
     *
     * @return string
     */
    public function getCardHolderType()
    {
        return $this->container['card_holder_type'];
    }

    /**
     * Sets card_holder_type
     *
     * @param string $card_holder_type Indicator to specify whether the card is primary or supplementary. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardHolderType} resource to get valid value of this field with description.
     *
     * @return $this
     */
    public function setCardHolderType($card_holder_type)
    {
        $this->container['card_holder_type'] = $card_holder_type;

        return $this;
    }

    /**
     * Gets card_issue_reason
     *
     * @return string
     */
    public function getCardIssueReason()
    {
        return $this->container['card_issue_reason'];
    }

    /**
     * Sets card_issue_reason
     *
     * @param string $card_issue_reason Specifies the reason for the card issuance. Applicable only for recently issued cards. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardIssueReason} resource to get valid value of this field with description.
     *
     * @return $this
     */
    public function setCardIssueReason($card_issue_reason)
    {
        $this->container['card_issue_reason'] = $card_issue_reason;

        return $this;
    }

    /**
     * Gets card_functions_allowed
     *
     * @return \Swagger\Client\Model\CardFunctionsAllowed[]
     */
    public function getCardFunctionsAllowed()
    {
        return $this->container['card_functions_allowed'];
    }

    /**
     * Sets card_functions_allowed
     *
     * @param \Swagger\Client\Model\CardFunctionsAllowed[] $card_functions_allowed card_functions_allowed
     *
     * @return $this
     */
    public function setCardFunctionsAllowed($card_functions_allowed)
    {
        $this->container['card_functions_allowed'] = $card_functions_allowed;

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
