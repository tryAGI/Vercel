
#nullable enable

namespace Vercel
{
    /// <summary>
    /// CI sentinel — check run `source` only (no parent check).
    /// </summary>
    public sealed partial class UpdateDeploymentCheckRunResponseVariant2SourceVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subKind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateDeploymentCheckRunResponseVariant2SourceVariant2SubKindJsonConverter))]
        public global::Vercel.UpdateDeploymentCheckRunResponseVariant2SourceVariant2SubKind SubKind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateDeploymentCheckRunResponseVariant2SourceVariant2OriginJsonConverter))]
        public global::Vercel.UpdateDeploymentCheckRunResponseVariant2SourceVariant2Origin Origin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDeploymentCheckRunResponseVariant2SourceVariant2" /> class.
        /// </summary>
        /// <param name="subKind"></param>
        /// <param name="origin"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDeploymentCheckRunResponseVariant2SourceVariant2(
            global::Vercel.UpdateDeploymentCheckRunResponseVariant2SourceVariant2SubKind subKind,
            global::Vercel.UpdateDeploymentCheckRunResponseVariant2SourceVariant2Origin origin)
        {
            this.SubKind = subKind;
            this.Origin = origin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDeploymentCheckRunResponseVariant2SourceVariant2" /> class.
        /// </summary>
        public UpdateDeploymentCheckRunResponseVariant2SourceVariant2()
        {
        }

    }
}