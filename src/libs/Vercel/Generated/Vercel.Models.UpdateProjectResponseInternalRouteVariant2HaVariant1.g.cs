
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProjectResponseInternalRouteVariant2HaVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateProjectResponseInternalRouteVariant2HaVariant1TypeJsonConverter))]
        public global::Vercel.UpdateProjectResponseInternalRouteVariant2HaVariant1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateProjectResponseInternalRouteVariant2HaVariant1KeyJsonConverter))]
        public global::Vercel.UpdateProjectResponseInternalRouteVariant2HaVariant1Key Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateProjectResponseInternalRouteVariant2HaVariant1Value Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectResponseInternalRouteVariant2HaVariant1" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type"></param>
        /// <param name="key"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectResponseInternalRouteVariant2HaVariant1(
            global::Vercel.UpdateProjectResponseInternalRouteVariant2HaVariant1Value value,
            global::Vercel.UpdateProjectResponseInternalRouteVariant2HaVariant1Type type,
            global::Vercel.UpdateProjectResponseInternalRouteVariant2HaVariant1Key key)
        {
            this.Type = type;
            this.Key = key;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectResponseInternalRouteVariant2HaVariant1" /> class.
        /// </summary>
        public UpdateProjectResponseInternalRouteVariant2HaVariant1()
        {
        }
    }
}