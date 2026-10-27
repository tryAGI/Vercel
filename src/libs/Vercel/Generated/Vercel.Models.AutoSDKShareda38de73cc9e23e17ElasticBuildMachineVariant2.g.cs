
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Server-owned Elastic assignment; responses may fall back to the legacy label. Not accepted as input. Memory is measured in MiB.
    /// </summary>
    public sealed partial class AutoSDKShareda38de73cc9e23e17ElasticBuildMachineVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cores")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Cores { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShareda38de73cc9e23e17ElasticBuildMachineVariant2LabelJsonConverter))]
        public global::Vercel.AutoSDKShareda38de73cc9e23e17ElasticBuildMachineVariant2Label Label { get; set; }

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
        /// Initializes a new instance of the <see cref="AutoSDKShareda38de73cc9e23e17ElasticBuildMachineVariant2" /> class.
        /// </summary>
        /// <param name="cores"></param>
        /// <param name="memory"></param>
        /// <param name="label"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShareda38de73cc9e23e17ElasticBuildMachineVariant2(
            double cores,
            double memory,
            global::Vercel.AutoSDKShareda38de73cc9e23e17ElasticBuildMachineVariant2Label label)
        {
            this.Cores = cores;
            this.Label = label;
            this.Memory = memory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareda38de73cc9e23e17ElasticBuildMachineVariant2" /> class.
        /// </summary>
        public AutoSDKShareda38de73cc9e23e17ElasticBuildMachineVariant2()
        {
        }

    }
}