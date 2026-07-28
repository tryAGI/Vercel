
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadProjectAvatarResponseSandbox
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UploadProjectAvatarResponseSandboxRegionJsonConverter))]
        public global::Vercel.UploadProjectAvatarResponseSandboxRegion? Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failoverRegions")]
        public global::System.Collections.Generic.IList<global::Vercel.UploadProjectAvatarResponseSandboxFailoverRegion>? FailoverRegions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadProjectAvatarResponseSandbox" /> class.
        /// </summary>
        /// <param name="region"></param>
        /// <param name="failoverRegions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadProjectAvatarResponseSandbox(
            global::Vercel.UploadProjectAvatarResponseSandboxRegion? region,
            global::System.Collections.Generic.IList<global::Vercel.UploadProjectAvatarResponseSandboxFailoverRegion>? failoverRegions)
        {
            this.Region = region;
            this.FailoverRegions = failoverRegions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadProjectAvatarResponseSandbox" /> class.
        /// </summary>
        public UploadProjectAvatarResponseSandbox()
        {
        }

    }
}