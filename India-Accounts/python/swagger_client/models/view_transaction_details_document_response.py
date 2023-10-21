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

class ViewTransactionDetailsDocumentResponse(object):
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
        'binary_data': 'str',
        'next_start_index': 'str'
    }

    attribute_map = {
        'binary_data': 'binaryData',
        'next_start_index': 'nextStartIndex'
    }

    def __init__(self, binary_data=None, next_start_index=None):  # noqa: E501
        """ViewTransactionDetailsDocumentResponse - a model defined in Swagger"""  # noqa: E501
        self._binary_data = None
        self._next_start_index = None
        self.discriminator = None
        self.binary_data = binary_data
        if next_start_index is not None:
            self.next_start_index = next_start_index

    @property
    def binary_data(self):
        """Gets the binary_data of this ViewTransactionDetailsDocumentResponse.  # noqa: E501

        This field contains binary data of the Transaction detials.  # noqa: E501

        :return: The binary_data of this ViewTransactionDetailsDocumentResponse.  # noqa: E501
        :rtype: str
        """
        return self._binary_data

    @binary_data.setter
    def binary_data(self, binary_data):
        """Sets the binary_data of this ViewTransactionDetailsDocumentResponse.

        This field contains binary data of the Transaction detials.  # noqa: E501

        :param binary_data: The binary_data of this ViewTransactionDetailsDocumentResponse.  # noqa: E501
        :type: str
        """
        if binary_data is None:
            raise ValueError("Invalid value for `binary_data`, must not be `None`")  # noqa: E501

        self._binary_data = binary_data

    @property
    def next_start_index(self):
        """Gets the next_start_index of this ViewTransactionDetailsDocumentResponse.  # noqa: E501

        In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.  # noqa: E501

        :return: The next_start_index of this ViewTransactionDetailsDocumentResponse.  # noqa: E501
        :rtype: str
        """
        return self._next_start_index

    @next_start_index.setter
    def next_start_index(self, next_start_index):
        """Sets the next_start_index of this ViewTransactionDetailsDocumentResponse.

        In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.  # noqa: E501

        :param next_start_index: The next_start_index of this ViewTransactionDetailsDocumentResponse.  # noqa: E501
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
        if issubclass(ViewTransactionDetailsDocumentResponse, dict):
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
        if not isinstance(other, ViewTransactionDetailsDocumentResponse):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
