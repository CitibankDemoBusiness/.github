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

class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse(object):
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
        'customer_name': 'str',
        'product_code': 'str',
        'service_charge_amount': 'str',
        'card_id': 'str',
        'product_name': 'str',
        'display_card_number': 'str',
        'pending_transaction': 'PendingTransaction',
        'statement': 'Statement',
        'epp_offers': 'list[EppOffers]'
    }

    attribute_map = {
        'customer_name': 'customerName',
        'product_code': 'productCode',
        'service_charge_amount': 'serviceChargeAmount',
        'card_id': 'cardId',
        'product_name': 'productName',
        'display_card_number': 'displayCardNumber',
        'pending_transaction': 'pendingTransaction',
        'statement': 'statement',
        'epp_offers': 'eppOffers'
    }

    def __init__(self, customer_name=None, product_code=None, service_charge_amount=None, card_id=None, product_name=None, display_card_number=None, pending_transaction=None, statement=None, epp_offers=None):  # noqa: E501
        """RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse - a model defined in Swagger"""  # noqa: E501
        self._customer_name = None
        self._product_code = None
        self._service_charge_amount = None
        self._card_id = None
        self._product_name = None
        self._display_card_number = None
        self._pending_transaction = None
        self._statement = None
        self._epp_offers = None
        self.discriminator = None
        self.customer_name = customer_name
        self.product_code = product_code
        if service_charge_amount is not None:
            self.service_charge_amount = service_charge_amount
        if card_id is not None:
            self.card_id = card_id
        self.product_name = product_name
        self.display_card_number = display_card_number
        if pending_transaction is not None:
            self.pending_transaction = pending_transaction
        if statement is not None:
            self.statement = statement
        if epp_offers is not None:
            self.epp_offers = epp_offers

    @property
    def customer_name(self):
        """Gets the customer_name of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.  # noqa: E501

        his refers to the name of the customer  # noqa: E501

        :return: The customer_name of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.  # noqa: E501
        :rtype: str
        """
        return self._customer_name

    @customer_name.setter
    def customer_name(self, customer_name):
        """Sets the customer_name of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.

        his refers to the name of the customer  # noqa: E501

        :param customer_name: The customer_name of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.  # noqa: E501
        :type: str
        """
        if customer_name is None:
            raise ValueError("Invalid value for `customer_name`, must not be `None`")  # noqa: E501

        self._customer_name = customer_name

    @property
    def product_code(self):
        """Gets the product_code of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.  # noqa: E501

        A unique code that identifies the product  # noqa: E501

        :return: The product_code of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.  # noqa: E501
        :rtype: str
        """
        return self._product_code

    @product_code.setter
    def product_code(self, product_code):
        """Sets the product_code of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.

        A unique code that identifies the product  # noqa: E501

        :param product_code: The product_code of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.  # noqa: E501
        :type: str
        """
        if product_code is None:
            raise ValueError("Invalid value for `product_code`, must not be `None`")  # noqa: E501

        self._product_code = product_code

    @property
    def service_charge_amount(self):
        """Gets the service_charge_amount of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.  # noqa: E501

        Booking Fees Amount  # noqa: E501

        :return: The service_charge_amount of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.  # noqa: E501
        :rtype: str
        """
        return self._service_charge_amount

    @service_charge_amount.setter
    def service_charge_amount(self, service_charge_amount):
        """Sets the service_charge_amount of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.

        Booking Fees Amount  # noqa: E501

        :param service_charge_amount: The service_charge_amount of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.  # noqa: E501
        :type: str
        """

        self._service_charge_amount = service_charge_amount

    @property
    def card_id(self):
        """Gets the card_id of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.  # noqa: E501

        The customer card identifier in encrypted format  # noqa: E501

        :return: The card_id of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.  # noqa: E501
        :rtype: str
        """
        return self._card_id

    @card_id.setter
    def card_id(self, card_id):
        """Sets the card_id of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.

        The customer card identifier in encrypted format  # noqa: E501

        :param card_id: The card_id of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.  # noqa: E501
        :type: str
        """

        self._card_id = card_id

    @property
    def product_name(self):
        """Gets the product_name of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.  # noqa: E501

        The name of the product  # noqa: E501

        :return: The product_name of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.  # noqa: E501
        :rtype: str
        """
        return self._product_name

    @product_name.setter
    def product_name(self, product_name):
        """Sets the product_name of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.

        The name of the product  # noqa: E501

        :param product_name: The product_name of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.  # noqa: E501
        :type: str
        """
        if product_name is None:
            raise ValueError("Invalid value for `product_name`, must not be `None`")  # noqa: E501

        self._product_name = product_name

    @property
    def display_card_number(self):
        """Gets the display_card_number of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.  # noqa: E501

        A masked Card number that can be displayed to the customer  # noqa: E501

        :return: The display_card_number of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.  # noqa: E501
        :rtype: str
        """
        return self._display_card_number

    @display_card_number.setter
    def display_card_number(self, display_card_number):
        """Sets the display_card_number of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.

        A masked Card number that can be displayed to the customer  # noqa: E501

        :param display_card_number: The display_card_number of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.  # noqa: E501
        :type: str
        """
        if display_card_number is None:
            raise ValueError("Invalid value for `display_card_number`, must not be `None`")  # noqa: E501

        self._display_card_number = display_card_number

    @property
    def pending_transaction(self):
        """Gets the pending_transaction of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.  # noqa: E501


        :return: The pending_transaction of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.  # noqa: E501
        :rtype: PendingTransaction
        """
        return self._pending_transaction

    @pending_transaction.setter
    def pending_transaction(self, pending_transaction):
        """Sets the pending_transaction of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.


        :param pending_transaction: The pending_transaction of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.  # noqa: E501
        :type: PendingTransaction
        """

        self._pending_transaction = pending_transaction

    @property
    def statement(self):
        """Gets the statement of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.  # noqa: E501


        :return: The statement of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.  # noqa: E501
        :rtype: Statement
        """
        return self._statement

    @statement.setter
    def statement(self, statement):
        """Sets the statement of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.


        :param statement: The statement of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.  # noqa: E501
        :type: Statement
        """

        self._statement = statement

    @property
    def epp_offers(self):
        """Gets the epp_offers of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.  # noqa: E501


        :return: The epp_offers of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.  # noqa: E501
        :rtype: list[EppOffers]
        """
        return self._epp_offers

    @epp_offers.setter
    def epp_offers(self, epp_offers):
        """Sets the epp_offers of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.


        :param epp_offers: The epp_offers of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.  # noqa: E501
        :type: list[EppOffers]
        """

        self._epp_offers = epp_offers

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
        if issubclass(RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse, dict):
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
        if not isinstance(other, RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other