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

class RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest(object):
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
        'card_details': 'CardDetails',
        'original_authorization_code': 'str',
        'refund_authorization_code': 'str'
    }

    attribute_map = {
        'card_details': 'cardDetails',
        'original_authorization_code': 'originalAuthorizationCode',
        'refund_authorization_code': 'refundAuthorizationCode'
    }

    def __init__(self, card_details=None, original_authorization_code=None, refund_authorization_code=None):  # noqa: E501
        """RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest - a model defined in Swagger"""  # noqa: E501
        self._card_details = None
        self._original_authorization_code = None
        self._refund_authorization_code = None
        self.discriminator = None
        if card_details is not None:
            self.card_details = card_details
        self.original_authorization_code = original_authorization_code
        self.refund_authorization_code = refund_authorization_code

    @property
    def card_details(self):
        """Gets the card_details of this RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest.  # noqa: E501


        :return: The card_details of this RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest.  # noqa: E501
        :rtype: CardDetails
        """
        return self._card_details

    @card_details.setter
    def card_details(self, card_details):
        """Sets the card_details of this RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest.


        :param card_details: The card_details of this RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest.  # noqa: E501
        :type: CardDetails
        """

        self._card_details = card_details

    @property
    def original_authorization_code(self):
        """Gets the original_authorization_code of this RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest.  # noqa: E501

        Authorization Code for Original Transaction  # noqa: E501

        :return: The original_authorization_code of this RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest.  # noqa: E501
        :rtype: str
        """
        return self._original_authorization_code

    @original_authorization_code.setter
    def original_authorization_code(self, original_authorization_code):
        """Sets the original_authorization_code of this RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest.

        Authorization Code for Original Transaction  # noqa: E501

        :param original_authorization_code: The original_authorization_code of this RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest.  # noqa: E501
        :type: str
        """
        if original_authorization_code is None:
            raise ValueError("Invalid value for `original_authorization_code`, must not be `None`")  # noqa: E501

        self._original_authorization_code = original_authorization_code

    @property
    def refund_authorization_code(self):
        """Gets the refund_authorization_code of this RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest.  # noqa: E501

        Authorization Code for Refund Transaction  # noqa: E501

        :return: The refund_authorization_code of this RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest.  # noqa: E501
        :rtype: str
        """
        return self._refund_authorization_code

    @refund_authorization_code.setter
    def refund_authorization_code(self, refund_authorization_code):
        """Sets the refund_authorization_code of this RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest.

        Authorization Code for Refund Transaction  # noqa: E501

        :param refund_authorization_code: The refund_authorization_code of this RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest.  # noqa: E501
        :type: str
        """
        if refund_authorization_code is None:
            raise ValueError("Invalid value for `refund_authorization_code`, must not be `None`")  # noqa: E501

        self._refund_authorization_code = refund_authorization_code

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
        if issubclass(RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest, dict):
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
        if not isinstance(other, RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other