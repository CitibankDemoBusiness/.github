# coding: utf-8

"""
    Onboarding

    The Onboarding API allows you to initiate the basic account opening process for new customers. The resources allow you to present eligible products, send applications for screening and submit a new application for one or more products. The resources also allow you to submit supporting documents. Application status can be checked at any point in the process, with decisioning happening in real time.  # noqa: E501

    OpenAPI spec version: 1.0.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

import pprint
import re  # noqa: F401

import six

class ApplicationUpdateReadyCreditProduct(object):
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
        'product_code': 'str',
        'source_code': 'str',
        'organization': 'str',
        'logo': 'str',
        'request_credit_shield': 'bool',
        'emboss_name': 'str',
        'billing_address': 'str',
        'card_delivery_address': 'str',
        'pin_delivery_address': 'str',
        'gift_code': 'str',
        'credit_limit_increase_indicator': 'bool',
        'atm_required_flag': 'bool',
        'cheque_book_required_flag': 'bool',
        'balance_transfer_details': 'list[ApplicationUpdateBalanceTransferDetails]'
    }

    attribute_map = {
        'product_code': 'productCode',
        'source_code': 'sourceCode',
        'organization': 'organization',
        'logo': 'logo',
        'request_credit_shield': 'requestCreditShield',
        'emboss_name': 'embossName',
        'billing_address': 'billingAddress',
        'card_delivery_address': 'cardDeliveryAddress',
        'pin_delivery_address': 'pinDeliveryAddress',
        'gift_code': 'giftCode',
        'credit_limit_increase_indicator': 'creditLimitIncreaseIndicator',
        'atm_required_flag': 'atmRequiredFlag',
        'cheque_book_required_flag': 'chequeBookRequiredFlag',
        'balance_transfer_details': 'balanceTransferDetails'
    }

    def __init__(self, product_code=None, source_code=None, organization=None, logo=None, request_credit_shield=None, emboss_name=None, billing_address=None, card_delivery_address=None, pin_delivery_address=None, gift_code=None, credit_limit_increase_indicator=None, atm_required_flag=None, cheque_book_required_flag=None, balance_transfer_details=None):  # noqa: E501
        """ApplicationUpdateReadyCreditProduct - a model defined in Swagger"""  # noqa: E501
        self._product_code = None
        self._source_code = None
        self._organization = None
        self._logo = None
        self._request_credit_shield = None
        self._emboss_name = None
        self._billing_address = None
        self._card_delivery_address = None
        self._pin_delivery_address = None
        self._gift_code = None
        self._credit_limit_increase_indicator = None
        self._atm_required_flag = None
        self._cheque_book_required_flag = None
        self._balance_transfer_details = None
        self.discriminator = None
        if product_code is not None:
            self.product_code = product_code
        if source_code is not None:
            self.source_code = source_code
        if organization is not None:
            self.organization = organization
        if logo is not None:
            self.logo = logo
        if request_credit_shield is not None:
            self.request_credit_shield = request_credit_shield
        if emboss_name is not None:
            self.emboss_name = emboss_name
        if billing_address is not None:
            self.billing_address = billing_address
        if card_delivery_address is not None:
            self.card_delivery_address = card_delivery_address
        if pin_delivery_address is not None:
            self.pin_delivery_address = pin_delivery_address
        if gift_code is not None:
            self.gift_code = gift_code
        if credit_limit_increase_indicator is not None:
            self.credit_limit_increase_indicator = credit_limit_increase_indicator
        if atm_required_flag is not None:
            self.atm_required_flag = atm_required_flag
        if cheque_book_required_flag is not None:
            self.cheque_book_required_flag = cheque_book_required_flag
        if balance_transfer_details is not None:
            self.balance_transfer_details = balance_transfer_details

    @property
    def product_code(self):
        """Gets the product_code of this ApplicationUpdateReadyCreditProduct.  # noqa: E501

        A unique code that identifies the product  # noqa: E501

        :return: The product_code of this ApplicationUpdateReadyCreditProduct.  # noqa: E501
        :rtype: str
        """
        return self._product_code

    @product_code.setter
    def product_code(self, product_code):
        """Sets the product_code of this ApplicationUpdateReadyCreditProduct.

        A unique code that identifies the product  # noqa: E501

        :param product_code: The product_code of this ApplicationUpdateReadyCreditProduct.  # noqa: E501
        :type: str
        """

        self._product_code = product_code

    @property
    def source_code(self):
        """Gets the source_code of this ApplicationUpdateReadyCreditProduct.  # noqa: E501

        A source code to identify the product  # noqa: E501

        :return: The source_code of this ApplicationUpdateReadyCreditProduct.  # noqa: E501
        :rtype: str
        """
        return self._source_code

    @source_code.setter
    def source_code(self, source_code):
        """Sets the source_code of this ApplicationUpdateReadyCreditProduct.

        A source code to identify the product  # noqa: E501

        :param source_code: The source_code of this ApplicationUpdateReadyCreditProduct.  # noqa: E501
        :type: str
        """

        self._source_code = source_code

    @property
    def organization(self):
        """Gets the organization of this ApplicationUpdateReadyCreditProduct.  # noqa: E501

        Card issuing organization name  # noqa: E501

        :return: The organization of this ApplicationUpdateReadyCreditProduct.  # noqa: E501
        :rtype: str
        """
        return self._organization

    @organization.setter
    def organization(self, organization):
        """Sets the organization of this ApplicationUpdateReadyCreditProduct.

        Card issuing organization name  # noqa: E501

        :param organization: The organization of this ApplicationUpdateReadyCreditProduct.  # noqa: E501
        :type: str
        """

        self._organization = organization

    @property
    def logo(self):
        """Gets the logo of this ApplicationUpdateReadyCreditProduct.  # noqa: E501

        Product logo to identify the product  # noqa: E501

        :return: The logo of this ApplicationUpdateReadyCreditProduct.  # noqa: E501
        :rtype: str
        """
        return self._logo

    @logo.setter
    def logo(self, logo):
        """Sets the logo of this ApplicationUpdateReadyCreditProduct.

        Product logo to identify the product  # noqa: E501

        :param logo: The logo of this ApplicationUpdateReadyCreditProduct.  # noqa: E501
        :type: str
        """

        self._logo = logo

    @property
    def request_credit_shield(self):
        """Gets the request_credit_shield of this ApplicationUpdateReadyCreditProduct.  # noqa: E501

        Insurance enrolment for outstanding balance on the card. Valid values: true and false  # noqa: E501

        :return: The request_credit_shield of this ApplicationUpdateReadyCreditProduct.  # noqa: E501
        :rtype: bool
        """
        return self._request_credit_shield

    @request_credit_shield.setter
    def request_credit_shield(self, request_credit_shield):
        """Sets the request_credit_shield of this ApplicationUpdateReadyCreditProduct.

        Insurance enrolment for outstanding balance on the card. Valid values: true and false  # noqa: E501

        :param request_credit_shield: The request_credit_shield of this ApplicationUpdateReadyCreditProduct.  # noqa: E501
        :type: bool
        """

        self._request_credit_shield = request_credit_shield

    @property
    def emboss_name(self):
        """Gets the emboss_name of this ApplicationUpdateReadyCreditProduct.  # noqa: E501

        Name to be embossed on card  # noqa: E501

        :return: The emboss_name of this ApplicationUpdateReadyCreditProduct.  # noqa: E501
        :rtype: str
        """
        return self._emboss_name

    @emboss_name.setter
    def emboss_name(self, emboss_name):
        """Sets the emboss_name of this ApplicationUpdateReadyCreditProduct.

        Name to be embossed on card  # noqa: E501

        :param emboss_name: The emboss_name of this ApplicationUpdateReadyCreditProduct.  # noqa: E501
        :type: str
        """

        self._emboss_name = emboss_name

    @property
    def billing_address(self):
        """Gets the billing_address of this ApplicationUpdateReadyCreditProduct.  # noqa: E501

        Billing address of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The billing_address of this ApplicationUpdateReadyCreditProduct.  # noqa: E501
        :rtype: str
        """
        return self._billing_address

    @billing_address.setter
    def billing_address(self, billing_address):
        """Sets the billing_address of this ApplicationUpdateReadyCreditProduct.

        Billing address of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param billing_address: The billing_address of this ApplicationUpdateReadyCreditProduct.  # noqa: E501
        :type: str
        """

        self._billing_address = billing_address

    @property
    def card_delivery_address(self):
        """Gets the card_delivery_address of this ApplicationUpdateReadyCreditProduct.  # noqa: E501

        Card delivery address of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The card_delivery_address of this ApplicationUpdateReadyCreditProduct.  # noqa: E501
        :rtype: str
        """
        return self._card_delivery_address

    @card_delivery_address.setter
    def card_delivery_address(self, card_delivery_address):
        """Sets the card_delivery_address of this ApplicationUpdateReadyCreditProduct.

        Card delivery address of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param card_delivery_address: The card_delivery_address of this ApplicationUpdateReadyCreditProduct.  # noqa: E501
        :type: str
        """

        self._card_delivery_address = card_delivery_address

    @property
    def pin_delivery_address(self):
        """Gets the pin_delivery_address of this ApplicationUpdateReadyCreditProduct.  # noqa: E501

        Delivery address  for card pin of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The pin_delivery_address of this ApplicationUpdateReadyCreditProduct.  # noqa: E501
        :rtype: str
        """
        return self._pin_delivery_address

    @pin_delivery_address.setter
    def pin_delivery_address(self, pin_delivery_address):
        """Sets the pin_delivery_address of this ApplicationUpdateReadyCreditProduct.

        Delivery address  for card pin of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param pin_delivery_address: The pin_delivery_address of this ApplicationUpdateReadyCreditProduct.  # noqa: E501
        :type: str
        """

        self._pin_delivery_address = pin_delivery_address

    @property
    def gift_code(self):
        """Gets the gift_code of this ApplicationUpdateReadyCreditProduct.  # noqa: E501

        A  unique code that identifies the gift offered along with the product  # noqa: E501

        :return: The gift_code of this ApplicationUpdateReadyCreditProduct.  # noqa: E501
        :rtype: str
        """
        return self._gift_code

    @gift_code.setter
    def gift_code(self, gift_code):
        """Sets the gift_code of this ApplicationUpdateReadyCreditProduct.

        A  unique code that identifies the gift offered along with the product  # noqa: E501

        :param gift_code: The gift_code of this ApplicationUpdateReadyCreditProduct.  # noqa: E501
        :type: str
        """

        self._gift_code = gift_code

    @property
    def credit_limit_increase_indicator(self):
        """Gets the credit_limit_increase_indicator of this ApplicationUpdateReadyCreditProduct.  # noqa: E501

        Option for to review the credit limit in the future.Valid values: true and false  # noqa: E501

        :return: The credit_limit_increase_indicator of this ApplicationUpdateReadyCreditProduct.  # noqa: E501
        :rtype: bool
        """
        return self._credit_limit_increase_indicator

    @credit_limit_increase_indicator.setter
    def credit_limit_increase_indicator(self, credit_limit_increase_indicator):
        """Sets the credit_limit_increase_indicator of this ApplicationUpdateReadyCreditProduct.

        Option for to review the credit limit in the future.Valid values: true and false  # noqa: E501

        :param credit_limit_increase_indicator: The credit_limit_increase_indicator of this ApplicationUpdateReadyCreditProduct.  # noqa: E501
        :type: bool
        """

        self._credit_limit_increase_indicator = credit_limit_increase_indicator

    @property
    def atm_required_flag(self):
        """Gets the atm_required_flag of this ApplicationUpdateReadyCreditProduct.  # noqa: E501

        Option to get ATM card along with product. Valid values: true and false  # noqa: E501

        :return: The atm_required_flag of this ApplicationUpdateReadyCreditProduct.  # noqa: E501
        :rtype: bool
        """
        return self._atm_required_flag

    @atm_required_flag.setter
    def atm_required_flag(self, atm_required_flag):
        """Sets the atm_required_flag of this ApplicationUpdateReadyCreditProduct.

        Option to get ATM card along with product. Valid values: true and false  # noqa: E501

        :param atm_required_flag: The atm_required_flag of this ApplicationUpdateReadyCreditProduct.  # noqa: E501
        :type: bool
        """

        self._atm_required_flag = atm_required_flag

    @property
    def cheque_book_required_flag(self):
        """Gets the cheque_book_required_flag of this ApplicationUpdateReadyCreditProduct.  # noqa: E501

        Option to get cheque book along with product. Valid values: true and false  # noqa: E501

        :return: The cheque_book_required_flag of this ApplicationUpdateReadyCreditProduct.  # noqa: E501
        :rtype: bool
        """
        return self._cheque_book_required_flag

    @cheque_book_required_flag.setter
    def cheque_book_required_flag(self, cheque_book_required_flag):
        """Sets the cheque_book_required_flag of this ApplicationUpdateReadyCreditProduct.

        Option to get cheque book along with product. Valid values: true and false  # noqa: E501

        :param cheque_book_required_flag: The cheque_book_required_flag of this ApplicationUpdateReadyCreditProduct.  # noqa: E501
        :type: bool
        """

        self._cheque_book_required_flag = cheque_book_required_flag

    @property
    def balance_transfer_details(self):
        """Gets the balance_transfer_details of this ApplicationUpdateReadyCreditProduct.  # noqa: E501


        :return: The balance_transfer_details of this ApplicationUpdateReadyCreditProduct.  # noqa: E501
        :rtype: list[ApplicationUpdateBalanceTransferDetails]
        """
        return self._balance_transfer_details

    @balance_transfer_details.setter
    def balance_transfer_details(self, balance_transfer_details):
        """Sets the balance_transfer_details of this ApplicationUpdateReadyCreditProduct.


        :param balance_transfer_details: The balance_transfer_details of this ApplicationUpdateReadyCreditProduct.  # noqa: E501
        :type: list[ApplicationUpdateBalanceTransferDetails]
        """

        self._balance_transfer_details = balance_transfer_details

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
        if issubclass(ApplicationUpdateReadyCreditProduct, dict):
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
        if not isinstance(other, ApplicationUpdateReadyCreditProduct):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
