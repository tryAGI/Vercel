
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShareda4dd3b1b30ff7300Condition
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lhs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.AutoSDKShareda4dd3b1b30ff7300ConditionLhsVariant1, global::Vercel.AutoSDKShareda4dd3b1b30ff7300ConditionLhsVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AnyOf<global::Vercel.AutoSDKShareda4dd3b1b30ff7300ConditionLhsVariant1, global::Vercel.AutoSDKShareda4dd3b1b30ff7300ConditionLhsVariant2> Lhs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShareda4dd3b1b30ff7300ConditionCmpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShareda4dd3b1b30ff7300ConditionCmp Cmp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rhs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.AutoSDKShareda4dd3b1b30ff7300ConditionRhsVariant1, global::Vercel.AutoSDKShareda4dd3b1b30ff7300ConditionRhsVariant2, string, double?, bool?>))]
        public global::Vercel.AnyOf<global::Vercel.AutoSDKShareda4dd3b1b30ff7300ConditionRhsVariant1, global::Vercel.AutoSDKShareda4dd3b1b30ff7300ConditionRhsVariant2, string, double?, bool?>? Rhs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmpOptions")]
        public global::Vercel.AutoSDKShareda4dd3b1b30ff7300ConditionCmpOptions? CmpOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareda4dd3b1b30ff7300Condition" /> class.
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="cmp"></param>
        /// <param name="rhs"></param>
        /// <param name="cmpOptions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShareda4dd3b1b30ff7300Condition(
            global::Vercel.AnyOf<global::Vercel.AutoSDKShareda4dd3b1b30ff7300ConditionLhsVariant1, global::Vercel.AutoSDKShareda4dd3b1b30ff7300ConditionLhsVariant2> lhs,
            global::Vercel.AutoSDKShareda4dd3b1b30ff7300ConditionCmp cmp,
            global::Vercel.AnyOf<global::Vercel.AutoSDKShareda4dd3b1b30ff7300ConditionRhsVariant1, global::Vercel.AutoSDKShareda4dd3b1b30ff7300ConditionRhsVariant2, string, double?, bool?>? rhs,
            global::Vercel.AutoSDKShareda4dd3b1b30ff7300ConditionCmpOptions? cmpOptions)
        {
            this.Lhs = lhs;
            this.Cmp = cmp;
            this.Rhs = rhs;
            this.CmpOptions = cmpOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareda4dd3b1b30ff7300Condition" /> class.
        /// </summary>
        public AutoSDKShareda4dd3b1b30ff7300Condition()
        {
        }

    }
}