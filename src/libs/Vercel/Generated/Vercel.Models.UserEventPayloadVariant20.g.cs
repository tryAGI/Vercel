
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant20
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Alias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant20" /> class.
        /// </summary>
        /// <param name="alias"></param>
        /// <param name="deploymentUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant20(
            string alias,
            string deploymentUrl)
        {
            this.Alias = alias ?? throw new global::System.ArgumentNullException(nameof(alias));
            this.DeploymentUrl = deploymentUrl ?? throw new global::System.ArgumentNullException(nameof(deploymentUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant20" /> class.
        /// </summary>
        public UserEventPayloadVariant20()
        {
        }
    }
}