
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateErl
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("algo")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateErlAlgoJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateErlAlgo Algo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Window { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Keys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateErl" /> class.
        /// </summary>
        /// <param name="algo"></param>
        /// <param name="window"></param>
        /// <param name="limit"></param>
        /// <param name="keys"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateErl(
            global::Vercel.GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateErlAlgo algo,
            double window,
            double limit,
            global::System.Collections.Generic.IList<string> keys)
        {
            this.Algo = algo;
            this.Window = window;
            this.Limit = limit;
            this.Keys = keys ?? throw new global::System.ArgumentNullException(nameof(keys));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateErl" /> class.
        /// </summary>
        public GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateErl()
        {
        }
    }
}