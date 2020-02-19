/*
 * SaasPro
 * APIs to interface with communications tax engine.<br />The API requires Basic authentication.<br />Users with access to multiple clients must also set request header parameter for <code>client_id</code>.<br />Set <code>client_profile_id</code> to specify profile to be used for taxation.
 *
 * The version of the OpenAPI document: v2
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import org.openapitools.client.model.Error;
import org.openapitools.client.model.InvoiceResult;
import org.junit.Assert;
import org.junit.Ignore;
import org.junit.Test;


/**
 * Model tests for CalcTaxesResponse
 */
public class CalcTaxesResponseTest {
    private final CalcTaxesResponse model = new CalcTaxesResponse();

    /**
     * Model tests for CalcTaxesResponse
     */
    @Test
    public void testCalcTaxesResponse() {
        // TODO: test CalcTaxesResponse
    }

    /**
     * Test the property 'inv'
     */
    @Test
    public void invTest() {
        // TODO: test inv
    }

    /**
     * Test the property 'err'
     */
    @Test
    public void errTest() {
        // TODO: test err
    }

}
