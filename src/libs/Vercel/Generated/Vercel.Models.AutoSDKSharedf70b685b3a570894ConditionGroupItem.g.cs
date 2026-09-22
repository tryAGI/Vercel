
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedf70b685b3a570894ConditionGroupItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedf70b685b3a570894ConditionGroupItemCondition> Conditions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedf70b685b3a570894ConditionGroupItem" /> class.
        /// </summary>
        /// <param name="conditions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedf70b685b3a570894ConditionGroupItem(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedf70b685b3a570894ConditionGroupItemCondition> conditions)
        {
            this.Conditions = conditions ?? throw new global::System.ArgumentNullException(nameof(conditions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedf70b685b3a570894ConditionGroupItem" /> class.
        /// </summary>
        public AutoSDKSharedf70b685b3a570894ConditionGroupItem()
        {
        }

    }
}