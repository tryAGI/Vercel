
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSandboxesRequestNetworkPolicyVariant2Subnets
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow")]
        public global::System.Collections.Generic.IList<string>? Allow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deny")]
        public global::System.Collections.Generic.IList<string>? Deny { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxesRequestNetworkPolicyVariant2Subnets" /> class.
        /// </summary>
        /// <param name="allow"></param>
        /// <param name="deny"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSandboxesRequestNetworkPolicyVariant2Subnets(
            global::System.Collections.Generic.IList<string>? allow,
            global::System.Collections.Generic.IList<string>? deny)
        {
            this.Allow = allow;
            this.Deny = deny;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxesRequestNetworkPolicyVariant2Subnets" /> class.
        /// </summary>
        public CreateSandboxesRequestNetworkPolicyVariant2Subnets()
        {
        }
    }
}