
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Flags defined in the Build Output API, used by this deployment. Primarily used by the Toolbar to know about the used flags.
    /// </summary>
    public sealed partial class GetDeploymentResponseVariant1Flags
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("definitions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Vercel.GetDeploymentResponseVariant1FlagsDefinitions2> Definitions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant1Flags" /> class.
        /// </summary>
        /// <param name="definitions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentResponseVariant1Flags(
            global::System.Collections.Generic.Dictionary<string, global::Vercel.GetDeploymentResponseVariant1FlagsDefinitions2> definitions)
        {
            this.Definitions = definitions ?? throw new global::System.ArgumentNullException(nameof(definitions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant1Flags" /> class.
        /// </summary>
        public GetDeploymentResponseVariant1Flags()
        {
        }
    }
}