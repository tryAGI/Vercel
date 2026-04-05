
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateCheckRequest
    {
        /// <summary>
        /// The name of the check being created<br/>
        /// Example: Performance Check
        /// </summary>
        /// <example>Performance Check</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Path of the page that is being checked<br/>
        /// Example: /
        /// </summary>
        /// <example>/</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// The current status of the check
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateCheckRequestStatusJsonConverter))]
        public global::Vercel.UpdateCheckRequestStatus? Status { get; set; }

        /// <summary>
        /// The result of the check being run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conclusion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateCheckRequestConclusionJsonConverter))]
        public global::Vercel.UpdateCheckRequestConclusion? Conclusion { get; set; }

        /// <summary>
        /// A URL a user may visit to see more information about the check<br/>
        /// Example: https://example.com/check/run/1234abc
        /// </summary>
        /// <example>https://example.com/check/run/1234abc</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("detailsUrl")]
        public string? DetailsUrl { get; set; }

        /// <summary>
        /// The results of the check Run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::Vercel.UpdateCheckRequestOutput? Output { get; set; }

        /// <summary>
        /// An identifier that can be used as an external reference<br/>
        /// Example: 1234abc
        /// </summary>
        /// <example>1234abc</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalId")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCheckRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the check being created<br/>
        /// Example: Performance Check
        /// </param>
        /// <param name="path">
        /// Path of the page that is being checked<br/>
        /// Example: /
        /// </param>
        /// <param name="status">
        /// The current status of the check
        /// </param>
        /// <param name="conclusion">
        /// The result of the check being run
        /// </param>
        /// <param name="detailsUrl">
        /// A URL a user may visit to see more information about the check<br/>
        /// Example: https://example.com/check/run/1234abc
        /// </param>
        /// <param name="output">
        /// The results of the check Run
        /// </param>
        /// <param name="externalId">
        /// An identifier that can be used as an external reference<br/>
        /// Example: 1234abc
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCheckRequest(
            string? name,
            string? path,
            global::Vercel.UpdateCheckRequestStatus? status,
            global::Vercel.UpdateCheckRequestConclusion? conclusion,
            string? detailsUrl,
            global::Vercel.UpdateCheckRequestOutput? output,
            string? externalId)
        {
            this.Name = name;
            this.Path = path;
            this.Status = status;
            this.Conclusion = conclusion;
            this.DetailsUrl = detailsUrl;
            this.Output = output;
            this.ExternalId = externalId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCheckRequest" /> class.
        /// </summary>
        public UpdateCheckRequest()
        {
        }
    }
}