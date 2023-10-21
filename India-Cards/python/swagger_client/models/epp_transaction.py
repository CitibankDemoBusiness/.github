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

class EppTransaction(object):
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
        'reference_id': 'str',
        'installment_amount': 'float',
        'principal_amount': 'float',
        'installment_interest_amount': 'float',
        'initial_interest_amount': 'float',
        'statement_unpaid_balance_amount': 'float'
    }

    attribute_map = {
        'reference_id': 'referenceId',
        'installment_amount': 'installmentAmount',
        'principal_amount': 'principalAmount',
        'installment_interest_amount': 'installmentInterestAmount',
        'initial_interest_amount': 'initialInterestAmount',
        'statement_unpaid_balance_amount': 'statementUnpaidBalanceAmount'
    }

    def __init__(self, reference_id=None, installment_amount=None, principal_amount=None, installment_interest_amount=None, initial_interest_amount=None, statement_unpaid_balance_amount=None):  # noqa: E501
        """EppTransaction - a model defined in Swagger"""  # noqa: E501
        self._reference_id = None
        self._installment_amount = None
        self._principal_amount = None
        self._installment_interest_amount = None
        self._initial_interest_amount = None
        self._statement_unpaid_balance_amount = None
        self.discriminator = None
        self.reference_id = reference_id
        if installment_amount is not None:
            self.installment_amount = installment_amount
        if principal_amount is not None:
            self.principal_amount = principal_amount
        if installment_interest_amount is not None:
            self.installment_interest_amount = installment_interest_amount
        if initial_interest_amount is not None:
            self.initial_interest_amount = initial_interest_amount
        if statement_unpaid_balance_amount is not None:
            self.statement_unpaid_balance_amount = statement_unpaid_balance_amount

    @property
    def reference_id(self):
        """Gets the reference_id of this EppTransaction.  # noqa: E501

        Reference Id to uniquely identify the loan.   # noqa: E501

        :return: The reference_id of this EppTransaction.  # noqa: E501
        :rtype: str
        """
        return self._reference_id

    @reference_id.setter
    def reference_id(self, reference_id):
        """Sets the reference_id of this EppTransaction.

        Reference Id to uniquely identify the loan.   # noqa: E501

        :param reference_id: The reference_id of this EppTransaction.  # noqa: E501
        :type: str
        """
        if reference_id is None:
            raise ValueError("Invalid value for `reference_id`, must not be `None`")  # noqa: E501

        self._reference_id = reference_id

    @property
    def installment_amount(self):
        """Gets the installment_amount of this EppTransaction.  # noqa: E501

        Installment amount to be paid by customer in order to repay the loan.  # noqa: E501

        :return: The installment_amount of this EppTransaction.  # noqa: E501
        :rtype: float
        """
        return self._installment_amount

    @installment_amount.setter
    def installment_amount(self, installment_amount):
        """Sets the installment_amount of this EppTransaction.

        Installment amount to be paid by customer in order to repay the loan.  # noqa: E501

        :param installment_amount: The installment_amount of this EppTransaction.  # noqa: E501
        :type: float
        """

        self._installment_amount = installment_amount

    @property
    def principal_amount(self):
        """Gets the principal_amount of this EppTransaction.  # noqa: E501

        The portion of the Principal Amount Paid for the loan.  # noqa: E501

        :return: The principal_amount of this EppTransaction.  # noqa: E501
        :rtype: float
        """
        return self._principal_amount

    @principal_amount.setter
    def principal_amount(self, principal_amount):
        """Sets the principal_amount of this EppTransaction.

        The portion of the Principal Amount Paid for the loan.  # noqa: E501

        :param principal_amount: The principal_amount of this EppTransaction.  # noqa: E501
        :type: float
        """

        self._principal_amount = principal_amount

    @property
    def installment_interest_amount(self):
        """Gets the installment_interest_amount of this EppTransaction.  # noqa: E501

        The interest  amount to be paid as installment.  # noqa: E501

        :return: The installment_interest_amount of this EppTransaction.  # noqa: E501
        :rtype: float
        """
        return self._installment_interest_amount

    @installment_interest_amount.setter
    def installment_interest_amount(self, installment_interest_amount):
        """Sets the installment_interest_amount of this EppTransaction.

        The interest  amount to be paid as installment.  # noqa: E501

        :param installment_interest_amount: The installment_interest_amount of this EppTransaction.  # noqa: E501
        :type: float
        """

        self._installment_interest_amount = installment_interest_amount

    @property
    def initial_interest_amount(self):
        """Gets the initial_interest_amount of this EppTransaction.  # noqa: E501

        Initial interest amount charged to customer from the epp booking date to the first installment start date  # noqa: E501

        :return: The initial_interest_amount of this EppTransaction.  # noqa: E501
        :rtype: float
        """
        return self._initial_interest_amount

    @initial_interest_amount.setter
    def initial_interest_amount(self, initial_interest_amount):
        """Sets the initial_interest_amount of this EppTransaction.

        Initial interest amount charged to customer from the epp booking date to the first installment start date  # noqa: E501

        :param initial_interest_amount: The initial_interest_amount of this EppTransaction.  # noqa: E501
        :type: float
        """

        self._initial_interest_amount = initial_interest_amount

    @property
    def statement_unpaid_balance_amount(self):
        """Gets the statement_unpaid_balance_amount of this EppTransaction.  # noqa: E501

        This field indicates the remaining statement balance amount that remains due and payable.  # noqa: E501

        :return: The statement_unpaid_balance_amount of this EppTransaction.  # noqa: E501
        :rtype: float
        """
        return self._statement_unpaid_balance_amount

    @statement_unpaid_balance_amount.setter
    def statement_unpaid_balance_amount(self, statement_unpaid_balance_amount):
        """Sets the statement_unpaid_balance_amount of this EppTransaction.

        This field indicates the remaining statement balance amount that remains due and payable.  # noqa: E501

        :param statement_unpaid_balance_amount: The statement_unpaid_balance_amount of this EppTransaction.  # noqa: E501
        :type: float
        """

        self._statement_unpaid_balance_amount = statement_unpaid_balance_amount

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
        if issubclass(EppTransaction, dict):
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
        if not isinstance(other, EppTransaction):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other