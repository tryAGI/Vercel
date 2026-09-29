
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineElasticTransition
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("algorithmVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AlgorithmVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double At { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineElasticTransitionDirectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineElasticTransitionDirection Direction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineElasticTransition" /> class.
        /// </summary>
        /// <param name="algorithmVersion"></param>
        /// <param name="at"></param>
        /// <param name="direction"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineElasticTransition(
            string algorithmVersion,
            double at,
            global::Vercel.AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineElasticTransitionDirection direction)
        {
            this.AlgorithmVersion = algorithmVersion ?? throw new global::System.ArgumentNullException(nameof(algorithmVersion));
            this.At = at;
            this.Direction = direction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineElasticTransition" /> class.
        /// </summary>
        public AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineElasticTransition()
        {
        }

    }
}