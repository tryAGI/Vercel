
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Server-owned Elastic assignment; responses may fall back to the legacy label. Not accepted as input. Memory is measured in MiB.
    /// </summary>
    public sealed partial class GetProjectResponseResourceConfigElasticBuildMachine
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cores")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Cores { get; set; }

        /// <summary>
        /// Machine types an elastic decision can effectively apply or persist. The algorithm may consider Basic, but Basic is normalized to standard before an elastic decision becomes effective.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectResponseResourceConfigElasticBuildMachineLabelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectResponseResourceConfigElasticBuildMachineLabel Label { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Memory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseResourceConfigElasticBuildMachine" /> class.
        /// </summary>
        /// <param name="cores"></param>
        /// <param name="label">
        /// Machine types an elastic decision can effectively apply or persist. The algorithm may consider Basic, but Basic is normalized to standard before an elastic decision becomes effective.
        /// </param>
        /// <param name="memory"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectResponseResourceConfigElasticBuildMachine(
            double cores,
            global::Vercel.GetProjectResponseResourceConfigElasticBuildMachineLabel label,
            double memory)
        {
            this.Cores = cores;
            this.Label = label;
            this.Memory = memory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseResourceConfigElasticBuildMachine" /> class.
        /// </summary>
        public GetProjectResponseResourceConfigElasticBuildMachine()
        {
        }

    }
}