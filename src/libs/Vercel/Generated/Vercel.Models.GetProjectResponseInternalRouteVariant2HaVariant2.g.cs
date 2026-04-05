
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectResponseInternalRouteVariant2HaVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectResponseInternalRouteVariant2HaVariant2TypeJsonConverter))]
        public global::Vercel.GetProjectResponseInternalRouteVariant2HaVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectResponseInternalRouteVariant2HaVariant2Value Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseInternalRouteVariant2HaVariant2" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectResponseInternalRouteVariant2HaVariant2(
            global::Vercel.GetProjectResponseInternalRouteVariant2HaVariant2Value value,
            global::Vercel.GetProjectResponseInternalRouteVariant2HaVariant2Type type)
        {
            this.Type = type;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseInternalRouteVariant2HaVariant2" /> class.
        /// </summary>
        public GetProjectResponseInternalRouteVariant2HaVariant2()
        {
        }
    }
}