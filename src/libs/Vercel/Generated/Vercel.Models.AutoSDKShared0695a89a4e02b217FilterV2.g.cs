
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared0695a89a4e02b217FilterV2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKShared0695a89a4e02b217FilterV2FilterVariant1, global::Vercel.AutoSDKShared0695a89a4e02b217FilterV2FilterVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.AutoSDKShared0695a89a4e02b217FilterV2FilterVariant1, global::Vercel.AutoSDKShared0695a89a4e02b217FilterV2FilterVariant2> Filter { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared0695a89a4e02b217FilterV2VersionJsonConverter))]
        public global::Vercel.AutoSDKShared0695a89a4e02b217FilterV2Version Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0695a89a4e02b217FilterV2" /> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared0695a89a4e02b217FilterV2(
            global::Vercel.OneOf<global::Vercel.AutoSDKShared0695a89a4e02b217FilterV2FilterVariant1, global::Vercel.AutoSDKShared0695a89a4e02b217FilterV2FilterVariant2> filter,
            global::Vercel.AutoSDKShared0695a89a4e02b217FilterV2Version version)
        {
            this.Filter = filter;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0695a89a4e02b217FilterV2" /> class.
        /// </summary>
        public AutoSDKShared0695a89a4e02b217FilterV2()
        {
        }

    }
}