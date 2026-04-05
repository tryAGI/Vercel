
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditRouteRequest
    {
        /// <summary>
        /// The full route object to replace the existing route with
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("route")]
        public global::Vercel.EditRouteRequestRoute? Route { get; set; }

        /// <summary>
        /// If true, restores the staged route to the value in the production version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restore")]
        public bool? Restore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditRouteRequest" /> class.
        /// </summary>
        /// <param name="route">
        /// The full route object to replace the existing route with
        /// </param>
        /// <param name="restore">
        /// If true, restores the staged route to the value in the production version.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditRouteRequest(
            global::Vercel.EditRouteRequestRoute? route,
            bool? restore)
        {
            this.Route = route;
            this.Restore = restore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditRouteRequest" /> class.
        /// </summary>
        public EditRouteRequest()
        {
        }
    }
}