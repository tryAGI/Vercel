
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCheckRequest
    {
        /// <summary>
        /// The name of the check being created<br/>
        /// Example: Performance Check
        /// </summary>
        /// <example>Performance Check</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Path of the page that is being checked<br/>
        /// Example: /
        /// </summary>
        /// <example>/</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Whether the check should block a deployment from succeeding<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocking")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Blocking { get; set; }

        /// <summary>
        /// URL to display for further details<br/>
        /// Example: http://example.com
        /// </summary>
        /// <example>http://example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("detailsUrl")]
        public string? DetailsUrl { get; set; }

        /// <summary>
        /// An identifier that can be used as an external reference<br/>
        /// Example: 1234abc
        /// </summary>
        /// <example>1234abc</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalId")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// Whether a user should be able to request for the check to be rerun if it fails<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rerequestable")]
        public bool? Rerequestable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCheckRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the check being created<br/>
        /// Example: Performance Check
        /// </param>
        /// <param name="blocking">
        /// Whether the check should block a deployment from succeeding<br/>
        /// Example: true
        /// </param>
        /// <param name="path">
        /// Path of the page that is being checked<br/>
        /// Example: /
        /// </param>
        /// <param name="detailsUrl">
        /// URL to display for further details<br/>
        /// Example: http://example.com
        /// </param>
        /// <param name="externalId">
        /// An identifier that can be used as an external reference<br/>
        /// Example: 1234abc
        /// </param>
        /// <param name="rerequestable">
        /// Whether a user should be able to request for the check to be rerun if it fails<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCheckRequest(
            string name,
            bool blocking,
            string? path,
            string? detailsUrl,
            string? externalId,
            bool? rerequestable)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Path = path;
            this.Blocking = blocking;
            this.DetailsUrl = detailsUrl;
            this.ExternalId = externalId;
            this.Rerequestable = rerequestable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCheckRequest" /> class.
        /// </summary>
        public CreateCheckRequest()
        {
        }
    }
}