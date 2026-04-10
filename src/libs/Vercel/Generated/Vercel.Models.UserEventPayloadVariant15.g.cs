
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant15
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Alias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliasId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AliasId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deploymentId")]
        public string? DeploymentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant15" /> class.
        /// </summary>
        /// <param name="alias"></param>
        /// <param name="aliasId"></param>
        /// <param name="name"></param>
        /// <param name="deploymentId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant15(
            string alias,
            string aliasId,
            string? name,
            string? deploymentId)
        {
            this.Name = name;
            this.Alias = alias ?? throw new global::System.ArgumentNullException(nameof(alias));
            this.AliasId = aliasId ?? throw new global::System.ArgumentNullException(nameof(aliasId));
            this.DeploymentId = deploymentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant15" /> class.
        /// </summary>
        public UserEventPayloadVariant15()
        {
        }
    }
}