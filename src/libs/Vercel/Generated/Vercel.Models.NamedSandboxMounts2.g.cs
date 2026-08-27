
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Key-value pairs of mount path and drive.
    /// </summary>
    public sealed partial class NamedSandboxMounts2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("drive")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Drive { get; set; }

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
        /// <param name="drive"></param>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NamedSandboxMounts2(
            string drive,
            global::Vercel.NamedSandboxMountsMode? mode)
        {
            this.Drive = drive ?? throw new global::System.ArgumentNullException(nameof(drive));
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