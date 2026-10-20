
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared3aee88dc9f99cb9bAffinity
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared3aee88dc9f99cb9bAffinityModeJsonConverter))]
        public global::Vercel.AutoSDKShared3aee88dc9f99cb9bAffinityMode Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared3aee88dc9f99cb9bAffinity" /> class.
        /// </summary>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared3aee88dc9f99cb9bAffinity(
            global::Vercel.AutoSDKShared3aee88dc9f99cb9bAffinityMode mode)
        {
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared3aee88dc9f99cb9bAffinity" /> class.
        /// </summary>
        public AutoSDKShared3aee88dc9f99cb9bAffinity()
        {
        }

    }
}