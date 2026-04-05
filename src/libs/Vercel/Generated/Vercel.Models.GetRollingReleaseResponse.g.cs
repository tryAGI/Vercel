
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The response format for rolling release endpoints that return rolling release information
    /// </summary>
    public sealed partial class GetRollingReleaseResponse
    {
        /// <summary>
        /// Rolling release information including configuration and document details, or null if no rolling release exists
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rollingRelease")]
        public global::Vercel.GetRollingReleaseResponseRollingRelease? RollingRelease { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRollingReleaseResponse" /> class.
        /// </summary>
        /// <param name="rollingRelease">
        /// Rolling release information including configuration and document details, or null if no rolling release exists
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRollingReleaseResponse(
            global::Vercel.GetRollingReleaseResponseRollingRelease? rollingRelease)
        {
            this.RollingRelease = rollingRelease;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRollingReleaseResponse" /> class.
        /// </summary>
        public GetRollingReleaseResponse()
        {
        }
    }
}