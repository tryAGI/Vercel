
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteRollingReleaseConfigResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rollingRelease")]
        public object? RollingRelease { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRollingReleaseConfigResponse" /> class.
        /// </summary>
        /// <param name="rollingRelease"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteRollingReleaseConfigResponse(
            object? rollingRelease)
        {
            this.RollingRelease = rollingRelease;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRollingReleaseConfigResponse" /> class.
        /// </summary>
        public DeleteRollingReleaseConfigResponse()
        {
        }
    }
}