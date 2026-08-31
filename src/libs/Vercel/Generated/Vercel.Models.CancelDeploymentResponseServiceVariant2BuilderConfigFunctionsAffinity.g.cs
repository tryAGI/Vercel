
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CancelDeploymentResponseServiceVariant2BuilderConfigFunctionsAffinity
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseServiceVariant2BuilderConfigFunctionsAffinityModeJsonConverter))]
        public global::Vercel.CancelDeploymentResponseServiceVariant2BuilderConfigFunctionsAffinityMode Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseServiceVariant2BuilderConfigFunctionsAffinity" /> class.
        /// </summary>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelDeploymentResponseServiceVariant2BuilderConfigFunctionsAffinity(
            global::Vercel.CancelDeploymentResponseServiceVariant2BuilderConfigFunctionsAffinityMode mode)
        {
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseServiceVariant2BuilderConfigFunctionsAffinity" /> class.
        /// </summary>
        public CancelDeploymentResponseServiceVariant2BuilderConfigFunctionsAffinity()
        {
        }

    }
}