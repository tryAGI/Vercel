
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant1ItemSecurityFirewallRouteHaValue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("re")]
        public string? Re { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eq")]
        public string? Eq { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("neq")]
        public string? Neq { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inc")]
        public global::System.Collections.Generic.IList<string>? Inc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ninc")]
        public global::System.Collections.Generic.IList<string>? Ninc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pre")]
        public string? Pre { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suf")]
        public string? Suf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gt")]
        public double? Gt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gte")]
        public double? Gte { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lt")]
        public double? Lt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lte")]
        public double? Lte { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant1ItemSecurityFirewallRouteHaValue" /> class.
        /// </summary>
        /// <param name="re"></param>
        /// <param name="eq"></param>
        /// <param name="neq"></param>
        /// <param name="inc"></param>
        /// <param name="ninc"></param>
        /// <param name="pre"></param>
        /// <param name="suf"></param>
        /// <param name="gt"></param>
        /// <param name="gte"></param>
        /// <param name="lt"></param>
        /// <param name="lte"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant1ItemSecurityFirewallRouteHaValue(
            string? re,
            string? eq,
            string? neq,
            global::System.Collections.Generic.IList<string>? inc,
            global::System.Collections.Generic.IList<string>? ninc,
            string? pre,
            string? suf,
            double? gt,
            double? gte,
            double? lt,
            double? lte)
        {
            this.Re = re;
            this.Eq = eq;
            this.Neq = neq;
            this.Inc = inc;
            this.Ninc = ninc;
            this.Pre = pre;
            this.Suf = suf;
            this.Gt = gt;
            this.Gte = gte;
            this.Lt = lt;
            this.Lte = lte;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant1ItemSecurityFirewallRouteHaValue" /> class.
        /// </summary>
        public GetProjectsResponseVariant1ItemSecurityFirewallRouteHaValue()
        {
        }
    }
}