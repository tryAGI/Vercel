
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Key-value pairs of mount path and volume.
    /// </summary>
    public sealed partial class NamedSandboxMounts2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Volume { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.NamedSandboxMountsModeJsonConverter))]
        public global::Vercel.NamedSandboxMountsMode? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NamedSandboxMounts2" /> class.
        /// </summary>
        /// <param name="volume"></param>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NamedSandboxMounts2(
            string volume,
            global::Vercel.NamedSandboxMountsMode? mode)
        {
            this.Volume = volume ?? throw new global::System.ArgumentNullException(nameof(volume));
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NamedSandboxMounts2" /> class.
        /// </summary>
        public NamedSandboxMounts2()
        {
        }

    }
}