
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetConditionalBypassResponseVariant2ResultItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditionGroup")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetConditionalBypassResponseVariant2ResultItemConditionGroupItem> ConditionGroup { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConditionalBypassResponseVariant2ResultItem" /> class.
        /// </summary>
        /// <param name="conditionGroup"></param>
        /// <param name="domain"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConditionalBypassResponseVariant2ResultItem(
            global::System.Collections.Generic.IList<global::Vercel.GetConditionalBypassResponseVariant2ResultItemConditionGroupItem> conditionGroup,
            string domain)
        {
            this.ConditionGroup = conditionGroup ?? throw new global::System.ArgumentNullException(nameof(conditionGroup));
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConditionalBypassResponseVariant2ResultItem" /> class.
        /// </summary>
        public GetConditionalBypassResponseVariant2ResultItem()
        {
        }

    }
}