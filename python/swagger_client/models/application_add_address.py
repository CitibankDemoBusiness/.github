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

class ApplicationAddAddress(object):
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
        'address_type': 'str',
        'address_line1': 'str',
        'address_line2': 'str',
        'address_line3': 'str',
        'address_line4': 'str',
        'city_name': 'str',
        'state': 'str',
        'postal_code': 'str',
        'province_code': 'str',
        'country_code': 'str',
        'ok_to_mail': 'bool',
        'residence_duration_in_years': 'int',
        'residence_duration_in_months': 'int',
        'country_specific_address': 'ApplicationAddCountrySpecificAddress'
    }

    attribute_map = {
        'address_type': 'addressType',
        'address_line1': 'addressLine1',
        'address_line2': 'addressLine2',
        'address_line3': 'addressLine3',
        'address_line4': 'addressLine4',
        'city_name': 'cityName',
        'state': 'state',
        'postal_code': 'postalCode',
        'province_code': 'provinceCode',
        'country_code': 'countryCode',
        'ok_to_mail': 'okToMail',
        'residence_duration_in_years': 'residenceDurationInYears',
        'residence_duration_in_months': 'residenceDurationInMonths',
        'country_specific_address': 'countrySpecificAddress'
    }

    def __init__(self, address_type=None, address_line1=None, address_line2=None, address_line3=None, address_line4=None, city_name=None, state=None, postal_code=None, province_code=None, country_code=None, ok_to_mail=None, residence_duration_in_years=None, residence_duration_in_months=None, country_specific_address=None):  # noqa: E501
        """ApplicationAddAddress - a model defined in Swagger"""  # noqa: E501
        self._address_type = None
        self._address_line1 = None
        self._address_line2 = None
        self._address_line3 = None
        self._address_line4 = None
        self._city_name = None
        self._state = None
        self._postal_code = None
        self._province_code = None
        self._country_code = None
        self._ok_to_mail = None
        self._residence_duration_in_years = None
        self._residence_duration_in_months = None
        self._country_specific_address = None
        self.discriminator = None
        if address_type is not None:
            self.address_type = address_type
        if address_line1 is not None:
            self.address_line1 = address_line1
        if address_line2 is not None:
            self.address_line2 = address_line2
        if address_line3 is not None:
            self.address_line3 = address_line3
        if address_line4 is not None:
            self.address_line4 = address_line4
        if city_name is not None:
            self.city_name = city_name
        if state is not None:
            self.state = state
        if postal_code is not None:
            self.postal_code = postal_code
        if province_code is not None:
            self.province_code = province_code
        if country_code is not None:
            self.country_code = country_code
        if ok_to_mail is not None:
            self.ok_to_mail = ok_to_mail
        if residence_duration_in_years is not None:
            self.residence_duration_in_years = residence_duration_in_years
        if residence_duration_in_months is not None:
            self.residence_duration_in_months = residence_duration_in_months
        if country_specific_address is not None:
            self.country_specific_address = country_specific_address

    @property
    def address_type(self):
        """Gets the address_type of this ApplicationAddAddress.  # noqa: E501

        Type of address. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The address_type of this ApplicationAddAddress.  # noqa: E501
        :rtype: str
        """
        return self._address_type

    @address_type.setter
    def address_type(self, address_type):
        """Sets the address_type of this ApplicationAddAddress.

        Type of address. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param address_type: The address_type of this ApplicationAddAddress.  # noqa: E501
        :type: str
        """

        self._address_type = address_type

    @property
    def address_line1(self):
        """Gets the address_line1 of this ApplicationAddAddress.  # noqa: E501

        Address line 1  # noqa: E501

        :return: The address_line1 of this ApplicationAddAddress.  # noqa: E501
        :rtype: str
        """
        return self._address_line1

    @address_line1.setter
    def address_line1(self, address_line1):
        """Sets the address_line1 of this ApplicationAddAddress.

        Address line 1  # noqa: E501

        :param address_line1: The address_line1 of this ApplicationAddAddress.  # noqa: E501
        :type: str
        """

        self._address_line1 = address_line1

    @property
    def address_line2(self):
        """Gets the address_line2 of this ApplicationAddAddress.  # noqa: E501

        Address line 2  # noqa: E501

        :return: The address_line2 of this ApplicationAddAddress.  # noqa: E501
        :rtype: str
        """
        return self._address_line2

    @address_line2.setter
    def address_line2(self, address_line2):
        """Sets the address_line2 of this ApplicationAddAddress.

        Address line 2  # noqa: E501

        :param address_line2: The address_line2 of this ApplicationAddAddress.  # noqa: E501
        :type: str
        """

        self._address_line2 = address_line2

    @property
    def address_line3(self):
        """Gets the address_line3 of this ApplicationAddAddress.  # noqa: E501

        Address line 3  # noqa: E501

        :return: The address_line3 of this ApplicationAddAddress.  # noqa: E501
        :rtype: str
        """
        return self._address_line3

    @address_line3.setter
    def address_line3(self, address_line3):
        """Sets the address_line3 of this ApplicationAddAddress.

        Address line 3  # noqa: E501

        :param address_line3: The address_line3 of this ApplicationAddAddress.  # noqa: E501
        :type: str
        """

        self._address_line3 = address_line3

    @property
    def address_line4(self):
        """Gets the address_line4 of this ApplicationAddAddress.  # noqa: E501

        Address line 4  # noqa: E501

        :return: The address_line4 of this ApplicationAddAddress.  # noqa: E501
        :rtype: str
        """
        return self._address_line4

    @address_line4.setter
    def address_line4(self, address_line4):
        """Sets the address_line4 of this ApplicationAddAddress.

        Address line 4  # noqa: E501

        :param address_line4: The address_line4 of this ApplicationAddAddress.  # noqa: E501
        :type: str
        """

        self._address_line4 = address_line4

    @property
    def city_name(self):
        """Gets the city_name of this ApplicationAddAddress.  # noqa: E501

        City  # noqa: E501

        :return: The city_name of this ApplicationAddAddress.  # noqa: E501
        :rtype: str
        """
        return self._city_name

    @city_name.setter
    def city_name(self, city_name):
        """Sets the city_name of this ApplicationAddAddress.

        City  # noqa: E501

        :param city_name: The city_name of this ApplicationAddAddress.  # noqa: E501
        :type: str
        """

        self._city_name = city_name

    @property
    def state(self):
        """Gets the state of this ApplicationAddAddress.  # noqa: E501

        State.This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressState} resource to get valid value of this field with description. You can use addressState field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The state of this ApplicationAddAddress.  # noqa: E501
        :rtype: str
        """
        return self._state

    @state.setter
    def state(self, state):
        """Sets the state of this ApplicationAddAddress.

        State.This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressState} resource to get valid value of this field with description. You can use addressState field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param state: The state of this ApplicationAddAddress.  # noqa: E501
        :type: str
        """

        self._state = state

    @property
    def postal_code(self):
        """Gets the postal_code of this ApplicationAddAddress.  # noqa: E501

        Postal/ZIP code  # noqa: E501

        :return: The postal_code of this ApplicationAddAddress.  # noqa: E501
        :rtype: str
        """
        return self._postal_code

    @postal_code.setter
    def postal_code(self, postal_code):
        """Sets the postal_code of this ApplicationAddAddress.

        Postal/ZIP code  # noqa: E501

        :param postal_code: The postal_code of this ApplicationAddAddress.  # noqa: E501
        :type: str
        """

        self._postal_code = postal_code

    @property
    def province_code(self):
        """Gets the province_code of this ApplicationAddAddress.  # noqa: E501

        Province code  # noqa: E501

        :return: The province_code of this ApplicationAddAddress.  # noqa: E501
        :rtype: str
        """
        return self._province_code

    @province_code.setter
    def province_code(self, province_code):
        """Sets the province_code of this ApplicationAddAddress.

        Province code  # noqa: E501

        :param province_code: The province_code of this ApplicationAddAddress.  # noqa: E501
        :type: str
        """

        self._province_code = province_code

    @property
    def country_code(self):
        """Gets the country_code of this ApplicationAddAddress.  # noqa: E501

        ISO country code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use countryCode field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The country_code of this ApplicationAddAddress.  # noqa: E501
        :rtype: str
        """
        return self._country_code

    @country_code.setter
    def country_code(self, country_code):
        """Sets the country_code of this ApplicationAddAddress.

        ISO country code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use countryCode field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param country_code: The country_code of this ApplicationAddAddress.  # noqa: E501
        :type: str
        """

        self._country_code = country_code

    @property
    def ok_to_mail(self):
        """Gets the ok_to_mail of this ApplicationAddAddress.  # noqa: E501

        Applicant's consent for receiving mail. Valid values: true and false  # noqa: E501

        :return: The ok_to_mail of this ApplicationAddAddress.  # noqa: E501
        :rtype: bool
        """
        return self._ok_to_mail

    @ok_to_mail.setter
    def ok_to_mail(self, ok_to_mail):
        """Sets the ok_to_mail of this ApplicationAddAddress.

        Applicant's consent for receiving mail. Valid values: true and false  # noqa: E501

        :param ok_to_mail: The ok_to_mail of this ApplicationAddAddress.  # noqa: E501
        :type: bool
        """

        self._ok_to_mail = ok_to_mail

    @property
    def residence_duration_in_years(self):
        """Gets the residence_duration_in_years of this ApplicationAddAddress.  # noqa: E501

        Applicant's residence duration in the current address in years. Applicable only for residential address.  # noqa: E501

        :return: The residence_duration_in_years of this ApplicationAddAddress.  # noqa: E501
        :rtype: int
        """
        return self._residence_duration_in_years

    @residence_duration_in_years.setter
    def residence_duration_in_years(self, residence_duration_in_years):
        """Sets the residence_duration_in_years of this ApplicationAddAddress.

        Applicant's residence duration in the current address in years. Applicable only for residential address.  # noqa: E501

        :param residence_duration_in_years: The residence_duration_in_years of this ApplicationAddAddress.  # noqa: E501
        :type: int
        """

        self._residence_duration_in_years = residence_duration_in_years

    @property
    def residence_duration_in_months(self):
        """Gets the residence_duration_in_months of this ApplicationAddAddress.  # noqa: E501

        Applicant's residence duration in the current address in months. Applicable only for residential address.  # noqa: E501

        :return: The residence_duration_in_months of this ApplicationAddAddress.  # noqa: E501
        :rtype: int
        """
        return self._residence_duration_in_months

    @residence_duration_in_months.setter
    def residence_duration_in_months(self, residence_duration_in_months):
        """Sets the residence_duration_in_months of this ApplicationAddAddress.

        Applicant's residence duration in the current address in months. Applicable only for residential address.  # noqa: E501

        :param residence_duration_in_months: The residence_duration_in_months of this ApplicationAddAddress.  # noqa: E501
        :type: int
        """

        self._residence_duration_in_months = residence_duration_in_months

    @property
    def country_specific_address(self):
        """Gets the country_specific_address of this ApplicationAddAddress.  # noqa: E501


        :return: The country_specific_address of this ApplicationAddAddress.  # noqa: E501
        :rtype: ApplicationAddCountrySpecificAddress
        """
        return self._country_specific_address

    @country_specific_address.setter
    def country_specific_address(self, country_specific_address):
        """Sets the country_specific_address of this ApplicationAddAddress.


        :param country_specific_address: The country_specific_address of this ApplicationAddAddress.  # noqa: E501
        :type: ApplicationAddCountrySpecificAddress
        """

        self._country_specific_address = country_specific_address

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
        if issubclass(ApplicationAddAddress, dict):
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
        if not isinstance(other, ApplicationAddAddress):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
