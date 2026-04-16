
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateIntegrationStoreDirectResponseStoreProductCapabilities
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductCapabilitiesSecretRotation, bool?>))]
        public global::Vercel.OneOf<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductCapabilitiesSecretRotation, bool?>? SecretRotation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandbox")]
        public bool? Sandbox { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linking")]
        public bool? Linking { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("importResource")]
        public bool? ImportResource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectedImportResource")]
        public bool? ConnectedImportResource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nativeImportResource")]
        public bool? NativeImportResource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("databaseUI")]
        public bool? DatabaseUI { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("v0Flavors")]
        public bool? V0Flavors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreProductCapabilities" /> class.
        /// </summary>
        /// <param name="mcp"></param>
        /// <param name="mcpReadonly"></param>
        /// <param name="sso"></param>
        /// <param name="billable"></param>
        /// <param name="transferable"></param>
        /// <param name="secretsSync"></param>
        /// <param name="secretRotation"></param>
        /// <param name="sandbox"></param>
        /// <param name="linking"></param>
        /// <param name="projects"></param>
        /// <param name="v0"></param>
        /// <param name="importResource"></param>
        /// <param name="connectedImportResource"></param>
        /// <param name="nativeImportResource"></param>
        /// <param name="databaseUI"></param>
        /// <param name="v0Flavors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateIntegrationStoreDirectResponseStoreProductCapabilities(
            bool? mcp,
            bool? mcpReadonly,
            bool? sso,
            bool? billable,
            bool? transferable,
            bool? secretsSync,
            global::Vercel.OneOf<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductCapabilitiesSecretRotation, bool?>? secretRotation,
            bool? sandbox,
            bool? linking,
            bool? projects,
            bool? v0,
            bool? importResource,
            bool? connectedImportResource,
            bool? nativeImportResource,
            bool? databaseUI,
            bool? v0Flavors)
        {
            this.Mcp = mcp;
            this.McpReadonly = mcpReadonly;
            this.Sso = sso;
            this.Billable = billable;
            this.Transferable = transferable;
            this.SecretsSync = secretsSync;
            this.SecretRotation = secretRotation;
            this.Sandbox = sandbox;
            this.Linking = linking;
            this.Projects = projects;
            this.V0 = v0;
            this.ImportResource = importResource;
            this.ConnectedImportResource = connectedImportResource;
            this.NativeImportResource = nativeImportResource;
            this.DatabaseUI = databaseUI;
            this.V0Flavors = v0Flavors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreProductCapabilities" /> class.
        /// </summary>
        public CreateIntegrationStoreDirectResponseStoreProductCapabilities()
        {
        }
    }
}