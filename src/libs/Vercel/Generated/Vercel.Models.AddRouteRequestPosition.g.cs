
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Controls where the route is inserted. Defaults to \"end\" if omitted.
    /// </summary>
    public sealed partial class AddRouteRequestPosition
    {
        /// <summary>
        /// \"after\"/\"before\" require referenceId.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AddRouteRequestPositionPlacementJsonConverter))]
        public global::Vercel.AddRouteRequestPositionPlacement? Placement { get; set; }

        /// <summary>
        /// Route ID to insert after/before. Required for \"after\"/\"before\".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceId")]
        public string? ReferenceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddRouteRequestPosition" /> class.
        /// </summary>
        /// <param name="placement">
        /// \"after\"/\"before\" require referenceId.
        /// </param>
        /// <param name="referenceId">
        /// Route ID to insert after/before. Required for \"after\"/\"before\".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddRouteRequestPosition(
            global::Vercel.AddRouteRequestPositionPlacement? placement,
            string? referenceId)
        {
            this.Placement = placement;
            this.ReferenceId = referenceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddRouteRequestPosition" /> class.
        /// </summary>
        public AddRouteRequestPosition()
        {
        }
    }
}