
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDeploymentResponseRouteVariant1Mitigate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentResponseRouteVariant1MitigateActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CreateDeploymentResponseRouteVariant1MitigateAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseRouteVariant1Mitigate" /> class.
        /// </summary>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentResponseRouteVariant1Mitigate(
            global::Vercel.CreateDeploymentResponseRouteVariant1MitigateAction action)
        {
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseRouteVariant1Mitigate" /> class.
        /// </summary>
        public CreateDeploymentResponseRouteVariant1Mitigate()
        {
        }
    }
}