
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateMicrofrontendsGroupRequest
    {
        /// <summary>
        /// The new name for the existing microfrontends group.<br/>
        /// Example: MFE Group 1
        /// </summary>
        /// <example>MFE Group 1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The new fallback environment for the microfrontends group. Must be \"SAME_ENV\", \"PRODUCTION\", or a valid custom environment slug from the default app.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallbackEnvironment")]
        public string? FallbackEnvironment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMicrofrontendsGroupRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The new name for the existing microfrontends group.<br/>
        /// Example: MFE Group 1
        /// </param>
        /// <param name="fallbackEnvironment">
        /// The new fallback environment for the microfrontends group. Must be \"SAME_ENV\", \"PRODUCTION\", or a valid custom environment slug from the default app.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateMicrofrontendsGroupRequest(
            string? name,
            string? fallbackEnvironment)
        {
            this.Name = name;
            this.FallbackEnvironment = fallbackEnvironment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMicrofrontendsGroupRequest" /> class.
        /// </summary>
        public UpdateMicrofrontendsGroupRequest()
        {
        }
    }
}