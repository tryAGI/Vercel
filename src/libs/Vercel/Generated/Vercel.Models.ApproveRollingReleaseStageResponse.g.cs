
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The response format for rolling release endpoints that return rolling release information
    /// </summary>
    public sealed partial class ApproveRollingReleaseStageResponse
    {
        /// <summary>
        /// Rolling release information including configuration and document details, or null if no rolling release exists
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rollingRelease")]
        public global::Vercel.ApproveRollingReleaseStageResponseRollingRelease? RollingRelease { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApproveRollingReleaseStageResponse" /> class.
        /// </summary>
        /// <param name="rollingRelease">
        /// Rolling release information including configuration and document details, or null if no rolling release exists
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApproveRollingReleaseStageResponse(
            global::Vercel.ApproveRollingReleaseStageResponseRollingRelease? rollingRelease)
        {
            this.RollingRelease = rollingRelease;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApproveRollingReleaseStageResponse" /> class.
        /// </summary>
        public ApproveRollingReleaseStageResponse()
        {
        }
    }
}