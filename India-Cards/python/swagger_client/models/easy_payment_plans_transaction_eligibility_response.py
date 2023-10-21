# coding: utf-8

"""
    Cards

    The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.  # noqa: E501

    OpenAPI spec version: 1.0.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

import pprint
import re  # noqa: F401

import six

class EasyPaymentPlansTransactionEligibilityResponse(object):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    """
    Attributes:
      swagger_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    swagger_types = {
        'tenor': 'str',
        'effective_interest_rate': 'float',
        'annual_percentage_rate': 'float',
        'installment_amount': 'float',
        'one_time_processing_fee_indicator': 'str',
        'one_time_processing_fee_amount': 'float',
        'one_time_processing_fee_percentage': 'float',
        'offer_indicator': 'str'
    }

    attribute_map = {
        'tenor': 'tenor',
        'effective_interest_rate': 'effectiveInterestRate',
        'annual_percentage_rate': 'annualPercentageRate',
        'installment_amount': 'installmentAmount',
        'one_time_processing_fee_indicator': 'oneTimeProcessingFeeIndicator',
        'one_time_processing_fee_amount': 'oneTimeProcessingFeeAmount',
        'one_time_processing_fee_percentage': 'oneTimeProcessingFeePercentage',
        'offer_indicator': 'offerIndicator'
    }

    def __init__(self, tenor=None, effective_interest_rate=None, annual_percentage_rate=None, installment_amount=None, one_time_processing_fee_indicator=None, one_time_processing_fee_amount=None, one_time_processing_fee_percentage=None, offer_indicator=None):  # noqa: E501
        """EasyPaymentPlansTransactionEligibilityResponse - a model defined in Swagger"""  # noqa: E501
        self._tenor = None
        self._effective_interest_rate = None
        self._annual_percentage_rate = None
        self._installment_amount = None
        self._one_time_processing_fee_indicator = None
        self._one_time_processing_fee_amount = None
        self._one_time_processing_fee_percentage = None
        self._offer_indicator = None
        self.discriminator = None
        self.tenor = tenor
        self.effective_interest_rate = effective_interest_rate
        if annual_percentage_rate is not None:
            self.annual_percentage_rate = annual_percentage_rate
        if installment_amount is not None:
            self.installment_amount = installment_amount
        if one_time_processing_fee_indicator is not None:
            self.one_time_processing_fee_indicator = one_time_processing_fee_indicator
        if one_time_processing_fee_amount is not None:
            self.one_time_processing_fee_amount = one_time_processing_fee_amount
        if one_time_processing_fee_percentage is not None:
            self.one_time_processing_fee_percentage = one_time_processing_fee_percentage
        self.offer_indicator = offer_indicator

    @property
    def tenor(self):
        """Gets the tenor of this EasyPaymentPlansTransactionEligibilityResponse.  # noqa: E501

        Tenure of loan in months.  # noqa: E501

        :return: The tenor of this EasyPaymentPlansTransactionEligibilityResponse.  # noqa: E501
        :rtype: str
        """
        return self._tenor

    @tenor.setter
    def tenor(self, tenor):
        """Sets the tenor of this EasyPaymentPlansTransactionEligibilityResponse.

        Tenure of loan in months.  # noqa: E501

        :param tenor: The tenor of this EasyPaymentPlansTransactionEligibilityResponse.  # noqa: E501
        :type: str
        """
        if tenor is None:
            raise ValueError("Invalid value for `tenor`, must not be `None`")  # noqa: E501

        self._tenor = tenor

    @property
    def effective_interest_rate(self):
        """Gets the effective_interest_rate of this EasyPaymentPlansTransactionEligibilityResponse.  # noqa: E501

        The interest rate applicable on loan amount.  # noqa: E501

        :return: The effective_interest_rate of this EasyPaymentPlansTransactionEligibilityResponse.  # noqa: E501
        :rtype: float
        """
        return self._effective_interest_rate

    @effective_interest_rate.setter
    def effective_interest_rate(self, effective_interest_rate):
        """Sets the effective_interest_rate of this EasyPaymentPlansTransactionEligibilityResponse.

        The interest rate applicable on loan amount.  # noqa: E501

        :param effective_interest_rate: The effective_interest_rate of this EasyPaymentPlansTransactionEligibilityResponse.  # noqa: E501
        :type: float
        """
        if effective_interest_rate is None:
            raise ValueError("Invalid value for `effective_interest_rate`, must not be `None`")  # noqa: E501

        self._effective_interest_rate = effective_interest_rate

    @property
    def annual_percentage_rate(self):
        """Gets the annual_percentage_rate of this EasyPaymentPlansTransactionEligibilityResponse.  # noqa: E501

        Interest rate for a whole year. This includes any fees or additional cost associated.  # noqa: E501

        :return: The annual_percentage_rate of this EasyPaymentPlansTransactionEligibilityResponse.  # noqa: E501
        :rtype: float
        """
        return self._annual_percentage_rate

    @annual_percentage_rate.setter
    def annual_percentage_rate(self, annual_percentage_rate):
        """Sets the annual_percentage_rate of this EasyPaymentPlansTransactionEligibilityResponse.

        Interest rate for a whole year. This includes any fees or additional cost associated.  # noqa: E501

        :param annual_percentage_rate: The annual_percentage_rate of this EasyPaymentPlansTransactionEligibilityResponse.  # noqa: E501
        :type: float
        """

        self._annual_percentage_rate = annual_percentage_rate

    @property
    def installment_amount(self):
        """Gets the installment_amount of this EasyPaymentPlansTransactionEligibilityResponse.  # noqa: E501

        Installment amount to be paid by customer in order to repay the loan.  # noqa: E501

        :return: The installment_amount of this EasyPaymentPlansTransactionEligibilityResponse.  # noqa: E501
        :rtype: float
        """
        return self._installment_amount

    @installment_amount.setter
    def installment_amount(self, installment_amount):
        """Sets the installment_amount of this EasyPaymentPlansTransactionEligibilityResponse.

        Installment amount to be paid by customer in order to repay the loan.  # noqa: E501

        :param installment_amount: The installment_amount of this EasyPaymentPlansTransactionEligibilityResponse.  # noqa: E501
        :type: float
        """

        self._installment_amount = installment_amount

    @property
    def one_time_processing_fee_indicator(self):
        """Gets the one_time_processing_fee_indicator of this EasyPaymentPlansTransactionEligibilityResponse.  # noqa: E501

        One time processing fee indicator. Valid values : PERCENTAGE, FIXED_AMOUNT. This is a reference data field. Please use /v1/apac/utilities/referenceData/{oneTimeProcessingFeeIndicator} resource to get valid value of this field with description.  # noqa: E501

        :return: The one_time_processing_fee_indicator of this EasyPaymentPlansTransactionEligibilityResponse.  # noqa: E501
        :rtype: str
        """
        return self._one_time_processing_fee_indicator

    @one_time_processing_fee_indicator.setter
    def one_time_processing_fee_indicator(self, one_time_processing_fee_indicator):
        """Sets the one_time_processing_fee_indicator of this EasyPaymentPlansTransactionEligibilityResponse.

        One time processing fee indicator. Valid values : PERCENTAGE, FIXED_AMOUNT. This is a reference data field. Please use /v1/apac/utilities/referenceData/{oneTimeProcessingFeeIndicator} resource to get valid value of this field with description.  # noqa: E501

        :param one_time_processing_fee_indicator: The one_time_processing_fee_indicator of this EasyPaymentPlansTransactionEligibilityResponse.  # noqa: E501
        :type: str
        """

        self._one_time_processing_fee_indicator = one_time_processing_fee_indicator

    @property
    def one_time_processing_fee_amount(self):
        """Gets the one_time_processing_fee_amount of this EasyPaymentPlansTransactionEligibilityResponse.  # noqa: E501

        Fee charged as part of one time processing.  # noqa: E501

        :return: The one_time_processing_fee_amount of this EasyPaymentPlansTransactionEligibilityResponse.  # noqa: E501
        :rtype: float
        """
        return self._one_time_processing_fee_amount

    @one_time_processing_fee_amount.setter
    def one_time_processing_fee_amount(self, one_time_processing_fee_amount):
        """Sets the one_time_processing_fee_amount of this EasyPaymentPlansTransactionEligibilityResponse.

        Fee charged as part of one time processing.  # noqa: E501

        :param one_time_processing_fee_amount: The one_time_processing_fee_amount of this EasyPaymentPlansTransactionEligibilityResponse.  # noqa: E501
        :type: float
        """

        self._one_time_processing_fee_amount = one_time_processing_fee_amount

    @property
    def one_time_processing_fee_percentage(self):
        """Gets the one_time_processing_fee_percentage of this EasyPaymentPlansTransactionEligibilityResponse.  # noqa: E501

        Percentage of one time processing fee charged.  # noqa: E501

        :return: The one_time_processing_fee_percentage of this EasyPaymentPlansTransactionEligibilityResponse.  # noqa: E501
        :rtype: float
        """
        return self._one_time_processing_fee_percentage

    @one_time_processing_fee_percentage.setter
    def one_time_processing_fee_percentage(self, one_time_processing_fee_percentage):
        """Sets the one_time_processing_fee_percentage of this EasyPaymentPlansTransactionEligibilityResponse.

        Percentage of one time processing fee charged.  # noqa: E501

        :param one_time_processing_fee_percentage: The one_time_processing_fee_percentage of this EasyPaymentPlansTransactionEligibilityResponse.  # noqa: E501
        :type: float
        """

        self._one_time_processing_fee_percentage = one_time_processing_fee_percentage

    @property
    def offer_indicator(self):
        """Gets the offer_indicator of this EasyPaymentPlansTransactionEligibilityResponse.  # noqa: E501

        This is to indicate if the offer is rate/fee/hybrid based. This is a reference data field. Please use /v1/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description.  # noqa: E501

        :return: The offer_indicator of this EasyPaymentPlansTransactionEligibilityResponse.  # noqa: E501
        :rtype: str
        """
        return self._offer_indicator

    @offer_indicator.setter
    def offer_indicator(self, offer_indicator):
        """Sets the offer_indicator of this EasyPaymentPlansTransactionEligibilityResponse.

        This is to indicate if the offer is rate/fee/hybrid based. This is a reference data field. Please use /v1/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description.  # noqa: E501

        :param offer_indicator: The offer_indicator of this EasyPaymentPlansTransactionEligibilityResponse.  # noqa: E501
        :type: str
        """
        if offer_indicator is None:
            raise ValueError("Invalid value for `offer_indicator`, must not be `None`")  # noqa: E501

        self._offer_indicator = offer_indicator

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.swagger_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value
        if issubclass(EasyPaymentPlansTransactionEligibilityResponse, dict):
            for key, value in self.items():
                result[key] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, EasyPaymentPlansTransactionEligibilityResponse):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
