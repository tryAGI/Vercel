
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateResourceSecretsRequestSecret
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// A map of environments to override values for the secret, used for setting different values across deployments in production, preview, and development environments. Note: the same value will be used for all deployments in the given environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environmentOverrides")]
        public global::Vercel.UpdateResourceSecretsRequestSecretEnvironmentOverrides? EnvironmentOverrides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResourceSecretsRequestSecret" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="prefix"></param>
        /// <param name="environmentOverrides">
        /// A map of environments to override values for the secret, used for setting different values across deployments in production, preview, and development environments. Note: the same value will be used for all deployments in the given environment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateResourceSecretsRequestSecret(
            string name,
            string value,
            string? prefix,
            global::Vercel.UpdateResourceSecretsRequestSecretEnvironmentOverrides? environmentOverrides)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Prefix = prefix;
            this.EnvironmentOverrides = environmentOverrides;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResourceSecretsRequestSecret" /> class.
        /// </summary>
        public UpdateResourceSecretsRequestSecret()
        {
        }
    }
}