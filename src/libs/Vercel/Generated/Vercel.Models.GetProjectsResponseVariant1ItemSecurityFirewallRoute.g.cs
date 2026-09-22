
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetProjectsResponseVariant1ItemSecurityFirewallRoute
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dest")]
        public string? Dest { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("handle")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant1ItemSecurityFirewallRouteHandleJsonConverter))]
        public global::Vercel.GetProjectsResponseVariant1ItemSecurityFirewallRouteHandle? Handle { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has")]
        public global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant1ItemSecurityFirewallRouteHa>? Has { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("missing")]
        public global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItem>? Missing { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mitigate")]
        public global::Vercel.GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigate? Mitigate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.GetProjectsResponseVariant1ItemSecurityFirewallRouteSrc>))]
        public global::Vercel.OneOf<string, global::Vercel.GetProjectsResponseVariant1ItemSecurityFirewallRouteSrc>? Src { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public double? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tierRequirement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant1ItemSecurityFirewallRouteTierRequirementJsonConverter))]
        public global::Vercel.GetProjectsResponseVariant1ItemSecurityFirewallRouteTierRequirement? TierRequirement { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transforms")]
        public global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant1ItemSecurityFirewallRouteTransform>? Transforms { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant1ItemSecurityFirewallRoute" /> class.
        /// </summary>
        /// <param name="dest"></param>
        /// <param name="handle"></param>
        /// <param name="has"></param>
        /// <param name="missing"></param>
        /// <param name="mitigate"></param>
        /// <param name="src"></param>
        /// <param name="status"></param>
        /// <param name="tierRequirement"></param>
        /// <param name="transforms"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant1ItemSecurityFirewallRoute(
            string? dest,
            global::Vercel.GetProjectsResponseVariant1ItemSecurityFirewallRouteHandle? handle,
            global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant1ItemSecurityFirewallRouteHa>? has,
            global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant1ItemSecurityFirewallRouteMissingItem>? missing,
            global::Vercel.GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigate? mitigate,
            global::Vercel.OneOf<string, global::Vercel.GetProjectsResponseVariant1ItemSecurityFirewallRouteSrc>? src,
            double? status,
            global::Vercel.GetProjectsResponseVariant1ItemSecurityFirewallRouteTierRequirement? tierRequirement,
            global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant1ItemSecurityFirewallRouteTransform>? transforms)
        {
            this.Dest = dest;
            this.Handle = handle;
            this.Has = has;
            this.Missing = missing;
            this.Mitigate = mitigate;
            this.Src = src;
            this.Status = status;
            this.TierRequirement = tierRequirement;
            this.Transforms = transforms;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant1ItemSecurityFirewallRoute" /> class.
        /// </summary>
        public GetProjectsResponseVariant1ItemSecurityFirewallRoute()
        {
        }

    }
}