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

class ParentPhone(object):
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
        'area_code': 'str',
        'phone_number': 'str',
        'extension': 'str',
        'ok_to_sms': 'bool',
        'ok_to_call': 'bool'
    }

    attribute_map = {
        'phone_type': 'phoneType',
        'phone_country_code': 'phoneCountryCode',
        'area_code': 'areaCode',
        'phone_number': 'phoneNumber',
        'extension': 'extension',
        'ok_to_sms': 'okToSms',
        'ok_to_call': 'okToCall'
    }

    def __init__(self, phone_type=None, phone_country_code=None, area_code=None, phone_number=None, extension=None, ok_to_sms=None, ok_to_call=None):  # noqa: E501
        """ParentPhone - a model defined in Swagger"""  # noqa: E501
        self._phone_type = None
        self._phone_country_code = None
        self._area_code = None
        self._phone_number = None
        self._extension = None
        self._ok_to_sms = None
        self._ok_to_call = None
        self.discriminator = None
        self.phone_type = phone_type
        self.phone_country_code = phone_country_code
        if area_code is not None:
            self.area_code = area_code
        self.phone_number = phone_number
        if extension is not None:
            self.extension = extension
        if ok_to_sms is not None:
            self.ok_to_sms = ok_to_sms
        if ok_to_call is not None:
            self.ok_to_call = ok_to_call

    @property
    def phone_type(self):
        """Gets the phone_type of this ParentPhone.  # noqa: E501

        The type of phone. Ex:OFFICE, HOME, MOBILE, PRIMARY_MOBILE, FAX. This is a reference data field. Please use /v1/utilities/referenceData/{phoneType} resource to get valid value of this field with description.  # noqa: E501

        :return: The phone_type of this ParentPhone.  # noqa: E501
        :rtype: str
        """
        return self._phone_type

    @phone_type.setter
    def phone_type(self, phone_type):
        """Sets the phone_type of this ParentPhone.

        The type of phone. Ex:OFFICE, HOME, MOBILE, PRIMARY_MOBILE, FAX. This is a reference data field. Please use /v1/utilities/referenceData/{phoneType} resource to get valid value of this field with description.  # noqa: E501

        :param phone_type: The phone_type of this ParentPhone.  # noqa: E501
        :type: str
        """
        if phone_type is None:
            raise ValueError("Invalid value for `phone_type`, must not be `None`")  # noqa: E501

        self._phone_type = phone_type

    @property
    def phone_country_code(self):
        """Gets the phone_country_code of this ParentPhone.  # noqa: E501

        Country code of phone number  # noqa: E501

        :return: The phone_country_code of this ParentPhone.  # noqa: E501
        :rtype: str
        """
        return self._phone_country_code

    @phone_country_code.setter
    def phone_country_code(self, phone_country_code):
        """Sets the phone_country_code of this ParentPhone.

        Country code of phone number  # noqa: E501

        :param phone_country_code: The phone_country_code of this ParentPhone.  # noqa: E501
        :type: str
        """
        if phone_country_code is None:
            raise ValueError("Invalid value for `phone_country_code`, must not be `None`")  # noqa: E501

        self._phone_country_code = phone_country_code

    @property
    def area_code(self):
        """Gets the area_code of this ParentPhone.  # noqa: E501

        The area code of phone number  # noqa: E501

        :return: The area_code of this ParentPhone.  # noqa: E501
        :rtype: str
        """
        return self._area_code

    @area_code.setter
    def area_code(self, area_code):
        """Sets the area_code of this ParentPhone.

        The area code of phone number  # noqa: E501

        :param area_code: The area_code of this ParentPhone.  # noqa: E501
        :type: str
        """

        self._area_code = area_code

    @property
    def phone_number(self):
        """Gets the phone_number of this ParentPhone.  # noqa: E501

        Parent's phone number  # noqa: E501

        :return: The phone_number of this ParentPhone.  # noqa: E501
        :rtype: str
        """
        return self._phone_number

    @phone_number.setter
    def phone_number(self, phone_number):
        """Sets the phone_number of this ParentPhone.

        Parent's phone number  # noqa: E501

        :param phone_number: The phone_number of this ParentPhone.  # noqa: E501
        :type: str
        """
        if phone_number is None:
            raise ValueError("Invalid value for `phone_number`, must not be `None`")  # noqa: E501

        self._phone_number = phone_number

    @property
    def extension(self):
        """Gets the extension of this ParentPhone.  # noqa: E501

        Extension of telephone number  # noqa: E501

        :return: The extension of this ParentPhone.  # noqa: E501
        :rtype: str
        """
        return self._extension

    @extension.setter
    def extension(self, extension):
        """Sets the extension of this ParentPhone.

        Extension of telephone number  # noqa: E501

        :param extension: The extension of this ParentPhone.  # noqa: E501
        :type: str
        """

        self._extension = extension

    @property
    def ok_to_sms(self):
        """Gets the ok_to_sms of this ParentPhone.  # noqa: E501

        Parent's consent for receiving sms. This is applicable only if phone type is MOBILE. Valid values: true and false  # noqa: E501

        :return: The ok_to_sms of this ParentPhone.  # noqa: E501
        :rtype: bool
        """
        return self._ok_to_sms

    @ok_to_sms.setter
    def ok_to_sms(self, ok_to_sms):
        """Sets the ok_to_sms of this ParentPhone.

        Parent's consent for receiving sms. This is applicable only if phone type is MOBILE. Valid values: true and false  # noqa: E501

        :param ok_to_sms: The ok_to_sms of this ParentPhone.  # noqa: E501
        :type: bool
        """

        self._ok_to_sms = ok_to_sms

    @property
    def ok_to_call(self):
        """Gets the ok_to_call of this ParentPhone.  # noqa: E501

        Parent's consent for receiving phone calls. Valid values: true and false  # noqa: E501

        :return: The ok_to_call of this ParentPhone.  # noqa: E501
        :rtype: bool
        """
        return self._ok_to_call

    @ok_to_call.setter
    def ok_to_call(self, ok_to_call):
        """Sets the ok_to_call of this ParentPhone.

        Parent's consent for receiving phone calls. Valid values: true and false  # noqa: E501

        :param ok_to_call: The ok_to_call of this ParentPhone.  # noqa: E501
        :type: bool
        """

        self._ok_to_call = ok_to_call

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
        if issubclass(ParentPhone, dict):
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
        if not isinstance(other, ParentPhone):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
