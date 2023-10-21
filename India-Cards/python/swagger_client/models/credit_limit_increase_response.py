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

class CreditLimitIncreaseResponse(object):
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
        'response_code': 'str'
    }

    attribute_map = {
        'response_code': 'responseCode'
    }

    def __init__(self, response_code=None):  # noqa: E501
        """CreditLimitIncreaseResponse - a model defined in Swagger"""  # noqa: E501
        self._response_code = None
        self.discriminator = None
        if response_code is not None:
            self.response_code = response_code

    @property
    def response_code(self):
        """Gets the response_code of this CreditLimitIncreaseResponse.  # noqa: E501

        Response code.This is a reference data field. Please use /v1/apac/utilities/referenceData/{responseCode} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The response_code of this CreditLimitIncreaseResponse.  # noqa: E501
        :rtype: str
        """
        return self._response_code

    @response_code.setter
    def response_code(self, response_code):
        """Sets the response_code of this CreditLimitIncreaseResponse.

        Response code.This is a reference data field. Please use /v1/apac/utilities/referenceData/{responseCode} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param response_code: The response_code of this CreditLimitIncreaseResponse.  # noqa: E501
        :type: str
        """

        self._response_code = response_code

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
        if issubclass(CreditLimitIncreaseResponse, dict):
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
        if not isinstance(other, CreditLimitIncreaseResponse):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
