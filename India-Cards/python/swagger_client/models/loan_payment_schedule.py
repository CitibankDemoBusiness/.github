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

class LoanPaymentSchedule(object):
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
        'installment_number': 'int',
        'principal_amount': 'float',
        'installment_interest_amount': 'float',
        'installment_amount': 'float',
        'installment_date': 'date'
    }

    attribute_map = {
        'installment_number': 'installmentNumber',
        'principal_amount': 'principalAmount',
        'installment_interest_amount': 'installmentInterestAmount',
        'installment_amount': 'installmentAmount',
        'installment_date': 'installmentDate'
    }

    def __init__(self, installment_number=None, principal_amount=None, installment_interest_amount=None, installment_amount=None, installment_date=None):  # noqa: E501
        """LoanPaymentSchedule - a model defined in Swagger"""  # noqa: E501
        self._installment_number = None
        self._principal_amount = None
        self._installment_interest_amount = None
        self._installment_amount = None
        self._installment_date = None
        self.discriminator = None
        if installment_number is not None:
            self.installment_number = installment_number
        if principal_amount is not None:
            self.principal_amount = principal_amount
        if installment_interest_amount is not None:
            self.installment_interest_amount = installment_interest_amount
        if installment_amount is not None:
            self.installment_amount = installment_amount
        if installment_date is not None:
            self.installment_date = installment_date

    @property
    def installment_number(self):
        """Gets the installment_number of this LoanPaymentSchedule.  # noqa: E501

        The installment number of the total number of installments  # noqa: E501

        :return: The installment_number of this LoanPaymentSchedule.  # noqa: E501
        :rtype: int
        """
        return self._installment_number

    @installment_number.setter
    def installment_number(self, installment_number):
        """Sets the installment_number of this LoanPaymentSchedule.

        The installment number of the total number of installments  # noqa: E501

        :param installment_number: The installment_number of this LoanPaymentSchedule.  # noqa: E501
        :type: int
        """

        self._installment_number = installment_number

    @property
    def principal_amount(self):
        """Gets the principal_amount of this LoanPaymentSchedule.  # noqa: E501

        The portion of the principal amount paid for the loan.  # noqa: E501

        :return: The principal_amount of this LoanPaymentSchedule.  # noqa: E501
        :rtype: float
        """
        return self._principal_amount

    @principal_amount.setter
    def principal_amount(self, principal_amount):
        """Sets the principal_amount of this LoanPaymentSchedule.

        The portion of the principal amount paid for the loan.  # noqa: E501

        :param principal_amount: The principal_amount of this LoanPaymentSchedule.  # noqa: E501
        :type: float
        """

        self._principal_amount = principal_amount

    @property
    def installment_interest_amount(self):
        """Gets the installment_interest_amount of this LoanPaymentSchedule.  # noqa: E501

        The interest amount to be paid as installment  # noqa: E501

        :return: The installment_interest_amount of this LoanPaymentSchedule.  # noqa: E501
        :rtype: float
        """
        return self._installment_interest_amount

    @installment_interest_amount.setter
    def installment_interest_amount(self, installment_interest_amount):
        """Sets the installment_interest_amount of this LoanPaymentSchedule.

        The interest amount to be paid as installment  # noqa: E501

        :param installment_interest_amount: The installment_interest_amount of this LoanPaymentSchedule.  # noqa: E501
        :type: float
        """

        self._installment_interest_amount = installment_interest_amount

    @property
    def installment_amount(self):
        """Gets the installment_amount of this LoanPaymentSchedule.  # noqa: E501

        Installment amount to be payed by customer in order to repay the loan.  # noqa: E501

        :return: The installment_amount of this LoanPaymentSchedule.  # noqa: E501
        :rtype: float
        """
        return self._installment_amount

    @installment_amount.setter
    def installment_amount(self, installment_amount):
        """Sets the installment_amount of this LoanPaymentSchedule.

        Installment amount to be payed by customer in order to repay the loan.  # noqa: E501

        :param installment_amount: The installment_amount of this LoanPaymentSchedule.  # noqa: E501
        :type: float
        """

        self._installment_amount = installment_amount

    @property
    def installment_date(self):
        """Gets the installment_date of this LoanPaymentSchedule.  # noqa: E501

        Date of installment in ISO 8601 date format YYYY-MM-DD  # noqa: E501

        :return: The installment_date of this LoanPaymentSchedule.  # noqa: E501
        :rtype: date
        """
        return self._installment_date

    @installment_date.setter
    def installment_date(self, installment_date):
        """Sets the installment_date of this LoanPaymentSchedule.

        Date of installment in ISO 8601 date format YYYY-MM-DD  # noqa: E501

        :param installment_date: The installment_date of this LoanPaymentSchedule.  # noqa: E501
        :type: date
        """

        self._installment_date = installment_date

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
        if issubclass(LoanPaymentSchedule, dict):
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
        if not isinstance(other, LoanPaymentSchedule):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other