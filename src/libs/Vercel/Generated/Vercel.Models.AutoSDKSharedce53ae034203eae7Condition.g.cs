
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedce53ae034203eae7Condition
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedce53ae034203eae7ConditionCmpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedce53ae034203eae7ConditionCmp Cmp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmpOptions")]
        public global::Vercel.AutoSDKSharedce53ae034203eae7ConditionCmpOptions? CmpOptions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lhs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKSharedce53ae034203eae7ConditionLhsVariant1, global::Vercel.AutoSDKSharedce53ae034203eae7ConditionLhsVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.AutoSDKSharedce53ae034203eae7ConditionLhsVariant1, global::Vercel.AutoSDKSharedce53ae034203eae7ConditionLhsVariant2> Lhs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rhs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::Vercel.AutoSDKSharedce53ae034203eae7ConditionRhsVariant3, global::Vercel.AutoSDKSharedce53ae034203eae7ConditionRhsVariant4, bool?>))]
        public global::Vercel.OneOf<string, double?, global::Vercel.AutoSDKSharedce53ae034203eae7ConditionRhsVariant3, global::Vercel.AutoSDKSharedce53ae034203eae7ConditionRhsVariant4, bool?>? Rhs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedce53ae034203eae7Condition" /> class.
        /// </summary>
        /// <param name="cmp"></param>
        /// <param name="lhs"></param>
        /// <param name="cmpOptions"></param>
        /// <param name="rhs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedce53ae034203eae7Condition(
            global::Vercel.AutoSDKSharedce53ae034203eae7ConditionCmp cmp,
            global::Vercel.OneOf<global::Vercel.AutoSDKSharedce53ae034203eae7ConditionLhsVariant1, global::Vercel.AutoSDKSharedce53ae034203eae7ConditionLhsVariant2> lhs,
            global::Vercel.AutoSDKSharedce53ae034203eae7ConditionCmpOptions? cmpOptions,
            global::Vercel.OneOf<string, double?, global::Vercel.AutoSDKSharedce53ae034203eae7ConditionRhsVariant3, global::Vercel.AutoSDKSharedce53ae034203eae7ConditionRhsVariant4, bool?>? rhs)
        {
            this.Cmp = cmp;
            this.CmpOptions = cmpOptions;
            this.Lhs = lhs;
            this.Rhs = rhs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedce53ae034203eae7Condition" /> class.
        /// </summary>
        public AutoSDKSharedce53ae034203eae7Condition()
        {
        }

    }
}