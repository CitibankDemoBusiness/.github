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

class CreditCardStatementSummary(object):
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
        'card_id': 'str',
        'display_account_number': 'str',
        'eligible_source_accts_for_payment_flag': 'bool',
        'epp_eligible_amount': 'float',
        'epp_minimum_eligible_amount': 'float',
        'epp_minimum_installment_amount': 'float',
        'credit_card_statement': 'list[CreditCardStatement]',
        'statement_summary_error_details': 'ErrorResponse',
        'next_start_index': 'str'
    }

    attribute_map = {
        'card_id': 'cardId',
        'display_account_number': 'displayAccountNumber',
        'eligible_source_accts_for_payment_flag': 'eligibleSourceAcctsForPaymentFlag',
        'epp_eligible_amount': 'eppEligibleAmount',
        'epp_minimum_eligible_amount': 'eppMinimumEligibleAmount',
        'epp_minimum_installment_amount': 'eppMinimumInstallmentAmount',
        'credit_card_statement': 'creditCardStatement',
        'statement_summary_error_details': 'statementSummaryErrorDetails',
        'next_start_index': 'nextStartIndex'
    }

    def __init__(self, card_id=None, display_account_number=None, eligible_source_accts_for_payment_flag=None, epp_eligible_amount=None, epp_minimum_eligible_amount=None, epp_minimum_installment_amount=None, credit_card_statement=None, statement_summary_error_details=None, next_start_index=None):  # noqa: E501
        """CreditCardStatementSummary - a model defined in Swagger"""  # noqa: E501
        self._card_id = None
        self._display_account_number = None
        self._eligible_source_accts_for_payment_flag = None
        self._epp_eligible_amount = None
        self._epp_minimum_eligible_amount = None
        self._epp_minimum_installment_amount = None
        self._credit_card_statement = None
        self._statement_summary_error_details = None
        self._next_start_index = None
        self.discriminator = None
        self.card_id = card_id
        self.display_account_number = display_account_number
        if eligible_source_accts_for_payment_flag is not None:
            self.eligible_source_accts_for_payment_flag = eligible_source_accts_for_payment_flag
        if epp_eligible_amount is not None:
            self.epp_eligible_amount = epp_eligible_amount
        if epp_minimum_eligible_amount is not None:
            self.epp_minimum_eligible_amount = epp_minimum_eligible_amount
        if epp_minimum_installment_amount is not None:
            self.epp_minimum_installment_amount = epp_minimum_installment_amount
        if credit_card_statement is not None:
            self.credit_card_statement = credit_card_statement
        if statement_summary_error_details is not None:
            self.statement_summary_error_details = statement_summary_error_details
        if next_start_index is not None:
            self.next_start_index = next_start_index

    @property
    def card_id(self):
        """Gets the card_id of this CreditCardStatementSummary.  # noqa: E501

        The card id  in encrypted format  # noqa: E501

        :return: The card_id of this CreditCardStatementSummary.  # noqa: E501
        :rtype: str
        """
        return self._card_id

    @card_id.setter
    def card_id(self, card_id):
        """Sets the card_id of this CreditCardStatementSummary.

        The card id  in encrypted format  # noqa: E501

        :param card_id: The card_id of this CreditCardStatementSummary.  # noqa: E501
        :type: str
        """
        if card_id is None:
            raise ValueError("Invalid value for `card_id`, must not be `None`")  # noqa: E501

        self._card_id = card_id

    @property
    def display_account_number(self):
        """Gets the display_account_number of this CreditCardStatementSummary.  # noqa: E501

        A masked account number that can be displayed to the customer  # noqa: E501

        :return: The display_account_number of this CreditCardStatementSummary.  # noqa: E501
        :rtype: str
        """
        return self._display_account_number

    @display_account_number.setter
    def display_account_number(self, display_account_number):
        """Sets the display_account_number of this CreditCardStatementSummary.

        A masked account number that can be displayed to the customer  # noqa: E501

        :param display_account_number: The display_account_number of this CreditCardStatementSummary.  # noqa: E501
        :type: str
        """
        if display_account_number is None:
            raise ValueError("Invalid value for `display_account_number`, must not be `None`")  # noqa: E501

        self._display_account_number = display_account_number

    @property
    def eligible_source_accts_for_payment_flag(self):
        """Gets the eligible_source_accts_for_payment_flag of this CreditCardStatementSummary.  # noqa: E501

        ’Flag to indicate if eligible source accounts are available to make credit card payment on-line.  # noqa: E501

        :return: The eligible_source_accts_for_payment_flag of this CreditCardStatementSummary.  # noqa: E501
        :rtype: bool
        """
        return self._eligible_source_accts_for_payment_flag

    @eligible_source_accts_for_payment_flag.setter
    def eligible_source_accts_for_payment_flag(self, eligible_source_accts_for_payment_flag):
        """Sets the eligible_source_accts_for_payment_flag of this CreditCardStatementSummary.

        ’Flag to indicate if eligible source accounts are available to make credit card payment on-line.  # noqa: E501

        :param eligible_source_accts_for_payment_flag: The eligible_source_accts_for_payment_flag of this CreditCardStatementSummary.  # noqa: E501
        :type: bool
        """

        self._eligible_source_accts_for_payment_flag = eligible_source_accts_for_payment_flag

    @property
    def epp_eligible_amount(self):
        """Gets the epp_eligible_amount of this CreditCardStatementSummary.  # noqa: E501

        Eligible amount for Equal Payment Plan. Applicable only if eligibleForEqualPaymentPlan='ELIGIBLE'.  # noqa: E501

        :return: The epp_eligible_amount of this CreditCardStatementSummary.  # noqa: E501
        :rtype: float
        """
        return self._epp_eligible_amount

    @epp_eligible_amount.setter
    def epp_eligible_amount(self, epp_eligible_amount):
        """Sets the epp_eligible_amount of this CreditCardStatementSummary.

        Eligible amount for Equal Payment Plan. Applicable only if eligibleForEqualPaymentPlan='ELIGIBLE'.  # noqa: E501

        :param epp_eligible_amount: The epp_eligible_amount of this CreditCardStatementSummary.  # noqa: E501
        :type: float
        """

        self._epp_eligible_amount = epp_eligible_amount

    @property
    def epp_minimum_eligible_amount(self):
        """Gets the epp_minimum_eligible_amount of this CreditCardStatementSummary.  # noqa: E501

        Minimum eligible amount for which Equal Payment Plan can be booked. Applicable only if eligibleForEqualPaymentPlan='ELIGIBLE'.  # noqa: E501

        :return: The epp_minimum_eligible_amount of this CreditCardStatementSummary.  # noqa: E501
        :rtype: float
        """
        return self._epp_minimum_eligible_amount

    @epp_minimum_eligible_amount.setter
    def epp_minimum_eligible_amount(self, epp_minimum_eligible_amount):
        """Sets the epp_minimum_eligible_amount of this CreditCardStatementSummary.

        Minimum eligible amount for which Equal Payment Plan can be booked. Applicable only if eligibleForEqualPaymentPlan='ELIGIBLE'.  # noqa: E501

        :param epp_minimum_eligible_amount: The epp_minimum_eligible_amount of this CreditCardStatementSummary.  # noqa: E501
        :type: float
        """

        self._epp_minimum_eligible_amount = epp_minimum_eligible_amount

    @property
    def epp_minimum_installment_amount(self):
        """Gets the epp_minimum_installment_amount of this CreditCardStatementSummary.  # noqa: E501

        Minimum instalment amount for Equal Payment Plan. Applicable only if eligibleForEqualPaymentPlan='ELIGIBLE'.  # noqa: E501

        :return: The epp_minimum_installment_amount of this CreditCardStatementSummary.  # noqa: E501
        :rtype: float
        """
        return self._epp_minimum_installment_amount

    @epp_minimum_installment_amount.setter
    def epp_minimum_installment_amount(self, epp_minimum_installment_amount):
        """Sets the epp_minimum_installment_amount of this CreditCardStatementSummary.

        Minimum instalment amount for Equal Payment Plan. Applicable only if eligibleForEqualPaymentPlan='ELIGIBLE'.  # noqa: E501

        :param epp_minimum_installment_amount: The epp_minimum_installment_amount of this CreditCardStatementSummary.  # noqa: E501
        :type: float
        """

        self._epp_minimum_installment_amount = epp_minimum_installment_amount

    @property
    def credit_card_statement(self):
        """Gets the credit_card_statement of this CreditCardStatementSummary.  # noqa: E501


        :return: The credit_card_statement of this CreditCardStatementSummary.  # noqa: E501
        :rtype: list[CreditCardStatement]
        """
        return self._credit_card_statement

    @credit_card_statement.setter
    def credit_card_statement(self, credit_card_statement):
        """Sets the credit_card_statement of this CreditCardStatementSummary.


        :param credit_card_statement: The credit_card_statement of this CreditCardStatementSummary.  # noqa: E501
        :type: list[CreditCardStatement]
        """

        self._credit_card_statement = credit_card_statement

    @property
    def statement_summary_error_details(self):
        """Gets the statement_summary_error_details of this CreditCardStatementSummary.  # noqa: E501


        :return: The statement_summary_error_details of this CreditCardStatementSummary.  # noqa: E501
        :rtype: ErrorResponse
        """
        return self._statement_summary_error_details

    @statement_summary_error_details.setter
    def statement_summary_error_details(self, statement_summary_error_details):
        """Sets the statement_summary_error_details of this CreditCardStatementSummary.


        :param statement_summary_error_details: The statement_summary_error_details of this CreditCardStatementSummary.  # noqa: E501
        :type: ErrorResponse
        """

        self._statement_summary_error_details = statement_summary_error_details

    @property
    def next_start_index(self):
        """Gets the next_start_index of this CreditCardStatementSummary.  # noqa: E501

        In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.  # noqa: E501

        :return: The next_start_index of this CreditCardStatementSummary.  # noqa: E501
        :rtype: str
        """
        return self._next_start_index

    @next_start_index.setter
    def next_start_index(self, next_start_index):
        """Sets the next_start_index of this CreditCardStatementSummary.

        In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.  # noqa: E501

        :param next_start_index: The next_start_index of this CreditCardStatementSummary.  # noqa: E501
        :type: str
        """

        self._next_start_index = next_start_index

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
        if issubclass(CreditCardStatementSummary, dict):
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
        if not isinstance(other, CreditCardStatementSummary):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other