
#nullable enable

namespace Vercel
{
    /// <summary>
    /// If the deployment was created using a Custom Environment, then this property contains information regarding the environment used.
    /// </summary>
    public sealed partial class CancelDeploymentResponseCustomEnvironmentVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseCustomEnvironmentVariant2" /> class.
        /// </summary>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelDeploymentResponseCustomEnvironmentVariant2(
            string id)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseCustomEnvironmentVariant2" /> class.
        /// </summary>
        public CancelDeploymentResponseCustomEnvironmentVariant2()
        {
        }
    }
}