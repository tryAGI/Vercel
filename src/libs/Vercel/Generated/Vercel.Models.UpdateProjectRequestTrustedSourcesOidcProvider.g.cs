
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProjectRequestTrustedSourcesOidcProvider
    {
        /// <summary>
        /// The label or description of the trusted source
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// A set of environments, either as explicit slugs or a named preset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UpdateProjectRequestTrustedSourcesOidcProviderToVariant1, global::Vercel.UpdateProjectRequestTrustedSourcesOidcProviderToVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.UpdateProjectRequestTrustedSourcesOidcProviderToVariant1, global::Vercel.UpdateProjectRequestTrustedSourcesOidcProviderToVariant2> To { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claims")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>> Claims { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestTrustedSourcesOidcProvider" /> class.
        /// </summary>
        /// <param name="to">
        /// A set of environments, either as explicit slugs or a named preset
        /// </param>
        /// <param name="claims"></param>
        /// <param name="label">
        /// The label or description of the trusted source
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectRequestTrustedSourcesOidcProvider(
            global::Vercel.OneOf<global::Vercel.UpdateProjectRequestTrustedSourcesOidcProviderToVariant1, global::Vercel.UpdateProjectRequestTrustedSourcesOidcProviderToVariant2> to,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>> claims,
            string? label)
        {
            this.Label = label;
            this.To = to;
            this.Claims = claims ?? throw new global::System.ArgumentNullException(nameof(claims));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestTrustedSourcesOidcProvider" /> class.
        /// </summary>
        public UpdateProjectRequestTrustedSourcesOidcProvider()
        {
        }
    }
}