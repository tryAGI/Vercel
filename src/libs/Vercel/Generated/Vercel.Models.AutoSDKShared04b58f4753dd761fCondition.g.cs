
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared04b58f4753dd761fCondition
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lhs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.AutoSDKShared04b58f4753dd761fConditionLhsVariant1, global::Vercel.AutoSDKShared04b58f4753dd761fConditionLhsVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AnyOf<global::Vercel.AutoSDKShared04b58f4753dd761fConditionLhsVariant1, global::Vercel.AutoSDKShared04b58f4753dd761fConditionLhsVariant2> Lhs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared04b58f4753dd761fConditionCmpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared04b58f4753dd761fConditionCmp Cmp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rhs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.AutoSDKShared04b58f4753dd761fConditionRhsVariant1, global::Vercel.AutoSDKShared04b58f4753dd761fConditionRhsVariant2, string, double?, bool?>))]
        public global::Vercel.AnyOf<global::Vercel.AutoSDKShared04b58f4753dd761fConditionRhsVariant1, global::Vercel.AutoSDKShared04b58f4753dd761fConditionRhsVariant2, string, double?, bool?>? Rhs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmpOptions")]
        public global::Vercel.AutoSDKShared04b58f4753dd761fConditionCmpOptions? CmpOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared04b58f4753dd761fCondition" /> class.
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="cmp"></param>
        /// <param name="rhs"></param>
        /// <param name="cmpOptions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared04b58f4753dd761fCondition(
            global::Vercel.AnyOf<global::Vercel.AutoSDKShared04b58f4753dd761fConditionLhsVariant1, global::Vercel.AutoSDKShared04b58f4753dd761fConditionLhsVariant2> lhs,
            global::Vercel.AutoSDKShared04b58f4753dd761fConditionCmp cmp,
            global::Vercel.AnyOf<global::Vercel.AutoSDKShared04b58f4753dd761fConditionRhsVariant1, global::Vercel.AutoSDKShared04b58f4753dd761fConditionRhsVariant2, string, double?, bool?>? rhs,
            global::Vercel.AutoSDKShared04b58f4753dd761fConditionCmpOptions? cmpOptions)
        {
            this.Lhs = lhs;
            this.Cmp = cmp;
            this.Rhs = rhs;
            this.CmpOptions = cmpOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared04b58f4753dd761fCondition" /> class.
        /// </summary>
        public AutoSDKShared04b58f4753dd761fCondition()
        {
        }

    }
}