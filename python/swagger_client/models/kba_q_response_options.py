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

class KbaQResponseOptions(object):
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
        'option_sequence_number': 'int',
        'option_text': 'str'
    }

    attribute_map = {
        'option_sequence_number': 'optionSequenceNumber',
        'option_text': 'optionText'
    }

    def __init__(self, option_sequence_number=None, option_text=None):  # noqa: E501
        """KbaQResponseOptions - a model defined in Swagger"""  # noqa: E501
        self._option_sequence_number = None
        self._option_text = None
        self.discriminator = None
        if option_sequence_number is not None:
            self.option_sequence_number = option_sequence_number
        if option_text is not None:
            self.option_text = option_text

    @property
    def option_sequence_number(self):
        """Gets the option_sequence_number of this KbaQResponseOptions.  # noqa: E501

        Option sequence number  # noqa: E501

        :return: The option_sequence_number of this KbaQResponseOptions.  # noqa: E501
        :rtype: int
        """
        return self._option_sequence_number

    @option_sequence_number.setter
    def option_sequence_number(self, option_sequence_number):
        """Sets the option_sequence_number of this KbaQResponseOptions.

        Option sequence number  # noqa: E501

        :param option_sequence_number: The option_sequence_number of this KbaQResponseOptions.  # noqa: E501
        :type: int
        """

        self._option_sequence_number = option_sequence_number

    @property
    def option_text(self):
        """Gets the option_text of this KbaQResponseOptions.  # noqa: E501

        Option text to be displayed to the end user.  # noqa: E501

        :return: The option_text of this KbaQResponseOptions.  # noqa: E501
        :rtype: str
        """
        return self._option_text

    @option_text.setter
    def option_text(self, option_text):
        """Sets the option_text of this KbaQResponseOptions.

        Option text to be displayed to the end user.  # noqa: E501

        :param option_text: The option_text of this KbaQResponseOptions.  # noqa: E501
        :type: str
        """

        self._option_text = option_text

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
        if issubclass(KbaQResponseOptions, dict):
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
        if not isinstance(other, KbaQResponseOptions):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
