
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CancelDeploymentResponseServiceVariant2FunctionsExperimentalTriggerVariant3
    {
        /// <summary>
        /// Event type - must be "schedule/v1beta" (REQUIRED)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseServiceVariant2FunctionsExperimentalTriggerVariant3TypeJsonConverter))]
        public global::Vercel.CancelDeploymentResponseServiceVariant2FunctionsExperimentalTriggerVariant3Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseServiceVariant2FunctionsExperimentalTriggerVariant3" /> class.
        /// </summary>
        /// <param name="type">
        /// Event type - must be "schedule/v1beta" (REQUIRED)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelDeploymentResponseServiceVariant2FunctionsExperimentalTriggerVariant3(
            global::Vercel.CancelDeploymentResponseServiceVariant2FunctionsExperimentalTriggerVariant3Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseServiceVariant2FunctionsExperimentalTriggerVariant3" /> class.
        /// </summary>
        public CancelDeploymentResponseServiceVariant2FunctionsExperimentalTriggerVariant3()
        {
        }

    }
}