
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDrainResponseVariant1FilterV2Variant2FilterVariant1Log
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::System.Collections.Generic.IList<global::Vercel.GetDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource>? Sources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("legacy_excludeCachedStaticAssetLogs")]
        public bool? LegacyExcludeCachedStaticAssetLogs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDrainResponseVariant1FilterV2Variant2FilterVariant1Log" /> class.
        /// </summary>
        /// <param name="sources"></param>
        /// <param name="legacyExcludeCachedStaticAssetLogs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDrainResponseVariant1FilterV2Variant2FilterVariant1Log(
            global::System.Collections.Generic.IList<global::Vercel.GetDrainResponseVariant1FilterV2Variant2FilterVariant1LogSource>? sources,
            bool? legacyExcludeCachedStaticAssetLogs)
        {
            this.Sources = sources;
            this.LegacyExcludeCachedStaticAssetLogs = legacyExcludeCachedStaticAssetLogs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDrainResponseVariant1FilterV2Variant2FilterVariant1Log" /> class.
        /// </summary>
        public GetDrainResponseVariant1FilterV2Variant2FilterVariant1Log()
        {
        }
    }
}