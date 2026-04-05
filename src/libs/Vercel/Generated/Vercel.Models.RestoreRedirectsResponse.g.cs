
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RestoreRedirectsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.RestoreRedirectsResponseVersion Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restored")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Restored { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failedToRestore")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> FailedToRestore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreRedirectsResponse" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="restored"></param>
        /// <param name="failedToRestore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RestoreRedirectsResponse(
            global::Vercel.RestoreRedirectsResponseVersion version,
            global::System.Collections.Generic.IList<string> restored,
            global::System.Collections.Generic.IList<string> failedToRestore)
        {
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Restored = restored ?? throw new global::System.ArgumentNullException(nameof(restored));
            this.FailedToRestore = failedToRestore ?? throw new global::System.ArgumentNullException(nameof(failedToRestore));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreRedirectsResponse" /> class.
        /// </summary>
        public RestoreRedirectsResponse()
        {
        }
    }
}