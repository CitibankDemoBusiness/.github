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

class DataRequirementsApplicant(object):
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
        'application_type': 'str',
        'employment_status': 'str',
        'min_age': 'int',
        'max_age': 'int',
        'min_annual_income': 'int',
        'min_annual_income_currency_code': 'str',
        'document': 'list[DataRequirementsDocument]'
    }

    attribute_map = {
        'application_type': 'application_type',
        'employment_status': 'employment_status',
        'min_age': 'min_age',
        'max_age': 'max_age',
        'min_annual_income': 'min_annual_income',
        'min_annual_income_currency_code': 'min_annual_income_currency_code',
        'document': 'document'
    }

    def __init__(self, application_type=None, employment_status=None, min_age=None, max_age=None, min_annual_income=None, min_annual_income_currency_code='MYR', document=None):  # noqa: E501
        """DataRequirementsApplicant - a model defined in Swagger"""  # noqa: E501
        self._application_type = None
        self._employment_status = None
        self._min_age = None
        self._max_age = None
        self._min_annual_income = None
        self._min_annual_income_currency_code = None
        self._document = None
        self.discriminator = None
        self.application_type = application_type
        if employment_status is not None:
            self.employment_status = employment_status
        if min_age is not None:
            self.min_age = min_age
        if max_age is not None:
            self.max_age = max_age
        if min_annual_income is not None:
            self.min_annual_income = min_annual_income
        if min_annual_income_currency_code is not None:
            self.min_annual_income_currency_code = min_annual_income_currency_code
        if document is not None:
            self.document = document

    @property
    def application_type(self):
        """Gets the application_type of this DataRequirementsApplicant.  # noqa: E501

        Type of the card application  # noqa: E501

        :return: The application_type of this DataRequirementsApplicant.  # noqa: E501
        :rtype: str
        """
        return self._application_type

    @application_type.setter
    def application_type(self, application_type):
        """Sets the application_type of this DataRequirementsApplicant.

        Type of the card application  # noqa: E501

        :param application_type: The application_type of this DataRequirementsApplicant.  # noqa: E501
        :type: str
        """
        if application_type is None:
            raise ValueError("Invalid value for `application_type`, must not be `None`")  # noqa: E501
        allowed_values = ["principal", "supplementary", "any"]  # noqa: E501
        if application_type not in allowed_values:
            raise ValueError(
                "Invalid value for `application_type` ({0}), must be one of {1}"  # noqa: E501
                .format(application_type, allowed_values)
            )

        self._application_type = application_type

    @property
    def employment_status(self):
        """Gets the employment_status of this DataRequirementsApplicant.  # noqa: E501

        Employment status of the applicant  # noqa: E501

        :return: The employment_status of this DataRequirementsApplicant.  # noqa: E501
        :rtype: str
        """
        return self._employment_status

    @employment_status.setter
    def employment_status(self, employment_status):
        """Sets the employment_status of this DataRequirementsApplicant.

        Employment status of the applicant  # noqa: E501

        :param employment_status: The employment_status of this DataRequirementsApplicant.  # noqa: E501
        :type: str
        """
        allowed_values = ["employed", "self_employed", "graduate", "others", "any"]  # noqa: E501
        if employment_status not in allowed_values:
            raise ValueError(
                "Invalid value for `employment_status` ({0}), must be one of {1}"  # noqa: E501
                .format(employment_status, allowed_values)
            )

        self._employment_status = employment_status

    @property
    def min_age(self):
        """Gets the min_age of this DataRequirementsApplicant.  # noqa: E501

        Minimum age of applicant  # noqa: E501

        :return: The min_age of this DataRequirementsApplicant.  # noqa: E501
        :rtype: int
        """
        return self._min_age

    @min_age.setter
    def min_age(self, min_age):
        """Sets the min_age of this DataRequirementsApplicant.

        Minimum age of applicant  # noqa: E501

        :param min_age: The min_age of this DataRequirementsApplicant.  # noqa: E501
        :type: int
        """

        self._min_age = min_age

    @property
    def max_age(self):
        """Gets the max_age of this DataRequirementsApplicant.  # noqa: E501

        Maximum age of applicant  # noqa: E501

        :return: The max_age of this DataRequirementsApplicant.  # noqa: E501
        :rtype: int
        """
        return self._max_age

    @max_age.setter
    def max_age(self, max_age):
        """Sets the max_age of this DataRequirementsApplicant.

        Maximum age of applicant  # noqa: E501

        :param max_age: The max_age of this DataRequirementsApplicant.  # noqa: E501
        :type: int
        """

        self._max_age = max_age

    @property
    def min_annual_income(self):
        """Gets the min_annual_income of this DataRequirementsApplicant.  # noqa: E501

        Minimum annual income  # noqa: E501

        :return: The min_annual_income of this DataRequirementsApplicant.  # noqa: E501
        :rtype: int
        """
        return self._min_annual_income

    @min_annual_income.setter
    def min_annual_income(self, min_annual_income):
        """Sets the min_annual_income of this DataRequirementsApplicant.

        Minimum annual income  # noqa: E501

        :param min_annual_income: The min_annual_income of this DataRequirementsApplicant.  # noqa: E501
        :type: int
        """

        self._min_annual_income = min_annual_income

    @property
    def min_annual_income_currency_code(self):
        """Gets the min_annual_income_currency_code of this DataRequirementsApplicant.  # noqa: E501

        ISO-4217 3 characters currency code for minimum annual income  # noqa: E501

        :return: The min_annual_income_currency_code of this DataRequirementsApplicant.  # noqa: E501
        :rtype: str
        """
        return self._min_annual_income_currency_code

    @min_annual_income_currency_code.setter
    def min_annual_income_currency_code(self, min_annual_income_currency_code):
        """Sets the min_annual_income_currency_code of this DataRequirementsApplicant.

        ISO-4217 3 characters currency code for minimum annual income  # noqa: E501

        :param min_annual_income_currency_code: The min_annual_income_currency_code of this DataRequirementsApplicant.  # noqa: E501
        :type: str
        """

        self._min_annual_income_currency_code = min_annual_income_currency_code

    @property
    def document(self):
        """Gets the document of this DataRequirementsApplicant.  # noqa: E501


        :return: The document of this DataRequirementsApplicant.  # noqa: E501
        :rtype: list[DataRequirementsDocument]
        """
        return self._document

    @document.setter
    def document(self, document):
        """Sets the document of this DataRequirementsApplicant.


        :param document: The document of this DataRequirementsApplicant.  # noqa: E501
        :type: list[DataRequirementsDocument]
        """

        self._document = document

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
        if issubclass(DataRequirementsApplicant, dict):
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
        if not isinstance(other, DataRequirementsApplicant):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other