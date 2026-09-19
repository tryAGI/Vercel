
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateDeploymentResponseVariant2ServiceVariant2RedirectHaVariant2Value
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
        [global::System.Text.Json.Serialization.JsonPropertyName("inc")]
        public global::System.Collections.Generic.IList<string>? Inc { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("neq")]
        public string? Neq { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("re")]
        public string? Re { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suf")]
        public string? Suf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseVariant2ServiceVariant2RedirectHaVariant2Value" /> class.
        /// </summary>
        /// <param name="eq"></param>
        /// <param name="gt"></param>
        /// <param name="gte"></param>
        /// <param name="inc"></param>
        /// <param name="lt"></param>
        /// <param name="lte"></param>
        /// <param name="neq"></param>
        /// <param name="ninc"></param>
        /// <param name="pre"></param>
        /// <param name="re"></param>
        /// <param name="suf"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentResponseVariant2ServiceVariant2RedirectHaVariant2Value(
            global::Vercel.OneOf<string, double?>? eq,
            double? gt,
            double? gte,
            global::System.Collections.Generic.IList<string>? inc,
            double? lt,
            double? lte,
            string? neq,
            global::System.Collections.Generic.IList<string>? ninc,
            string? pre,
            string? re,
            string? suf)
        {
            this.Eq = eq;
            this.Gt = gt;
            this.Gte = gte;
            this.Inc = inc;
            this.Lt = lt;
            this.Lte = lte;
            this.Neq = neq;
            this.Ninc = ninc;
            this.Pre = pre;
            this.Re = re;
            this.Suf = suf;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseVariant2ServiceVariant2RedirectHaVariant2Value" /> class.
        /// </summary>
        public CreateDeploymentResponseVariant2ServiceVariant2RedirectHaVariant2Value()
        {
        }

    }
}