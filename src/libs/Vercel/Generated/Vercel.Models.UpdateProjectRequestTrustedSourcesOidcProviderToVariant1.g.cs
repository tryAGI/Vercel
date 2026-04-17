
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProjectRequestTrustedSourcesOidcProviderToVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slugs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Slugs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestTrustedSourcesOidcProviderToVariant1" /> class.
        /// </summary>
        /// <param name="slugs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectRequestTrustedSourcesOidcProviderToVariant1(
            global::System.Collections.Generic.IList<string> slugs)
        {
            this.Slugs = slugs ?? throw new global::System.ArgumentNullException(nameof(slugs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestTrustedSourcesOidcProviderToVariant1" /> class.
        /// </summary>
        public UpdateProjectRequestTrustedSourcesOidcProviderToVariant1()
        {
        }
    }
}