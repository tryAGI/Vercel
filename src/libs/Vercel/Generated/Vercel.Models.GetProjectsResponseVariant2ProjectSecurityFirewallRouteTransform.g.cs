
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant2ProjectSecurityFirewallRouteTransform
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant2ProjectSecurityFirewallRouteTransformTypeJsonConverter))]
        public global::Vercel.GetProjectsResponseVariant2ProjectSecurityFirewallRouteTransformType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant2ProjectSecurityFirewallRouteTransformOpJsonConverter))]
        public global::Vercel.GetProjectsResponseVariant2ProjectSecurityFirewallRouteTransformOp Op { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectsResponseVariant2ProjectSecurityFirewallRouteTransformTarget Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Args { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant2ProjectSecurityFirewallRouteTransform" /> class.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="args"></param>
        /// <param name="type"></param>
        /// <param name="op"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant2ProjectSecurityFirewallRouteTransform(
            global::Vercel.GetProjectsResponseVariant2ProjectSecurityFirewallRouteTransformTarget target,
            string args,
            global::Vercel.GetProjectsResponseVariant2ProjectSecurityFirewallRouteTransformType type,
            global::Vercel.GetProjectsResponseVariant2ProjectSecurityFirewallRouteTransformOp op)
        {
            this.Type = type;
            this.Op = op;
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
            this.Args = args ?? throw new global::System.ArgumentNullException(nameof(args));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant2ProjectSecurityFirewallRouteTransform" /> class.
        /// </summary>
        public GetProjectsResponseVariant2ProjectSecurityFirewallRouteTransform()
        {
        }

    }
}