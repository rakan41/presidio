/*
 * Presidio
 *
 * Context aware, pluggable and customizable PII anonymization service for text and images.
 *
 * The version of the OpenAPI document: 2.0
 * Contact: presidio@microsoft.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Microsoft.Presidio.Client.OpenAPIDateConverter;

namespace Microsoft.Presidio.Model
{
    /// <summary>
    /// Anonymizer
    /// </summary>
    [JsonConverter(typeof(AnonymizerJsonConverter))]
    [DataContract(Name = "Anonymizer")]
    public partial class Anonymizer : AbstractOpenAPISchema, IEquatable<Anonymizer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Anonymizer" /> class
        /// with the <see cref="Encrypt" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Encrypt.</param>
        public Anonymizer(Encrypt actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Anonymizer" /> class
        /// with the <see cref="Hash" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Hash.</param>
        public Anonymizer(Hash actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Anonymizer" /> class
        /// with the <see cref="Mask" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Mask.</param>
        public Anonymizer(Mask actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Anonymizer" /> class
        /// with the <see cref="Redact" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Redact.</param>
        public Anonymizer(Redact actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Anonymizer" /> class
        /// with the <see cref="Replace" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Replace.</param>
        public Anonymizer(Replace actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(Encrypt))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Hash))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Mask))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Redact))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Replace))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: Encrypt, Hash, Mask, Redact, Replace");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `Encrypt`. If the actual instanct is not `Encrypt`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Encrypt</returns>
        public Encrypt GetEncrypt()
        {
            return (Encrypt)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Hash`. If the actual instanct is not `Hash`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Hash</returns>
        public Hash GetHash()
        {
            return (Hash)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Mask`. If the actual instanct is not `Mask`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Mask</returns>
        public Mask GetMask()
        {
            return (Mask)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Redact`. If the actual instanct is not `Redact`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Redact</returns>
        public Redact GetRedact()
        {
            return (Redact)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Replace`. If the actual instanct is not `Replace`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Replace</returns>
        public Replace GetReplace()
        {
            return (Replace)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Anonymizer {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, Anonymizer.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of Anonymizer
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of Anonymizer</returns>
        public static Anonymizer FromJson(string jsonString)
        {
            Anonymizer newAnonymizer = null;

            if (jsonString == null)
            {
                return newAnonymizer;
            }

            try
            {
                newAnonymizer = new Anonymizer(JsonConvert.DeserializeObject<Encrypt>(jsonString, Anonymizer.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newAnonymizer;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(String.Format("Failed to deserialize `{0}` into Encrypt: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newAnonymizer = new Anonymizer(JsonConvert.DeserializeObject<Hash>(jsonString, Anonymizer.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newAnonymizer;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(String.Format("Failed to deserialize `{0}` into Hash: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newAnonymizer = new Anonymizer(JsonConvert.DeserializeObject<Mask>(jsonString, Anonymizer.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newAnonymizer;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(String.Format("Failed to deserialize `{0}` into Mask: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newAnonymizer = new Anonymizer(JsonConvert.DeserializeObject<Redact>(jsonString, Anonymizer.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newAnonymizer;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(String.Format("Failed to deserialize `{0}` into Redact: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newAnonymizer = new Anonymizer(JsonConvert.DeserializeObject<Replace>(jsonString, Anonymizer.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newAnonymizer;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(String.Format("Failed to deserialize `{0}` into Replace: {1}", jsonString, exception.ToString()));
            }

            // no match found, throw an exception
            throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Anonymizer);
        }

        /// <summary>
        /// Returns true if Anonymizer instances are equal
        /// </summary>
        /// <param name="input">Instance of Anonymizer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Anonymizer input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
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

    /// <summary>
    /// Custom JSON converter for Anonymizer
    /// </summary>
    public class AnonymizerJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((String)(typeof(Anonymizer).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return Anonymizer.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}