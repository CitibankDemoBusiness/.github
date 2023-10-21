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

class ProductConfirmation(object):
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
        'credit_specific_selection': 'CreditSpecificSelection',
        'loan_specific_selection': 'LoanSpecificSelection'
    }

    attribute_map = {
        'product_code': 'productCode',
        'source_code': 'sourceCode',
        'organization': 'organization',
        'credit_specific_selection': 'creditSpecificSelection',
        'loan_specific_selection': 'loanSpecificSelection'
    }

    def __init__(self, product_code=None, source_code=None, organization=None, credit_specific_selection=None, loan_specific_selection=None):  # noqa: E501
        """ProductConfirmation - a model defined in Swagger"""  # noqa: E501
        self._product_code = None
        self._source_code = None
        self._organization = None
        self._credit_specific_selection = None
        self._loan_specific_selection = None
        self.discriminator = None
        self.product_code = product_code
        if source_code is not None:
            self.source_code = source_code
        if organization is not None:
            self.organization = organization
        if credit_specific_selection is not None:
            self.credit_specific_selection = credit_specific_selection
        if loan_specific_selection is not None:
            self.loan_specific_selection = loan_specific_selection

    @property
    def product_code(self):
        """Gets the product_code of this ProductConfirmation.  # noqa: E501

        A unique code that identifies the product  # noqa: E501

        :return: The product_code of this ProductConfirmation.  # noqa: E501
        :rtype: str
        """
        return self._product_code

    @product_code.setter
    def product_code(self, product_code):
        """Sets the product_code of this ProductConfirmation.

        A unique code that identifies the product  # noqa: E501

        :param product_code: The product_code of this ProductConfirmation.  # noqa: E501
        :type: str
        """
        if product_code is None:
            raise ValueError("Invalid value for `product_code`, must not be `None`")  # noqa: E501

        self._product_code = product_code

    @property
    def source_code(self):
        """Gets the source_code of this ProductConfirmation.  # noqa: E501

        A source code to identify the product  # noqa: E501

        :return: The source_code of this ProductConfirmation.  # noqa: E501
        :rtype: str
        """
        return self._source_code

    @source_code.setter
    def source_code(self, source_code):
        """Sets the source_code of this ProductConfirmation.

        A source code to identify the product  # noqa: E501

        :param source_code: The source_code of this ProductConfirmation.  # noqa: E501
        :type: str
        """

        self._source_code = source_code

    @property
    def organization(self):
        """Gets the organization of this ProductConfirmation.  # noqa: E501

        Card issuing Organisation code  # noqa: E501

        :return: The organization of this ProductConfirmation.  # noqa: E501
        :rtype: str
        """
        return self._organization

    @organization.setter
    def organization(self, organization):
        """Sets the organization of this ProductConfirmation.

        Card issuing Organisation code  # noqa: E501

        :param organization: The organization of this ProductConfirmation.  # noqa: E501
        :type: str
        """

        self._organization = organization

    @property
    def credit_specific_selection(self):
        """Gets the credit_specific_selection of this ProductConfirmation.  # noqa: E501


        :return: The credit_specific_selection of this ProductConfirmation.  # noqa: E501
        :rtype: CreditSpecificSelection
        """
        return self._credit_specific_selection

    @credit_specific_selection.setter
    def credit_specific_selection(self, credit_specific_selection):
        """Sets the credit_specific_selection of this ProductConfirmation.


        :param credit_specific_selection: The credit_specific_selection of this ProductConfirmation.  # noqa: E501
        :type: CreditSpecificSelection
        """

        self._credit_specific_selection = credit_specific_selection

    @property
    def loan_specific_selection(self):
        """Gets the loan_specific_selection of this ProductConfirmation.  # noqa: E501


        :return: The loan_specific_selection of this ProductConfirmation.  # noqa: E501
        :rtype: LoanSpecificSelection
        """
        return self._loan_specific_selection

    @loan_specific_selection.setter
    def loan_specific_selection(self, loan_specific_selection):
        """Sets the loan_specific_selection of this ProductConfirmation.


        :param loan_specific_selection: The loan_specific_selection of this ProductConfirmation.  # noqa: E501
        :type: LoanSpecificSelection
        """

        self._loan_specific_selection = loan_specific_selection

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
        if issubclass(ProductConfirmation, dict):
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
        if not isinstance(other, ProductConfirmation):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other