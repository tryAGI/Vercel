
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Metadata about any AWS Route53 Hosted Zones associated with the Network.
    /// </summary>
    public sealed partial class NetworkPeeringConnections
    {
        /// <summary>
        /// The number of AWS Route53 Hosted Zones associated with the Network.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkPeeringConnections" /> class.
        /// </summary>
        /// <param name="count">
        /// The number of AWS Route53 Hosted Zones associated with the Network.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NetworkPeeringConnections(
            double count)
        {
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkPeeringConnections" /> class.
        /// </summary>
        public NetworkPeeringConnections()
        {
        }
    }
}