
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetMicrofrontendsInGroupResponseProjectTrustedSourcesOidcProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Environments { get; set; }

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
        /// Initializes a new instance of the <see cref="GetMicrofrontendsInGroupResponseProjectTrustedSourcesOidcProvider" /> class.
        /// </summary>
        /// <param name="environments"></param>
        /// <param name="claims"></param>
        /// <param name="label"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMicrofrontendsInGroupResponseProjectTrustedSourcesOidcProvider(
            global::System.Collections.Generic.IList<string> environments,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>> claims,
            string? label)
        {
            this.Label = label;
            this.Environments = environments ?? throw new global::System.ArgumentNullException(nameof(environments));
            this.Claims = claims ?? throw new global::System.ArgumentNullException(nameof(claims));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMicrofrontendsInGroupResponseProjectTrustedSourcesOidcProvider" /> class.
        /// </summary>
        public GetMicrofrontendsInGroupResponseProjectTrustedSourcesOidcProvider()
        {
        }
    }
}