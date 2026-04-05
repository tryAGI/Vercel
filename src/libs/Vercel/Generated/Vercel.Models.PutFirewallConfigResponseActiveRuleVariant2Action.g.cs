
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PutFirewallConfigResponseActiveRuleVariant2Action
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mitigate")]
        public global::Vercel.PutFirewallConfigResponseActiveRuleVariant2ActionMitigate? Mitigate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFirewallConfigResponseActiveRuleVariant2Action" /> class.
        /// </summary>
        /// <param name="mitigate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutFirewallConfigResponseActiveRuleVariant2Action(
            global::Vercel.PutFirewallConfigResponseActiveRuleVariant2ActionMitigate? mitigate)
        {
            this.Mitigate = mitigate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutFirewallConfigResponseActiveRuleVariant2Action" /> class.
        /// </summary>
        public PutFirewallConfigResponseActiveRuleVariant2Action()
        {
        }
    }
}