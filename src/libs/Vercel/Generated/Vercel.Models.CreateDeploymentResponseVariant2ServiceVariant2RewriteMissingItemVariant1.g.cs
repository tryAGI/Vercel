
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDeploymentResponseVariant2ServiceVariant2RewriteMissingItemVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentResponseVariant2ServiceVariant2RewriteMissingItemVariant1TypeJsonConverter))]
        public global::Vercel.CreateDeploymentResponseVariant2ServiceVariant2RewriteMissingItemVariant1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.CreateDeploymentResponseVariant2ServiceVariant2RewriteMissingItemVariant1Value>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<string, global::Vercel.CreateDeploymentResponseVariant2ServiceVariant2RewriteMissingItemVariant1Value> Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseVariant2ServiceVariant2RewriteMissingItemVariant1" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentResponseVariant2ServiceVariant2RewriteMissingItemVariant1(
            global::Vercel.OneOf<string, global::Vercel.CreateDeploymentResponseVariant2ServiceVariant2RewriteMissingItemVariant1Value> value,
            global::Vercel.CreateDeploymentResponseVariant2ServiceVariant2RewriteMissingItemVariant1Type type)
        {
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseVariant2ServiceVariant2RewriteMissingItemVariant1" /> class.
        /// </summary>
        public CreateDeploymentResponseVariant2ServiceVariant2RewriteMissingItemVariant1()
        {
        }

    }
}