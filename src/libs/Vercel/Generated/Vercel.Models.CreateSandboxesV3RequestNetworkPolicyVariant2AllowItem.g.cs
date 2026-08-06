
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSandboxesV3RequestNetworkPolicyVariant2AllowItem
    {
        /// <summary>
        /// Optional L7 match. When provided, the injection rule only applies to requests that satisfy every specified dimension. When multiple injection rules target the same domain they are evaluated in order and the first match wins; a rule without `match` matches any request and shadows later rules for the same domain.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("match")]
        public global::Vercel.CreateSandboxesV3RequestNetworkPolicyVariant2AllowItemMatch? Match { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transform")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateSandboxesV3RequestNetworkPolicyVariant2AllowItemTransformItem>? Transform { get; set; }

        /// <summary>
        /// HTTP/1.1 proxy URL to forward traffic to. Must not include query string or fragment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forwardURL")]
        public string? ForwardURL { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxesV3RequestNetworkPolicyVariant2AllowItem" /> class.
        /// </summary>
        /// <param name="match">
        /// Optional L7 match. When provided, the injection rule only applies to requests that satisfy every specified dimension. When multiple injection rules target the same domain they are evaluated in order and the first match wins; a rule without `match` matches any request and shadows later rules for the same domain.
        /// </param>
        /// <param name="transform"></param>
        /// <param name="forwardURL">
        /// HTTP/1.1 proxy URL to forward traffic to. Must not include query string or fragment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSandboxesV3RequestNetworkPolicyVariant2AllowItem(
            global::Vercel.CreateSandboxesV3RequestNetworkPolicyVariant2AllowItemMatch? match,
            global::System.Collections.Generic.IList<global::Vercel.CreateSandboxesV3RequestNetworkPolicyVariant2AllowItemTransformItem>? transform,
            string? forwardURL)
        {
            this.Match = match;
            this.Transform = transform;
            this.ForwardURL = forwardURL;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxesV3RequestNetworkPolicyVariant2AllowItem" /> class.
        /// </summary>
        public CreateSandboxesV3RequestNetworkPolicyVariant2AllowItem()
        {
        }

    }
}