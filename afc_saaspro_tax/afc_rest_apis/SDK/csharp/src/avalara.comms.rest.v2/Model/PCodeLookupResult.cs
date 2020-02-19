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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = avalara.comms.rest.v2.Client.OpenAPIDateConverter;

namespace avalara.comms.rest.v2.Model
{
    /// <summary>
    /// PCodeLookupResult
    /// </summary>
    [DataContract]
    public partial class PCodeLookupResult :  IEquatable<PCodeLookupResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PCodeLookupResult" /> class.
        /// </summary>
        /// <param name="locationData">locationData.</param>
        /// <param name="matchCount">matchCount.</param>
        /// <param name="inputMatchType">inputMatchType.</param>
        /// <param name="matchTypeApplied">matchTypeApplied.</param>
        /// <param name="resultsLimit">resultsLimit.</param>
        public PCodeLookupResult(List<LocationItem> locationData = default(List<LocationItem>), int matchCount = default(int), string inputMatchType = default(string), string matchTypeApplied = default(string), int resultsLimit = default(int))
        {
            this.LocationData = locationData;
            this.InputMatchType = inputMatchType;
            this.MatchTypeApplied = matchTypeApplied;
            this.LocationData = locationData;
            this.MatchCount = matchCount;
            this.InputMatchType = inputMatchType;
            this.MatchTypeApplied = matchTypeApplied;
            this.ResultsLimit = resultsLimit;
        }
        
        /// <summary>
        /// Gets or Sets LocationData
        /// </summary>
        [DataMember(Name="LocationData", EmitDefaultValue=true)]
        public List<LocationItem> LocationData { get; set; }

        /// <summary>
        /// Gets or Sets MatchCount
        /// </summary>
        [DataMember(Name="MatchCount", EmitDefaultValue=false)]
        public int MatchCount { get; set; }

        /// <summary>
        /// Gets or Sets InputMatchType
        /// </summary>
        [DataMember(Name="InputMatchType", EmitDefaultValue=true)]
        public string InputMatchType { get; set; }

        /// <summary>
        /// Gets or Sets MatchTypeApplied
        /// </summary>
        [DataMember(Name="MatchTypeApplied", EmitDefaultValue=true)]
        public string MatchTypeApplied { get; set; }

        /// <summary>
        /// Gets or Sets ResultsLimit
        /// </summary>
        [DataMember(Name="ResultsLimit", EmitDefaultValue=false)]
        public int ResultsLimit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PCodeLookupResult {\n");
            sb.Append("  LocationData: ").Append(LocationData).Append("\n");
            sb.Append("  MatchCount: ").Append(MatchCount).Append("\n");
            sb.Append("  InputMatchType: ").Append(InputMatchType).Append("\n");
            sb.Append("  MatchTypeApplied: ").Append(MatchTypeApplied).Append("\n");
            sb.Append("  ResultsLimit: ").Append(ResultsLimit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PCodeLookupResult);
        }

        /// <summary>
        /// Returns true if PCodeLookupResult instances are equal
        /// </summary>
        /// <param name="input">Instance of PCodeLookupResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PCodeLookupResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LocationData == input.LocationData ||
                    this.LocationData != null &&
                    input.LocationData != null &&
                    this.LocationData.SequenceEqual(input.LocationData)
                ) && 
                (
                    this.MatchCount == input.MatchCount ||
                    (this.MatchCount != null &&
                    this.MatchCount.Equals(input.MatchCount))
                ) && 
                (
                    this.InputMatchType == input.InputMatchType ||
                    (this.InputMatchType != null &&
                    this.InputMatchType.Equals(input.InputMatchType))
                ) && 
                (
                    this.MatchTypeApplied == input.MatchTypeApplied ||
                    (this.MatchTypeApplied != null &&
                    this.MatchTypeApplied.Equals(input.MatchTypeApplied))
                ) && 
                (
                    this.ResultsLimit == input.ResultsLimit ||
                    (this.ResultsLimit != null &&
                    this.ResultsLimit.Equals(input.ResultsLimit))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.LocationData != null)
                    hashCode = hashCode * 59 + this.LocationData.GetHashCode();
                if (this.MatchCount != null)
                    hashCode = hashCode * 59 + this.MatchCount.GetHashCode();
                if (this.InputMatchType != null)
                    hashCode = hashCode * 59 + this.InputMatchType.GetHashCode();
                if (this.MatchTypeApplied != null)
                    hashCode = hashCode * 59 + this.MatchTypeApplied.GetHashCode();
                if (this.ResultsLimit != null)
                    hashCode = hashCode * 59 + this.ResultsLimit.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
