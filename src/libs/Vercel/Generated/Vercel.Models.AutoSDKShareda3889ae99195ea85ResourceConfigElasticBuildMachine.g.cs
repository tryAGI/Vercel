
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Server-owned Elastic assignment; responses may fall back to the legacy label. Not accepted as input. Memory is measured in MiB.
    /// </summary>
    public sealed partial class AutoSDKShareda3889ae99195ea85ResourceConfigElasticBuildMachine
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cores")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Cores { get; set; }

        /// <summary>
        /// Machine types elastic can assign. Widens when the elastic algorithm adds the 14 CPU tier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShareda3889ae99195ea85ResourceConfigElasticBuildMachineLabelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShareda3889ae99195ea85ResourceConfigElasticBuildMachineLabel Label { get; set; }

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
        /// Initializes a new instance of the <see cref="AutoSDKShareda3889ae99195ea85ResourceConfigElasticBuildMachine" /> class.
        /// </summary>
        /// <param name="cores"></param>
        /// <param name="label">
        /// Machine types elastic can assign. Widens when the elastic algorithm adds the 14 CPU tier.
        /// </param>
        /// <param name="memory"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShareda3889ae99195ea85ResourceConfigElasticBuildMachine(
            double cores,
            global::Vercel.AutoSDKShareda3889ae99195ea85ResourceConfigElasticBuildMachineLabel label,
            double memory)
        {
            this.Cores = cores;
            this.Label = label;
            this.Memory = memory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareda3889ae99195ea85ResourceConfigElasticBuildMachine" /> class.
        /// </summary>
        public AutoSDKShareda3889ae99195ea85ResourceConfigElasticBuildMachine()
        {
        }

    }
}