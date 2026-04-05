
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditRouteResponseRoute
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routeType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.EditRouteResponseRouteRouteTypeJsonConverter))]
        public global::Vercel.EditRouteResponseRouteRouteType? RouteType { get; set; }

        /// <summary>
        /// Unique identifier for the routing rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Human-readable name for the routing rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional description of what the routing rule does.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whether the routing rule is enabled. Defaults to true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Whether this route is new and not yet published to production. Set to true only when a route is first created via add-route. Cleared (set to false) when a version is promoted to production.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("staged")]
        public bool? Staged { get; set; }

        /// <summary>
        /// The route definition from @vercel/routing-utils.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("route")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.EditRouteResponseRouteRoute Route { get; set; }

        /// <summary>
        /// Original source pattern provided by user (path-to-regexp or regex). Used to display the user's input in API responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rawSrc")]
        public string? RawSrc { get; set; }

        /// <summary>
        /// Original destination provided by user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rawDest")]
        public string? RawDest { get; set; }

        /// <summary>
        /// The syntax type of the source pattern. Determines how the pattern is compiled to regex.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("srcSyntax")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.EditRouteResponseRouteSrcSyntaxJsonConverter))]
        public global::Vercel.EditRouteResponseRouteSrcSyntax? SrcSyntax { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditRouteResponseRoute" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the routing rule.
        /// </param>
        /// <param name="name">
        /// Human-readable name for the routing rule.
        /// </param>
        /// <param name="route">
        /// The route definition from @vercel/routing-utils.
        /// </param>
        /// <param name="routeType"></param>
        /// <param name="description">
        /// Optional description of what the routing rule does.
        /// </param>
        /// <param name="enabled">
        /// Whether the routing rule is enabled. Defaults to true.
        /// </param>
        /// <param name="staged">
        /// Whether this route is new and not yet published to production. Set to true only when a route is first created via add-route. Cleared (set to false) when a version is promoted to production.
        /// </param>
        /// <param name="rawSrc">
        /// Original source pattern provided by user (path-to-regexp or regex). Used to display the user's input in API responses.
        /// </param>
        /// <param name="rawDest">
        /// Original destination provided by user.
        /// </param>
        /// <param name="srcSyntax">
        /// The syntax type of the source pattern. Determines how the pattern is compiled to regex.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditRouteResponseRoute(
            string id,
            string name,
            global::Vercel.EditRouteResponseRouteRoute route,
            global::Vercel.EditRouteResponseRouteRouteType? routeType,
            string? description,
            bool? enabled,
            bool? staged,
            string? rawSrc,
            string? rawDest,
            global::Vercel.EditRouteResponseRouteSrcSyntax? srcSyntax)
        {
            this.RouteType = routeType;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Enabled = enabled;
            this.Staged = staged;
            this.Route = route ?? throw new global::System.ArgumentNullException(nameof(route));
            this.RawSrc = rawSrc;
            this.RawDest = rawDest;
            this.SrcSyntax = srcSyntax;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditRouteResponseRoute" /> class.
        /// </summary>
        public EditRouteResponseRoute()
        {
        }
    }
}