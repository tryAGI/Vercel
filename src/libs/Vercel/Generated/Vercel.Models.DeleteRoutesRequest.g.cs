
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteRoutesRequest
    {
        /// <summary>
        /// The IDs of the routes to delete
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routeIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RouteIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRoutesRequest" /> class.
        /// </summary>
        /// <param name="routeIds">
        /// The IDs of the routes to delete
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteRoutesRequest(
            global::System.Collections.Generic.IList<string> routeIds)
        {
            this.RouteIds = routeIds ?? throw new global::System.ArgumentNullException(nameof(routeIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRoutesRequest" /> class.
        /// </summary>
        public DeleteRoutesRequest()
        {
        }
    }
}