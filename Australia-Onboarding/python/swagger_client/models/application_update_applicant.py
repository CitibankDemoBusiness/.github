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

class ApplicationUpdateApplicant(object):
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
        'name': 'ApplicationUpdateName',
        'phone': 'list[ApplicationUpdatePhone]',
        'email': 'list[ApplicationUpdateEmail]',
        'ocr': 'ApplicationUpdateOcr',
        'demographics': 'ApplicationUpdateDemographics',
        'address': 'list[ApplicationUpdateAddress]',
        'contact_preference': 'ApplicationUpdateContactPreference',
        'contact_consent': 'ApplicationUpdateContactConsent',
        'financial_information': 'ApplicationUpdateFinancialInformation',
        'mother_maiden_name': 'str',
        'education': 'ApplicationUpdateEducation',
        'employment_details': 'list[ApplicationUpdateEmploymentDetails]',
        'identification_document_details': 'list[ApplicationUpdateIdentificationDocumentDetails]',
        'additional_data': 'ApplicationUpdateAdditionalData',
        'partner_customer_details': 'ApplicationUpdatePartnerCustomerDetails',
        'consent_details': 'list[ApplicationUpdateConsentDetails]',
        'marketing_consent': 'ApplicationUpdateMarketingConsent',
        'self_declaration': 'ApplicationUpdateSelfDeclaration',
        'kyc_information': 'ApplicationUpdateKycInformation'
    }

    attribute_map = {
        'name': 'name',
        'phone': 'phone',
        'email': 'email',
        'ocr': 'ocr',
        'demographics': 'demographics',
        'address': 'address',
        'contact_preference': 'contactPreference',
        'contact_consent': 'contactConsent',
        'financial_information': 'financialInformation',
        'mother_maiden_name': 'motherMaidenName',
        'education': 'education',
        'employment_details': 'employmentDetails',
        'identification_document_details': 'identificationDocumentDetails',
        'additional_data': 'additionalData',
        'partner_customer_details': 'partnerCustomerDetails',
        'consent_details': 'consentDetails',
        'marketing_consent': 'marketingConsent',
        'self_declaration': 'selfDeclaration',
        'kyc_information': 'kycInformation'
    }

    def __init__(self, name=None, phone=None, email=None, ocr=None, demographics=None, address=None, contact_preference=None, contact_consent=None, financial_information=None, mother_maiden_name=None, education=None, employment_details=None, identification_document_details=None, additional_data=None, partner_customer_details=None, consent_details=None, marketing_consent=None, self_declaration=None, kyc_information=None):  # noqa: E501
        """ApplicationUpdateApplicant - a model defined in Swagger"""  # noqa: E501
        self._name = None
        self._phone = None
        self._email = None
        self._ocr = None
        self._demographics = None
        self._address = None
        self._contact_preference = None
        self._contact_consent = None
        self._financial_information = None
        self._mother_maiden_name = None
        self._education = None
        self._employment_details = None
        self._identification_document_details = None
        self._additional_data = None
        self._partner_customer_details = None
        self._consent_details = None
        self._marketing_consent = None
        self._self_declaration = None
        self._kyc_information = None
        self.discriminator = None
        if name is not None:
            self.name = name
        if phone is not None:
            self.phone = phone
        if email is not None:
            self.email = email
        if ocr is not None:
            self.ocr = ocr
        if demographics is not None:
            self.demographics = demographics
        if address is not None:
            self.address = address
        if contact_preference is not None:
            self.contact_preference = contact_preference
        if contact_consent is not None:
            self.contact_consent = contact_consent
        if financial_information is not None:
            self.financial_information = financial_information
        if mother_maiden_name is not None:
            self.mother_maiden_name = mother_maiden_name
        if education is not None:
            self.education = education
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
        if marketing_consent is not None:
            self.marketing_consent = marketing_consent
        if self_declaration is not None:
            self.self_declaration = self_declaration
        if kyc_information is not None:
            self.kyc_information = kyc_information

    @property
    def name(self):
        """Gets the name of this ApplicationUpdateApplicant.  # noqa: E501


        :return: The name of this ApplicationUpdateApplicant.  # noqa: E501
        :rtype: ApplicationUpdateName
        """
        return self._name

    @name.setter
    def name(self, name):
        """Sets the name of this ApplicationUpdateApplicant.


        :param name: The name of this ApplicationUpdateApplicant.  # noqa: E501
        :type: ApplicationUpdateName
        """

        self._name = name

    @property
    def phone(self):
        """Gets the phone of this ApplicationUpdateApplicant.  # noqa: E501


        :return: The phone of this ApplicationUpdateApplicant.  # noqa: E501
        :rtype: list[ApplicationUpdatePhone]
        """
        return self._phone

    @phone.setter
    def phone(self, phone):
        """Sets the phone of this ApplicationUpdateApplicant.


        :param phone: The phone of this ApplicationUpdateApplicant.  # noqa: E501
        :type: list[ApplicationUpdatePhone]
        """

        self._phone = phone

    @property
    def email(self):
        """Gets the email of this ApplicationUpdateApplicant.  # noqa: E501


        :return: The email of this ApplicationUpdateApplicant.  # noqa: E501
        :rtype: list[ApplicationUpdateEmail]
        """
        return self._email

    @email.setter
    def email(self, email):
        """Sets the email of this ApplicationUpdateApplicant.


        :param email: The email of this ApplicationUpdateApplicant.  # noqa: E501
        :type: list[ApplicationUpdateEmail]
        """

        self._email = email

    @property
    def ocr(self):
        """Gets the ocr of this ApplicationUpdateApplicant.  # noqa: E501


        :return: The ocr of this ApplicationUpdateApplicant.  # noqa: E501
        :rtype: ApplicationUpdateOcr
        """
        return self._ocr

    @ocr.setter
    def ocr(self, ocr):
        """Sets the ocr of this ApplicationUpdateApplicant.


        :param ocr: The ocr of this ApplicationUpdateApplicant.  # noqa: E501
        :type: ApplicationUpdateOcr
        """

        self._ocr = ocr

    @property
    def demographics(self):
        """Gets the demographics of this ApplicationUpdateApplicant.  # noqa: E501


        :return: The demographics of this ApplicationUpdateApplicant.  # noqa: E501
        :rtype: ApplicationUpdateDemographics
        """
        return self._demographics

    @demographics.setter
    def demographics(self, demographics):
        """Sets the demographics of this ApplicationUpdateApplicant.


        :param demographics: The demographics of this ApplicationUpdateApplicant.  # noqa: E501
        :type: ApplicationUpdateDemographics
        """

        self._demographics = demographics

    @property
    def address(self):
        """Gets the address of this ApplicationUpdateApplicant.  # noqa: E501


        :return: The address of this ApplicationUpdateApplicant.  # noqa: E501
        :rtype: list[ApplicationUpdateAddress]
        """
        return self._address

    @address.setter
    def address(self, address):
        """Sets the address of this ApplicationUpdateApplicant.


        :param address: The address of this ApplicationUpdateApplicant.  # noqa: E501
        :type: list[ApplicationUpdateAddress]
        """

        self._address = address

    @property
    def contact_preference(self):
        """Gets the contact_preference of this ApplicationUpdateApplicant.  # noqa: E501


        :return: The contact_preference of this ApplicationUpdateApplicant.  # noqa: E501
        :rtype: ApplicationUpdateContactPreference
        """
        return self._contact_preference

    @contact_preference.setter
    def contact_preference(self, contact_preference):
        """Sets the contact_preference of this ApplicationUpdateApplicant.


        :param contact_preference: The contact_preference of this ApplicationUpdateApplicant.  # noqa: E501
        :type: ApplicationUpdateContactPreference
        """

        self._contact_preference = contact_preference

    @property
    def contact_consent(self):
        """Gets the contact_consent of this ApplicationUpdateApplicant.  # noqa: E501


        :return: The contact_consent of this ApplicationUpdateApplicant.  # noqa: E501
        :rtype: ApplicationUpdateContactConsent
        """
        return self._contact_consent

    @contact_consent.setter
    def contact_consent(self, contact_consent):
        """Sets the contact_consent of this ApplicationUpdateApplicant.


        :param contact_consent: The contact_consent of this ApplicationUpdateApplicant.  # noqa: E501
        :type: ApplicationUpdateContactConsent
        """

        self._contact_consent = contact_consent

    @property
    def financial_information(self):
        """Gets the financial_information of this ApplicationUpdateApplicant.  # noqa: E501


        :return: The financial_information of this ApplicationUpdateApplicant.  # noqa: E501
        :rtype: ApplicationUpdateFinancialInformation
        """
        return self._financial_information

    @financial_information.setter
    def financial_information(self, financial_information):
        """Sets the financial_information of this ApplicationUpdateApplicant.


        :param financial_information: The financial_information of this ApplicationUpdateApplicant.  # noqa: E501
        :type: ApplicationUpdateFinancialInformation
        """

        self._financial_information = financial_information

    @property
    def mother_maiden_name(self):
        """Gets the mother_maiden_name of this ApplicationUpdateApplicant.  # noqa: E501

        Mother's maiden name  # noqa: E501

        :return: The mother_maiden_name of this ApplicationUpdateApplicant.  # noqa: E501
        :rtype: str
        """
        return self._mother_maiden_name

    @mother_maiden_name.setter
    def mother_maiden_name(self, mother_maiden_name):
        """Sets the mother_maiden_name of this ApplicationUpdateApplicant.

        Mother's maiden name  # noqa: E501

        :param mother_maiden_name: The mother_maiden_name of this ApplicationUpdateApplicant.  # noqa: E501
        :type: str
        """

        self._mother_maiden_name = mother_maiden_name

    @property
    def education(self):
        """Gets the education of this ApplicationUpdateApplicant.  # noqa: E501


        :return: The education of this ApplicationUpdateApplicant.  # noqa: E501
        :rtype: ApplicationUpdateEducation
        """
        return self._education

    @education.setter
    def education(self, education):
        """Sets the education of this ApplicationUpdateApplicant.


        :param education: The education of this ApplicationUpdateApplicant.  # noqa: E501
        :type: ApplicationUpdateEducation
        """

        self._education = education

    @property
    def employment_details(self):
        """Gets the employment_details of this ApplicationUpdateApplicant.  # noqa: E501


        :return: The employment_details of this ApplicationUpdateApplicant.  # noqa: E501
        :rtype: list[ApplicationUpdateEmploymentDetails]
        """
        return self._employment_details

    @employment_details.setter
    def employment_details(self, employment_details):
        """Sets the employment_details of this ApplicationUpdateApplicant.


        :param employment_details: The employment_details of this ApplicationUpdateApplicant.  # noqa: E501
        :type: list[ApplicationUpdateEmploymentDetails]
        """

        self._employment_details = employment_details

    @property
    def identification_document_details(self):
        """Gets the identification_document_details of this ApplicationUpdateApplicant.  # noqa: E501


        :return: The identification_document_details of this ApplicationUpdateApplicant.  # noqa: E501
        :rtype: list[ApplicationUpdateIdentificationDocumentDetails]
        """
        return self._identification_document_details

    @identification_document_details.setter
    def identification_document_details(self, identification_document_details):
        """Sets the identification_document_details of this ApplicationUpdateApplicant.


        :param identification_document_details: The identification_document_details of this ApplicationUpdateApplicant.  # noqa: E501
        :type: list[ApplicationUpdateIdentificationDocumentDetails]
        """

        self._identification_document_details = identification_document_details

    @property
    def additional_data(self):
        """Gets the additional_data of this ApplicationUpdateApplicant.  # noqa: E501


        :return: The additional_data of this ApplicationUpdateApplicant.  # noqa: E501
        :rtype: ApplicationUpdateAdditionalData
        """
        return self._additional_data

    @additional_data.setter
    def additional_data(self, additional_data):
        """Sets the additional_data of this ApplicationUpdateApplicant.


        :param additional_data: The additional_data of this ApplicationUpdateApplicant.  # noqa: E501
        :type: ApplicationUpdateAdditionalData
        """

        self._additional_data = additional_data

    @property
    def partner_customer_details(self):
        """Gets the partner_customer_details of this ApplicationUpdateApplicant.  # noqa: E501


        :return: The partner_customer_details of this ApplicationUpdateApplicant.  # noqa: E501
        :rtype: ApplicationUpdatePartnerCustomerDetails
        """
        return self._partner_customer_details

    @partner_customer_details.setter
    def partner_customer_details(self, partner_customer_details):
        """Sets the partner_customer_details of this ApplicationUpdateApplicant.


        :param partner_customer_details: The partner_customer_details of this ApplicationUpdateApplicant.  # noqa: E501
        :type: ApplicationUpdatePartnerCustomerDetails
        """

        self._partner_customer_details = partner_customer_details

    @property
    def consent_details(self):
        """Gets the consent_details of this ApplicationUpdateApplicant.  # noqa: E501


        :return: The consent_details of this ApplicationUpdateApplicant.  # noqa: E501
        :rtype: list[ApplicationUpdateConsentDetails]
        """
        return self._consent_details

    @consent_details.setter
    def consent_details(self, consent_details):
        """Sets the consent_details of this ApplicationUpdateApplicant.


        :param consent_details: The consent_details of this ApplicationUpdateApplicant.  # noqa: E501
        :type: list[ApplicationUpdateConsentDetails]
        """

        self._consent_details = consent_details

    @property
    def marketing_consent(self):
        """Gets the marketing_consent of this ApplicationUpdateApplicant.  # noqa: E501


        :return: The marketing_consent of this ApplicationUpdateApplicant.  # noqa: E501
        :rtype: ApplicationUpdateMarketingConsent
        """
        return self._marketing_consent

    @marketing_consent.setter
    def marketing_consent(self, marketing_consent):
        """Sets the marketing_consent of this ApplicationUpdateApplicant.


        :param marketing_consent: The marketing_consent of this ApplicationUpdateApplicant.  # noqa: E501
        :type: ApplicationUpdateMarketingConsent
        """

        self._marketing_consent = marketing_consent

    @property
    def self_declaration(self):
        """Gets the self_declaration of this ApplicationUpdateApplicant.  # noqa: E501


        :return: The self_declaration of this ApplicationUpdateApplicant.  # noqa: E501
        :rtype: ApplicationUpdateSelfDeclaration
        """
        return self._self_declaration

    @self_declaration.setter
    def self_declaration(self, self_declaration):
        """Sets the self_declaration of this ApplicationUpdateApplicant.


        :param self_declaration: The self_declaration of this ApplicationUpdateApplicant.  # noqa: E501
        :type: ApplicationUpdateSelfDeclaration
        """

        self._self_declaration = self_declaration

    @property
    def kyc_information(self):
        """Gets the kyc_information of this ApplicationUpdateApplicant.  # noqa: E501


        :return: The kyc_information of this ApplicationUpdateApplicant.  # noqa: E501
        :rtype: ApplicationUpdateKycInformation
        """
        return self._kyc_information

    @kyc_information.setter
    def kyc_information(self, kyc_information):
        """Sets the kyc_information of this ApplicationUpdateApplicant.


        :param kyc_information: The kyc_information of this ApplicationUpdateApplicant.  # noqa: E501
        :type: ApplicationUpdateKycInformation
        """

        self._kyc_information = kyc_information

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
        if issubclass(ApplicationUpdateApplicant, dict):
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
        if not isinstance(other, ApplicationUpdateApplicant):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other