
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShareda861c3cb40ec56dcFilterV2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1, global::Vercel.AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1, global::Vercel.AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant2> Filter { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShareda861c3cb40ec56dcFilterV2VersionJsonConverter))]
        public global::Vercel.AutoSDKShareda861c3cb40ec56dcFilterV2Version Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareda861c3cb40ec56dcFilterV2" /> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShareda861c3cb40ec56dcFilterV2(
            global::Vercel.OneOf<global::Vercel.AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant1, global::Vercel.AutoSDKShareda861c3cb40ec56dcFilterV2FilterVariant2> filter,
            global::Vercel.AutoSDKShareda861c3cb40ec56dcFilterV2Version version)
        {
            this.Filter = filter;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareda861c3cb40ec56dcFilterV2" /> class.
        /// </summary>
        public AutoSDKShareda861c3cb40ec56dcFilterV2()
        {
        }

    }
}