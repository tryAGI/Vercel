
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetRoutesResponseVariant4Limit
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxRoutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxRoutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentRoutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CurrentRoutes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRoutesResponseVariant4Limit" /> class.
        /// </summary>
        /// <param name="maxRoutes"></param>
        /// <param name="currentRoutes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRoutesResponseVariant4Limit(
            double maxRoutes,
            double currentRoutes)
        {
            this.MaxRoutes = maxRoutes;
            this.CurrentRoutes = currentRoutes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRoutesResponseVariant4Limit" /> class.
        /// </summary>
        public GetRoutesResponseVariant4Limit()
        {
        }
    }
}