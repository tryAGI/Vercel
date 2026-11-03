
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedd5d6c9ab94c25f66FilterV2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKSharedd5d6c9ab94c25f66FilterV2FilterVariant1, global::Vercel.AutoSDKSharedd5d6c9ab94c25f66FilterV2FilterVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.AutoSDKSharedd5d6c9ab94c25f66FilterV2FilterVariant1, global::Vercel.AutoSDKSharedd5d6c9ab94c25f66FilterV2FilterVariant2> Filter { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedd5d6c9ab94c25f66FilterV2VersionJsonConverter))]
        public global::Vercel.AutoSDKSharedd5d6c9ab94c25f66FilterV2Version Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedd5d6c9ab94c25f66FilterV2" /> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedd5d6c9ab94c25f66FilterV2(
            global::Vercel.OneOf<global::Vercel.AutoSDKSharedd5d6c9ab94c25f66FilterV2FilterVariant1, global::Vercel.AutoSDKSharedd5d6c9ab94c25f66FilterV2FilterVariant2> filter,
            global::Vercel.AutoSDKSharedd5d6c9ab94c25f66FilterV2Version version)
        {
            this.Filter = filter;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedd5d6c9ab94c25f66FilterV2" /> class.
        /// </summary>
        public AutoSDKSharedd5d6c9ab94c25f66FilterV2()
        {
        }

    }
}