
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddRouteRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("route")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AddRouteRequestRoute Route { get; set; }

        /// <summary>
        /// Controls where the route is inserted. Defaults to "end" if omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public global::Vercel.AddRouteRequestPosition? Position { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddRouteRequest" /> class.
        /// </summary>
        /// <param name="route"></param>
        /// <param name="position">
        /// Controls where the route is inserted. Defaults to "end" if omitted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddRouteRequest(
            global::Vercel.AddRouteRequestRoute route,
            global::Vercel.AddRouteRequestPosition? position)
        {
            this.Route = route ?? throw new global::System.ArgumentNullException(nameof(route));
            this.Position = position;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddRouteRequest" /> class.
        /// </summary>
        public AddRouteRequest()
        {
        }
    }
}