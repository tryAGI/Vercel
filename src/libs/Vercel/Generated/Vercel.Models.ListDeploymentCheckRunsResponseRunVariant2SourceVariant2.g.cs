
#nullable enable

namespace Vercel
{
    /// <summary>
    /// CI sentinel — check run `source` only (no parent check).
    /// </summary>
    public sealed partial class ListDeploymentCheckRunsResponseRunVariant2SourceVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListDeploymentCheckRunsResponseRunVariant2SourceVariant2OriginJsonConverter))]
        public global::Vercel.ListDeploymentCheckRunsResponseRunVariant2SourceVariant2Origin Origin { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subKind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListDeploymentCheckRunsResponseRunVariant2SourceVariant2SubKindJsonConverter))]
        public global::Vercel.ListDeploymentCheckRunsResponseRunVariant2SourceVariant2SubKind SubKind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDeploymentCheckRunsResponseRunVariant2SourceVariant2" /> class.
        /// </summary>
        /// <param name="origin"></param>
        /// <param name="subKind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListDeploymentCheckRunsResponseRunVariant2SourceVariant2(
            global::Vercel.ListDeploymentCheckRunsResponseRunVariant2SourceVariant2Origin origin,
            global::Vercel.ListDeploymentCheckRunsResponseRunVariant2SourceVariant2SubKind subKind)
        {
            this.Origin = origin;
            this.SubKind = subKind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDeploymentCheckRunsResponseRunVariant2SourceVariant2" /> class.
        /// </summary>
        public ListDeploymentCheckRunsResponseRunVariant2SourceVariant2()
        {
        }

    }
}