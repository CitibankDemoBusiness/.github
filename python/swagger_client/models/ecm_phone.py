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

class ECMPhone(object):
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
        'phone_type': 'str',
        'phone_country_code': 'str',
        'phone_number': 'str',
        'area_code': 'str',
        'extension': 'str'
    }

    attribute_map = {
        'phone_type': 'phoneType',
        'phone_country_code': 'phoneCountryCode',
        'phone_number': 'phoneNumber',
        'area_code': 'areaCode',
        'extension': 'extension'
    }

    def __init__(self, phone_type=None, phone_country_code=None, phone_number=None, area_code=None, extension=None):  # noqa: E501
        """ECMPhone - a model defined in Swagger"""  # noqa: E501
        self._phone_type = None
        self._phone_country_code = None
        self._phone_number = None
        self._area_code = None
        self._extension = None
        self.discriminator = None
        self.phone_type = phone_type
        self.phone_country_code = phone_country_code
        self.phone_number = phone_number
        if area_code is not None:
            self.area_code = area_code
        if extension is not None:
            self.extension = extension

    @property
    def phone_type(self):
        """Gets the phone_type of this ECMPhone.  # noqa: E501

        The type of phone. Ex:OFFICE, HOME, MOBILE, PRIMARY_MOBILE, FAX. This is a reference data field. Please use /v1/utilities/referenceData/{phoneType} resource to get valid value of this field with description.  # noqa: E501

        :return: The phone_type of this ECMPhone.  # noqa: E501
        :rtype: str
        """
        return self._phone_type

    @phone_type.setter
    def phone_type(self, phone_type):
        """Sets the phone_type of this ECMPhone.

        The type of phone. Ex:OFFICE, HOME, MOBILE, PRIMARY_MOBILE, FAX. This is a reference data field. Please use /v1/utilities/referenceData/{phoneType} resource to get valid value of this field with description.  # noqa: E501

        :param phone_type: The phone_type of this ECMPhone.  # noqa: E501
        :type: str
        """
        if phone_type is None:
            raise ValueError("Invalid value for `phone_type`, must not be `None`")  # noqa: E501

        self._phone_type = phone_type

    @property
    def phone_country_code(self):
        """Gets the phone_country_code of this ECMPhone.  # noqa: E501

        Country code of phone number  # noqa: E501

        :return: The phone_country_code of this ECMPhone.  # noqa: E501
        :rtype: str
        """
        return self._phone_country_code

    @phone_country_code.setter
    def phone_country_code(self, phone_country_code):
        """Sets the phone_country_code of this ECMPhone.

        Country code of phone number  # noqa: E501

        :param phone_country_code: The phone_country_code of this ECMPhone.  # noqa: E501
        :type: str
        """
        if phone_country_code is None:
            raise ValueError("Invalid value for `phone_country_code`, must not be `None`")  # noqa: E501

        self._phone_country_code = phone_country_code

    @property
    def phone_number(self):
        """Gets the phone_number of this ECMPhone.  # noqa: E501

        Applicants phone number  # noqa: E501

        :return: The phone_number of this ECMPhone.  # noqa: E501
        :rtype: str
        """
        return self._phone_number

    @phone_number.setter
    def phone_number(self, phone_number):
        """Sets the phone_number of this ECMPhone.

        Applicants phone number  # noqa: E501

        :param phone_number: The phone_number of this ECMPhone.  # noqa: E501
        :type: str
        """
        if phone_number is None:
            raise ValueError("Invalid value for `phone_number`, must not be `None`")  # noqa: E501

        self._phone_number = phone_number

    @property
    def area_code(self):
        """Gets the area_code of this ECMPhone.  # noqa: E501

        The area code of phone number  # noqa: E501

        :return: The area_code of this ECMPhone.  # noqa: E501
        :rtype: str
        """
        return self._area_code

    @area_code.setter
    def area_code(self, area_code):
        """Sets the area_code of this ECMPhone.

        The area code of phone number  # noqa: E501

        :param area_code: The area_code of this ECMPhone.  # noqa: E501
        :type: str
        """

        self._area_code = area_code

    @property
    def extension(self):
        """Gets the extension of this ECMPhone.  # noqa: E501

        Extension of telephone number  # noqa: E501

        :return: The extension of this ECMPhone.  # noqa: E501
        :rtype: str
        """
        return self._extension

    @extension.setter
    def extension(self, extension):
        """Sets the extension of this ECMPhone.

        Extension of telephone number  # noqa: E501

        :param extension: The extension of this ECMPhone.  # noqa: E501
        :type: str
        """

        self._extension = extension

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
        if issubclass(ECMPhone, dict):
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
        if not isinstance(other, ECMPhone):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
