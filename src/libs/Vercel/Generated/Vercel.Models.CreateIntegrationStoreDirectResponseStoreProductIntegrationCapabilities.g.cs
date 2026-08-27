
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateIntegrationStoreDirectResponseStoreProductIntegrationCapabilities
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provisioning")]
        public bool? Provisioning { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("templateCloneOnly")]
        public bool? TemplateCloneOnly { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        public bool? Checks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectedProvisioning")]
        public bool? ConnectedProvisioning { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secretRotation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductIntegrationCapabilitiesSecretRotation, bool?>))]
        public global::Vercel.OneOf<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductIntegrationCapabilitiesSecretRotation, bool?>? SecretRotation { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("requiresBrowserInstall")]
        public bool? RequiresBrowserInstall { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("v0Flavors")]
        public bool? V0Flavors { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flexCommitEligible")]
        public bool? FlexCommitEligible { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateConfiguration")]
        public bool? UpdateConfiguration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxAllowedTeams")]
        public double? MaxAllowedTeams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreProductIntegrationCapabilities" /> class.
        /// </summary>
        /// <param name="provisioning"></param>
        /// <param name="mcp"></param>
        /// <param name="mcpReadonly"></param>
        /// <param name="sso"></param>
        /// <param name="billable"></param>
        /// <param name="transferable"></param>
        /// <param name="templateCloneOnly"></param>
        /// <param name="checks"></param>
        /// <param name="connectedProvisioning"></param>
        /// <param name="secretRotation"></param>
        /// <param name="importResource"></param>
        /// <param name="connectedImportResource"></param>
        /// <param name="nativeImportResource"></param>
        /// <param name="requiresBrowserInstall"></param>
        /// <param name="v0Flavors"></param>
        /// <param name="flexCommitEligible"></param>
        /// <param name="updateConfiguration"></param>
        /// <param name="maxAllowedTeams"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateIntegrationStoreDirectResponseStoreProductIntegrationCapabilities(
            bool? provisioning,
            bool? mcp,
            bool? mcpReadonly,
            bool? sso,
            bool? billable,
            bool? transferable,
            bool? templateCloneOnly,
            bool? checks,
            bool? connectedProvisioning,
            global::Vercel.OneOf<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductIntegrationCapabilitiesSecretRotation, bool?>? secretRotation,
            bool? importResource,
            bool? connectedImportResource,
            bool? nativeImportResource,
            bool? requiresBrowserInstall,
            bool? v0Flavors,
            bool? flexCommitEligible,
            bool? updateConfiguration,
            double? maxAllowedTeams)
        {
            this.Provisioning = provisioning;
            this.Mcp = mcp;
            this.McpReadonly = mcpReadonly;
            this.Sso = sso;
            this.Billable = billable;
            this.Transferable = transferable;
            this.TemplateCloneOnly = templateCloneOnly;
            this.Checks = checks;
            this.ConnectedProvisioning = connectedProvisioning;
            this.SecretRotation = secretRotation;
            this.ImportResource = importResource;
            this.ConnectedImportResource = connectedImportResource;
            this.NativeImportResource = nativeImportResource;
            this.RequiresBrowserInstall = requiresBrowserInstall;
            this.V0Flavors = v0Flavors;
            this.FlexCommitEligible = flexCommitEligible;
            this.UpdateConfiguration = updateConfiguration;
            this.MaxAllowedTeams = maxAllowedTeams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreProductIntegrationCapabilities" /> class.
        /// </summary>
        public CreateIntegrationStoreDirectResponseStoreProductIntegrationCapabilities()
        {
        }

    }
}