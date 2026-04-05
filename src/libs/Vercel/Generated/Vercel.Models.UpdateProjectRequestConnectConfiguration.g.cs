
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProjectRequestConnectConfiguration
    {
        /// <summary>
        /// The ID of the environment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("envId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnvId { get; set; }

        /// <summary>
        /// The ID of the Secure Compute network
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectConfigurationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectConfigurationId { get; set; }

        /// <summary>
        /// Whether the configuration should be passive, meaning builds will not run there and only passive Serverless Functions will be deployed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passive")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Passive { get; set; }

        /// <summary>
        /// Flag saying if project builds should use Secure Compute
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildsEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool BuildsEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestConnectConfiguration" /> class.
        /// </summary>
        /// <param name="envId">
        /// The ID of the environment
        /// </param>
        /// <param name="connectConfigurationId">
        /// The ID of the Secure Compute network
        /// </param>
        /// <param name="passive">
        /// Whether the configuration should be passive, meaning builds will not run there and only passive Serverless Functions will be deployed
        /// </param>
        /// <param name="buildsEnabled">
        /// Flag saying if project builds should use Secure Compute
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectRequestConnectConfiguration(
            string envId,
            string connectConfigurationId,
            bool passive,
            bool buildsEnabled)
        {
            this.EnvId = envId ?? throw new global::System.ArgumentNullException(nameof(envId));
            this.ConnectConfigurationId = connectConfigurationId ?? throw new global::System.ArgumentNullException(nameof(connectConfigurationId));
            this.Passive = passive;
            this.BuildsEnabled = buildsEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequestConnectConfiguration" /> class.
        /// </summary>
        public UpdateProjectRequestConnectConfiguration()
        {
        }
    }
}