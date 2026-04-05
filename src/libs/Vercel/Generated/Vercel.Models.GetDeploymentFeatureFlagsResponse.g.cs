
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDeploymentFeatureFlagsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Flags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::Vercel.GetDeploymentFeatureFlagsResponseStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentFeatureFlagsResponse" /> class.
        /// </summary>
        /// <param name="flags"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentFeatureFlagsResponse(
            global::System.Collections.Generic.IList<object> flags,
            global::Vercel.GetDeploymentFeatureFlagsResponseStatus? status)
        {
            this.Flags = flags ?? throw new global::System.ArgumentNullException(nameof(flags));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentFeatureFlagsResponse" /> class.
        /// </summary>
        public GetDeploymentFeatureFlagsResponse()
        {
        }
    }
}