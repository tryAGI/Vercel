
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDrainResponseVariant1FilterV2Variant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDrainResponseVariant1FilterV2Variant1VersionJsonConverter))]
        public global::Vercel.CreateDrainResponseVariant1FilterV2Variant1Version Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDrainResponseVariant1FilterV2Variant1" /> class.
        /// </summary>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDrainResponseVariant1FilterV2Variant1(
            global::Vercel.CreateDrainResponseVariant1FilterV2Variant1Version version)
        {
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDrainResponseVariant1FilterV2Variant1" /> class.
        /// </summary>
        public CreateDrainResponseVariant1FilterV2Variant1()
        {
        }
    }
}