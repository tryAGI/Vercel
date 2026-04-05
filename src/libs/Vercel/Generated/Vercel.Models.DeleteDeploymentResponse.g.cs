
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteDeploymentResponse
    {
        /// <summary>
        /// The removed deployment ID.<br/>
        /// Example: dpl_5WJWYSyB7BpgTj3EuwF37WMRBXBtPQ2iTMJHJBJyRfd
        /// </summary>
        /// <example>dpl_5WJWYSyB7BpgTj3EuwF37WMRBXBtPQ2iTMJHJBJyRfd</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uid { get; set; }

        /// <summary>
        /// A constant with the final state of the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.DeleteDeploymentResponseStateJsonConverter))]
        public global::Vercel.DeleteDeploymentResponseState State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDeploymentResponse" /> class.
        /// </summary>
        /// <param name="uid">
        /// The removed deployment ID.<br/>
        /// Example: dpl_5WJWYSyB7BpgTj3EuwF37WMRBXBtPQ2iTMJHJBJyRfd
        /// </param>
        /// <param name="state">
        /// A constant with the final state of the deployment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteDeploymentResponse(
            string uid,
            global::Vercel.DeleteDeploymentResponseState state)
        {
            this.Uid = uid ?? throw new global::System.ArgumentNullException(nameof(uid));
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDeploymentResponse" /> class.
        /// </summary>
        public DeleteDeploymentResponse()
        {
        }
    }
}