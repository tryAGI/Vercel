
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateDeploymentResponseVariant2ServiceVariant1BuilderConfigFunctionsAffinity
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentResponseVariant2ServiceVariant1BuilderConfigFunctionsAffinityModeJsonConverter))]
        public global::Vercel.CreateDeploymentResponseVariant2ServiceVariant1BuilderConfigFunctionsAffinityMode Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseVariant2ServiceVariant1BuilderConfigFunctionsAffinity" /> class.
        /// </summary>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentResponseVariant2ServiceVariant1BuilderConfigFunctionsAffinity(
            global::Vercel.CreateDeploymentResponseVariant2ServiceVariant1BuilderConfigFunctionsAffinityMode mode)
        {
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseVariant2ServiceVariant1BuilderConfigFunctionsAffinity" /> class.
        /// </summary>
        public CreateDeploymentResponseVariant2ServiceVariant1BuilderConfigFunctionsAffinity()
        {
        }

    }
}