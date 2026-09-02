
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Slack workspace metadata.
    /// </summary>
    public sealed partial class ConnectConnectorUpdateDataTypeSlackSlackTeam
    {
        /// <summary>
        /// Slack workspace ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Slack workspace name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Slack workspace domain.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateDataTypeSlackSlackTeam" /> class.
        /// </summary>
        /// <param name="id">
        /// Slack workspace ID.
        /// </param>
        /// <param name="name">
        /// Slack workspace name.
        /// </param>
        /// <param name="domain">
        /// Slack workspace domain.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectConnectorUpdateDataTypeSlackSlackTeam(
            string id,
            string? name,
            string? domain)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.Domain = domain;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConnectorUpdateDataTypeSlackSlackTeam" /> class.
        /// </summary>
        public ConnectConnectorUpdateDataTypeSlackSlackTeam()
        {
        }

    }
}