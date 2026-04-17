
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateMicrofrontendsResponseTrustedSourcesOidcProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UpdateMicrofrontendsResponseTrustedSourcesOidcProviderToVariant1, global::Vercel.UpdateMicrofrontendsResponseTrustedSourcesOidcProviderToVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.UpdateMicrofrontendsResponseTrustedSourcesOidcProviderToVariant1, global::Vercel.UpdateMicrofrontendsResponseTrustedSourcesOidcProviderToVariant2> To { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateMicrofrontendsResponseTrustedSourcesOidcProvider" /> class.
        /// </summary>
        /// <param name="to"></param>
        /// <param name="claims"></param>
        /// <param name="label"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateMicrofrontendsResponseTrustedSourcesOidcProvider(
            global::Vercel.OneOf<global::Vercel.UpdateMicrofrontendsResponseTrustedSourcesOidcProviderToVariant1, global::Vercel.UpdateMicrofrontendsResponseTrustedSourcesOidcProviderToVariant2> to,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>> claims,
            string? label)
        {
            this.To = to;
            this.Label = label;
            this.Claims = claims ?? throw new global::System.ArgumentNullException(nameof(claims));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMicrofrontendsResponseTrustedSourcesOidcProvider" /> class.
        /// </summary>
        public UpdateMicrofrontendsResponseTrustedSourcesOidcProvider()
        {
        }
    }
}