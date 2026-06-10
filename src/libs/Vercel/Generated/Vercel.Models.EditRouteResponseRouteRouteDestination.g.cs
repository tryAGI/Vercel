
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditRouteResponseRouteRouteDestination
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.EditRouteResponseRouteRouteDestinationTypeJsonConverter))]
        public global::Vercel.EditRouteResponseRouteRouteDestinationType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Service { get; set; }

        /// <summary>
        /// Routing-only path used to select a route inside the target service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditRouteResponseRouteRouteDestination" /> class.
        /// </summary>
        /// <param name="service"></param>
        /// <param name="type"></param>
        /// <param name="path">
        /// Routing-only path used to select a route inside the target service.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditRouteResponseRouteRouteDestination(
            string service,
            global::Vercel.EditRouteResponseRouteRouteDestinationType type,
            string? path)
        {
            this.Type = type;
            this.Service = service ?? throw new global::System.ArgumentNullException(nameof(service));
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditRouteResponseRouteRouteDestination" /> class.
        /// </summary>
        public EditRouteResponseRouteRouteDestination()
        {
        }

    }
}