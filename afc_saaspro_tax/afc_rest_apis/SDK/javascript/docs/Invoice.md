# SaasPro.Invoice

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**doc** | **String** | Document code. | [optional] 
**cmmt** | **Boolean** | Indicates if invoice should be committed as soon as it is processed.  Default: false. | [optional] 
**bill** | [**Location**](Location.md) |  | [optional] 
**cust** | **Number** | Customer type. | [optional] 
**lfln** | **Boolean** | Indicates if customer is a Lifeline participant.  Default: false. | [optional] 
**_date** | **Date** | Invoice date. | [optional] 
**exms** | [**[TaxExemption]**](TaxExemption.md) | Tax exemptions. | [optional] 
**itms** | [**[LineItem]**](LineItem.md) | Line items. | [optional] 
**invm** | **Boolean** | Indicates if all line items within invoice should be processed in invoice mode.  Default: true. | [optional] 
**dtl** | **Boolean** | Indicates if individual line item taxes should be included in response.  Default: true. | [optional] 
**summ** | **Boolean** | Indicates if the summarized taxes for the invoice should be included in the resonse.  Default: false. | [optional] 
**opt** | [**[KeyValuePair]**](KeyValuePair.md) | Optional values for invoice. Maximum of 5. Keys must be numeric from 1 to 5. | [optional] 
**acct** | **String** | Account reference for reporting | [optional] 
**custref** | **String** | Customer Reference for reporting | [optional] 
**invn** | **String** | Invoice Number reference for reporting | [optional] 
**bcyc** | **String** | Bill Cycle reference for reporting | [optional] 
**bpd** | [**BillingPeriod**](BillingPeriod.md) |  | [optional] 
**ccycd** | **String** | Currency code for invoice.  Example: CAD &#x3D; Canadian Dollar | [optional] 


