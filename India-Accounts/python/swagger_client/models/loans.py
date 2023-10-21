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

class Loans(object):
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
        'loan_reference_id': 'str',
        'display_account_number': 'str',
        'transaction_date': 'date',
        'transaction_description': 'str',
        'installment_amount': 'float',
        'next_installment_amount': 'float',
        'outstanding_balance_amount': 'float',
        'tenor': 'float',
        'outstanding_tenor': 'float',
        'original_loan_amount': 'float',
        'annual_percentage_rate': 'float',
        'effective_interest_rate': 'float',
        'processing_charge_amount': 'float',
        'outstanding_interest_amount': 'float',
        'self_early_loan_closure_allowed_flag': 'bool',
        'installment_cycle': 'int'
    }

    attribute_map = {
        'loan_reference_id': 'loanReferenceId',
        'display_account_number': 'displayAccountNumber',
        'transaction_date': 'transactionDate',
        'transaction_description': 'transactionDescription',
        'installment_amount': 'installmentAmount',
        'next_installment_amount': 'nextInstallmentAmount',
        'outstanding_balance_amount': 'outstandingBalanceAmount',
        'tenor': 'tenor',
        'outstanding_tenor': 'outstandingTenor',
        'original_loan_amount': 'originalLoanAmount',
        'annual_percentage_rate': 'annualPercentageRate',
        'effective_interest_rate': 'effectiveInterestRate',
        'processing_charge_amount': 'processingChargeAmount',
        'outstanding_interest_amount': 'outstandingInterestAmount',
        'self_early_loan_closure_allowed_flag': 'selfEarlyLoanClosureAllowedFlag',
        'installment_cycle': 'installmentCycle'
    }

    def __init__(self, loan_reference_id=None, display_account_number=None, transaction_date=None, transaction_description=None, installment_amount=None, next_installment_amount=None, outstanding_balance_amount=None, tenor=None, outstanding_tenor=None, original_loan_amount=None, annual_percentage_rate=None, effective_interest_rate=None, processing_charge_amount=None, outstanding_interest_amount=None, self_early_loan_closure_allowed_flag=None, installment_cycle=None):  # noqa: E501
        """Loans - a model defined in Swagger"""  # noqa: E501
        self._loan_reference_id = None
        self._display_account_number = None
        self._transaction_date = None
        self._transaction_description = None
        self._installment_amount = None
        self._next_installment_amount = None
        self._outstanding_balance_amount = None
        self._tenor = None
        self._outstanding_tenor = None
        self._original_loan_amount = None
        self._annual_percentage_rate = None
        self._effective_interest_rate = None
        self._processing_charge_amount = None
        self._outstanding_interest_amount = None
        self._self_early_loan_closure_allowed_flag = None
        self._installment_cycle = None
        self.discriminator = None
        self.loan_reference_id = loan_reference_id
        if display_account_number is not None:
            self.display_account_number = display_account_number
        self.transaction_date = transaction_date
        self.transaction_description = transaction_description
        self.installment_amount = installment_amount
        if next_installment_amount is not None:
            self.next_installment_amount = next_installment_amount
        self.outstanding_balance_amount = outstanding_balance_amount
        self.tenor = tenor
        if outstanding_tenor is not None:
            self.outstanding_tenor = outstanding_tenor
        self.original_loan_amount = original_loan_amount
        self.annual_percentage_rate = annual_percentage_rate
        if effective_interest_rate is not None:
            self.effective_interest_rate = effective_interest_rate
        if processing_charge_amount is not None:
            self.processing_charge_amount = processing_charge_amount
        if outstanding_interest_amount is not None:
            self.outstanding_interest_amount = outstanding_interest_amount
        if self_early_loan_closure_allowed_flag is not None:
            self.self_early_loan_closure_allowed_flag = self_early_loan_closure_allowed_flag
        if installment_cycle is not None:
            self.installment_cycle = installment_cycle

    @property
    def loan_reference_id(self):
        """Gets the loan_reference_id of this Loans.  # noqa: E501

        Reference Id to uniquely identify the loan.   # noqa: E501

        :return: The loan_reference_id of this Loans.  # noqa: E501
        :rtype: str
        """
        return self._loan_reference_id

    @loan_reference_id.setter
    def loan_reference_id(self, loan_reference_id):
        """Sets the loan_reference_id of this Loans.

        Reference Id to uniquely identify the loan.   # noqa: E501

        :param loan_reference_id: The loan_reference_id of this Loans.  # noqa: E501
        :type: str
        """
        if loan_reference_id is None:
            raise ValueError("Invalid value for `loan_reference_id`, must not be `None`")  # noqa: E501

        self._loan_reference_id = loan_reference_id

    @property
    def display_account_number(self):
        """Gets the display_account_number of this Loans.  # noqa: E501

        Last 4 digits of account number.   # noqa: E501

        :return: The display_account_number of this Loans.  # noqa: E501
        :rtype: str
        """
        return self._display_account_number

    @display_account_number.setter
    def display_account_number(self, display_account_number):
        """Sets the display_account_number of this Loans.

        Last 4 digits of account number.   # noqa: E501

        :param display_account_number: The display_account_number of this Loans.  # noqa: E501
        :type: str
        """

        self._display_account_number = display_account_number

    @property
    def transaction_date(self):
        """Gets the transaction_date of this Loans.  # noqa: E501

        Transaction date in YYYY-MM-DD format value conforming to ISO 8601.  # noqa: E501

        :return: The transaction_date of this Loans.  # noqa: E501
        :rtype: date
        """
        return self._transaction_date

    @transaction_date.setter
    def transaction_date(self, transaction_date):
        """Sets the transaction_date of this Loans.

        Transaction date in YYYY-MM-DD format value conforming to ISO 8601.  # noqa: E501

        :param transaction_date: The transaction_date of this Loans.  # noqa: E501
        :type: date
        """
        if transaction_date is None:
            raise ValueError("Invalid value for `transaction_date`, must not be `None`")  # noqa: E501

        self._transaction_date = transaction_date

    @property
    def transaction_description(self):
        """Gets the transaction_description of this Loans.  # noqa: E501

        Transaction description from the merchant, POS or bank. If there are foreign currency transactions on checking /saving account(s) then description includes exchange rate, city and country.  # noqa: E501

        :return: The transaction_description of this Loans.  # noqa: E501
        :rtype: str
        """
        return self._transaction_description

    @transaction_description.setter
    def transaction_description(self, transaction_description):
        """Sets the transaction_description of this Loans.

        Transaction description from the merchant, POS or bank. If there are foreign currency transactions on checking /saving account(s) then description includes exchange rate, city and country.  # noqa: E501

        :param transaction_description: The transaction_description of this Loans.  # noqa: E501
        :type: str
        """
        if transaction_description is None:
            raise ValueError("Invalid value for `transaction_description`, must not be `None`")  # noqa: E501

        self._transaction_description = transaction_description

    @property
    def installment_amount(self):
        """Gets the installment_amount of this Loans.  # noqa: E501

        Installment loan payment amount  # noqa: E501

        :return: The installment_amount of this Loans.  # noqa: E501
        :rtype: float
        """
        return self._installment_amount

    @installment_amount.setter
    def installment_amount(self, installment_amount):
        """Sets the installment_amount of this Loans.

        Installment loan payment amount  # noqa: E501

        :param installment_amount: The installment_amount of this Loans.  # noqa: E501
        :type: float
        """
        if installment_amount is None:
            raise ValueError("Invalid value for `installment_amount`, must not be `None`")  # noqa: E501

        self._installment_amount = installment_amount

    @property
    def next_installment_amount(self):
        """Gets the next_installment_amount of this Loans.  # noqa: E501

        Next installment amount in local currency.  # noqa: E501

        :return: The next_installment_amount of this Loans.  # noqa: E501
        :rtype: float
        """
        return self._next_installment_amount

    @next_installment_amount.setter
    def next_installment_amount(self, next_installment_amount):
        """Sets the next_installment_amount of this Loans.

        Next installment amount in local currency.  # noqa: E501

        :param next_installment_amount: The next_installment_amount of this Loans.  # noqa: E501
        :type: float
        """

        self._next_installment_amount = next_installment_amount

    @property
    def outstanding_balance_amount(self):
        """Gets the outstanding_balance_amount of this Loans.  # noqa: E501

        The amount of money owed.  # noqa: E501

        :return: The outstanding_balance_amount of this Loans.  # noqa: E501
        :rtype: float
        """
        return self._outstanding_balance_amount

    @outstanding_balance_amount.setter
    def outstanding_balance_amount(self, outstanding_balance_amount):
        """Sets the outstanding_balance_amount of this Loans.

        The amount of money owed.  # noqa: E501

        :param outstanding_balance_amount: The outstanding_balance_amount of this Loans.  # noqa: E501
        :type: float
        """
        if outstanding_balance_amount is None:
            raise ValueError("Invalid value for `outstanding_balance_amount`, must not be `None`")  # noqa: E501

        self._outstanding_balance_amount = outstanding_balance_amount

    @property
    def tenor(self):
        """Gets the tenor of this Loans.  # noqa: E501

        Tenure of loan in months.  # noqa: E501

        :return: The tenor of this Loans.  # noqa: E501
        :rtype: float
        """
        return self._tenor

    @tenor.setter
    def tenor(self, tenor):
        """Sets the tenor of this Loans.

        Tenure of loan in months.  # noqa: E501

        :param tenor: The tenor of this Loans.  # noqa: E501
        :type: float
        """
        if tenor is None:
            raise ValueError("Invalid value for `tenor`, must not be `None`")  # noqa: E501

        self._tenor = tenor

    @property
    def outstanding_tenor(self):
        """Gets the outstanding_tenor of this Loans.  # noqa: E501

        Number of months remaining for completion of loan.  # noqa: E501

        :return: The outstanding_tenor of this Loans.  # noqa: E501
        :rtype: float
        """
        return self._outstanding_tenor

    @outstanding_tenor.setter
    def outstanding_tenor(self, outstanding_tenor):
        """Sets the outstanding_tenor of this Loans.

        Number of months remaining for completion of loan.  # noqa: E501

        :param outstanding_tenor: The outstanding_tenor of this Loans.  # noqa: E501
        :type: float
        """

        self._outstanding_tenor = outstanding_tenor

    @property
    def original_loan_amount(self):
        """Gets the original_loan_amount of this Loans.  # noqa: E501

        Original loan amount borrowed by customer.  # noqa: E501

        :return: The original_loan_amount of this Loans.  # noqa: E501
        :rtype: float
        """
        return self._original_loan_amount

    @original_loan_amount.setter
    def original_loan_amount(self, original_loan_amount):
        """Sets the original_loan_amount of this Loans.

        Original loan amount borrowed by customer.  # noqa: E501

        :param original_loan_amount: The original_loan_amount of this Loans.  # noqa: E501
        :type: float
        """
        if original_loan_amount is None:
            raise ValueError("Invalid value for `original_loan_amount`, must not be `None`")  # noqa: E501

        self._original_loan_amount = original_loan_amount

    @property
    def annual_percentage_rate(self):
        """Gets the annual_percentage_rate of this Loans.  # noqa: E501

        Interest rate for a whole year. This includes any fees or additional cost associated.  # noqa: E501

        :return: The annual_percentage_rate of this Loans.  # noqa: E501
        :rtype: float
        """
        return self._annual_percentage_rate

    @annual_percentage_rate.setter
    def annual_percentage_rate(self, annual_percentage_rate):
        """Sets the annual_percentage_rate of this Loans.

        Interest rate for a whole year. This includes any fees or additional cost associated.  # noqa: E501

        :param annual_percentage_rate: The annual_percentage_rate of this Loans.  # noqa: E501
        :type: float
        """
        if annual_percentage_rate is None:
            raise ValueError("Invalid value for `annual_percentage_rate`, must not be `None`")  # noqa: E501

        self._annual_percentage_rate = annual_percentage_rate

    @property
    def effective_interest_rate(self):
        """Gets the effective_interest_rate of this Loans.  # noqa: E501

        Effective Percentage Rate  # noqa: E501

        :return: The effective_interest_rate of this Loans.  # noqa: E501
        :rtype: float
        """
        return self._effective_interest_rate

    @effective_interest_rate.setter
    def effective_interest_rate(self, effective_interest_rate):
        """Sets the effective_interest_rate of this Loans.

        Effective Percentage Rate  # noqa: E501

        :param effective_interest_rate: The effective_interest_rate of this Loans.  # noqa: E501
        :type: float
        """

        self._effective_interest_rate = effective_interest_rate

    @property
    def processing_charge_amount(self):
        """Gets the processing_charge_amount of this Loans.  # noqa: E501

        Charges levied on applicant by the bank to process the loan.  # noqa: E501

        :return: The processing_charge_amount of this Loans.  # noqa: E501
        :rtype: float
        """
        return self._processing_charge_amount

    @processing_charge_amount.setter
    def processing_charge_amount(self, processing_charge_amount):
        """Sets the processing_charge_amount of this Loans.

        Charges levied on applicant by the bank to process the loan.  # noqa: E501

        :param processing_charge_amount: The processing_charge_amount of this Loans.  # noqa: E501
        :type: float
        """

        self._processing_charge_amount = processing_charge_amount

    @property
    def outstanding_interest_amount(self):
        """Gets the outstanding_interest_amount of this Loans.  # noqa: E501

        Total Outstanding Interest Amount.  # noqa: E501

        :return: The outstanding_interest_amount of this Loans.  # noqa: E501
        :rtype: float
        """
        return self._outstanding_interest_amount

    @outstanding_interest_amount.setter
    def outstanding_interest_amount(self, outstanding_interest_amount):
        """Sets the outstanding_interest_amount of this Loans.

        Total Outstanding Interest Amount.  # noqa: E501

        :param outstanding_interest_amount: The outstanding_interest_amount of this Loans.  # noqa: E501
        :type: float
        """

        self._outstanding_interest_amount = outstanding_interest_amount

    @property
    def self_early_loan_closure_allowed_flag(self):
        """Gets the self_early_loan_closure_allowed_flag of this Loans.  # noqa: E501

        Flag to identify if the loan is allowed to be early self closed by customer or not..  # noqa: E501

        :return: The self_early_loan_closure_allowed_flag of this Loans.  # noqa: E501
        :rtype: bool
        """
        return self._self_early_loan_closure_allowed_flag

    @self_early_loan_closure_allowed_flag.setter
    def self_early_loan_closure_allowed_flag(self, self_early_loan_closure_allowed_flag):
        """Sets the self_early_loan_closure_allowed_flag of this Loans.

        Flag to identify if the loan is allowed to be early self closed by customer or not..  # noqa: E501

        :param self_early_loan_closure_allowed_flag: The self_early_loan_closure_allowed_flag of this Loans.  # noqa: E501
        :type: bool
        """

        self._self_early_loan_closure_allowed_flag = self_early_loan_closure_allowed_flag

    @property
    def installment_cycle(self):
        """Gets the installment_cycle of this Loans.  # noqa: E501

        Intallment Cycle  # noqa: E501

        :return: The installment_cycle of this Loans.  # noqa: E501
        :rtype: int
        """
        return self._installment_cycle

    @installment_cycle.setter
    def installment_cycle(self, installment_cycle):
        """Sets the installment_cycle of this Loans.

        Intallment Cycle  # noqa: E501

        :param installment_cycle: The installment_cycle of this Loans.  # noqa: E501
        :type: int
        """

        self._installment_cycle = installment_cycle

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
        if issubclass(Loans, dict):
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
        if not isinstance(other, Loans):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other