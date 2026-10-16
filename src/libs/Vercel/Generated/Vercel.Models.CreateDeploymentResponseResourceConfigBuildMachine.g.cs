
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Build machine configuration recorded for this deployment's build. See {@link DeploymentBuildMachine}. Distinct from the team/user `resourceConfig.buildMachine`, which only carries `default`.
    /// </summary>
    public sealed partial class CreateDeploymentResponseResourceConfigBuildMachine
    {
        /// <summary>
        /// Build cores. Deployment creation sets the requested value; dispatch replaces it with the cores assigned by routing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cores")]
        public double? Cores { get; set; }

        /// <summary>
        /// The build machine tier included with the customer's plan. For most customers this is standard; enhanced entitlements include enhanced, while `none` means every build is billed at its purchase type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultPurchaseType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentResponseResourceConfigBuildMachineDefaultPurchaseTypeJsonConverter))]
        public global::Vercel.CreateDeploymentResponseResourceConfigBuildMachineDefaultPurchaseType? DefaultPurchaseType { get; set; }

        /// <summary>
        /// Whether the build ran on a fixed or elastic machine. Used to drive billing for the build.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("machineSelectionType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentResponseResourceConfigBuildMachineMachineSelectionTypeJsonConverter))]
        public global::Vercel.CreateDeploymentResponseResourceConfigBuildMachineMachineSelectionType? MachineSelectionType { get; set; }

        /// <summary>
        /// Build memory, in MiB. Deployment creation sets the requested value; dispatch replaces it with the memory assigned by routing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        public double? Memory { get; set; }

        /// <summary>
        /// Machine type which was purchased/selected for this build. `basic` is the 2vCPU tier, recorded on the deployment so the build pipeline can detect a basic build without consulting the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purchaseType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentResponseResourceConfigBuildMachinePurchaseTypeJsonConverter))]
        public global::Vercel.CreateDeploymentResponseResourceConfigBuildMachinePurchaseType? PurchaseType { get; set; }

        /// <summary>
        /// The setting which selected the build machine when the deployment was created. Frozen here so later project or team changes do not rewrite its history.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selectionSource")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentResponseResourceConfigBuildMachineSelectionSourceJsonConverter))]
        public global::Vercel.CreateDeploymentResponseResourceConfigBuildMachineSelectionSource? SelectionSource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseResourceConfigBuildMachine" /> class.
        /// </summary>
        /// <param name="cores">
        /// Build cores. Deployment creation sets the requested value; dispatch replaces it with the cores assigned by routing.
        /// </param>
        /// <param name="defaultPurchaseType">
        /// The build machine tier included with the customer's plan. For most customers this is standard; enhanced entitlements include enhanced, while `none` means every build is billed at its purchase type.
        /// </param>
        /// <param name="machineSelectionType">
        /// Whether the build ran on a fixed or elastic machine. Used to drive billing for the build.
        /// </param>
        /// <param name="memory">
        /// Build memory, in MiB. Deployment creation sets the requested value; dispatch replaces it with the memory assigned by routing.
        /// </param>
        /// <param name="purchaseType">
        /// Machine type which was purchased/selected for this build. `basic` is the 2vCPU tier, recorded on the deployment so the build pipeline can detect a basic build without consulting the project.
        /// </param>
        /// <param name="selectionSource">
        /// The setting which selected the build machine when the deployment was created. Frozen here so later project or team changes do not rewrite its history.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentResponseResourceConfigBuildMachine(
            double? cores,
            global::Vercel.CreateDeploymentResponseResourceConfigBuildMachineDefaultPurchaseType? defaultPurchaseType,
            global::Vercel.CreateDeploymentResponseResourceConfigBuildMachineMachineSelectionType? machineSelectionType,
            double? memory,
            global::Vercel.CreateDeploymentResponseResourceConfigBuildMachinePurchaseType? purchaseType,
            global::Vercel.CreateDeploymentResponseResourceConfigBuildMachineSelectionSource? selectionSource)
        {
            this.Cores = cores;
            this.DefaultPurchaseType = defaultPurchaseType;
            this.MachineSelectionType = machineSelectionType;
            this.Memory = memory;
            this.PurchaseType = purchaseType;
            this.SelectionSource = selectionSource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseResourceConfigBuildMachine" /> class.
        /// </summary>
        public CreateDeploymentResponseResourceConfigBuildMachine()
        {
        }

    }
}