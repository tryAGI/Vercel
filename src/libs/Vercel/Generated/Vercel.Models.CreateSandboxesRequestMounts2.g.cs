
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSandboxesRequestMounts2
    {
        /// <summary>
        /// Name of the drive to mount. The drive must already exist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("drive")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Drive { get; set; }

        /// <summary>
        /// Mount the drive read-only or read-write.<br/>
        /// Default Value: read-write
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateSandboxesRequestMountsModeJsonConverter))]
        public global::Vercel.CreateSandboxesRequestMountsMode? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxesRequestMounts2" /> class.
        /// </summary>
        /// <param name="drive">
        /// Name of the drive to mount. The drive must already exist.
        /// </param>
        /// <param name="mode">
        /// Mount the drive read-only or read-write.<br/>
        /// Default Value: read-write
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSandboxesRequestMounts2(
            string drive,
            global::Vercel.CreateSandboxesRequestMountsMode? mode)
        {
            this.Drive = drive ?? throw new global::System.ArgumentNullException(nameof(drive));
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxesRequestMounts2" /> class.
        /// </summary>
        public CreateSandboxesRequestMounts2()
        {
        }

    }
}