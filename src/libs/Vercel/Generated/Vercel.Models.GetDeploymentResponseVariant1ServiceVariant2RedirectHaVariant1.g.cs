
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDeploymentResponseVariant1ServiceVariant2RedirectHaVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant1ServiceVariant2RedirectHaVariant1TypeJsonConverter))]
        public global::Vercel.GetDeploymentResponseVariant1ServiceVariant2RedirectHaVariant1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.GetDeploymentResponseVariant1ServiceVariant2RedirectHaVariant1Value>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<string, global::Vercel.GetDeploymentResponseVariant1ServiceVariant2RedirectHaVariant1Value> Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant1ServiceVariant2RedirectHaVariant1" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentResponseVariant1ServiceVariant2RedirectHaVariant1(
            global::Vercel.OneOf<string, global::Vercel.GetDeploymentResponseVariant1ServiceVariant2RedirectHaVariant1Value> value,
            global::Vercel.GetDeploymentResponseVariant1ServiceVariant2RedirectHaVariant1Type type)
        {
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant1ServiceVariant2RedirectHaVariant1" /> class.
        /// </summary>
        public GetDeploymentResponseVariant1ServiceVariant2RedirectHaVariant1()
        {
        }

    }
}