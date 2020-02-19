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
    /// Request body for tax calculation API.
    /// </summary>
    [DataContract]
    public partial class CalcTaxesRequest :  IEquatable<CalcTaxesRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalcTaxesRequest" /> class.
        /// </summary>
        /// <param name="cfg">cfg.</param>
        /// <param name="cmpn">cmpn.</param>
        /// <param name="inv">inv.</param>
        /// <param name="ovr">ovr.</param>
        /// <param name="sovr">sovr.</param>
        public CalcTaxesRequest(RequestConfig cfg = default(RequestConfig), CompanyData cmpn = default(CompanyData), List<Invoice> inv = default(List<Invoice>), List<TaxOverride> ovr = default(List<TaxOverride>), List<SafeHarborOverride> sovr = default(List<SafeHarborOverride>))
        {
            this.Cfg = cfg;
            this.Cmpn = cmpn;
            this.Inv = inv;
            this.Ovr = ovr;
            this.Sovr = sovr;
            this.Cfg = cfg;
            this.Cmpn = cmpn;
            this.Inv = inv;
            this.Ovr = ovr;
            this.Sovr = sovr;
        }
        
        /// <summary>
        /// Gets or Sets Cfg
        /// </summary>
        [DataMember(Name="cfg", EmitDefaultValue=true)]
        public RequestConfig Cfg { get; set; }

        /// <summary>
        /// Gets or Sets Cmpn
        /// </summary>
        [DataMember(Name="cmpn", EmitDefaultValue=true)]
        public CompanyData Cmpn { get; set; }

        /// <summary>
        /// Gets or Sets Inv
        /// </summary>
        [DataMember(Name="inv", EmitDefaultValue=true)]
        public List<Invoice> Inv { get; set; }

        /// <summary>
        /// Gets or Sets Ovr
        /// </summary>
        [DataMember(Name="ovr", EmitDefaultValue=true)]
        public List<TaxOverride> Ovr { get; set; }

        /// <summary>
        /// Gets or Sets Sovr
        /// </summary>
        [DataMember(Name="sovr", EmitDefaultValue=true)]
        public List<SafeHarborOverride> Sovr { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CalcTaxesRequest {\n");
            sb.Append("  Cfg: ").Append(Cfg).Append("\n");
            sb.Append("  Cmpn: ").Append(Cmpn).Append("\n");
            sb.Append("  Inv: ").Append(Inv).Append("\n");
            sb.Append("  Ovr: ").Append(Ovr).Append("\n");
            sb.Append("  Sovr: ").Append(Sovr).Append("\n");
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
            return this.Equals(input as CalcTaxesRequest);
        }

        /// <summary>
        /// Returns true if CalcTaxesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CalcTaxesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CalcTaxesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cfg == input.Cfg ||
                    (this.Cfg != null &&
                    this.Cfg.Equals(input.Cfg))
                ) && 
                (
                    this.Cmpn == input.Cmpn ||
                    (this.Cmpn != null &&
                    this.Cmpn.Equals(input.Cmpn))
                ) && 
                (
                    this.Inv == input.Inv ||
                    this.Inv != null &&
                    input.Inv != null &&
                    this.Inv.SequenceEqual(input.Inv)
                ) && 
                (
                    this.Ovr == input.Ovr ||
                    this.Ovr != null &&
                    input.Ovr != null &&
                    this.Ovr.SequenceEqual(input.Ovr)
                ) && 
                (
                    this.Sovr == input.Sovr ||
                    this.Sovr != null &&
                    input.Sovr != null &&
                    this.Sovr.SequenceEqual(input.Sovr)
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
                if (this.Cfg != null)
                    hashCode = hashCode * 59 + this.Cfg.GetHashCode();
                if (this.Cmpn != null)
                    hashCode = hashCode * 59 + this.Cmpn.GetHashCode();
                if (this.Inv != null)
                    hashCode = hashCode * 59 + this.Inv.GetHashCode();
                if (this.Ovr != null)
                    hashCode = hashCode * 59 + this.Ovr.GetHashCode();
                if (this.Sovr != null)
                    hashCode = hashCode * 59 + this.Sovr.GetHashCode();
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
