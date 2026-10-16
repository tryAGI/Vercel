
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Server-owned Elastic assignment; responses may fall back to the legacy label. Not accepted as input. Memory is measured in MiB.
    /// </summary>
    public sealed partial class AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigElasticBuildMachine
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigElasticBuildMachineLabelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigElasticBuildMachineLabel Label { get; set; }

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
        /// Initializes a new instance of the <see cref="AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigElasticBuildMachine" /> class.
        /// </summary>
        /// <param name="cores"></param>
        /// <param name="label">
        /// Machine types an elastic decision can effectively apply or persist. The algorithm may consider Basic, but Basic is normalized to standard before an elastic decision becomes effective.
        /// </param>
        /// <param name="memory"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigElasticBuildMachine(
            double cores,
            global::Vercel.AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigElasticBuildMachineLabel label,
            double memory)
        {
            this.Cores = cores;
            this.Label = label;
            this.Memory = memory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigElasticBuildMachine" /> class.
        /// </summary>
        public AutoSDKShared866bd5cb8fda1c51DefaultResourceConfigElasticBuildMachine()
        {
        }

    }
}