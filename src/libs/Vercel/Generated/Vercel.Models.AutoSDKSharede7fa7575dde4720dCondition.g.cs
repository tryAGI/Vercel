
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharede7fa7575dde4720dCondition
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lhs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.AutoSDKSharede7fa7575dde4720dConditionLhsVariant1, global::Vercel.AutoSDKSharede7fa7575dde4720dConditionLhsVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AnyOf<global::Vercel.AutoSDKSharede7fa7575dde4720dConditionLhsVariant1, global::Vercel.AutoSDKSharede7fa7575dde4720dConditionLhsVariant2> Lhs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharede7fa7575dde4720dConditionCmpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharede7fa7575dde4720dConditionCmp Cmp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rhs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.AutoSDKSharede7fa7575dde4720dConditionRhsVariant1, global::Vercel.AutoSDKSharede7fa7575dde4720dConditionRhsVariant2, string, double?, bool?>))]
        public global::Vercel.AnyOf<global::Vercel.AutoSDKSharede7fa7575dde4720dConditionRhsVariant1, global::Vercel.AutoSDKSharede7fa7575dde4720dConditionRhsVariant2, string, double?, bool?>? Rhs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmpOptions")]
        public global::Vercel.AutoSDKSharede7fa7575dde4720dConditionCmpOptions? CmpOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede7fa7575dde4720dCondition" /> class.
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="cmp"></param>
        /// <param name="rhs"></param>
        /// <param name="cmpOptions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharede7fa7575dde4720dCondition(
            global::Vercel.AnyOf<global::Vercel.AutoSDKSharede7fa7575dde4720dConditionLhsVariant1, global::Vercel.AutoSDKSharede7fa7575dde4720dConditionLhsVariant2> lhs,
            global::Vercel.AutoSDKSharede7fa7575dde4720dConditionCmp cmp,
            global::Vercel.AnyOf<global::Vercel.AutoSDKSharede7fa7575dde4720dConditionRhsVariant1, global::Vercel.AutoSDKSharede7fa7575dde4720dConditionRhsVariant2, string, double?, bool?>? rhs,
            global::Vercel.AutoSDKSharede7fa7575dde4720dConditionCmpOptions? cmpOptions)
        {
            this.Lhs = lhs;
            this.Cmp = cmp;
            this.Rhs = rhs;
            this.CmpOptions = cmpOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede7fa7575dde4720dCondition" /> class.
        /// </summary>
        public AutoSDKSharede7fa7575dde4720dCondition()
        {
        }

    }
}