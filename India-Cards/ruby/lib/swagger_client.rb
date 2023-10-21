=begin
#Cards

#The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.29
=end

# Common files
require 'swagger_client/api_client'
require 'swagger_client/api_error'
require 'swagger_client/version'
require 'swagger_client/configuration'

# Models
require 'swagger_client/models/account'
require 'swagger_client/models/account_currency_details'
require 'swagger_client/models/account_details'
require 'swagger_client/models/account_dtls'
require 'swagger_client/models/activate_card_request'
require 'swagger_client/models/activation_request'
require 'swagger_client/models/address'
require 'swagger_client/models/amortization_schedule'
require 'swagger_client/models/applicant'
require 'swagger_client/models/bank_details'
require 'swagger_client/models/beneficiary_bank_detail'
require 'swagger_client/models/beneficiary_detail'
require 'swagger_client/models/binary_data'
require 'swagger_client/models/card_details'
require 'swagger_client/models/card_functions_allowed'
require 'swagger_client/models/card_listing_response'
require 'swagger_client/models/card_overseas_usage_confirmation_request'
require 'swagger_client/models/card_statement_summary_request'
require 'swagger_client/models/card_statement_summary_response'
require 'swagger_client/models/card_usage_confirmation_request'
require 'swagger_client/models/card_usage_request'
require 'swagger_client/models/cards_limits_and_enrollments_update_request'
require 'swagger_client/models/change_atm_pin_request'
require 'swagger_client/models/companion_card_application_request'
require 'swagger_client/models/companion_card_application_response'
require 'swagger_client/models/consent_details'
require 'swagger_client/models/corporate_officer_details'
require 'swagger_client/models/country_codes'
require 'swagger_client/models/country_specific_address'
require 'swagger_client/models/credit_card_details'
require 'swagger_client/models/credit_card_limit_details'
require 'swagger_client/models/credit_card_statement'
require 'swagger_client/models/credit_card_statement_summary'
require 'swagger_client/models/credit_limit_decrease_consent_request'
require 'swagger_client/models/credit_limit_decrease_consent_response'
require 'swagger_client/models/credit_limit_decrease_request'
require 'swagger_client/models/credit_limit_decrease_response'
require 'swagger_client/models/credit_limit_increase_request'
require 'swagger_client/models/credit_limit_increase_response'
require 'swagger_client/models/currency_details'
require 'swagger_client/models/cvv_verification_request'
require 'swagger_client/models/data'
require 'swagger_client/models/data_fees_charges'
require 'swagger_client/models/data_fees_charges_fee_charge_detail'
require 'swagger_client/models/data_product_details'
require 'swagger_client/models/data_product_offerings'
require 'swagger_client/models/data_promotions'
require 'swagger_client/models/data_requirements'
require 'swagger_client/models/data_requirements_applicant'
require 'swagger_client/models/data_requirements_document'
require 'swagger_client/models/data_requirements_requirement_detail'
require 'swagger_client/models/debit_card_details'
require 'swagger_client/models/debit_card_enrollment_details'
require 'swagger_client/models/debit_card_limit_details'
require 'swagger_client/models/demographics'
require 'swagger_client/models/domestic_transaction'
require 'swagger_client/models/easy_payment_plans_eligibility_inquiry_response'
require 'swagger_client/models/easy_payment_plans_transaction_eligibility_response'
require 'swagger_client/models/eligible_for_equal_payment_plan'
require 'swagger_client/models/employment_details'
require 'swagger_client/models/epp_amortization_schedule'
require 'swagger_client/models/epp_loan_booking'
require 'swagger_client/models/epp_loan_booking_confirmation_request'
require 'swagger_client/models/epp_loan_booking_confirmation_response'
require 'swagger_client/models/epp_loan_booking_request'
require 'swagger_client/models/epp_loan_booking_response'
require 'swagger_client/models/epp_offers'
require 'swagger_client/models/epp_repayment_scheule_response'
require 'swagger_client/models/epp_request'
require 'swagger_client/models/epp_response'
require 'swagger_client/models/epp_transaction'
require 'swagger_client/models/error_response'
require 'swagger_client/models/history_and_intraday_transaction'
require 'swagger_client/models/history_and_intraday_transaction_records'
require 'swagger_client/models/history_and_intraday_transactions'
require 'swagger_client/models/identification_document_details'
require 'swagger_client/models/initiate_credit_charge_card_corporate_cards_closure_request'
require 'swagger_client/models/initiate_credit_charge_card_corporate_cards_closure_response'
require 'swagger_client/models/international_transaction'
require 'swagger_client/models/linked_account_details'
require 'swagger_client/models/list_response'
require 'swagger_client/models/loan'
require 'swagger_client/models/loan_account'
require 'swagger_client/models/loan_amortization_schedule'
require 'swagger_client/models/loan_payment_plans'
require 'swagger_client/models/loan_payment_schedule'
require 'swagger_client/models/loan_summary'
require 'swagger_client/models/meta'
require 'swagger_client/models/multi_currency_account_eligibility'
require 'swagger_client/models/multi_currency_account_eligibility_response'
require 'swagger_client/models/multi_currency_account_enrollment_request'
require 'swagger_client/models/multi_currency_account_enrollment_response'
require 'swagger_client/models/multi_currency_account_enrollment_with_currency_request'
require 'swagger_client/models/multi_currency_account_enrollment_with_currency_response'
require 'swagger_client/models/name'
require 'swagger_client/models/notify_credit_charge_card_fulfillment_arrangement_authorised_transaction_request'
require 'swagger_client/models/overseas_card_usage_request'
require 'swagger_client/models/overseas_travel_plan_add_request'
require 'swagger_client/models/overseas_travel_plan_inquiry_response'
require 'swagger_client/models/overseas_travel_plan_update_request'
require 'swagger_client/models/partner_card_details'
require 'swagger_client/models/partner_card_listing_response'
require 'swagger_client/models/partner_customer_details'
require 'swagger_client/models/pending_authorization_transaction'
require 'swagger_client/models/pending_authorization_transaction_records'
require 'swagger_client/models/pending_authorization_transactions'
require 'swagger_client/models/pending_transaction'
require 'swagger_client/models/permanent_credit_limit_increase'
require 'swagger_client/models/phone'
require 'swagger_client/models/previous_primary_card'
require 'swagger_client/models/product_response'
require 'swagger_client/models/report_lost_stolen_card_request'
require 'swagger_client/models/report_lost_stolen_card_response'
require 'swagger_client/models/request_credit_charge_card_corporate_cards_suspension_and_cash_limit_allowed_request'
require 'swagger_client/models/request_credit_charge_card_fulfillment_arrangement_corporate_cards_damage_replacement_request'
require 'swagger_client/models/request_credit_charge_card_fulfillment_arrangement_corporate_cards_damage_replacement_response'
require 'swagger_client/models/request_credit_charge_card_fulfillment_arrangement_credit_plan_epp_refund_request'
require 'swagger_client/models/reset_atm_pin_confirmation_request'
require 'swagger_client/models/reset_atm_pin_confirmation_response'
require 'swagger_client/models/reset_atm_pin_request'
require 'swagger_client/models/retrieve_credit_charge_card_corporate_cards_cash_limit_request'
require 'swagger_client/models/retrieve_credit_charge_card_corporate_cards_cash_limit_response'
require 'swagger_client/models/retrieve_credit_charge_card_corporate_cards_detail_request'
require 'swagger_client/models/retrieve_credit_charge_card_corporate_cards_detail_response'
require 'swagger_client/models/retrieve_credit_charge_card_corporate_cards_pending_and_intraday_authorization_transactions_request'
require 'swagger_client/models/retrieve_credit_charge_card_corporate_cards_pending_and_intraday_authorization_transactions_response'
require 'swagger_client/models/retrieve_credit_charge_card_fulfillment_arrangement_credit_card_status_response'
require 'swagger_client/models/retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate_confirmation_pre_login_request'
require 'swagger_client/models/retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate_confirmation_pre_login_response'
require 'swagger_client/models/retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate_pre_login_request'
require 'swagger_client/models/retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate_pre_login_response'
require 'swagger_client/models/retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate_pre_login_with_validation_request'
require 'swagger_client/models/retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate_pre_login_with_validation_response'
require 'swagger_client/models/retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_loans_response'
require 'swagger_client/models/retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_epp_bookings_request'
require 'swagger_client/models/retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_epp_bookings_response'
require 'swagger_client/models/retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_epp_repayment_schedules_response'
require 'swagger_client/models/retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_epp_response'
require 'swagger_client/models/retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_loan_payment_plans_request'
require 'swagger_client/models/retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_loan_payment_plans_response'
require 'swagger_client/models/retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_loan_payment_schedules_request'
require 'swagger_client/models/retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_loan_payment_schedules_response'
require 'swagger_client/models/retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_loan_repayment_schedules_request'
require 'swagger_client/models/retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_loan_repayment_schedules_response'
require 'swagger_client/models/retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_outstanding_loan_repayment_schedules_response'
require 'swagger_client/models/reward_account'
require 'swagger_client/models/reward_points'
require 'swagger_client/models/rewards_inquiry_request'
require 'swagger_client/models/rewards_inquiry_response'
require 'swagger_client/models/statement'
require 'swagger_client/models/statement_list'
require 'swagger_client/models/statement_summary_request'
require 'swagger_client/models/supplementary_card_listing_response'
require 'swagger_client/models/supplementary_card_request'
require 'swagger_client/models/supplementary_card_response'
require 'swagger_client/models/supplementary_cards'
require 'swagger_client/models/temporary_credit_limit_increase'
require 'swagger_client/models/transaction_authorization_codes'
require 'swagger_client/models/transaction_reference_id'
require 'swagger_client/models/travel_plan'
require 'swagger_client/models/unbilled_transaction'
require 'swagger_client/models/update_credit_charge_card_corporate_cards_cash_limit_request'
require 'swagger_client/models/update_credit_charge_card_corporate_cards_credit_limit_request'
require 'swagger_client/models/update_credit_charge_card_corporate_cards_credit_limit_response'
require 'swagger_client/models/update_credit_charge_card_fulfillment_arrangement_corporate_cards_lost_or_stolen_request'
require 'swagger_client/models/update_credit_charge_card_fulfillment_arrangement_corporate_cards_lost_or_stolen_response'
require 'swagger_client/models/update_credit_charge_card_fulfillment_arrangement_corporate_cards_spend_control_request'
require 'swagger_client/models/update_issued_device_allocation_device_pfid_request'
require 'swagger_client/models/update_issued_device_allocation_device_pfid_response'

# APIs
require 'swagger_client/api/accounts_api'
require 'swagger_client/api/cards_api'
require 'swagger_client/api/crossproductutilities_api'
require 'swagger_client/api/card_servicing_api'
require 'swagger_client/api/cards_api'
require 'swagger_client/api/credit_cards_api'
require 'swagger_client/api/cross_product_utilities_api'
require 'swagger_client/api/customer_foundational_api'
require 'swagger_client/api/default_api'
require 'swagger_client/api/rewards_api'

module SwaggerClient
  class << self
    # Customize default settings for the SDK using block.
    #   SwaggerClient.configure do |config|
    #     config.username = "xxx"
    #     config.password = "xxx"
    #   end
    # If no block given, return the default Configuration object.
    def configure
      if block_given?
        yield(Configuration.default)
      else
        Configuration.default
      end
    end
  end
end
