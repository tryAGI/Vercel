
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared5f7d6053e0f466daAffinity
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared5f7d6053e0f466daAffinityModeJsonConverter))]
        public global::Vercel.AutoSDKShared5f7d6053e0f466daAffinityMode Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared5f7d6053e0f466daAffinity" /> class.
        /// </summary>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared5f7d6053e0f466daAffinity(
            global::Vercel.AutoSDKShared5f7d6053e0f466daAffinityMode mode)
        {
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared5f7d6053e0f466daAffinity" /> class.
        /// </summary>
        public AutoSDKShared5f7d6053e0f466daAffinity()
        {
        }

    }
}