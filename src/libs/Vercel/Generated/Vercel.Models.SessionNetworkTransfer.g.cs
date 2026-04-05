
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The quantity of data transfered to and from the sandbox, in bytes. This value is only available once the sandbox is stopped, and only if it stopped successfully.<br/>
    /// Example: {"in":12543852,"out":15368}
    /// </summary>
    public sealed partial class SessionNetworkTransfer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ingress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Ingress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("egress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Egress { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionNetworkTransfer" /> class.
        /// </summary>
        /// <param name="ingress"></param>
        /// <param name="egress"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionNetworkTransfer(
            double ingress,
            double egress)
        {
            this.Ingress = ingress;
            this.Egress = egress;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionNetworkTransfer" /> class.
        /// </summary>
        public SessionNetworkTransfer()
        {
        }
    }
}