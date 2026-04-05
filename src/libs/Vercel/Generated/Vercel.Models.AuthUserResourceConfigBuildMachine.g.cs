
#nullable enable

namespace Vercel
{
    /// <summary>
    /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
    /// </summary>
    public sealed partial class AuthUserResourceConfigBuildMachine
    {
        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AuthUserResourceConfigBuildMachineDefaultJsonConverter))]
        public global::Vercel.AuthUserResourceConfigBuildMachineDefault? Default { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purchaseType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AuthUserResourceConfigBuildMachinePurchaseTypeJsonConverter))]
        public global::Vercel.AuthUserResourceConfigBuildMachinePurchaseType? PurchaseType { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultPurchaseType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AuthUserResourceConfigBuildMachineDefaultPurchaseTypeJsonConverter))]
        public global::Vercel.AuthUserResourceConfigBuildMachineDefaultPurchaseType? DefaultPurchaseType { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cores")]
        public double? Cores { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        public double? Memory { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("machineSelectionType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AuthUserResourceConfigBuildMachineMachineSelectionTypeJsonConverter))]
        public global::Vercel.AuthUserResourceConfigBuildMachineMachineSelectionType? MachineSelectionType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserResourceConfigBuildMachine" /> class.
        /// </summary>
        /// <param name="default">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="purchaseType">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="defaultPurchaseType">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="cores">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="memory">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="machineSelectionType">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthUserResourceConfigBuildMachine(
            global::Vercel.AuthUserResourceConfigBuildMachineDefault? @default,
            global::Vercel.AuthUserResourceConfigBuildMachinePurchaseType? purchaseType,
            global::Vercel.AuthUserResourceConfigBuildMachineDefaultPurchaseType? defaultPurchaseType,
            double? cores,
            double? memory,
            global::Vercel.AuthUserResourceConfigBuildMachineMachineSelectionType? machineSelectionType)
        {
            this.Default = @default;
            this.PurchaseType = purchaseType;
            this.DefaultPurchaseType = defaultPurchaseType;
            this.Cores = cores;
            this.Memory = memory;
            this.MachineSelectionType = machineSelectionType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserResourceConfigBuildMachine" /> class.
        /// </summary>
        public AuthUserResourceConfigBuildMachine()
        {
        }
    }
}