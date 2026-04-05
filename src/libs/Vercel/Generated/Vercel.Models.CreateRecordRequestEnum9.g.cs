
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRecordRequestEnum9
    {
        /// <summary>
        /// A subdomain name.<br/>
        /// Example: subdomain
        /// </summary>
        /// <example>subdomain</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Must be of type `NS`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateRecordRequestEnumType9JsonConverter))]
        public global::Vercel.CreateRecordRequestEnumType9 Type { get; set; }

        /// <summary>
        /// The TTL value. Must be a number between 60 and 2147483647. Default value is 60.<br/>
        /// Example: 60
        /// </summary>
        /// <example>60</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        public double? Ttl { get; set; }

        /// <summary>
        /// An NS domain value.<br/>
        /// Example: ns1.example.com
        /// </summary>
        /// <example>ns1.example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateRecordRequestEnum9" /> class.
        /// </summary>
        /// <param name="name">
        /// A subdomain name.<br/>
        /// Example: subdomain
        /// </param>
        /// <param name="type">
        /// Must be of type `NS`.
        /// </param>
        /// <param name="ttl">
        /// The TTL value. Must be a number between 60 and 2147483647. Default value is 60.<br/>
        /// Example: 60
        /// </param>
        /// <param name="value">
        /// An NS domain value.<br/>
        /// Example: ns1.example.com
        /// </param>
        /// <param name="comment">
        /// A comment to add context on what this DNS record is for<br/>
        /// Example: used to verify ownership of domain
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRecordRequestEnum9(
            string name,
            global::Vercel.CreateRecordRequestEnumType9 type,
            double? ttl,
            string? value,
            string? comment)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Ttl = ttl;
            this.Value = value;
            this.Comment = comment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecordRequestEnum9" /> class.
        /// </summary>
        public CreateRecordRequestEnum9()
        {
        }
    }
}