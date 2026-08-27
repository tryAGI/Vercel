
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Config-driven CI task — check run `source` only (no parent check).
    /// </summary>
    public sealed partial class GetDeploymentCheckRunResponseVariant2SourceVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subKind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentCheckRunResponseVariant2SourceVariant1SubKindJsonConverter))]
        public global::Vercel.GetDeploymentCheckRunResponseVariant2SourceVariant1SubKind SubKind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentCheckRunResponseVariant2SourceVariant1OriginJsonConverter))]
        public global::Vercel.GetDeploymentCheckRunResponseVariant2SourceVariant1Origin Origin { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invocationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InvocationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobDefinitionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobDefinitionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentCheckRunResponseVariant2SourceVariant1" /> class.
        /// </summary>
        /// <param name="invocationId"></param>
        /// <param name="jobDefinitionId"></param>
        /// <param name="subKind"></param>
        /// <param name="origin"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentCheckRunResponseVariant2SourceVariant1(
            string invocationId,
            string jobDefinitionId,
            global::Vercel.GetDeploymentCheckRunResponseVariant2SourceVariant1SubKind subKind,
            global::Vercel.GetDeploymentCheckRunResponseVariant2SourceVariant1Origin origin)
        {
            this.SubKind = subKind;
            this.Origin = origin;
            this.InvocationId = invocationId ?? throw new global::System.ArgumentNullException(nameof(invocationId));
            this.JobDefinitionId = jobDefinitionId ?? throw new global::System.ArgumentNullException(nameof(jobDefinitionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentCheckRunResponseVariant2SourceVariant1" /> class.
        /// </summary>
        public GetDeploymentCheckRunResponseVariant2SourceVariant1()
        {
        }

    }
}