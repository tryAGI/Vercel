
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDeploymentCheckRunResponseVariant1SourceVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentCheckRunResponseVariant1SourceVariant3KindJsonConverter))]
        public global::Vercel.GetDeploymentCheckRunResponseVariant1SourceVariant3Kind Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentCheckRunResponseVariant1SourceVariant3ProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDeploymentCheckRunResponseVariant1SourceVariant3Provider Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalCheckName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExternalCheckName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentCheckRunResponseVariant1SourceVariant3" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="externalCheckName"></param>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentCheckRunResponseVariant1SourceVariant3(
            global::Vercel.GetDeploymentCheckRunResponseVariant1SourceVariant3Provider provider,
            string externalCheckName,
            global::Vercel.GetDeploymentCheckRunResponseVariant1SourceVariant3Kind kind)
        {
            this.Kind = kind;
            this.Provider = provider;
            this.ExternalCheckName = externalCheckName ?? throw new global::System.ArgumentNullException(nameof(externalCheckName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentCheckRunResponseVariant1SourceVariant3" /> class.
        /// </summary>
        public GetDeploymentCheckRunResponseVariant1SourceVariant3()
        {
        }

    }
}