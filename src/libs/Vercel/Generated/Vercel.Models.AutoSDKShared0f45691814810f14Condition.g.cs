
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared0f45691814810f14Condition
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared0f45691814810f14ConditionCmpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared0f45691814810f14ConditionCmp Cmp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmpOptions")]
        public global::Vercel.AutoSDKShared0f45691814810f14ConditionCmpOptions? CmpOptions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lhs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKShared0f45691814810f14ConditionLhsVariant1, global::Vercel.AutoSDKShared0f45691814810f14ConditionLhsVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.AutoSDKShared0f45691814810f14ConditionLhsVariant1, global::Vercel.AutoSDKShared0f45691814810f14ConditionLhsVariant2> Lhs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rhs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::Vercel.AutoSDKShared0f45691814810f14ConditionRhsVariant3, global::Vercel.AutoSDKShared0f45691814810f14ConditionRhsVariant4, bool?>))]
        public global::Vercel.OneOf<string, double?, global::Vercel.AutoSDKShared0f45691814810f14ConditionRhsVariant3, global::Vercel.AutoSDKShared0f45691814810f14ConditionRhsVariant4, bool?>? Rhs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0f45691814810f14Condition" /> class.
        /// </summary>
        /// <param name="cmp"></param>
        /// <param name="lhs"></param>
        /// <param name="cmpOptions"></param>
        /// <param name="rhs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared0f45691814810f14Condition(
            global::Vercel.AutoSDKShared0f45691814810f14ConditionCmp cmp,
            global::Vercel.OneOf<global::Vercel.AutoSDKShared0f45691814810f14ConditionLhsVariant1, global::Vercel.AutoSDKShared0f45691814810f14ConditionLhsVariant2> lhs,
            global::Vercel.AutoSDKShared0f45691814810f14ConditionCmpOptions? cmpOptions,
            global::Vercel.OneOf<string, double?, global::Vercel.AutoSDKShared0f45691814810f14ConditionRhsVariant3, global::Vercel.AutoSDKShared0f45691814810f14ConditionRhsVariant4, bool?>? rhs)
        {
            this.Cmp = cmp;
            this.CmpOptions = cmpOptions;
            this.Lhs = lhs;
            this.Rhs = rhs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared0f45691814810f14Condition" /> class.
        /// </summary>
        public AutoSDKShared0f45691814810f14Condition()
        {
        }

    }
}