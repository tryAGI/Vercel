
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared94938587734e5f57OidcProvider
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKShared94938587734e5f57OidcProviderToVariant1, global::Vercel.AutoSDKShared94938587734e5f57OidcProviderToVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.AutoSDKShared94938587734e5f57OidcProviderToVariant1, global::Vercel.AutoSDKShared94938587734e5f57OidcProviderToVariant2> To { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claims")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>> Claims { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared94938587734e5f57OidcProvider" /> class.
        /// </summary>
        /// <param name="to"></param>
        /// <param name="claims"></param>
        /// <param name="label"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared94938587734e5f57OidcProvider(
            global::Vercel.OneOf<global::Vercel.AutoSDKShared94938587734e5f57OidcProviderToVariant1, global::Vercel.AutoSDKShared94938587734e5f57OidcProviderToVariant2> to,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>> claims,
            string? label)
        {
            this.To = to;
            this.Claims = claims ?? throw new global::System.ArgumentNullException(nameof(claims));
            this.Label = label;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared94938587734e5f57OidcProvider" /> class.
        /// </summary>
        public AutoSDKShared94938587734e5f57OidcProvider()
        {
        }

    }
}