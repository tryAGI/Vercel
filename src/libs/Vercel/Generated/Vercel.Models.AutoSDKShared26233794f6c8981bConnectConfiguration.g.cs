
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared26233794f6c8981bConnectConfiguration
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws")]
        public global::Vercel.AutoSDKShared26233794f6c8981bConnectConfigurationAws? Aws { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildsEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool BuildsEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectConfigurationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectConfigurationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dc")]
        public string? Dc { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("envId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.AutoSDKShared26233794f6c8981bConnectConfigurationEnvId?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<string, global::Vercel.AutoSDKShared26233794f6c8981bConnectConfigurationEnvId?> EnvId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passive")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Passive { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared26233794f6c8981bConnectConfiguration" /> class.
        /// </summary>
        /// <param name="buildsEnabled"></param>
        /// <param name="connectConfigurationId"></param>
        /// <param name="createdAt"></param>
        /// <param name="envId"></param>
        /// <param name="passive"></param>
        /// <param name="updatedAt"></param>
        /// <param name="aws"></param>
        /// <param name="dc"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared26233794f6c8981bConnectConfiguration(
            bool buildsEnabled,
            string connectConfigurationId,
            double createdAt,
            global::Vercel.OneOf<string, global::Vercel.AutoSDKShared26233794f6c8981bConnectConfigurationEnvId?> envId,
            bool passive,
            double updatedAt,
            global::Vercel.AutoSDKShared26233794f6c8981bConnectConfigurationAws? aws,
            string? dc)
        {
            this.Aws = aws;
            this.BuildsEnabled = buildsEnabled;
            this.ConnectConfigurationId = connectConfigurationId ?? throw new global::System.ArgumentNullException(nameof(connectConfigurationId));
            this.CreatedAt = createdAt;
            this.Dc = dc;
            this.EnvId = envId;
            this.Passive = passive;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared26233794f6c8981bConnectConfiguration" /> class.
        /// </summary>
        public AutoSDKShared26233794f6c8981bConnectConfiguration()
        {
        }

    }
}