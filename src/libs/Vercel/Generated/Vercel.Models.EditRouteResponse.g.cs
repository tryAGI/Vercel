
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditRouteResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("route")]
        public global::Vercel.EditRouteResponseRoute? Route { get; set; }

        /// <summary>
        /// A version of routing rules stored in S3.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.EditRouteResponseVersion Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditRouteResponse" /> class.
        /// </summary>
        /// <param name="version">
        /// A version of routing rules stored in S3.
        /// </param>
        /// <param name="route"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditRouteResponse(
            global::Vercel.EditRouteResponseVersion version,
            global::Vercel.EditRouteResponseRoute? route)
        {
            this.Route = route;
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditRouteResponse" /> class.
        /// </summary>
        public EditRouteResponse()
        {
        }
    }
}