
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateIntegrationStoreDirectResponseStoreCapabilities
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp")]
        public bool? Mcp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcpReadonly")]
        public bool? McpReadonly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sso")]
        public bool? Sso { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billable")]
        public bool? Billable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transferable")]
        public bool? Transferable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secretsSync")]
        public bool? SecretsSync { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secretRotation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateIntegrationStoreDirectResponseStoreCapabilitiesSecretRotation, bool?>))]
        public global::Vercel.OneOf<global::Vercel.CreateIntegrationStoreDirectResponseStoreCapabilitiesSecretRotation, bool?>? SecretRotation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        public bool? Projects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("v0")]
        public bool? V0 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreCapabilities" /> class.
        /// </summary>
        /// <param name="mcp"></param>
        /// <param name="mcpReadonly"></param>
        /// <param name="sso"></param>
        /// <param name="billable"></param>
        /// <param name="transferable"></param>
        /// <param name="secretsSync"></param>
        /// <param name="secretRotation"></param>
        /// <param name="projects"></param>
        /// <param name="v0"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateIntegrationStoreDirectResponseStoreCapabilities(
            bool? mcp,
            bool? mcpReadonly,
            bool? sso,
            bool? billable,
            bool? transferable,
            bool? secretsSync,
            global::Vercel.OneOf<global::Vercel.CreateIntegrationStoreDirectResponseStoreCapabilitiesSecretRotation, bool?>? secretRotation,
            bool? projects,
            bool? v0)
        {
            this.Mcp = mcp;
            this.McpReadonly = mcpReadonly;
            this.Sso = sso;
            this.Billable = billable;
            this.Transferable = transferable;
            this.SecretsSync = secretsSync;
            this.SecretRotation = secretRotation;
            this.Projects = projects;
            this.V0 = v0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreCapabilities" /> class.
        /// </summary>
        public CreateIntegrationStoreDirectResponseStoreCapabilities()
        {
        }
    }
}