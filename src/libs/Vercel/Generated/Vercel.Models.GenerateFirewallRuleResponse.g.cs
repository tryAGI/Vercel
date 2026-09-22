
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
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rule")]
        public global::Vercel.GenerateFirewallRuleResponseRule? Rule { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateFirewallRuleResponse" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="rule"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateFirewallRuleResponse(
            string? error,
            global::Vercel.GenerateFirewallRuleResponseRule? rule)
        {
            this.Error = error;
            this.Rule = rule;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateFirewallRuleResponse" /> class.
        /// </summary>
        public GenerateFirewallRuleResponse()
        {
        }

    }
}