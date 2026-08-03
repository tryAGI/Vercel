
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Build machine configuration recorded for this deployment's build. See {@link DeploymentBuildMachine}. Distinct from the team/user `resourceConfig.buildMachine`, which only carries `default`.
    /// </summary>
    public sealed partial class CreateDeploymentResponseVariant2ResourceConfigBuildMachine
    {
        /// <summary>
        /// Machine type which was purchased/selected for this build. `basic` is the 2vCPU tier, recorded on the deployment so the build pipeline can detect a basic build without consulting the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purchaseType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentResponseVariant2ResourceConfigBuildMachinePurchaseTypeJsonConverter))]
        public global::Vercel.CreateDeploymentResponseVariant2ResourceConfigBuildMachinePurchaseType? PurchaseType { get; set; }

        /// <summary>
        /// The default plan type for the build machine — what the customer is *paying* for on their plan. For most customers, this is standard, but some customers have an entitlement for enhanced builds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultPurchaseType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentResponseVariant2ResourceConfigBuildMachineDefaultPurchaseTypeJsonConverter))]
        public global::Vercel.CreateDeploymentResponseVariant2ResourceConfigBuildMachineDefaultPurchaseType? DefaultPurchaseType { get; set; }

        /// <summary>
        /// Whether the build ran on a fixed or elastic machine. Used to drive billing for the build.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("machineSelectionType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentResponseVariant2ResourceConfigBuildMachineMachineSelectionTypeJsonConverter))]
        public global::Vercel.CreateDeploymentResponseVariant2ResourceConfigBuildMachineMachineSelectionType? MachineSelectionType { get; set; }

        /// <summary>
        /// Number of cores the build machine ran with. Set at dispatch time once the build lands on a hive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cores")]
        public double? Cores { get; set; }

        /// <summary>
        /// Memory, in MiB, the build machine ran with. Set at dispatch time once the build lands on a hive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        public double? Memory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseVariant2ResourceConfigBuildMachine" /> class.
        /// </summary>
        /// <param name="purchaseType">
        /// Machine type which was purchased/selected for this build. `basic` is the 2vCPU tier, recorded on the deployment so the build pipeline can detect a basic build without consulting the project.
        /// </param>
        /// <param name="defaultPurchaseType">
        /// The default plan type for the build machine — what the customer is *paying* for on their plan. For most customers, this is standard, but some customers have an entitlement for enhanced builds.
        /// </param>
        /// <param name="machineSelectionType">
        /// Whether the build ran on a fixed or elastic machine. Used to drive billing for the build.
        /// </param>
        /// <param name="cores">
        /// Number of cores the build machine ran with. Set at dispatch time once the build lands on a hive.
        /// </param>
        /// <param name="memory">
        /// Memory, in MiB, the build machine ran with. Set at dispatch time once the build lands on a hive.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentResponseVariant2ResourceConfigBuildMachine(
            global::Vercel.CreateDeploymentResponseVariant2ResourceConfigBuildMachinePurchaseType? purchaseType,
            global::Vercel.CreateDeploymentResponseVariant2ResourceConfigBuildMachineDefaultPurchaseType? defaultPurchaseType,
            global::Vercel.CreateDeploymentResponseVariant2ResourceConfigBuildMachineMachineSelectionType? machineSelectionType,
            double? cores,
            double? memory)
        {
            this.PurchaseType = purchaseType;
            this.DefaultPurchaseType = defaultPurchaseType;
            this.MachineSelectionType = machineSelectionType;
            this.Cores = cores;
            this.Memory = memory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseVariant2ResourceConfigBuildMachine" /> class.
        /// </summary>
        public CreateDeploymentResponseVariant2ResourceConfigBuildMachine()
        {
        }

    }
}