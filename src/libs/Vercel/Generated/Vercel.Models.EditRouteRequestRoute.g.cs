
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The full route object to replace the existing route with
    /// </summary>
    public sealed partial class EditRouteRequestRoute
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Pattern syntax type. If not provided, inferred from pattern.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("srcSyntax")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.EditRouteRequestRouteSrcSyntaxJsonConverter))]
        public global::Vercel.EditRouteRequestRouteSrcSyntax? SrcSyntax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("route")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.EditRouteRequestRouteRoute Route { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditRouteRequestRoute" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="route"></param>
        /// <param name="description"></param>
        /// <param name="enabled"></param>
        /// <param name="srcSyntax">
        /// Pattern syntax type. If not provided, inferred from pattern.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditRouteRequestRoute(
            string name,
            global::Vercel.EditRouteRequestRouteRoute route,
            string? description,
            bool? enabled,
            global::Vercel.EditRouteRequestRouteSrcSyntax? srcSyntax)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Enabled = enabled;
            this.SrcSyntax = srcSyntax;
            this.Route = route ?? throw new global::System.ArgumentNullException(nameof(route));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditRouteRequestRoute" /> class.
        /// </summary>
        public EditRouteRequestRoute()
        {
        }
    }
}