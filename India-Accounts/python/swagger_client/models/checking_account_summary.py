# coding: utf-8

"""
    Accounts

    The Accounts API allows you to retrieve account and transaction data for Citi Customers who have authorized your app. In most cases, you'll want to request a summary of all accounts first, which will return basic account information and accountIds. Once you have this information, you can request additional account details and/or transactions.  # noqa: E501

    OpenAPI spec version: 1.0.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

import pprint
import re  # noqa: F401

import six

class CheckingAccountSummary(object):
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
        'product_name': 'str',
        'product_code': 'str',
        'account_nickname': 'str',
        'display_account_number': 'str',
        'account_id': 'str',
        'currency_code': 'str',
        'account_status': 'str',
        'account_classification': 'str',
        'current_balance': 'float',
        'available_balance': 'float'
    }

    attribute_map = {
        'product_name': 'productName',
        'product_code': 'productCode',
        'account_nickname': 'accountNickname',
        'display_account_number': 'displayAccountNumber',
        'account_id': 'accountId',
        'currency_code': 'currencyCode',
        'account_status': 'accountStatus',
        'account_classification': 'accountClassification',
        'current_balance': 'currentBalance',
        'available_balance': 'availableBalance'
    }

    def __init__(self, product_name=None, product_code=None, account_nickname=None, display_account_number=None, account_id=None, currency_code=None, account_status=None, account_classification=None, current_balance=None, available_balance=None):  # noqa: E501
        """CheckingAccountSummary - a model defined in Swagger"""  # noqa: E501
        self._product_name = None
        self._product_code = None
        self._account_nickname = None
        self._display_account_number = None
        self._account_id = None
        self._currency_code = None
        self._account_status = None
        self._account_classification = None
        self._current_balance = None
        self._available_balance = None
        self.discriminator = None
        if product_name is not None:
            self.product_name = product_name
        if product_code is not None:
            self.product_code = product_code
        if account_nickname is not None:
            self.account_nickname = account_nickname
        if display_account_number is not None:
            self.display_account_number = display_account_number
        if account_id is not None:
            self.account_id = account_id
        if currency_code is not None:
            self.currency_code = currency_code
        if account_status is not None:
            self.account_status = account_status
        if account_classification is not None:
            self.account_classification = account_classification
        if current_balance is not None:
            self.current_balance = current_balance
        if available_balance is not None:
            self.available_balance = available_balance

    @property
    def product_name(self):
        """Gets the product_name of this CheckingAccountSummary.  # noqa: E501

        The name of the product  # noqa: E501

        :return: The product_name of this CheckingAccountSummary.  # noqa: E501
        :rtype: str
        """
        return self._product_name

    @product_name.setter
    def product_name(self, product_name):
        """Sets the product_name of this CheckingAccountSummary.

        The name of the product  # noqa: E501

        :param product_name: The product_name of this CheckingAccountSummary.  # noqa: E501
        :type: str
        """

        self._product_name = product_name

    @property
    def product_code(self):
        """Gets the product_code of this CheckingAccountSummary.  # noqa: E501

        A unique code that identifies the product  # noqa: E501

        :return: The product_code of this CheckingAccountSummary.  # noqa: E501
        :rtype: str
        """
        return self._product_code

    @product_code.setter
    def product_code(self, product_code):
        """Sets the product_code of this CheckingAccountSummary.

        A unique code that identifies the product  # noqa: E501

        :param product_code: The product_code of this CheckingAccountSummary.  # noqa: E501
        :type: str
        """

        self._product_code = product_code

    @property
    def account_nickname(self):
        """Gets the account_nickname of this CheckingAccountSummary.  # noqa: E501

        The nickname of the account assigned by the customer  # noqa: E501

        :return: The account_nickname of this CheckingAccountSummary.  # noqa: E501
        :rtype: str
        """
        return self._account_nickname

    @account_nickname.setter
    def account_nickname(self, account_nickname):
        """Sets the account_nickname of this CheckingAccountSummary.

        The nickname of the account assigned by the customer  # noqa: E501

        :param account_nickname: The account_nickname of this CheckingAccountSummary.  # noqa: E501
        :type: str
        """

        self._account_nickname = account_nickname

    @property
    def display_account_number(self):
        """Gets the display_account_number of this CheckingAccountSummary.  # noqa: E501

        A masked account number that can be displayed to the customer  # noqa: E501

        :return: The display_account_number of this CheckingAccountSummary.  # noqa: E501
        :rtype: str
        """
        return self._display_account_number

    @display_account_number.setter
    def display_account_number(self, display_account_number):
        """Sets the display_account_number of this CheckingAccountSummary.

        A masked account number that can be displayed to the customer  # noqa: E501

        :param display_account_number: The display_account_number of this CheckingAccountSummary.  # noqa: E501
        :type: str
        """

        self._display_account_number = display_account_number

    @property
    def account_id(self):
        """Gets the account_id of this CheckingAccountSummary.  # noqa: E501

        The customer account identifier in encrypted format.  # noqa: E501

        :return: The account_id of this CheckingAccountSummary.  # noqa: E501
        :rtype: str
        """
        return self._account_id

    @account_id.setter
    def account_id(self, account_id):
        """Sets the account_id of this CheckingAccountSummary.

        The customer account identifier in encrypted format.  # noqa: E501

        :param account_id: The account_id of this CheckingAccountSummary.  # noqa: E501
        :type: str
        """

        self._account_id = account_id

    @property
    def currency_code(self):
        """Gets the currency_code of this CheckingAccountSummary.  # noqa: E501

        The currency code in ISO 4217 format  # noqa: E501

        :return: The currency_code of this CheckingAccountSummary.  # noqa: E501
        :rtype: str
        """
        return self._currency_code

    @currency_code.setter
    def currency_code(self, currency_code):
        """Sets the currency_code of this CheckingAccountSummary.

        The currency code in ISO 4217 format  # noqa: E501

        :param currency_code: The currency_code of this CheckingAccountSummary.  # noqa: E501
        :type: str
        """

        self._currency_code = currency_code

    @property
    def account_status(self):
        """Gets the account_status of this CheckingAccountSummary.  # noqa: E501

        Status of the account. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The account_status of this CheckingAccountSummary.  # noqa: E501
        :rtype: str
        """
        return self._account_status

    @account_status.setter
    def account_status(self, account_status):
        """Sets the account_status of this CheckingAccountSummary.

        Status of the account. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param account_status: The account_status of this CheckingAccountSummary.  # noqa: E501
        :type: str
        """

        self._account_status = account_status

    @property
    def account_classification(self):
        """Gets the account_classification of this CheckingAccountSummary.  # noqa: E501

        Classification of account either as ASSET or LIABILITY. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountClassification} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The account_classification of this CheckingAccountSummary.  # noqa: E501
        :rtype: str
        """
        return self._account_classification

    @account_classification.setter
    def account_classification(self, account_classification):
        """Sets the account_classification of this CheckingAccountSummary.

        Classification of account either as ASSET or LIABILITY. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountClassification} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param account_classification: The account_classification of this CheckingAccountSummary.  # noqa: E501
        :type: str
        """

        self._account_classification = account_classification

    @property
    def current_balance(self):
        """Gets the current_balance of this CheckingAccountSummary.  # noqa: E501

        The current balance including any pending or in progress deposits and withdrawals  # noqa: E501

        :return: The current_balance of this CheckingAccountSummary.  # noqa: E501
        :rtype: float
        """
        return self._current_balance

    @current_balance.setter
    def current_balance(self, current_balance):
        """Sets the current_balance of this CheckingAccountSummary.

        The current balance including any pending or in progress deposits and withdrawals  # noqa: E501

        :param current_balance: The current_balance of this CheckingAccountSummary.  # noqa: E501
        :type: float
        """

        self._current_balance = current_balance

    @property
    def available_balance(self):
        """Gets the available_balance of this CheckingAccountSummary.  # noqa: E501

        The available balance of the saving account. It is the amount available  to withdraw or transfer immediately  # noqa: E501

        :return: The available_balance of this CheckingAccountSummary.  # noqa: E501
        :rtype: float
        """
        return self._available_balance

    @available_balance.setter
    def available_balance(self, available_balance):
        """Sets the available_balance of this CheckingAccountSummary.

        The available balance of the saving account. It is the amount available  to withdraw or transfer immediately  # noqa: E501

        :param available_balance: The available_balance of this CheckingAccountSummary.  # noqa: E501
        :type: float
        """

        self._available_balance = available_balance

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
        if issubclass(CheckingAccountSummary, dict):
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
        if not isinstance(other, CheckingAccountSummary):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
