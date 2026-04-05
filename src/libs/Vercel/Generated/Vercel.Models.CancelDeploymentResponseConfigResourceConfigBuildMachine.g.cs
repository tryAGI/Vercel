
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CancelDeploymentResponseConfigResourceConfigBuildMachine
    {
        /// <summary>
        /// Machine type that was used for the build.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purchaseType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseConfigResourceConfigBuildMachinePurchaseTypeJsonConverter))]
        public global::Vercel.CancelDeploymentResponseConfigResourceConfigBuildMachinePurchaseType? PurchaseType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseConfigResourceConfigBuildMachine" /> class.
        /// </summary>
        /// <param name="purchaseType">
        /// Machine type that was used for the build.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelDeploymentResponseConfigResourceConfigBuildMachine(
            global::Vercel.CancelDeploymentResponseConfigResourceConfigBuildMachinePurchaseType? purchaseType)
        {
            this.PurchaseType = purchaseType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseConfigResourceConfigBuildMachine" /> class.
        /// </summary>
        public CancelDeploymentResponseConfigResourceConfigBuildMachine()
        {
        }
    }
}