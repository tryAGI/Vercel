
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRecordRequestEnum10
    {
        /// <summary>
        /// Must be of type `HTTPS`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateRecordRequestEnumType10JsonConverter))]
        public global::Vercel.CreateRecordRequestEnumType10 Type { get; set; }

        /// <summary>
        /// The TTL value. Must be a number between 60 and 2147483647. Default value is 60.<br/>
        /// Example: 60
        /// </summary>
        /// <example>60</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        public double? Ttl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("https")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateRecordRequestEnumHttps Https { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateRecordRequestEnum10" /> class.
        /// </summary>
        /// <param name="https"></param>
        /// <param name="type">
        /// Must be of type `HTTPS`.
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
        public CreateRecordRequestEnum10(
            global::Vercel.CreateRecordRequestEnumHttps https,
            global::Vercel.CreateRecordRequestEnumType10 type,
            double? ttl,
            string? comment)
        {
            this.Type = type;
            this.Ttl = ttl;
            this.Https = https ?? throw new global::System.ArgumentNullException(nameof(https));
            this.Comment = comment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecordRequestEnum10" /> class.
        /// </summary>
        public CreateRecordRequestEnum10()
        {
        }
    }
}