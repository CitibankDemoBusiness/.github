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

class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest(object):
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
        'loan_amount': 'float',
        'tenor': 'float'
    }

    attribute_map = {
        'loan_amount': 'loanAmount',
        'tenor': 'tenor'
    }

    def __init__(self, loan_amount=None, tenor=None):  # noqa: E501
        """RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest - a model defined in Swagger"""  # noqa: E501
        self._loan_amount = None
        self._tenor = None
        self.discriminator = None
        if loan_amount is not None:
            self.loan_amount = loan_amount
        self.tenor = tenor

    @property
    def loan_amount(self):
        """Gets the loan_amount of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest.  # noqa: E501

        Loan amount for easy payment plan booking.  # noqa: E501

        :return: The loan_amount of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest.  # noqa: E501
        :rtype: float
        """
        return self._loan_amount

    @loan_amount.setter
    def loan_amount(self, loan_amount):
        """Sets the loan_amount of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest.

        Loan amount for easy payment plan booking.  # noqa: E501

        :param loan_amount: The loan_amount of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest.  # noqa: E501
        :type: float
        """

        self._loan_amount = loan_amount

    @property
    def tenor(self):
        """Gets the tenor of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest.  # noqa: E501

        Tenure of loan in months.  # noqa: E501

        :return: The tenor of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest.  # noqa: E501
        :rtype: float
        """
        return self._tenor

    @tenor.setter
    def tenor(self, tenor):
        """Sets the tenor of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest.

        Tenure of loan in months.  # noqa: E501

        :param tenor: The tenor of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest.  # noqa: E501
        :type: float
        """
        if tenor is None:
            raise ValueError("Invalid value for `tenor`, must not be `None`")  # noqa: E501

        self._tenor = tenor

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
        if issubclass(RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest, dict):
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
        if not isinstance(other, RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other