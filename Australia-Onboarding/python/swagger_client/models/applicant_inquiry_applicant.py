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

class ApplicantInquiryApplicant(object):
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
        'applicant_type': 'str',
        'applicant_id': 'str',
        'mother_maiden_name': 'str',
        'name': 'ApplicantInquiryName',
        'demographics': 'ApplicantInquiryDemographics',
        'address': 'list[ApplicantInquiryAddress]',
        'email': 'list[ApplicantInquiryEmail]',
        'phone': 'list[ApplicantInquiryPhone]',
        'financial_information': 'ApplicantInquiryFinancialInformation',
        'employment_details': 'list[ApplicantInquiryEmploymentDetails]',
        'identification_document_details': 'list[ApplicantInquiryIdentificationDocumentDetails]',
        'additional_data': 'ApplicantInquiryAdditionalData',
        'partner_customer_details': 'ApplicantInquiryPartnerCustomerDetails',
        'consent_details': 'list[ApplicantInquiryConsentDetails]',
        'required_documents': 'list[ApplicantInquiryRequiredDocuments]',
        'kyc_information': 'ApplicantInquiryKycInformation',
        'contact_consent': 'ApplicantInquiryContactConsent'
    }

    attribute_map = {
        'applicant_type': 'applicantType',
        'applicant_id': 'applicantId',
        'mother_maiden_name': 'motherMaidenName',
        'name': 'name',
        'demographics': 'demographics',
        'address': 'address',
        'email': 'email',
        'phone': 'phone',
        'financial_information': 'financialInformation',
        'employment_details': 'employmentDetails',
        'identification_document_details': 'identificationDocumentDetails',
        'additional_data': 'additionalData',
        'partner_customer_details': 'partnerCustomerDetails',
        'consent_details': 'consentDetails',
        'required_documents': 'requiredDocuments',
        'kyc_information': 'kycInformation',
        'contact_consent': 'contactConsent'
    }

    def __init__(self, applicant_type=None, applicant_id=None, mother_maiden_name=None, name=None, demographics=None, address=None, email=None, phone=None, financial_information=None, employment_details=None, identification_document_details=None, additional_data=None, partner_customer_details=None, consent_details=None, required_documents=None, kyc_information=None, contact_consent=None):  # noqa: E501
        """ApplicantInquiryApplicant - a model defined in Swagger"""  # noqa: E501
        self._applicant_type = None
        self._applicant_id = None
        self._mother_maiden_name = None
        self._name = None
        self._demographics = None
        self._address = None
        self._email = None
        self._phone = None
        self._financial_information = None
        self._employment_details = None
        self._identification_document_details = None
        self._additional_data = None
        self._partner_customer_details = None
        self._consent_details = None
        self._required_documents = None
        self._kyc_information = None
        self._contact_consent = None
        self.discriminator = None
        self.applicant_type = applicant_type
        if applicant_id is not None:
            self.applicant_id = applicant_id
        if mother_maiden_name is not None:
            self.mother_maiden_name = mother_maiden_name
        self.name = name
        if demographics is not None:
            self.demographics = demographics
        if address is not None:
            self.address = address
        if email is not None:
            self.email = email
        if phone is not None:
            self.phone = phone
        if financial_information is not None:
            self.financial_information = financial_information
        if employment_details is not None:
            self.employment_details = employment_details
        if identification_document_details is not None:
            self.identification_document_details = identification_document_details
        if additional_data is not None:
            self.additional_data = additional_data
        if partner_customer_details is not None:
            self.partner_customer_details = partner_customer_details
        if consent_details is not None:
            self.consent_details = consent_details
        if required_documents is not None:
            self.required_documents = required_documents
        if kyc_information is not None:
            self.kyc_information = kyc_information
        if contact_consent is not None:
            self.contact_consent = contact_consent

    @property
    def applicant_type(self):
        """Gets the applicant_type of this ApplicantInquiryApplicant.  # noqa: E501

        Type of an applicant.This is a reference data field.Please use /utilities/referenceData/{applicantType} resource to get valid values of this field with descriptions. You can use the fieldname as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The applicant_type of this ApplicantInquiryApplicant.  # noqa: E501
        :rtype: str
        """
        return self._applicant_type

    @applicant_type.setter
    def applicant_type(self, applicant_type):
        """Sets the applicant_type of this ApplicantInquiryApplicant.

        Type of an applicant.This is a reference data field.Please use /utilities/referenceData/{applicantType} resource to get valid values of this field with descriptions. You can use the fieldname as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param applicant_type: The applicant_type of this ApplicantInquiryApplicant.  # noqa: E501
        :type: str
        """
        if applicant_type is None:
            raise ValueError("Invalid value for `applicant_type`, must not be `None`")  # noqa: E501

        self._applicant_type = applicant_type

    @property
    def applicant_id(self):
        """Gets the applicant_id of this ApplicantInquiryApplicant.  # noqa: E501

        Unique ID created for an Applicant. This is retuned back in ApplicantAdd response and the same should be passed here.  # noqa: E501

        :return: The applicant_id of this ApplicantInquiryApplicant.  # noqa: E501
        :rtype: str
        """
        return self._applicant_id

    @applicant_id.setter
    def applicant_id(self, applicant_id):
        """Sets the applicant_id of this ApplicantInquiryApplicant.

        Unique ID created for an Applicant. This is retuned back in ApplicantAdd response and the same should be passed here.  # noqa: E501

        :param applicant_id: The applicant_id of this ApplicantInquiryApplicant.  # noqa: E501
        :type: str
        """

        self._applicant_id = applicant_id

    @property
    def mother_maiden_name(self):
        """Gets the mother_maiden_name of this ApplicantInquiryApplicant.  # noqa: E501

        Mothers maiden name  # noqa: E501

        :return: The mother_maiden_name of this ApplicantInquiryApplicant.  # noqa: E501
        :rtype: str
        """
        return self._mother_maiden_name

    @mother_maiden_name.setter
    def mother_maiden_name(self, mother_maiden_name):
        """Sets the mother_maiden_name of this ApplicantInquiryApplicant.

        Mothers maiden name  # noqa: E501

        :param mother_maiden_name: The mother_maiden_name of this ApplicantInquiryApplicant.  # noqa: E501
        :type: str
        """

        self._mother_maiden_name = mother_maiden_name

    @property
    def name(self):
        """Gets the name of this ApplicantInquiryApplicant.  # noqa: E501


        :return: The name of this ApplicantInquiryApplicant.  # noqa: E501
        :rtype: ApplicantInquiryName
        """
        return self._name

    @name.setter
    def name(self, name):
        """Sets the name of this ApplicantInquiryApplicant.


        :param name: The name of this ApplicantInquiryApplicant.  # noqa: E501
        :type: ApplicantInquiryName
        """
        if name is None:
            raise ValueError("Invalid value for `name`, must not be `None`")  # noqa: E501

        self._name = name

    @property
    def demographics(self):
        """Gets the demographics of this ApplicantInquiryApplicant.  # noqa: E501


        :return: The demographics of this ApplicantInquiryApplicant.  # noqa: E501
        :rtype: ApplicantInquiryDemographics
        """
        return self._demographics

    @demographics.setter
    def demographics(self, demographics):
        """Sets the demographics of this ApplicantInquiryApplicant.


        :param demographics: The demographics of this ApplicantInquiryApplicant.  # noqa: E501
        :type: ApplicantInquiryDemographics
        """

        self._demographics = demographics

    @property
    def address(self):
        """Gets the address of this ApplicantInquiryApplicant.  # noqa: E501


        :return: The address of this ApplicantInquiryApplicant.  # noqa: E501
        :rtype: list[ApplicantInquiryAddress]
        """
        return self._address

    @address.setter
    def address(self, address):
        """Sets the address of this ApplicantInquiryApplicant.


        :param address: The address of this ApplicantInquiryApplicant.  # noqa: E501
        :type: list[ApplicantInquiryAddress]
        """

        self._address = address

    @property
    def email(self):
        """Gets the email of this ApplicantInquiryApplicant.  # noqa: E501


        :return: The email of this ApplicantInquiryApplicant.  # noqa: E501
        :rtype: list[ApplicantInquiryEmail]
        """
        return self._email

    @email.setter
    def email(self, email):
        """Sets the email of this ApplicantInquiryApplicant.


        :param email: The email of this ApplicantInquiryApplicant.  # noqa: E501
        :type: list[ApplicantInquiryEmail]
        """

        self._email = email

    @property
    def phone(self):
        """Gets the phone of this ApplicantInquiryApplicant.  # noqa: E501


        :return: The phone of this ApplicantInquiryApplicant.  # noqa: E501
        :rtype: list[ApplicantInquiryPhone]
        """
        return self._phone

    @phone.setter
    def phone(self, phone):
        """Sets the phone of this ApplicantInquiryApplicant.


        :param phone: The phone of this ApplicantInquiryApplicant.  # noqa: E501
        :type: list[ApplicantInquiryPhone]
        """

        self._phone = phone

    @property
    def financial_information(self):
        """Gets the financial_information of this ApplicantInquiryApplicant.  # noqa: E501


        :return: The financial_information of this ApplicantInquiryApplicant.  # noqa: E501
        :rtype: ApplicantInquiryFinancialInformation
        """
        return self._financial_information

    @financial_information.setter
    def financial_information(self, financial_information):
        """Sets the financial_information of this ApplicantInquiryApplicant.


        :param financial_information: The financial_information of this ApplicantInquiryApplicant.  # noqa: E501
        :type: ApplicantInquiryFinancialInformation
        """

        self._financial_information = financial_information

    @property
    def employment_details(self):
        """Gets the employment_details of this ApplicantInquiryApplicant.  # noqa: E501


        :return: The employment_details of this ApplicantInquiryApplicant.  # noqa: E501
        :rtype: list[ApplicantInquiryEmploymentDetails]
        """
        return self._employment_details

    @employment_details.setter
    def employment_details(self, employment_details):
        """Sets the employment_details of this ApplicantInquiryApplicant.


        :param employment_details: The employment_details of this ApplicantInquiryApplicant.  # noqa: E501
        :type: list[ApplicantInquiryEmploymentDetails]
        """

        self._employment_details = employment_details

    @property
    def identification_document_details(self):
        """Gets the identification_document_details of this ApplicantInquiryApplicant.  # noqa: E501


        :return: The identification_document_details of this ApplicantInquiryApplicant.  # noqa: E501
        :rtype: list[ApplicantInquiryIdentificationDocumentDetails]
        """
        return self._identification_document_details

    @identification_document_details.setter
    def identification_document_details(self, identification_document_details):
        """Sets the identification_document_details of this ApplicantInquiryApplicant.


        :param identification_document_details: The identification_document_details of this ApplicantInquiryApplicant.  # noqa: E501
        :type: list[ApplicantInquiryIdentificationDocumentDetails]
        """

        self._identification_document_details = identification_document_details

    @property
    def additional_data(self):
        """Gets the additional_data of this ApplicantInquiryApplicant.  # noqa: E501


        :return: The additional_data of this ApplicantInquiryApplicant.  # noqa: E501
        :rtype: ApplicantInquiryAdditionalData
        """
        return self._additional_data

    @additional_data.setter
    def additional_data(self, additional_data):
        """Sets the additional_data of this ApplicantInquiryApplicant.


        :param additional_data: The additional_data of this ApplicantInquiryApplicant.  # noqa: E501
        :type: ApplicantInquiryAdditionalData
        """

        self._additional_data = additional_data

    @property
    def partner_customer_details(self):
        """Gets the partner_customer_details of this ApplicantInquiryApplicant.  # noqa: E501


        :return: The partner_customer_details of this ApplicantInquiryApplicant.  # noqa: E501
        :rtype: ApplicantInquiryPartnerCustomerDetails
        """
        return self._partner_customer_details

    @partner_customer_details.setter
    def partner_customer_details(self, partner_customer_details):
        """Sets the partner_customer_details of this ApplicantInquiryApplicant.


        :param partner_customer_details: The partner_customer_details of this ApplicantInquiryApplicant.  # noqa: E501
        :type: ApplicantInquiryPartnerCustomerDetails
        """

        self._partner_customer_details = partner_customer_details

    @property
    def consent_details(self):
        """Gets the consent_details of this ApplicantInquiryApplicant.  # noqa: E501


        :return: The consent_details of this ApplicantInquiryApplicant.  # noqa: E501
        :rtype: list[ApplicantInquiryConsentDetails]
        """
        return self._consent_details

    @consent_details.setter
    def consent_details(self, consent_details):
        """Sets the consent_details of this ApplicantInquiryApplicant.


        :param consent_details: The consent_details of this ApplicantInquiryApplicant.  # noqa: E501
        :type: list[ApplicantInquiryConsentDetails]
        """

        self._consent_details = consent_details

    @property
    def required_documents(self):
        """Gets the required_documents of this ApplicantInquiryApplicant.  # noqa: E501


        :return: The required_documents of this ApplicantInquiryApplicant.  # noqa: E501
        :rtype: list[ApplicantInquiryRequiredDocuments]
        """
        return self._required_documents

    @required_documents.setter
    def required_documents(self, required_documents):
        """Sets the required_documents of this ApplicantInquiryApplicant.


        :param required_documents: The required_documents of this ApplicantInquiryApplicant.  # noqa: E501
        :type: list[ApplicantInquiryRequiredDocuments]
        """

        self._required_documents = required_documents

    @property
    def kyc_information(self):
        """Gets the kyc_information of this ApplicantInquiryApplicant.  # noqa: E501


        :return: The kyc_information of this ApplicantInquiryApplicant.  # noqa: E501
        :rtype: ApplicantInquiryKycInformation
        """
        return self._kyc_information

    @kyc_information.setter
    def kyc_information(self, kyc_information):
        """Sets the kyc_information of this ApplicantInquiryApplicant.


        :param kyc_information: The kyc_information of this ApplicantInquiryApplicant.  # noqa: E501
        :type: ApplicantInquiryKycInformation
        """

        self._kyc_information = kyc_information

    @property
    def contact_consent(self):
        """Gets the contact_consent of this ApplicantInquiryApplicant.  # noqa: E501


        :return: The contact_consent of this ApplicantInquiryApplicant.  # noqa: E501
        :rtype: ApplicantInquiryContactConsent
        """
        return self._contact_consent

    @contact_consent.setter
    def contact_consent(self, contact_consent):
        """Sets the contact_consent of this ApplicantInquiryApplicant.


        :param contact_consent: The contact_consent of this ApplicantInquiryApplicant.  # noqa: E501
        :type: ApplicantInquiryContactConsent
        """

        self._contact_consent = contact_consent

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
        if issubclass(ApplicantInquiryApplicant, dict):
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
        if not isinstance(other, ApplicantInquiryApplicant):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
