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

class ProductCatalogueResponse(object):
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
        'products': 'list[Product]',
        'next_start_index': 'str'
    }

    attribute_map = {
        'products': 'products',
        'next_start_index': 'nextStartIndex'
    }

    def __init__(self, products=None, next_start_index=None):  # noqa: E501
        """ProductCatalogueResponse - a model defined in Swagger"""  # noqa: E501
        self._products = None
        self._next_start_index = None
        self.discriminator = None
        self.products = products
        if next_start_index is not None:
            self.next_start_index = next_start_index

    @property
    def products(self):
        """Gets the products of this ProductCatalogueResponse.  # noqa: E501


        :return: The products of this ProductCatalogueResponse.  # noqa: E501
        :rtype: list[Product]
        """
        return self._products

    @products.setter
    def products(self, products):
        """Sets the products of this ProductCatalogueResponse.


        :param products: The products of this ProductCatalogueResponse.  # noqa: E501
        :type: list[Product]
        """
        if products is None:
            raise ValueError("Invalid value for `products`, must not be `None`")  # noqa: E501

        self._products = products

    @property
    def next_start_index(self):
        """Gets the next_start_index of this ProductCatalogueResponse.  # noqa: E501

        The next start index of the next subset of products.  # noqa: E501

        :return: The next_start_index of this ProductCatalogueResponse.  # noqa: E501
        :rtype: str
        """
        return self._next_start_index

    @next_start_index.setter
    def next_start_index(self, next_start_index):
        """Sets the next_start_index of this ProductCatalogueResponse.

        The next start index of the next subset of products.  # noqa: E501

        :param next_start_index: The next_start_index of this ProductCatalogueResponse.  # noqa: E501
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
        if issubclass(ProductCatalogueResponse, dict):
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
        if not isinstance(other, ProductCatalogueResponse):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other