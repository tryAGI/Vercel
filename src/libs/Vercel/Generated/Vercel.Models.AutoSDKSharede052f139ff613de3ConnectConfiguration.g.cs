
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharede052f139ff613de3ConnectConfiguration
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws")]
        public global::Vercel.AutoSDKSharede052f139ff613de3ConnectConfigurationAws? Aws { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.AutoSDKSharede052f139ff613de3ConnectConfigurationEnvId?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<string, global::Vercel.AutoSDKSharede052f139ff613de3ConnectConfigurationEnvId?> EnvId { get; set; }

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
        /// Initializes a new instance of the <see cref="AutoSDKSharede052f139ff613de3ConnectConfiguration" /> class.
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
        public AutoSDKSharede052f139ff613de3ConnectConfiguration(
            bool buildsEnabled,
            string connectConfigurationId,
            double createdAt,
            global::Vercel.OneOf<string, global::Vercel.AutoSDKSharede052f139ff613de3ConnectConfigurationEnvId?> envId,
            bool passive,
            double updatedAt,
            global::Vercel.AutoSDKSharede052f139ff613de3ConnectConfigurationAws? aws,
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
        /// Initializes a new instance of the <see cref="AutoSDKSharede052f139ff613de3ConnectConfiguration" /> class.
        /// </summary>
        public AutoSDKSharede052f139ff613de3ConnectConfiguration()
        {
        }

    }
}