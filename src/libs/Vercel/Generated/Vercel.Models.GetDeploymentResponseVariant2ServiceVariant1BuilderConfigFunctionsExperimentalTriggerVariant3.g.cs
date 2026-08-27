
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetDeploymentResponseVariant2ServiceVariant1BuilderConfigFunctionsExperimentalTriggerVariant3
    {
        /// <summary>
        /// Event type - must be "schedule/v1beta" (REQUIRED)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant2ServiceVariant1BuilderConfigFunctionsExperimentalTriggerVariant3TypeJsonConverter))]
        public global::Vercel.GetDeploymentResponseVariant2ServiceVariant1BuilderConfigFunctionsExperimentalTriggerVariant3Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant2ServiceVariant1BuilderConfigFunctionsExperimentalTriggerVariant3" /> class.
        /// </summary>
        /// <param name="type">
        /// Event type - must be "schedule/v1beta" (REQUIRED)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentResponseVariant2ServiceVariant1BuilderConfigFunctionsExperimentalTriggerVariant3(
            global::Vercel.GetDeploymentResponseVariant2ServiceVariant1BuilderConfigFunctionsExperimentalTriggerVariant3Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant2ServiceVariant1BuilderConfigFunctionsExperimentalTriggerVariant3" /> class.
        /// </summary>
        public GetDeploymentResponseVariant2ServiceVariant1BuilderConfigFunctionsExperimentalTriggerVariant3()
        {
        }

    }
}