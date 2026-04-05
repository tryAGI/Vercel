
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant2ProjectSecurityFirewallRoute
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.GetProjectsResponseVariant2ProjectSecurityFirewallRouteSrc>))]
        public global::Vercel.OneOf<string, global::Vercel.GetProjectsResponseVariant2ProjectSecurityFirewallRouteSrc>? Src { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has")]
        public global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant2ProjectSecurityFirewallRouteHa>? Has { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("missing")]
        public global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant2ProjectSecurityFirewallRouteMissingItem>? Missing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dest")]
        public string? Dest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public double? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("handle")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant2ProjectSecurityFirewallRouteHandleJsonConverter))]
        public global::Vercel.GetProjectsResponseVariant2ProjectSecurityFirewallRouteHandle? Handle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mitigate")]
        public global::Vercel.GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigate? Mitigate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant2ProjectSecurityFirewallRoute" /> class.
        /// </summary>
        /// <param name="src"></param>
        /// <param name="has"></param>
        /// <param name="missing"></param>
        /// <param name="dest"></param>
        /// <param name="status"></param>
        /// <param name="handle"></param>
        /// <param name="mitigate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant2ProjectSecurityFirewallRoute(
            global::Vercel.OneOf<string, global::Vercel.GetProjectsResponseVariant2ProjectSecurityFirewallRouteSrc>? src,
            global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant2ProjectSecurityFirewallRouteHa>? has,
            global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant2ProjectSecurityFirewallRouteMissingItem>? missing,
            string? dest,
            double? status,
            global::Vercel.GetProjectsResponseVariant2ProjectSecurityFirewallRouteHandle? handle,
            global::Vercel.GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigate? mitigate)
        {
            this.Src = src;
            this.Has = has;
            this.Missing = missing;
            this.Dest = dest;
            this.Status = status;
            this.Handle = handle;
            this.Mitigate = mitigate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant2ProjectSecurityFirewallRoute" /> class.
        /// </summary>
        public GetProjectsResponseVariant2ProjectSecurityFirewallRoute()
        {
        }
    }
}