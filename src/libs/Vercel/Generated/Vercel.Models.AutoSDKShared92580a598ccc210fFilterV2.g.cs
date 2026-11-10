
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared92580a598ccc210fFilterV2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKShared92580a598ccc210fFilterV2FilterVariant1, global::Vercel.AutoSDKShared92580a598ccc210fFilterV2FilterVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.AutoSDKShared92580a598ccc210fFilterV2FilterVariant1, global::Vercel.AutoSDKShared92580a598ccc210fFilterV2FilterVariant2> Filter { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared92580a598ccc210fFilterV2VersionJsonConverter))]
        public global::Vercel.AutoSDKShared92580a598ccc210fFilterV2Version Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared92580a598ccc210fFilterV2" /> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared92580a598ccc210fFilterV2(
            global::Vercel.OneOf<global::Vercel.AutoSDKShared92580a598ccc210fFilterV2FilterVariant1, global::Vercel.AutoSDKShared92580a598ccc210fFilterV2FilterVariant2> filter,
            global::Vercel.AutoSDKShared92580a598ccc210fFilterV2Version version)
        {
            this.Filter = filter;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared92580a598ccc210fFilterV2" /> class.
        /// </summary>
        public AutoSDKShared92580a598ccc210fFilterV2()
        {
        }

    }
}