
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetRoutesResponseVariant2RouteRouteTransformTarget
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.GetRoutesResponseVariant2RouteRouteTransformTargetKey>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant2RouteRouteTransformTargetKey> Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRoutesResponseVariant2RouteRouteTransformTarget" /> class.
        /// </summary>
        /// <param name="key"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRoutesResponseVariant2RouteRouteTransformTarget(
            global::Vercel.OneOf<string, global::Vercel.GetRoutesResponseVariant2RouteRouteTransformTargetKey> key)
        {
            this.Key = key;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRoutesResponseVariant2RouteRouteTransformTarget" /> class.
        /// </summary>
        public GetRoutesResponseVariant2RouteRouteTransformTarget()
        {
        }
    }
}