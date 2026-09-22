
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared9c06dfe8dd59ad6dFilterV2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKShared9c06dfe8dd59ad6dFilterV2FilterVariant1, global::Vercel.AutoSDKShared9c06dfe8dd59ad6dFilterV2FilterVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.AutoSDKShared9c06dfe8dd59ad6dFilterV2FilterVariant1, global::Vercel.AutoSDKShared9c06dfe8dd59ad6dFilterV2FilterVariant2> Filter { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared9c06dfe8dd59ad6dFilterV2VersionJsonConverter))]
        public global::Vercel.AutoSDKShared9c06dfe8dd59ad6dFilterV2Version Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared9c06dfe8dd59ad6dFilterV2" /> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared9c06dfe8dd59ad6dFilterV2(
            global::Vercel.OneOf<global::Vercel.AutoSDKShared9c06dfe8dd59ad6dFilterV2FilterVariant1, global::Vercel.AutoSDKShared9c06dfe8dd59ad6dFilterV2FilterVariant2> filter,
            global::Vercel.AutoSDKShared9c06dfe8dd59ad6dFilterV2Version version)
        {
            this.Filter = filter;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared9c06dfe8dd59ad6dFilterV2" /> class.
        /// </summary>
        public AutoSDKShared9c06dfe8dd59ad6dFilterV2()
        {
        }

    }
}