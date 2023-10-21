# ApplicationUpdateEducation

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**highest_education_level** | **string** | Highest education level of the applicant. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{highestEducationLevel} resource to get valid value of this field with description. You can use highestEducationLevel field name as the referenceCode parameter to retrieve the values. | [optional] 
**year_of_graduation** | **string** | Year of completing graduation. This is required if applicant is a student | [optional] 
**student_id** | **string** | Unique ID of the student. This is required if applicant is a student | [optional] 
**university** | **string** | University name. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{universityCode} resource to get valid value of this field with description. You can use university field name as the referenceCode parameter to retrieve the values. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)
