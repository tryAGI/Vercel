
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticTransition
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticTransitionDirectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticTransitionDirection Direction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticTransition" /> class.
        /// </summary>
        /// <param name="algorithmVersion"></param>
        /// <param name="at"></param>
        /// <param name="direction"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticTransition(
            string algorithmVersion,
            double at,
            global::Vercel.AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticTransitionDirection direction)
        {
            this.AlgorithmVersion = algorithmVersion ?? throw new global::System.ArgumentNullException(nameof(algorithmVersion));
            this.At = at;
            this.Direction = direction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticTransition" /> class.
        /// </summary>
        public AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticTransition()
        {
        }

    }
}