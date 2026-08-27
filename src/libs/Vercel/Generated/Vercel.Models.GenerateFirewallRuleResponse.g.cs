
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GenerateFirewallRuleResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rule")]
        public global::Vercel.GenerateFirewallRuleResponseRule? Rule { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateFirewallRuleResponse" /> class.
        /// </summary>
        /// <param name="rule"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateFirewallRuleResponse(
            global::Vercel.GenerateFirewallRuleResponseRule? rule,
            string? error)
        {
            this.Rule = rule;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateFirewallRuleResponse" /> class.
        /// </summary>
        public GenerateFirewallRuleResponse()
        {
        }

    }
}