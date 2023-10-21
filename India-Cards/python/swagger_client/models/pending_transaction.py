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

class PendingTransaction(object):
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
        'transaction_date': 'date',
        'transaction_description': 'str',
        'transaction_authorization_code': 'str',
        'transaction_reference_id': 'str',
        'merchant_name': 'str',
        'transaction_amount': 'float'
    }

    attribute_map = {
        'transaction_date': 'transactionDate',
        'transaction_description': 'transactionDescription',
        'transaction_authorization_code': 'transactionAuthorizationCode',
        'transaction_reference_id': 'transactionReferenceId',
        'merchant_name': 'merchantName',
        'transaction_amount': 'transactionAmount'
    }

    def __init__(self, transaction_date=None, transaction_description=None, transaction_authorization_code=None, transaction_reference_id=None, merchant_name=None, transaction_amount=None):  # noqa: E501
        """PendingTransaction - a model defined in Swagger"""  # noqa: E501
        self._transaction_date = None
        self._transaction_description = None
        self._transaction_authorization_code = None
        self._transaction_reference_id = None
        self._merchant_name = None
        self._transaction_amount = None
        self.discriminator = None
        self.transaction_date = transaction_date
        self.transaction_description = transaction_description
        if transaction_authorization_code is not None:
            self.transaction_authorization_code = transaction_authorization_code
        if transaction_reference_id is not None:
            self.transaction_reference_id = transaction_reference_id
        if merchant_name is not None:
            self.merchant_name = merchant_name
        self.transaction_amount = transaction_amount

    @property
    def transaction_date(self):
        """Gets the transaction_date of this PendingTransaction.  # noqa: E501

        Transaction date in YYYY-MM-DD format value conforming to ISO 8601. This needs to be formatted in front-end for country/locale specific display purposes. This is the field used for default sorting,  # noqa: E501

        :return: The transaction_date of this PendingTransaction.  # noqa: E501
        :rtype: date
        """
        return self._transaction_date

    @transaction_date.setter
    def transaction_date(self, transaction_date):
        """Sets the transaction_date of this PendingTransaction.

        Transaction date in YYYY-MM-DD format value conforming to ISO 8601. This needs to be formatted in front-end for country/locale specific display purposes. This is the field used for default sorting,  # noqa: E501

        :param transaction_date: The transaction_date of this PendingTransaction.  # noqa: E501
        :type: date
        """
        if transaction_date is None:
            raise ValueError("Invalid value for `transaction_date`, must not be `None`")  # noqa: E501

        self._transaction_date = transaction_date

    @property
    def transaction_description(self):
        """Gets the transaction_description of this PendingTransaction.  # noqa: E501

        Transaction description from the merchant, POS or bank. If there are foreign currency transactions on checking /saving account(s) then description includes exchange rate, city and country.  # noqa: E501

        :return: The transaction_description of this PendingTransaction.  # noqa: E501
        :rtype: str
        """
        return self._transaction_description

    @transaction_description.setter
    def transaction_description(self, transaction_description):
        """Sets the transaction_description of this PendingTransaction.

        Transaction description from the merchant, POS or bank. If there are foreign currency transactions on checking /saving account(s) then description includes exchange rate, city and country.  # noqa: E501

        :param transaction_description: The transaction_description of this PendingTransaction.  # noqa: E501
        :type: str
        """
        if transaction_description is None:
            raise ValueError("Invalid value for `transaction_description`, must not be `None`")  # noqa: E501

        self._transaction_description = transaction_description

    @property
    def transaction_authorization_code(self):
        """Gets the transaction_authorization_code of this PendingTransaction.  # noqa: E501

        Transaction authorization code is a unique to a sales credit card transaction to indicate that the sale has been authorized. This is applicable only for pending transactions.  # noqa: E501

        :return: The transaction_authorization_code of this PendingTransaction.  # noqa: E501
        :rtype: str
        """
        return self._transaction_authorization_code

    @transaction_authorization_code.setter
    def transaction_authorization_code(self, transaction_authorization_code):
        """Sets the transaction_authorization_code of this PendingTransaction.

        Transaction authorization code is a unique to a sales credit card transaction to indicate that the sale has been authorized. This is applicable only for pending transactions.  # noqa: E501

        :param transaction_authorization_code: The transaction_authorization_code of this PendingTransaction.  # noqa: E501
        :type: str
        """

        self._transaction_authorization_code = transaction_authorization_code

    @property
    def transaction_reference_id(self):
        """Gets the transaction_reference_id of this PendingTransaction.  # noqa: E501

        Reference Id to uniquely identify the transaction.  # noqa: E501

        :return: The transaction_reference_id of this PendingTransaction.  # noqa: E501
        :rtype: str
        """
        return self._transaction_reference_id

    @transaction_reference_id.setter
    def transaction_reference_id(self, transaction_reference_id):
        """Sets the transaction_reference_id of this PendingTransaction.

        Reference Id to uniquely identify the transaction.  # noqa: E501

        :param transaction_reference_id: The transaction_reference_id of this PendingTransaction.  # noqa: E501
        :type: str
        """

        self._transaction_reference_id = transaction_reference_id

    @property
    def merchant_name(self):
        """Gets the merchant_name of this PendingTransaction.  # noqa: E501

        Transaction merchant name.  # noqa: E501

        :return: The merchant_name of this PendingTransaction.  # noqa: E501
        :rtype: str
        """
        return self._merchant_name

    @merchant_name.setter
    def merchant_name(self, merchant_name):
        """Sets the merchant_name of this PendingTransaction.

        Transaction merchant name.  # noqa: E501

        :param merchant_name: The merchant_name of this PendingTransaction.  # noqa: E501
        :type: str
        """

        self._merchant_name = merchant_name

    @property
    def transaction_amount(self):
        """Gets the transaction_amount of this PendingTransaction.  # noqa: E501

        Transaction amount in local currency.  # noqa: E501

        :return: The transaction_amount of this PendingTransaction.  # noqa: E501
        :rtype: float
        """
        return self._transaction_amount

    @transaction_amount.setter
    def transaction_amount(self, transaction_amount):
        """Sets the transaction_amount of this PendingTransaction.

        Transaction amount in local currency.  # noqa: E501

        :param transaction_amount: The transaction_amount of this PendingTransaction.  # noqa: E501
        :type: float
        """
        if transaction_amount is None:
            raise ValueError("Invalid value for `transaction_amount`, must not be `None`")  # noqa: E501

        self._transaction_amount = transaction_amount

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
        if issubclass(PendingTransaction, dict):
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
        if not isinstance(other, PendingTransaction):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other