
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDeploymentCheckRunRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CheckId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentCheckRunRequest" /> class.
        /// </summary>
        /// <param name="checkId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentCheckRunRequest(
            string checkId)
        {
            this.CheckId = checkId ?? throw new global::System.ArgumentNullException(nameof(checkId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentCheckRunRequest" /> class.
        /// </summary>
        public CreateDeploymentCheckRunRequest()
        {
        }
    }
}