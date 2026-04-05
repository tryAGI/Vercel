
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateRecordRequest
    {
        /// <summary>
        /// The name of the DNS record<br/>
        /// Example: example-1
        /// </summary>
        /// <example>example-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The value of the DNS record<br/>
        /// Example: google.com
        /// </summary>
        /// <example>google.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// The type of the DNS record<br/>
        /// Example: A
        /// </summary>
        /// <example>A</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateRecordRequestTypeJsonConverter))]
        public global::Vercel.UpdateRecordRequestType? Type { get; set; }

        /// <summary>
        /// The Time to live (TTL) value of the DNS record<br/>
        /// Example: 60
        /// </summary>
        /// <example>60</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        public int? Ttl { get; set; }

        /// <summary>
        /// The MX priority value of the DNS record
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mxPriority")]
        public int? MxPriority { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("srv")]
        public global::Vercel.UpdateRecordRequestSrv? Srv { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("https")]
        public global::Vercel.UpdateRecordRequestHttps? Https { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateRecordRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the DNS record<br/>
        /// Example: example-1
        /// </param>
        /// <param name="value">
        /// The value of the DNS record<br/>
        /// Example: google.com
        /// </param>
        /// <param name="type">
        /// The type of the DNS record<br/>
        /// Example: A
        /// </param>
        /// <param name="ttl">
        /// The Time to live (TTL) value of the DNS record<br/>
        /// Example: 60
        /// </param>
        /// <param name="mxPriority">
        /// The MX priority value of the DNS record
        /// </param>
        /// <param name="srv"></param>
        /// <param name="https"></param>
        /// <param name="comment">
        /// A comment to add context on what this DNS record is for<br/>
        /// Example: used to verify ownership of domain
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRecordRequest(
            string? name,
            string? value,
            global::Vercel.UpdateRecordRequestType? type,
            int? ttl,
            int? mxPriority,
            global::Vercel.UpdateRecordRequestSrv? srv,
            global::Vercel.UpdateRecordRequestHttps? https,
            string? comment)
        {
            this.Name = name;
            this.Value = value;
            this.Type = type;
            this.Ttl = ttl;
            this.MxPriority = mxPriority;
            this.Srv = srv;
            this.Https = https;
            this.Comment = comment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRecordRequest" /> class.
        /// </summary>
        public UpdateRecordRequest()
        {
        }
    }
}