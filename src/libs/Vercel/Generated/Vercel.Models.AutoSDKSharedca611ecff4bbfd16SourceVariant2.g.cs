
#nullable enable

namespace Vercel
{
    /// <summary>
    /// CI sentinel — check run `source` only (no parent check).
    /// </summary>
    public sealed partial class AutoSDKSharedca611ecff4bbfd16SourceVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedca611ecff4bbfd16SourceVariant2OriginJsonConverter))]
        public global::Vercel.AutoSDKSharedca611ecff4bbfd16SourceVariant2Origin Origin { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subKind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedca611ecff4bbfd16SourceVariant2SubKindJsonConverter))]
        public global::Vercel.AutoSDKSharedca611ecff4bbfd16SourceVariant2SubKind SubKind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedca611ecff4bbfd16SourceVariant2" /> class.
        /// </summary>
        /// <param name="origin"></param>
        /// <param name="subKind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedca611ecff4bbfd16SourceVariant2(
            global::Vercel.AutoSDKSharedca611ecff4bbfd16SourceVariant2Origin origin,
            global::Vercel.AutoSDKSharedca611ecff4bbfd16SourceVariant2SubKind subKind)
        {
            this.Origin = origin;
            this.SubKind = subKind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedca611ecff4bbfd16SourceVariant2" /> class.
        /// </summary>
        public AutoSDKSharedca611ecff4bbfd16SourceVariant2()
        {
        }

    }
}