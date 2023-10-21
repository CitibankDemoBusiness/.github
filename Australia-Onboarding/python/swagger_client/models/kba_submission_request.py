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

class KbaSubmissionRequest(object):
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
        'questionnaire': 'list[Questionnaire]',
        'control_flow_id': 'str'
    }

    attribute_map = {
        'questionnaire': 'questionnaire',
        'control_flow_id': 'controlFlowId'
    }

    def __init__(self, questionnaire=None, control_flow_id=None):  # noqa: E501
        """KbaSubmissionRequest - a model defined in Swagger"""  # noqa: E501
        self._questionnaire = None
        self._control_flow_id = None
        self.discriminator = None
        if questionnaire is not None:
            self.questionnaire = questionnaire
        if control_flow_id is not None:
            self.control_flow_id = control_flow_id

    @property
    def questionnaire(self):
        """Gets the questionnaire of this KbaSubmissionRequest.  # noqa: E501


        :return: The questionnaire of this KbaSubmissionRequest.  # noqa: E501
        :rtype: list[Questionnaire]
        """
        return self._questionnaire

    @questionnaire.setter
    def questionnaire(self, questionnaire):
        """Sets the questionnaire of this KbaSubmissionRequest.


        :param questionnaire: The questionnaire of this KbaSubmissionRequest.  # noqa: E501
        :type: list[Questionnaire]
        """

        self._questionnaire = questionnaire

    @property
    def control_flow_id(self):
        """Gets the control_flow_id of this KbaSubmissionRequest.  # noqa: E501

        Control Flow Id  # noqa: E501

        :return: The control_flow_id of this KbaSubmissionRequest.  # noqa: E501
        :rtype: str
        """
        return self._control_flow_id

    @control_flow_id.setter
    def control_flow_id(self, control_flow_id):
        """Sets the control_flow_id of this KbaSubmissionRequest.

        Control Flow Id  # noqa: E501

        :param control_flow_id: The control_flow_id of this KbaSubmissionRequest.  # noqa: E501
        :type: str
        """

        self._control_flow_id = control_flow_id

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
        if issubclass(KbaSubmissionRequest, dict):
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
        if not isinstance(other, KbaSubmissionRequest):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other