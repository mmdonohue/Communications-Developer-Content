/* 
 * SaasPro
 *
 * APIs to interface with communications tax engine.<br />The API requires Basic authentication.<br />Users with access to multiple clients must also set request header parameter for <code>client_id</code>.<br />Set <code>client_profile_id</code> to specify profile to be used for taxation.
 *
 * The version of the OpenAPI document: v2
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using avalara.comms.rest.v2.Client;
using avalara.comms.rest.v2.Model;

namespace avalara.comms.rest.v2.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITaxCalculationApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Performs tax calculations on all invoices and line items within the request body.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="avalara.comms.rest.v2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calcTaxesRequest">CalcTaxesRequest object containing invoices to process and data required               for performing tax calculations. (optional)</param>
        /// <returns>CalcTaxesResponse</returns>
        CalcTaxesResponse ApiV2AfcCalcTaxesPost (CalcTaxesRequest calcTaxesRequest = default(CalcTaxesRequest));

        /// <summary>
        /// Performs tax calculations on all invoices and line items within the request body.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="avalara.comms.rest.v2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calcTaxesRequest">CalcTaxesRequest object containing invoices to process and data required               for performing tax calculations. (optional)</param>
        /// <returns>ApiResponse of CalcTaxesResponse</returns>
        ApiResponse<CalcTaxesResponse> ApiV2AfcCalcTaxesPostWithHttpInfo (CalcTaxesRequest calcTaxesRequest = default(CalcTaxesRequest));
        /// <summary>
        /// Commits or un-commits a document code.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="avalara.comms.rest.v2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="commitRequest">CommitRequest object containing document code and optional field data to override in reports. (optional)</param>
        /// <returns>CommitResponse</returns>
        CommitResponse ApiV2AfcCommitPost (CommitRequest commitRequest = default(CommitRequest));

        /// <summary>
        /// Commits or un-commits a document code.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="avalara.comms.rest.v2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="commitRequest">CommitRequest object containing document code and optional field data to override in reports. (optional)</param>
        /// <returns>ApiResponse of CommitResponse</returns>
        ApiResponse<CommitResponse> ApiV2AfcCommitPostWithHttpInfo (CommitRequest commitRequest = default(CommitRequest));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITaxCalculationApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Performs tax calculations on all invoices and line items within the request body.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="avalara.comms.rest.v2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calcTaxesRequest">CalcTaxesRequest object containing invoices to process and data required               for performing tax calculations. (optional)</param>
        /// <returns>Task of CalcTaxesResponse</returns>
        System.Threading.Tasks.Task<CalcTaxesResponse> ApiV2AfcCalcTaxesPostAsync (CalcTaxesRequest calcTaxesRequest = default(CalcTaxesRequest));

        /// <summary>
        /// Performs tax calculations on all invoices and line items within the request body.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="avalara.comms.rest.v2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calcTaxesRequest">CalcTaxesRequest object containing invoices to process and data required               for performing tax calculations. (optional)</param>
        /// <returns>Task of ApiResponse (CalcTaxesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CalcTaxesResponse>> ApiV2AfcCalcTaxesPostAsyncWithHttpInfo (CalcTaxesRequest calcTaxesRequest = default(CalcTaxesRequest));
        /// <summary>
        /// Commits or un-commits a document code.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="avalara.comms.rest.v2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="commitRequest">CommitRequest object containing document code and optional field data to override in reports. (optional)</param>
        /// <returns>Task of CommitResponse</returns>
        System.Threading.Tasks.Task<CommitResponse> ApiV2AfcCommitPostAsync (CommitRequest commitRequest = default(CommitRequest));

        /// <summary>
        /// Commits or un-commits a document code.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="avalara.comms.rest.v2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="commitRequest">CommitRequest object containing document code and optional field data to override in reports. (optional)</param>
        /// <returns>Task of ApiResponse (CommitResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CommitResponse>> ApiV2AfcCommitPostAsyncWithHttpInfo (CommitRequest commitRequest = default(CommitRequest));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITaxCalculationApi : ITaxCalculationApiSync, ITaxCalculationApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TaxCalculationApi : ITaxCalculationApi
    {
        private avalara.comms.rest.v2.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TaxCalculationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TaxCalculationApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaxCalculationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TaxCalculationApi(String basePath)
        {
            this.Configuration = avalara.comms.rest.v2.Client.Configuration.MergeConfigurations(
                avalara.comms.rest.v2.Client.GlobalConfiguration.Instance,
                new avalara.comms.rest.v2.Client.Configuration { BasePath = basePath }
            );
            this.Client = new avalara.comms.rest.v2.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new avalara.comms.rest.v2.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = avalara.comms.rest.v2.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaxCalculationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TaxCalculationApi(avalara.comms.rest.v2.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = avalara.comms.rest.v2.Client.Configuration.MergeConfigurations(
                avalara.comms.rest.v2.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new avalara.comms.rest.v2.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new avalara.comms.rest.v2.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = avalara.comms.rest.v2.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaxCalculationApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public TaxCalculationApi(avalara.comms.rest.v2.Client.ISynchronousClient client,avalara.comms.rest.v2.Client.IAsynchronousClient asyncClient, avalara.comms.rest.v2.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = avalara.comms.rest.v2.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public avalara.comms.rest.v2.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public avalara.comms.rest.v2.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public avalara.comms.rest.v2.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public avalara.comms.rest.v2.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Performs tax calculations on all invoices and line items within the request body. 
        /// </summary>
        /// <exception cref="avalara.comms.rest.v2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calcTaxesRequest">CalcTaxesRequest object containing invoices to process and data required               for performing tax calculations. (optional)</param>
        /// <returns>CalcTaxesResponse</returns>
        public CalcTaxesResponse ApiV2AfcCalcTaxesPost (CalcTaxesRequest calcTaxesRequest = default(CalcTaxesRequest))
        {
             avalara.comms.rest.v2.Client.ApiResponse<CalcTaxesResponse> localVarResponse = ApiV2AfcCalcTaxesPostWithHttpInfo(calcTaxesRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Performs tax calculations on all invoices and line items within the request body. 
        /// </summary>
        /// <exception cref="avalara.comms.rest.v2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calcTaxesRequest">CalcTaxesRequest object containing invoices to process and data required               for performing tax calculations. (optional)</param>
        /// <returns>ApiResponse of CalcTaxesResponse</returns>
        public avalara.comms.rest.v2.Client.ApiResponse< CalcTaxesResponse > ApiV2AfcCalcTaxesPostWithHttpInfo (CalcTaxesRequest calcTaxesRequest = default(CalcTaxesRequest))
        {
            avalara.comms.rest.v2.Client.RequestOptions localVarRequestOptions = new avalara.comms.rest.v2.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = avalara.comms.rest.v2.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = avalara.comms.rest.v2.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = calcTaxesRequest;

            // authentication (Basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + avalara.comms.rest.v2.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post< CalcTaxesResponse >("/api/v2/afc/CalcTaxes", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV2AfcCalcTaxesPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Performs tax calculations on all invoices and line items within the request body. 
        /// </summary>
        /// <exception cref="avalara.comms.rest.v2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calcTaxesRequest">CalcTaxesRequest object containing invoices to process and data required               for performing tax calculations. (optional)</param>
        /// <returns>Task of CalcTaxesResponse</returns>
        public async System.Threading.Tasks.Task<CalcTaxesResponse> ApiV2AfcCalcTaxesPostAsync (CalcTaxesRequest calcTaxesRequest = default(CalcTaxesRequest))
        {
             avalara.comms.rest.v2.Client.ApiResponse<CalcTaxesResponse> localVarResponse = await ApiV2AfcCalcTaxesPostAsyncWithHttpInfo(calcTaxesRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Performs tax calculations on all invoices and line items within the request body. 
        /// </summary>
        /// <exception cref="avalara.comms.rest.v2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calcTaxesRequest">CalcTaxesRequest object containing invoices to process and data required               for performing tax calculations. (optional)</param>
        /// <returns>Task of ApiResponse (CalcTaxesResponse)</returns>
        public async System.Threading.Tasks.Task<avalara.comms.rest.v2.Client.ApiResponse<CalcTaxesResponse>> ApiV2AfcCalcTaxesPostAsyncWithHttpInfo (CalcTaxesRequest calcTaxesRequest = default(CalcTaxesRequest))
        {

            avalara.comms.rest.v2.Client.RequestOptions localVarRequestOptions = new avalara.comms.rest.v2.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.Data = calcTaxesRequest;

            // authentication (Basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + avalara.comms.rest.v2.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<CalcTaxesResponse>("/api/v2/afc/CalcTaxes", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV2AfcCalcTaxesPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Commits or un-commits a document code. 
        /// </summary>
        /// <exception cref="avalara.comms.rest.v2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="commitRequest">CommitRequest object containing document code and optional field data to override in reports. (optional)</param>
        /// <returns>CommitResponse</returns>
        public CommitResponse ApiV2AfcCommitPost (CommitRequest commitRequest = default(CommitRequest))
        {
             avalara.comms.rest.v2.Client.ApiResponse<CommitResponse> localVarResponse = ApiV2AfcCommitPostWithHttpInfo(commitRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Commits or un-commits a document code. 
        /// </summary>
        /// <exception cref="avalara.comms.rest.v2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="commitRequest">CommitRequest object containing document code and optional field data to override in reports. (optional)</param>
        /// <returns>ApiResponse of CommitResponse</returns>
        public avalara.comms.rest.v2.Client.ApiResponse< CommitResponse > ApiV2AfcCommitPostWithHttpInfo (CommitRequest commitRequest = default(CommitRequest))
        {
            avalara.comms.rest.v2.Client.RequestOptions localVarRequestOptions = new avalara.comms.rest.v2.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = avalara.comms.rest.v2.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = avalara.comms.rest.v2.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = commitRequest;

            // authentication (Basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + avalara.comms.rest.v2.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post< CommitResponse >("/api/v2/afc/Commit", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV2AfcCommitPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Commits or un-commits a document code. 
        /// </summary>
        /// <exception cref="avalara.comms.rest.v2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="commitRequest">CommitRequest object containing document code and optional field data to override in reports. (optional)</param>
        /// <returns>Task of CommitResponse</returns>
        public async System.Threading.Tasks.Task<CommitResponse> ApiV2AfcCommitPostAsync (CommitRequest commitRequest = default(CommitRequest))
        {
             avalara.comms.rest.v2.Client.ApiResponse<CommitResponse> localVarResponse = await ApiV2AfcCommitPostAsyncWithHttpInfo(commitRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Commits or un-commits a document code. 
        /// </summary>
        /// <exception cref="avalara.comms.rest.v2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="commitRequest">CommitRequest object containing document code and optional field data to override in reports. (optional)</param>
        /// <returns>Task of ApiResponse (CommitResponse)</returns>
        public async System.Threading.Tasks.Task<avalara.comms.rest.v2.Client.ApiResponse<CommitResponse>> ApiV2AfcCommitPostAsyncWithHttpInfo (CommitRequest commitRequest = default(CommitRequest))
        {

            avalara.comms.rest.v2.Client.RequestOptions localVarRequestOptions = new avalara.comms.rest.v2.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.Data = commitRequest;

            // authentication (Basic) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + avalara.comms.rest.v2.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<CommitResponse>("/api/v2/afc/Commit", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiV2AfcCommitPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
