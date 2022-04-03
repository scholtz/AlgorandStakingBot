/* 
 * Algod REST API.
 *
 * API Endpoint for AlgoD Operations.
 *
 * OpenAPI spec version: 0.0.1
 * Contact: contact@algorand.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = Algorand.Client.SwaggerDateConverter;

namespace Algorand.Algod.Model
{
    /// <summary>
    /// AssetConfigTransactionType contains the additional fields for an asset config transaction
    /// </summary>
    [DataContract]
        public partial class AssetConfigTransactionType :  IEquatable<AssetConfigTransactionType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetConfigTransactionType" /> class.
        /// </summary>
        /// <param name="id">AssetID is the asset being configured (or empty if creating).</param>
        /// <param name="_params">_params.</param>
        public AssetConfigTransactionType(ulong? id = default(ulong?), AssetParams _params = default(AssetParams))
        {
            this.Id = id;
            this.Params = _params;
        }
        
        /// <summary>
        /// AssetID is the asset being configured (or empty if creating)
        /// </summary>
        /// <value>AssetID is the asset being configured (or empty if creating)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public ulong? Id { get; set; }

        /// <summary>
        /// Gets or Sets Params
        /// </summary>
        [DataMember(Name="params", EmitDefaultValue=false)]
        public AssetParams Params { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetConfigTransactionType {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
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
            return this.Equals(input as AssetConfigTransactionType);
        }

        /// <summary>
        /// Returns true if AssetConfigTransactionType instances are equal
        /// </summary>
        /// <param name="input">Instance of AssetConfigTransactionType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetConfigTransactionType input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Params == input.Params ||
                    (this.Params != null &&
                    this.Params.Equals(input.Params))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Params != null)
                    hashCode = hashCode * 59 + this.Params.GetHashCode();
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
