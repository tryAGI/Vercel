
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDeploymentResponseRouteVariant1MissingItemVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentResponseRouteVariant1MissingItemVariant1TypeJsonConverter))]
        public global::Vercel.CreateDeploymentResponseRouteVariant1MissingItemVariant1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.CreateDeploymentResponseRouteVariant1MissingItemVariant1Value>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<string, global::Vercel.CreateDeploymentResponseRouteVariant1MissingItemVariant1Value> Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseRouteVariant1MissingItemVariant1" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentResponseRouteVariant1MissingItemVariant1(
            global::Vercel.OneOf<string, global::Vercel.CreateDeploymentResponseRouteVariant1MissingItemVariant1Value> value,
            global::Vercel.CreateDeploymentResponseRouteVariant1MissingItemVariant1Type type)
        {
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseRouteVariant1MissingItemVariant1" /> class.
        /// </summary>
        public CreateDeploymentResponseRouteVariant1MissingItemVariant1()
        {
        }
    }
}