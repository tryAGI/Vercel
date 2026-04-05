
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CancelDeploymentResponseRouteVariant1HaVariant2Value
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eq")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>))]
        public global::Vercel.OneOf<string, double?>? Eq { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("re")]
        public string? Re { get; set; }

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
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseRouteVariant1HaVariant2Value" /> class.
        /// </summary>
        /// <param name="eq"></param>
        /// <param name="neq"></param>
        /// <param name="inc"></param>
        /// <param name="ninc"></param>
        /// <param name="pre"></param>
        /// <param name="suf"></param>
        /// <param name="re"></param>
        /// <param name="gt"></param>
        /// <param name="gte"></param>
        /// <param name="lt"></param>
        /// <param name="lte"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CancelDeploymentResponseRouteVariant1HaVariant2Value(
            global::Vercel.OneOf<string, double?>? eq,
            string? neq,
            global::System.Collections.Generic.IList<string>? inc,
            global::System.Collections.Generic.IList<string>? ninc,
            string? pre,
            string? suf,
            string? re,
            double? gt,
            double? gte,
            double? lt,
            double? lte)
        {
            this.Eq = eq;
            this.Neq = neq;
            this.Inc = inc;
            this.Ninc = ninc;
            this.Pre = pre;
            this.Suf = suf;
            this.Re = re;
            this.Gt = gt;
            this.Gte = gte;
            this.Lt = lt;
            this.Lte = lte;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseRouteVariant1HaVariant2Value" /> class.
        /// </summary>
        public CancelDeploymentResponseRouteVariant1HaVariant2Value()
        {
        }
    }
}