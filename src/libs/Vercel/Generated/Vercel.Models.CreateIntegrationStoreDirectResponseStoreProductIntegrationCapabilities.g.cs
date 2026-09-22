
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
        [global::System.Text.Json.Serialization.JsonPropertyName("billable")]
        public bool? Billable { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        public bool? Checks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectedImportResource")]
        public bool? ConnectedImportResource { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectedProvisioning")]
        public bool? ConnectedProvisioning { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flexCommitEligible")]
        public bool? FlexCommitEligible { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("importResource")]
        public bool? ImportResource { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxAllowedTeams")]
        public double? MaxAllowedTeams { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("nativeImportResource")]
        public bool? NativeImportResource { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provisioning")]
        public bool? Provisioning { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requiresBrowserInstall")]
        public bool? RequiresBrowserInstall { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secretRotation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductIntegrationCapabilitiesSecretRotation, bool?>))]
        public global::Vercel.OneOf<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductIntegrationCapabilitiesSecretRotation, bool?>? SecretRotation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sso")]
        public bool? Sso { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateCloneOnly")]
        public bool? TemplateCloneOnly { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transferable")]
        public bool? Transferable { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateConfiguration")]
        public bool? UpdateConfiguration { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreProductIntegrationCapabilities" /> class.
        /// </summary>
        /// <param name="billable"></param>
        /// <param name="checks"></param>
        /// <param name="connectedImportResource"></param>
        /// <param name="connectedProvisioning"></param>
        /// <param name="flexCommitEligible"></param>
        /// <param name="importResource"></param>
        /// <param name="maxAllowedTeams"></param>
        /// <param name="mcp"></param>
        /// <param name="mcpReadonly"></param>
        /// <param name="nativeImportResource"></param>
        /// <param name="provisioning"></param>
        /// <param name="requiresBrowserInstall"></param>
        /// <param name="secretRotation"></param>
        /// <param name="sso"></param>
        /// <param name="templateCloneOnly"></param>
        /// <param name="transferable"></param>
        /// <param name="updateConfiguration"></param>
        /// <param name="v0Flavors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateIntegrationStoreDirectResponseStoreProductIntegrationCapabilities(
            bool? billable,
            bool? checks,
            bool? connectedImportResource,
            bool? connectedProvisioning,
            bool? flexCommitEligible,
            bool? importResource,
            double? maxAllowedTeams,
            bool? mcp,
            bool? mcpReadonly,
            bool? nativeImportResource,
            bool? provisioning,
            bool? requiresBrowserInstall,
            global::Vercel.OneOf<global::Vercel.CreateIntegrationStoreDirectResponseStoreProductIntegrationCapabilitiesSecretRotation, bool?>? secretRotation,
            bool? sso,
            bool? templateCloneOnly,
            bool? transferable,
            bool? updateConfiguration,
            bool? v0Flavors)
        {
            this.Billable = billable;
            this.Checks = checks;
            this.ConnectedImportResource = connectedImportResource;
            this.ConnectedProvisioning = connectedProvisioning;
            this.FlexCommitEligible = flexCommitEligible;
            this.ImportResource = importResource;
            this.MaxAllowedTeams = maxAllowedTeams;
            this.Mcp = mcp;
            this.McpReadonly = mcpReadonly;
            this.NativeImportResource = nativeImportResource;
            this.Provisioning = provisioning;
            this.RequiresBrowserInstall = requiresBrowserInstall;
            this.SecretRotation = secretRotation;
            this.Sso = sso;
            this.TemplateCloneOnly = templateCloneOnly;
            this.Transferable = transferable;
            this.UpdateConfiguration = updateConfiguration;
            this.V0Flavors = v0Flavors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationStoreDirectResponseStoreProductIntegrationCapabilities" /> class.
        /// </summary>
        public CreateIntegrationStoreDirectResponseStoreProductIntegrationCapabilities()
        {
        }

    }
}