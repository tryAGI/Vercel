
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetDrainResponseVariant1FilterV2FilterVariant1Log
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("legacy_excludeCachedStaticAssetLogs")]
        public bool? LegacyExcludeCachedStaticAssetLogs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::System.Collections.Generic.IList<global::Vercel.GetDrainResponseVariant1FilterV2FilterVariant1LogSource>? Sources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDrainResponseVariant1FilterV2FilterVariant1Log" /> class.
        /// </summary>
        /// <param name="legacyExcludeCachedStaticAssetLogs"></param>
        /// <param name="sources"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDrainResponseVariant1FilterV2FilterVariant1Log(
            bool? legacyExcludeCachedStaticAssetLogs,
            global::System.Collections.Generic.IList<global::Vercel.GetDrainResponseVariant1FilterV2FilterVariant1LogSource>? sources)
        {
            this.LegacyExcludeCachedStaticAssetLogs = legacyExcludeCachedStaticAssetLogs;
            this.Sources = sources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDrainResponseVariant1FilterV2FilterVariant1Log" /> class.
        /// </summary>
        public GetDrainResponseVariant1FilterV2FilterVariant1Log()
        {
        }

    }
}