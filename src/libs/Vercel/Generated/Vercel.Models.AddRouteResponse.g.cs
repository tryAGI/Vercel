
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddRouteResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("route")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AddRouteResponseRoute Route { get; set; }

        /// <summary>
        /// A version of routing rules stored in S3.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AddRouteResponseVersion Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddRouteResponse" /> class.
        /// </summary>
        /// <param name="route"></param>
        /// <param name="version">
        /// A version of routing rules stored in S3.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddRouteResponse(
            global::Vercel.AddRouteResponseRoute route,
            global::Vercel.AddRouteResponseVersion version)
        {
            this.Route = route ?? throw new global::System.ArgumentNullException(nameof(route));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddRouteResponse" /> class.
        /// </summary>
        public AddRouteResponse()
        {
        }
    }
}