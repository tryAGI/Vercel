
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Native Vercel checks — check definition and check run `source`.
    /// </summary>
    public sealed partial class AutoSDKSharede3c00aaf9d3a15beSourceVariant4
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharede3c00aaf9d3a15beSourceVariant4OriginJsonConverter))]
        public global::Vercel.AutoSDKSharede3c00aaf9d3a15beSourceVariant4Origin? Origin { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subKind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharede3c00aaf9d3a15beSourceVariant4SubKindJsonConverter))]
        public global::Vercel.AutoSDKSharede3c00aaf9d3a15beSourceVariant4SubKind? SubKind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede3c00aaf9d3a15beSourceVariant4" /> class.
        /// </summary>
        /// <param name="origin"></param>
        /// <param name="subKind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharede3c00aaf9d3a15beSourceVariant4(
            global::Vercel.AutoSDKSharede3c00aaf9d3a15beSourceVariant4Origin? origin,
            global::Vercel.AutoSDKSharede3c00aaf9d3a15beSourceVariant4SubKind? subKind)
        {
            this.Origin = origin;
            this.SubKind = subKind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede3c00aaf9d3a15beSourceVariant4" /> class.
        /// </summary>
        public AutoSDKSharede3c00aaf9d3a15beSourceVariant4()
        {
        }

    }
}