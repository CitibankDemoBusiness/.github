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

class ResetAtmPinRequest(object):
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
        'card_id': 'str',
        'new_pin': 'str',
        'encryption_type': 'str',
        'key_device_id': 'str',
        'key_generation_id': 'str'
    }

    attribute_map = {
        'card_id': 'cardId',
        'new_pin': 'newPin',
        'encryption_type': 'encryptionType',
        'key_device_id': 'keyDeviceId',
        'key_generation_id': 'keyGenerationId'
    }

    def __init__(self, card_id=None, new_pin=None, encryption_type=None, key_device_id=None, key_generation_id=None):  # noqa: E501
        """ResetAtmPinRequest - a model defined in Swagger"""  # noqa: E501
        self._card_id = None
        self._new_pin = None
        self._encryption_type = None
        self._key_device_id = None
        self._key_generation_id = None
        self.discriminator = None
        self.card_id = card_id
        self.new_pin = new_pin
        if encryption_type is not None:
            self.encryption_type = encryption_type
        if key_device_id is not None:
            self.key_device_id = key_device_id
        if key_generation_id is not None:
            self.key_generation_id = key_generation_id

    @property
    def card_id(self):
        """Gets the card_id of this ResetAtmPinRequest.  # noqa: E501

        Unique Id of the card in encrypted format.  # noqa: E501

        :return: The card_id of this ResetAtmPinRequest.  # noqa: E501
        :rtype: str
        """
        return self._card_id

    @card_id.setter
    def card_id(self, card_id):
        """Sets the card_id of this ResetAtmPinRequest.

        Unique Id of the card in encrypted format.  # noqa: E501

        :param card_id: The card_id of this ResetAtmPinRequest.  # noqa: E501
        :type: str
        """
        if card_id is None:
            raise ValueError("Invalid value for `card_id`, must not be `None`")  # noqa: E501

        self._card_id = card_id

    @property
    def new_pin(self):
        """Gets the new_pin of this ResetAtmPinRequest.  # noqa: E501

        New pin in encrypted format.  # noqa: E501

        :return: The new_pin of this ResetAtmPinRequest.  # noqa: E501
        :rtype: str
        """
        return self._new_pin

    @new_pin.setter
    def new_pin(self, new_pin):
        """Sets the new_pin of this ResetAtmPinRequest.

        New pin in encrypted format.  # noqa: E501

        :param new_pin: The new_pin of this ResetAtmPinRequest.  # noqa: E501
        :type: str
        """
        if new_pin is None:
            raise ValueError("Invalid value for `new_pin`, must not be `None`")  # noqa: E501

        self._new_pin = new_pin

    @property
    def encryption_type(self):
        """Gets the encryption_type of this ResetAtmPinRequest.  # noqa: E501

        Type of the encryption. This is a reference data field. Please use /v1/apac/utilities/referenceData/{encryptionType} resource to get valid value of this field with description.  # noqa: E501

        :return: The encryption_type of this ResetAtmPinRequest.  # noqa: E501
        :rtype: str
        """
        return self._encryption_type

    @encryption_type.setter
    def encryption_type(self, encryption_type):
        """Sets the encryption_type of this ResetAtmPinRequest.

        Type of the encryption. This is a reference data field. Please use /v1/apac/utilities/referenceData/{encryptionType} resource to get valid value of this field with description.  # noqa: E501

        :param encryption_type: The encryption_type of this ResetAtmPinRequest.  # noqa: E501
        :type: str
        """

        self._encryption_type = encryption_type

    @property
    def key_device_id(self):
        """Gets the key_device_id of this ResetAtmPinRequest.  # noqa: E501

        Label to identify the HSM keys used to encrypt ATM PIN.  # noqa: E501

        :return: The key_device_id of this ResetAtmPinRequest.  # noqa: E501
        :rtype: str
        """
        return self._key_device_id

    @key_device_id.setter
    def key_device_id(self, key_device_id):
        """Sets the key_device_id of this ResetAtmPinRequest.

        Label to identify the HSM keys used to encrypt ATM PIN.  # noqa: E501

        :param key_device_id: The key_device_id of this ResetAtmPinRequest.  # noqa: E501
        :type: str
        """

        self._key_device_id = key_device_id

    @property
    def key_generation_id(self):
        """Gets the key_generation_id of this ResetAtmPinRequest.  # noqa: E501

        It is the generation ID of the HSM Keys referred for encryption of ATM PIN.  # noqa: E501

        :return: The key_generation_id of this ResetAtmPinRequest.  # noqa: E501
        :rtype: str
        """
        return self._key_generation_id

    @key_generation_id.setter
    def key_generation_id(self, key_generation_id):
        """Sets the key_generation_id of this ResetAtmPinRequest.

        It is the generation ID of the HSM Keys referred for encryption of ATM PIN.  # noqa: E501

        :param key_generation_id: The key_generation_id of this ResetAtmPinRequest.  # noqa: E501
        :type: str
        """

        self._key_generation_id = key_generation_id

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
        if issubclass(ResetAtmPinRequest, dict):
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
        if not isinstance(other, ResetAtmPinRequest):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other