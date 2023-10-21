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

class ListResponse(object):
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
        'more_indicator': 'str',
        'next_start_index': 'str',
        'size': 'int'
    }

    attribute_map = {
        'more_indicator': 'moreIndicator',
        'next_start_index': 'nextStartIndex',
        'size': 'size'
    }

    def __init__(self, more_indicator=None, next_start_index=None, size=None):  # noqa: E501
        """ListResponse - a model defined in Swagger"""  # noqa: E501
        self._more_indicator = None
        self._next_start_index = None
        self._size = None
        self.discriminator = None
        if more_indicator is not None:
            self.more_indicator = more_indicator
        if next_start_index is not None:
            self.next_start_index = next_start_index
        if size is not None:
            self.size = size

    @property
    def more_indicator(self):
        """Gets the more_indicator of this ListResponse.  # noqa: E501

        M - Indicates more rows present in list Space - Indicates no more rows in the list. M will be converted to Y at ESB  # noqa: E501

        :return: The more_indicator of this ListResponse.  # noqa: E501
        :rtype: str
        """
        return self._more_indicator

    @more_indicator.setter
    def more_indicator(self, more_indicator):
        """Sets the more_indicator of this ListResponse.

        M - Indicates more rows present in list Space - Indicates no more rows in the list. M will be converted to Y at ESB  # noqa: E501

        :param more_indicator: The more_indicator of this ListResponse.  # noqa: E501
        :type: str
        """

        self._more_indicator = more_indicator

    @property
    def next_start_index(self):
        """Gets the next_start_index of this ListResponse.  # noqa: E501

        Ending index of the list  # noqa: E501

        :return: The next_start_index of this ListResponse.  # noqa: E501
        :rtype: str
        """
        return self._next_start_index

    @next_start_index.setter
    def next_start_index(self, next_start_index):
        """Sets the next_start_index of this ListResponse.

        Ending index of the list  # noqa: E501

        :param next_start_index: The next_start_index of this ListResponse.  # noqa: E501
        :type: str
        """

        self._next_start_index = next_start_index

    @property
    def size(self):
        """Gets the size of this ListResponse.  # noqa: E501

        Size of the list  # noqa: E501

        :return: The size of this ListResponse.  # noqa: E501
        :rtype: int
        """
        return self._size

    @size.setter
    def size(self, size):
        """Sets the size of this ListResponse.

        Size of the list  # noqa: E501

        :param size: The size of this ListResponse.  # noqa: E501
        :type: int
        """

        self._size = size

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
        if issubclass(ListResponse, dict):
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
        if not isinstance(other, ListResponse):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
