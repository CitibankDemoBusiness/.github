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

class DebitCardEnrollmentDetails(object):
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
        'internet_purchase_access_flag': 'bool',
        'contactless_payment_enrolled_flag': 'bool',
        'overseas_atm_access_allowed_flag': 'bool'
    }

    attribute_map = {
        'internet_purchase_access_flag': 'internetPurchaseAccessFlag',
        'contactless_payment_enrolled_flag': 'contactlessPaymentEnrolledFlag',
        'overseas_atm_access_allowed_flag': 'overseasAtmAccessAllowedFlag'
    }

    def __init__(self, internet_purchase_access_flag=None, contactless_payment_enrolled_flag=None, overseas_atm_access_allowed_flag=None):  # noqa: E501
        """DebitCardEnrollmentDetails - a model defined in Swagger"""  # noqa: E501
        self._internet_purchase_access_flag = None
        self._contactless_payment_enrolled_flag = None
        self._overseas_atm_access_allowed_flag = None
        self.discriminator = None
        if internet_purchase_access_flag is not None:
            self.internet_purchase_access_flag = internet_purchase_access_flag
        if contactless_payment_enrolled_flag is not None:
            self.contactless_payment_enrolled_flag = contactless_payment_enrolled_flag
        if overseas_atm_access_allowed_flag is not None:
            self.overseas_atm_access_allowed_flag = overseas_atm_access_allowed_flag

    @property
    def internet_purchase_access_flag(self):
        """Gets the internet_purchase_access_flag of this DebitCardEnrollmentDetails.  # noqa: E501

        Flag to indicate if internet purchase access is enabled or not on the debit/credit card  # noqa: E501

        :return: The internet_purchase_access_flag of this DebitCardEnrollmentDetails.  # noqa: E501
        :rtype: bool
        """
        return self._internet_purchase_access_flag

    @internet_purchase_access_flag.setter
    def internet_purchase_access_flag(self, internet_purchase_access_flag):
        """Sets the internet_purchase_access_flag of this DebitCardEnrollmentDetails.

        Flag to indicate if internet purchase access is enabled or not on the debit/credit card  # noqa: E501

        :param internet_purchase_access_flag: The internet_purchase_access_flag of this DebitCardEnrollmentDetails.  # noqa: E501
        :type: bool
        """

        self._internet_purchase_access_flag = internet_purchase_access_flag

    @property
    def contactless_payment_enrolled_flag(self):
        """Gets the contactless_payment_enrolled_flag of this DebitCardEnrollmentDetails.  # noqa: E501

        Flag to indicate if contact-less payment is enabled or not on the debit/credit card  # noqa: E501

        :return: The contactless_payment_enrolled_flag of this DebitCardEnrollmentDetails.  # noqa: E501
        :rtype: bool
        """
        return self._contactless_payment_enrolled_flag

    @contactless_payment_enrolled_flag.setter
    def contactless_payment_enrolled_flag(self, contactless_payment_enrolled_flag):
        """Sets the contactless_payment_enrolled_flag of this DebitCardEnrollmentDetails.

        Flag to indicate if contact-less payment is enabled or not on the debit/credit card  # noqa: E501

        :param contactless_payment_enrolled_flag: The contactless_payment_enrolled_flag of this DebitCardEnrollmentDetails.  # noqa: E501
        :type: bool
        """

        self._contactless_payment_enrolled_flag = contactless_payment_enrolled_flag

    @property
    def overseas_atm_access_allowed_flag(self):
        """Gets the overseas_atm_access_allowed_flag of this DebitCardEnrollmentDetails.  # noqa: E501

        This field is to indicate if overseas ATM access is allowed to the card.  # noqa: E501

        :return: The overseas_atm_access_allowed_flag of this DebitCardEnrollmentDetails.  # noqa: E501
        :rtype: bool
        """
        return self._overseas_atm_access_allowed_flag

    @overseas_atm_access_allowed_flag.setter
    def overseas_atm_access_allowed_flag(self, overseas_atm_access_allowed_flag):
        """Sets the overseas_atm_access_allowed_flag of this DebitCardEnrollmentDetails.

        This field is to indicate if overseas ATM access is allowed to the card.  # noqa: E501

        :param overseas_atm_access_allowed_flag: The overseas_atm_access_allowed_flag of this DebitCardEnrollmentDetails.  # noqa: E501
        :type: bool
        """

        self._overseas_atm_access_allowed_flag = overseas_atm_access_allowed_flag

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
        if issubclass(DebitCardEnrollmentDetails, dict):
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
        if not isinstance(other, DebitCardEnrollmentDetails):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
