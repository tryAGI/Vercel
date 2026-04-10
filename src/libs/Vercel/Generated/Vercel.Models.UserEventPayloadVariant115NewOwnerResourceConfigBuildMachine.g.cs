
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant115NewOwnerResourceConfigBuildMachine
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineDefaultJsonConverter))]
        public global::Vercel.UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineDefault? Default { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purchaseType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant115NewOwnerResourceConfigBuildMachinePurchaseTypeJsonConverter))]
        public global::Vercel.UserEventPayloadVariant115NewOwnerResourceConfigBuildMachinePurchaseType? PurchaseType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultPurchaseType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineDefaultPurchaseTypeJsonConverter))]
        public global::Vercel.UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineDefaultPurchaseType? DefaultPurchaseType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cores")]
        public double? Cores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        public double? Memory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("machineSelectionType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineMachineSelectionTypeJsonConverter))]
        public global::Vercel.UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineMachineSelectionType? MachineSelectionType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant115NewOwnerResourceConfigBuildMachine" /> class.
        /// </summary>
        /// <param name="default"></param>
        /// <param name="purchaseType"></param>
        /// <param name="defaultPurchaseType"></param>
        /// <param name="cores"></param>
        /// <param name="memory"></param>
        /// <param name="machineSelectionType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant115NewOwnerResourceConfigBuildMachine(
            global::Vercel.UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineDefault? @default,
            global::Vercel.UserEventPayloadVariant115NewOwnerResourceConfigBuildMachinePurchaseType? purchaseType,
            global::Vercel.UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineDefaultPurchaseType? defaultPurchaseType,
            double? cores,
            double? memory,
            global::Vercel.UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineMachineSelectionType? machineSelectionType)
        {
            this.Default = @default;
            this.PurchaseType = purchaseType;
            this.DefaultPurchaseType = defaultPurchaseType;
            this.Cores = cores;
            this.Memory = memory;
            this.MachineSelectionType = machineSelectionType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant115NewOwnerResourceConfigBuildMachine" /> class.
        /// </summary>
        public UserEventPayloadVariant115NewOwnerResourceConfigBuildMachine()
        {
        }
    }
}