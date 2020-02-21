# avalara.comms.rest.v2 - the C# library for the SaasPro

APIs to interface with communications tax engine.<br />The API requires Basic authentication.<br />Users with access to multiple clients must also set request header parameter for <code>client_id</code>.<br />Set <code>client_profile_id</code> to specify profile to be used for taxation.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: v2
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.10.1 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.1 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.5.2 or later
- [CompareNETObjects](https://www.nuget.org/packages/CompareNETObjects) - 4.57.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 4.5.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
Install-Package CompareNETObjects
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using avalara.comms.rest.v2.Api;
using avalara.comms.rest.v2.Client;
using avalara.comms.rest.v2.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using avalara.comms.rest.v2.Api;
using avalara.comms.rest.v2.Client;
using avalara.comms.rest.v2.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: Basic
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CustomizationApi(config);
            var requestedClientId = 56;  // int? | Client id associated with profile(s) to be fetched  Null value will use client id submitting the request or default client id as applicable. (optional) 
            var requestedProfileId = 56;  // int? | Configuration profile id to be fetched  Use 0 to indicate all profiles  Null value will use profile id from request or 0 if not set. (optional) 
            var itemType = new TaxCalculationSettingTypes(); // TaxCalculationSettingTypes | Item Type  Examples:    Configuration, Bundle, Exclusion, Override, All (optional) 

            try
            {
                // Retrieves one or more profiles with associated settings and configurable items
                TaxCalculationSettingsResponse result = apiInstance.ApiV2ProfilesGetProfilesGet(requestedClientId, requestedProfileId, itemType);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CustomizationApi.ApiV2ProfilesGetProfilesGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*CustomizationApi* | [**ApiV2ProfilesGetProfilesGet**](docs/CustomizationApi.md#apiv2profilesgetprofilesget) | **GET** /api/v2/profiles/GetProfiles | Retrieves one or more profiles with associated settings and configurable items
*CustomizationApi* | [**ApiV2ProfilesSetBundlesPost**](docs/CustomizationApi.md#apiv2profilessetbundlespost) | **POST** /api/v2/profiles/SetBundles | Creates or updates bundle packages and associated profile mappings.
*CustomizationApi* | [**ApiV2ProfilesSetConfigPost**](docs/CustomizationApi.md#apiv2profilessetconfigpost) | **POST** /api/v2/profiles/SetConfig | Creates or updates configuration settings and associated profile mappings.
*CustomizationApi* | [**ApiV2ProfilesSetExclusionsPost**](docs/CustomizationApi.md#apiv2profilessetexclusionspost) | **POST** /api/v2/profiles/SetExclusions | Creates or updates exclusions and associated profile mappings.
*CustomizationApi* | [**ApiV2ProfilesSetOverridesPost**](docs/CustomizationApi.md#apiv2profilessetoverridespost) | **POST** /api/v2/profiles/SetOverrides | Creates or updates overrides and associated profile mappings.
*HealthCheckApi* | [**ApiV2HealthCheckGet**](docs/HealthCheckApi.md#apiv2healthcheckget) | **GET** /api/v2/HealthCheck | Health check that confirms the service is operational and ready to use
*JurisdictionDeterminationApi* | [**ApiV2AfcPCodePost**](docs/JurisdictionDeterminationApi.md#apiv2afcpcodepost) | **POST** /api/v2/afc/PCode | Get PCode(s) associated with a location - Ctry/State/County/City/Zip/NpaNxx/Fips.
*JurisdictionDeterminationApi* | [**ApiV2GeoBatchLogProcessIdGet**](docs/JurisdictionDeterminationApi.md#apiv2geobatchlogprocessidget) | **GET** /api/v2/geo/batch/log/{processId} | Retrieves log on Geo Batch file
*JurisdictionDeterminationApi* | [**ApiV2GeoBatchStatusProcessIdGet**](docs/JurisdictionDeterminationApi.md#apiv2geobatchstatusprocessidget) | **GET** /api/v2/geo/batch/status/{processId} | Retrieves information on Geo Batch file status
*JurisdictionDeterminationApi* | [**ApiV2GeoBatchUploadPost**](docs/JurisdictionDeterminationApi.md#apiv2geobatchuploadpost) | **POST** /api/v2/geo/batch/Upload | Uploads file to Geo Batch.
*JurisdictionDeterminationApi* | [**ApiV2GeoGeocodePost**](docs/JurisdictionDeterminationApi.md#apiv2geogeocodepost) | **POST** /api/v2/geo/Geocode | Geocodes one or multiple street addresses and/or lat/long coordinate pairs.
*LookupsApi* | [**ApiV2AfcLocationPcodeGet**](docs/LookupsApi.md#apiv2afclocationpcodeget) | **GET** /api/v2/afc/location/{pcode} | Get location data associated with a PCode
*LookupsApi* | [**ApiV2AfcPrimaryPCodeGet**](docs/LookupsApi.md#apiv2afcprimarypcodeget) | **GET** /api/v2/afc/primary/{pCode} | Get primary location data associated with a PCode
*LookupsApi* | [**ApiV2AfcServiceinfoGet**](docs/LookupsApi.md#apiv2afcserviceinfoget) | **GET** /api/v2/afc/serviceinfo | Retrieves server time, service build version and engine version
*LookupsApi* | [**ApiV2AfcTaxtypeTaxTypeGet**](docs/LookupsApi.md#apiv2afctaxtypetaxtypeget) | **GET** /api/v2/afc/taxtype/{taxType} | Get the tax information (description and category) for a tax type ID
*LookupsApi* | [**ApiV2AfcTspairsGet**](docs/LookupsApi.md#apiv2afctspairsget) | **GET** /api/v2/afc/tspairs | Get transaction/service pair information
*TaxCalculationApi* | [**ApiV2AfcCalcTaxesPost**](docs/TaxCalculationApi.md#apiv2afccalctaxespost) | **POST** /api/v2/afc/CalcTaxes | Performs tax calculations on all invoices and line items within the request body.
*TaxCalculationApi* | [**ApiV2AfcCommitPost**](docs/TaxCalculationApi.md#apiv2afccommitpost) | **POST** /api/v2/afc/Commit | Commits or un-commits a document code.


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Address](docs/Address.md)
 - [Model.BillingPeriod](docs/BillingPeriod.md)
 - [Model.BundleConfig](docs/BundleConfig.md)
 - [Model.BundleItem](docs/BundleItem.md)
 - [Model.CalcTaxesRequest](docs/CalcTaxesRequest.md)
 - [Model.CalcTaxesResponse](docs/CalcTaxesResponse.md)
 - [Model.CommitRequest](docs/CommitRequest.md)
 - [Model.CommitResponse](docs/CommitResponse.md)
 - [Model.CompanyData](docs/CompanyData.md)
 - [Model.Configuration](docs/Configuration.md)
 - [Model.Error](docs/Error.md)
 - [Model.Exclusion](docs/Exclusion.md)
 - [Model.ExclusionConfig](docs/ExclusionConfig.md)
 - [Model.GeoBatchDownloadResponse](docs/GeoBatchDownloadResponse.md)
 - [Model.GeoBatchLog](docs/GeoBatchLog.md)
 - [Model.GeoBatchLogItem](docs/GeoBatchLogItem.md)
 - [Model.GeoBatchStatus](docs/GeoBatchStatus.md)
 - [Model.GeoBatchSubmitFileResponse](docs/GeoBatchSubmitFileResponse.md)
 - [Model.GeocodeRequest](docs/GeocodeRequest.md)
 - [Model.GeocodeResult](docs/GeocodeResult.md)
 - [Model.InlineObject](docs/InlineObject.md)
 - [Model.Invoice](docs/Invoice.md)
 - [Model.InvoiceResult](docs/InvoiceResult.md)
 - [Model.KeyValuePair](docs/KeyValuePair.md)
 - [Model.LineItem](docs/LineItem.md)
 - [Model.LineItemResult](docs/LineItemResult.md)
 - [Model.Location](docs/Location.md)
 - [Model.LocationItem](docs/LocationItem.md)
 - [Model.NexusConfig](docs/NexusConfig.md)
 - [Model.OverrideConfig](docs/OverrideConfig.md)
 - [Model.PCodeLookupRequest](docs/PCodeLookupRequest.md)
 - [Model.PCodeLookupResult](docs/PCodeLookupResult.md)
 - [Model.ReportingInformation](docs/ReportingInformation.md)
 - [Model.RequestConfig](docs/RequestConfig.md)
 - [Model.SafeHarborOverride](docs/SafeHarborOverride.md)
 - [Model.ServiceInfo](docs/ServiceInfo.md)
 - [Model.SetTaxCalculationSettingRequest](docs/SetTaxCalculationSettingRequest.md)
 - [Model.Status](docs/Status.md)
 - [Model.SummarizedTax](docs/SummarizedTax.md)
 - [Model.TSPairData](docs/TSPairData.md)
 - [Model.Tax](docs/Tax.md)
 - [Model.TaxBracket](docs/TaxBracket.md)
 - [Model.TaxCalculationSettingTypes](docs/TaxCalculationSettingTypes.md)
 - [Model.TaxCalculationSettingsResponse](docs/TaxCalculationSettingsResponse.md)
 - [Model.TaxExemption](docs/TaxExemption.md)
 - [Model.TaxOverride](docs/TaxOverride.md)
 - [Model.TaxTypeData](docs/TaxTypeData.md)
 - [Model.TrafficStudyOverride](docs/TrafficStudyOverride.md)
 - [Model.VersionInfo](docs/VersionInfo.md)
 - [Model.Warning](docs/Warning.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Basic"></a>
### Basic

- **Type**: HTTP basic authentication
