
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetRouteVersionsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetRouteVersionsResponseVersion> Versions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRouteVersionsResponse" /> class.
        /// </summary>
        /// <param name="versions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRouteVersionsResponse(
            global::System.Collections.Generic.IList<global::Vercel.GetRouteVersionsResponseVersion> versions)
        {
            this.Versions = versions ?? throw new global::System.ArgumentNullException(nameof(versions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRouteVersionsResponse" /> class.
        /// </summary>
        public GetRouteVersionsResponse()
        {
        }
    }
}