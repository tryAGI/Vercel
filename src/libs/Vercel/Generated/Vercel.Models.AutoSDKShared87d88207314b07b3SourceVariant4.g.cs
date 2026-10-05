
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Native Vercel checks — check definition and check run `source`.
    /// </summary>
    public sealed partial class AutoSDKShared87d88207314b07b3SourceVariant4
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared87d88207314b07b3SourceVariant4OriginJsonConverter))]
        public global::Vercel.AutoSDKShared87d88207314b07b3SourceVariant4Origin? Origin { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subKind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared87d88207314b07b3SourceVariant4SubKindJsonConverter))]
        public global::Vercel.AutoSDKShared87d88207314b07b3SourceVariant4SubKind? SubKind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared87d88207314b07b3SourceVariant4" /> class.
        /// </summary>
        /// <param name="origin"></param>
        /// <param name="subKind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared87d88207314b07b3SourceVariant4(
            global::Vercel.AutoSDKShared87d88207314b07b3SourceVariant4Origin? origin,
            global::Vercel.AutoSDKShared87d88207314b07b3SourceVariant4SubKind? subKind)
        {
            this.Origin = origin;
            this.SubKind = subKind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared87d88207314b07b3SourceVariant4" /> class.
        /// </summary>
        public AutoSDKShared87d88207314b07b3SourceVariant4()
        {
        }

    }
}