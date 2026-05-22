
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Native lint/typecheck — check definition and check run `source`.
    /// </summary>
    public sealed partial class UpdateDeploymentCheckRunResponseVariant1SourceVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subKind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateDeploymentCheckRunResponseVariant1SourceVariant4SubKindJsonConverter))]
        public global::Vercel.UpdateDeploymentCheckRunResponseVariant1SourceVariant4SubKind? SubKind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateDeploymentCheckRunResponseVariant1SourceVariant4OriginJsonConverter))]
        public global::Vercel.UpdateDeploymentCheckRunResponseVariant1SourceVariant4Origin? Origin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDeploymentCheckRunResponseVariant1SourceVariant4" /> class.
        /// </summary>
        /// <param name="subKind"></param>
        /// <param name="origin"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDeploymentCheckRunResponseVariant1SourceVariant4(
            global::Vercel.UpdateDeploymentCheckRunResponseVariant1SourceVariant4SubKind? subKind,
            global::Vercel.UpdateDeploymentCheckRunResponseVariant1SourceVariant4Origin? origin)
        {
            this.SubKind = subKind;
            this.Origin = origin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDeploymentCheckRunResponseVariant1SourceVariant4" /> class.
        /// </summary>
        public UpdateDeploymentCheckRunResponseVariant1SourceVariant4()
        {
        }

    }
}