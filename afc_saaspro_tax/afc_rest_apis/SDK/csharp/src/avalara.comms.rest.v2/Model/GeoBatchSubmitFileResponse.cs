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
    /// Response body for Geo Batch Submit File API.
    /// </summary>
    [DataContract]
    public partial class GeoBatchSubmitFileResponse :  IEquatable<GeoBatchSubmitFileResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeoBatchSubmitFileResponse" /> class.
        /// </summary>
        /// <param name="processId">Process Id for File uploaded.</param>
        /// <param name="err">err.</param>
        public GeoBatchSubmitFileResponse(int? processId = default(int?), List<Error> err = default(List<Error>))
        {
            this.ProcessId = processId;
            this.Err = err;
            this.ProcessId = processId;
            this.Err = err;
        }
        
        /// <summary>
        /// Process Id for File uploaded
        /// </summary>
        /// <value>Process Id for File uploaded</value>
        [DataMember(Name="ProcessId", EmitDefaultValue=true)]
        public int? ProcessId { get; set; }

        /// <summary>
        /// Gets or Sets Err
        /// </summary>
        [DataMember(Name="err", EmitDefaultValue=true)]
        public List<Error> Err { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeoBatchSubmitFileResponse {\n");
            sb.Append("  ProcessId: ").Append(ProcessId).Append("\n");
            sb.Append("  Err: ").Append(Err).Append("\n");
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
            return this.Equals(input as GeoBatchSubmitFileResponse);
        }

        /// <summary>
        /// Returns true if GeoBatchSubmitFileResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GeoBatchSubmitFileResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeoBatchSubmitFileResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProcessId == input.ProcessId ||
                    (this.ProcessId != null &&
                    this.ProcessId.Equals(input.ProcessId))
                ) && 
                (
                    this.Err == input.Err ||
                    this.Err != null &&
                    input.Err != null &&
                    this.Err.SequenceEqual(input.Err)
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
                if (this.ProcessId != null)
                    hashCode = hashCode * 59 + this.ProcessId.GetHashCode();
                if (this.Err != null)
                    hashCode = hashCode * 59 + this.Err.GetHashCode();
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
