# This file is auto-generated by OpenAPI Generator (https://openapi-generator.tech)
# Please replace "TEST_VALUE" with a proper value and uncomment the code for testing the function

Describe 'avalara.comms.rest.v2 TaxCalculationApi' {
    Context 'TaxCalculationApi' {
        It 'Invoke-TaxCalculationApiApiV2AfcCalcTaxesPost' {
            $ret = Invoke-PetApiGetPetById -calcTaxesRequest "TEST_VALUE"
            #$ret | Should BeOfType avalara.comms.rest.v2.Model.ModelNameHere
            #$ret.property | Should Be 0
        }
    }

    Context 'TaxCalculationApi' {
        It 'Invoke-TaxCalculationApiApiV2AfcCommitPost' {
            $ret = Invoke-PetApiGetPetById -commitRequest "TEST_VALUE"
            #$ret | Should BeOfType avalara.comms.rest.v2.Model.ModelNameHere
            #$ret.property | Should Be 0
        }
    }

}
