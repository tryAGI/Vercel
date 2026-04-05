
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CancelDeploymentResponseRouteVariant1HaVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseRouteVariant1HaVariant2TypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CancelDeploymentResponseRouteVariant1HaVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.CancelDeploymentResponseRouteVariant1HaVariant2Value>))]
        public global::Vercel.OneOf<string, global::Vercel.CancelDeploymentResponseRouteVariant1HaVariant2Value>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseRouteVariant1HaVariant2" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelDeploymentResponseRouteVariant1HaVariant2(
            global::Vercel.CancelDeploymentResponseRouteVariant1HaVariant2Type type,
            string key,
            global::Vercel.OneOf<string, global::Vercel.CancelDeploymentResponseRouteVariant1HaVariant2Value>? value)
        {
            this.Type = type;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseRouteVariant1HaVariant2" /> class.
        /// </summary>
        public CancelDeploymentResponseRouteVariant1HaVariant2()
        {
        }
    }
}