
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Config-driven CI task — check run `source` only (no parent check).
    /// </summary>
    public sealed partial class CreateDeploymentCheckRunResponseVariant2SourceVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invocationAttempt")]
        public double? InvocationAttempt { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentCheckRunResponseVariant2SourceVariant1OriginJsonConverter))]
        public global::Vercel.CreateDeploymentCheckRunResponseVariant2SourceVariant1Origin Origin { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subKind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentCheckRunResponseVariant2SourceVariant1SubKindJsonConverter))]
        public global::Vercel.CreateDeploymentCheckRunResponseVariant2SourceVariant1SubKind SubKind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentCheckRunResponseVariant2SourceVariant1" /> class.
        /// </summary>
        /// <param name="invocationId"></param>
        /// <param name="jobDefinitionId"></param>
        /// <param name="invocationAttempt"></param>
        /// <param name="origin"></param>
        /// <param name="subKind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentCheckRunResponseVariant2SourceVariant1(
            string invocationId,
            string jobDefinitionId,
            double? invocationAttempt,
            global::Vercel.CreateDeploymentCheckRunResponseVariant2SourceVariant1Origin origin,
            global::Vercel.CreateDeploymentCheckRunResponseVariant2SourceVariant1SubKind subKind)
        {
            this.InvocationAttempt = invocationAttempt;
            this.InvocationId = invocationId ?? throw new global::System.ArgumentNullException(nameof(invocationId));
            this.JobDefinitionId = jobDefinitionId ?? throw new global::System.ArgumentNullException(nameof(jobDefinitionId));
            this.Origin = origin;
            this.SubKind = subKind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentCheckRunResponseVariant2SourceVariant1" /> class.
        /// </summary>
        public CreateDeploymentCheckRunResponseVariant2SourceVariant1()
        {
        }

    }
}