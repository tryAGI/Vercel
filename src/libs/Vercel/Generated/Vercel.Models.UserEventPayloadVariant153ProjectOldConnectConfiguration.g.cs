
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant153ProjectOldConnectConfiguration
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("envId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.UserEventPayloadVariant153ProjectOldConnectConfigurationEnvId?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<string, global::Vercel.UserEventPayloadVariant153ProjectOldConnectConfigurationEnvId?> EnvId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectConfigurationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectConfigurationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dc")]
        public string? Dc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passive")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Passive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildsEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool BuildsEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws")]
        public global::Vercel.UserEventPayloadVariant153ProjectOldConnectConfigurationAws? Aws { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

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
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant153ProjectOldConnectConfiguration" /> class.
        /// </summary>
        /// <param name="envId"></param>
        /// <param name="connectConfigurationId"></param>
        /// <param name="passive"></param>
        /// <param name="buildsEnabled"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="dc"></param>
        /// <param name="aws"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant153ProjectOldConnectConfiguration(
            global::Vercel.OneOf<string, global::Vercel.UserEventPayloadVariant153ProjectOldConnectConfigurationEnvId?> envId,
            string connectConfigurationId,
            bool passive,
            bool buildsEnabled,
            double createdAt,
            double updatedAt,
            string? dc,
            global::Vercel.UserEventPayloadVariant153ProjectOldConnectConfigurationAws? aws)
        {
            this.EnvId = envId;
            this.ConnectConfigurationId = connectConfigurationId ?? throw new global::System.ArgumentNullException(nameof(connectConfigurationId));
            this.Dc = dc;
            this.Passive = passive;
            this.BuildsEnabled = buildsEnabled;
            this.Aws = aws;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant153ProjectOldConnectConfiguration" /> class.
        /// </summary>
        public UserEventPayloadVariant153ProjectOldConnectConfiguration()
        {
        }
    }
}