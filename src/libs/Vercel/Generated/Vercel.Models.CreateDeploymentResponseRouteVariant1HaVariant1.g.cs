
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDeploymentResponseRouteVariant1HaVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentResponseRouteVariant1HaVariant1TypeJsonConverter))]
        public global::Vercel.CreateDeploymentResponseRouteVariant1HaVariant1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.CreateDeploymentResponseRouteVariant1HaVariant1Value>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<string, global::Vercel.CreateDeploymentResponseRouteVariant1HaVariant1Value> Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseRouteVariant1HaVariant1" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentResponseRouteVariant1HaVariant1(
            global::Vercel.OneOf<string, global::Vercel.CreateDeploymentResponseRouteVariant1HaVariant1Value> value,
            global::Vercel.CreateDeploymentResponseRouteVariant1HaVariant1Type type)
        {
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseRouteVariant1HaVariant1" /> class.
        /// </summary>
        public CreateDeploymentResponseRouteVariant1HaVariant1()
        {
        }
    }
}