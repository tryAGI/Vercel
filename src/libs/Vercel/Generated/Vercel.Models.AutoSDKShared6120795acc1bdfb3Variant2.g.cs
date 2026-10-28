
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared6120795acc1bdfb3Variant2
    {
        /// <summary>
        /// The build ran on a fixed machine. Drives billing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("machineSelectionType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared6120795acc1bdfb3Variant2MachineSelectionTypeJsonConverter))]
        public global::Vercel.AutoSDKShared6120795acc1bdfb3Variant2MachineSelectionType? MachineSelectionType { get; set; }

        /// <summary>
        /// Machine type purchased for this build.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purchaseType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared6120795acc1bdfb3Variant2PurchaseTypeJsonConverter))]
        public global::Vercel.AutoSDKShared6120795acc1bdfb3Variant2PurchaseType? PurchaseType { get; set; }

        /// <summary>
        /// Build cores. Deployment creation sets the requested value; dispatch replaces it with the cores assigned by routing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cores")]
        public double? Cores { get; set; }

        /// <summary>
        /// The build machine tier included with the customer's plan. For most customers this is standard; enhanced entitlements include enhanced, while `none` means every build is billed at its purchase type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultPurchaseType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared6120795acc1bdfb3Variant2DefaultPurchaseTypeJsonConverter))]
        public global::Vercel.AutoSDKShared6120795acc1bdfb3Variant2DefaultPurchaseType? DefaultPurchaseType { get; set; }

        /// <summary>
        /// Build memory, in MiB. Deployment creation sets the requested value; dispatch replaces it with the memory assigned by routing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        public double? Memory { get; set; }

        /// <summary>
        /// The setting which selected the build machine when the deployment was created. Frozen here so later project or team changes do not rewrite its history.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selectionSource")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared6120795acc1bdfb3Variant2SelectionSourceJsonConverter))]
        public global::Vercel.AutoSDKShared6120795acc1bdfb3Variant2SelectionSource? SelectionSource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared6120795acc1bdfb3Variant2" /> class.
        /// </summary>
        /// <param name="machineSelectionType">
        /// The build ran on a fixed machine. Drives billing.
        /// </param>
        /// <param name="purchaseType">
        /// Machine type purchased for this build.
        /// </param>
        /// <param name="cores">
        /// Build cores. Deployment creation sets the requested value; dispatch replaces it with the cores assigned by routing.
        /// </param>
        /// <param name="defaultPurchaseType">
        /// The build machine tier included with the customer's plan. For most customers this is standard; enhanced entitlements include enhanced, while `none` means every build is billed at its purchase type.
        /// </param>
        /// <param name="memory">
        /// Build memory, in MiB. Deployment creation sets the requested value; dispatch replaces it with the memory assigned by routing.
        /// </param>
        /// <param name="selectionSource">
        /// The setting which selected the build machine when the deployment was created. Frozen here so later project or team changes do not rewrite its history.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared6120795acc1bdfb3Variant2(
            global::Vercel.AutoSDKShared6120795acc1bdfb3Variant2MachineSelectionType? machineSelectionType,
            global::Vercel.AutoSDKShared6120795acc1bdfb3Variant2PurchaseType? purchaseType,
            double? cores,
            global::Vercel.AutoSDKShared6120795acc1bdfb3Variant2DefaultPurchaseType? defaultPurchaseType,
            double? memory,
            global::Vercel.AutoSDKShared6120795acc1bdfb3Variant2SelectionSource? selectionSource)
        {
            this.MachineSelectionType = machineSelectionType;
            this.PurchaseType = purchaseType;
            this.Cores = cores;
            this.DefaultPurchaseType = defaultPurchaseType;
            this.Memory = memory;
            this.SelectionSource = selectionSource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared6120795acc1bdfb3Variant2" /> class.
        /// </summary>
        public AutoSDKShared6120795acc1bdfb3Variant2()
        {
        }

    }
}