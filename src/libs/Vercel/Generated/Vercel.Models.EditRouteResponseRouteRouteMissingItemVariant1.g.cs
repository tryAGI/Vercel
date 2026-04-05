
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditRouteResponseRouteRouteMissingItemVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.EditRouteResponseRouteRouteMissingItemVariant1TypeJsonConverter))]
        public global::Vercel.EditRouteResponseRouteRouteMissingItemVariant1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.EditRouteResponseRouteRouteMissingItemVariant1Value>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<string, global::Vercel.EditRouteResponseRouteRouteMissingItemVariant1Value> Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditRouteResponseRouteRouteMissingItemVariant1" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditRouteResponseRouteRouteMissingItemVariant1(
            global::Vercel.OneOf<string, global::Vercel.EditRouteResponseRouteRouteMissingItemVariant1Value> value,
            global::Vercel.EditRouteResponseRouteRouteMissingItemVariant1Type type)
        {
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditRouteResponseRouteRouteMissingItemVariant1" /> class.
        /// </summary>
        public EditRouteResponseRouteRouteMissingItemVariant1()
        {
        }
    }
}