
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetRoutesResponseVariant3RouteRouteMitigate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetRoutesResponseVariant3RouteRouteMitigateActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetRoutesResponseVariant3RouteRouteMitigateAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRoutesResponseVariant3RouteRouteMitigate" /> class.
        /// </summary>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRoutesResponseVariant3RouteRouteMitigate(
            global::Vercel.GetRoutesResponseVariant3RouteRouteMitigateAction action)
        {
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRoutesResponseVariant3RouteRouteMitigate" /> class.
        /// </summary>
        public GetRoutesResponseVariant3RouteRouteMitigate()
        {
        }
    }
}