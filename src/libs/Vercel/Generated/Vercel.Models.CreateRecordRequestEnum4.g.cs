
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRecordRequestEnum4
    {
        /// <summary>
        /// A subdomain name or an empty string for the root domain.<br/>
        /// Example: subdomain
        /// </summary>
        /// <example>subdomain</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Must be of type `CAA`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateRecordRequestEnumType4JsonConverter))]
        public global::Vercel.CreateRecordRequestEnumType4 Type { get; set; }

        /// <summary>
        /// The TTL value. Must be a number between 60 and 2147483647. Default value is 60.<br/>
        /// Example: 60
        /// </summary>
        /// <example>60</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        public double? Ttl { get; set; }

        /// <summary>
        /// A CAA record to specify which Certificate Authorities (CAs) are allowed to issue certificates for the domain.<br/>
        /// Example: 0 issue \"letsencrypt.org\"
        /// </summary>
        /// <example>0 issue \"letsencrypt.org\"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// A comment to add context on what this DNS record is for<br/>
        /// Example: used to verify ownership of domain
        /// </summary>
        /// <example>used to verify ownership of domain</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecordRequestEnum4" /> class.
        /// </summary>
        /// <param name="name">
        /// A subdomain name or an empty string for the root domain.<br/>
        /// Example: subdomain
        /// </param>
        /// <param name="value">
        /// A CAA record to specify which Certificate Authorities (CAs) are allowed to issue certificates for the domain.<br/>
        /// Example: 0 issue \"letsencrypt.org\"
        /// </param>
        /// <param name="type">
        /// Must be of type `CAA`.
        /// </param>
        /// <param name="ttl">
        /// The TTL value. Must be a number between 60 and 2147483647. Default value is 60.<br/>
        /// Example: 60
        /// </param>
        /// <param name="comment">
        /// A comment to add context on what this DNS record is for<br/>
        /// Example: used to verify ownership of domain
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRecordRequestEnum4(
            string name,
            string value,
            global::Vercel.CreateRecordRequestEnumType4 type,
            double? ttl,
            string? comment)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Ttl = ttl;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Comment = comment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecordRequestEnum4" /> class.
        /// </summary>
        public CreateRecordRequestEnum4()
        {
        }
    }
}