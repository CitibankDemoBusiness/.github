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

class EmploymentDetails(object):
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
        'occupation_code': 'str'
    }

    attribute_map = {
        'occupation_code': 'occupationCode'
    }

    def __init__(self, occupation_code=None):  # noqa: E501
        """EmploymentDetails - a model defined in Swagger"""  # noqa: E501
        self._occupation_code = None
        self.discriminator = None
        self.occupation_code = occupation_code

    @property
    def occupation_code(self):
        """Gets the occupation_code of this EmploymentDetails.  # noqa: E501

        Occupation code. This is a reference data field. Please use /utilities/referenceData/{occupationCode} resource to get valid values of this field with descriptions.  # noqa: E501

        :return: The occupation_code of this EmploymentDetails.  # noqa: E501
        :rtype: str
        """
        return self._occupation_code

    @occupation_code.setter
    def occupation_code(self, occupation_code):
        """Sets the occupation_code of this EmploymentDetails.

        Occupation code. This is a reference data field. Please use /utilities/referenceData/{occupationCode} resource to get valid values of this field with descriptions.  # noqa: E501

        :param occupation_code: The occupation_code of this EmploymentDetails.  # noqa: E501
        :type: str
        """
        if occupation_code is None:
            raise ValueError("Invalid value for `occupation_code`, must not be `None`")  # noqa: E501

        self._occupation_code = occupation_code

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
        if issubclass(EmploymentDetails, dict):
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
        if not isinstance(other, EmploymentDetails):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
