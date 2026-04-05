
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetRollingReleaseConfigResponse
    {
        /// <summary>
        /// Project-level rolling release configuration that defines how deployments should be gradually rolled out
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rollingRelease")]
        public global::Vercel.GetRollingReleaseConfigResponseRollingRelease? RollingRelease { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRollingReleaseConfigResponse" /> class.
        /// </summary>
        /// <param name="rollingRelease">
        /// Project-level rolling release configuration that defines how deployments should be gradually rolled out
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRollingReleaseConfigResponse(
            global::Vercel.GetRollingReleaseConfigResponseRollingRelease? rollingRelease)
        {
            this.RollingRelease = rollingRelease;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRollingReleaseConfigResponse" /> class.
        /// </summary>
        public GetRollingReleaseConfigResponse()
        {
        }
    }
}