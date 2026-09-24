
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Build machine configuration recorded for this deployment's build. See {@link DeploymentBuildMachine}. Distinct from the team/user `resourceConfig.buildMachine`, which only carries `default`.
    /// </summary>
    public sealed partial class CancelDeploymentResponseResourceConfigBuildMachine
    {
        /// <summary>
        /// Number of cores the build machine ran with. Set at dispatch time once the build lands on a hive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cores")]
        public double? Cores { get; set; }

        /// <summary>
        /// The build machine tier included with the customer's plan. For most customers this is standard; enhanced entitlements include enhanced, while `none` means every build is billed at its purchase type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultPurchaseType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseResourceConfigBuildMachineDefaultPurchaseTypeJsonConverter))]
        public global::Vercel.CancelDeploymentResponseResourceConfigBuildMachineDefaultPurchaseType? DefaultPurchaseType { get; set; }

        /// <summary>
        /// Whether the build ran on a fixed or elastic machine. Used to drive billing for the build.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("machineSelectionType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseResourceConfigBuildMachineMachineSelectionTypeJsonConverter))]
        public global::Vercel.CancelDeploymentResponseResourceConfigBuildMachineMachineSelectionType? MachineSelectionType { get; set; }

        /// <summary>
        /// Memory, in MiB, the build machine ran with. Set at dispatch time once the build lands on a hive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        public double? Memory { get; set; }

        /// <summary>
        /// Machine type which was purchased/selected for this build. `basic` is the 2vCPU tier, recorded on the deployment so the build pipeline can detect a basic build without consulting the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purchaseType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseResourceConfigBuildMachinePurchaseTypeJsonConverter))]
        public global::Vercel.CancelDeploymentResponseResourceConfigBuildMachinePurchaseType? PurchaseType { get; set; }

        /// <summary>
        /// The setting which selected the build machine when the deployment was created. Frozen here so later project or team changes do not rewrite its history.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selectionSource")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseResourceConfigBuildMachineSelectionSourceJsonConverter))]
        public global::Vercel.CancelDeploymentResponseResourceConfigBuildMachineSelectionSource? SelectionSource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseResourceConfigBuildMachine" /> class.
        /// </summary>
        /// <param name="cores">
        /// Number of cores the build machine ran with. Set at dispatch time once the build lands on a hive.
        /// </param>
        /// <param name="defaultPurchaseType">
        /// The build machine tier included with the customer's plan. For most customers this is standard; enhanced entitlements include enhanced, while `none` means every build is billed at its purchase type.
        /// </param>
        /// <param name="machineSelectionType">
        /// Whether the build ran on a fixed or elastic machine. Used to drive billing for the build.
        /// </param>
        /// <param name="memory">
        /// Memory, in MiB, the build machine ran with. Set at dispatch time once the build lands on a hive.
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
        public CancelDeploymentResponseResourceConfigBuildMachine(
            double? cores,
            global::Vercel.CancelDeploymentResponseResourceConfigBuildMachineDefaultPurchaseType? defaultPurchaseType,
            global::Vercel.CancelDeploymentResponseResourceConfigBuildMachineMachineSelectionType? machineSelectionType,
            double? memory,
            global::Vercel.CancelDeploymentResponseResourceConfigBuildMachinePurchaseType? purchaseType,
            global::Vercel.CancelDeploymentResponseResourceConfigBuildMachineSelectionSource? selectionSource)
        {
            this.Cores = cores;
            this.DefaultPurchaseType = defaultPurchaseType;
            this.MachineSelectionType = machineSelectionType;
            this.Memory = memory;
            this.PurchaseType = purchaseType;
            this.SelectionSource = selectionSource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseResourceConfigBuildMachine" /> class.
        /// </summary>
        public CancelDeploymentResponseResourceConfigBuildMachine()
        {
        }

    }
}