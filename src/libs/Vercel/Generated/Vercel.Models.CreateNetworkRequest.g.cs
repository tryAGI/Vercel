
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateNetworkRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("awsAvailabilityZoneIds")]
        public global::System.Collections.Generic.IList<string>? AwsAvailabilityZoneIds { get; set; }

        /// <summary>
        /// The CIDR block of the network<br/>
        /// Example: 192.168.0.0/16
        /// </summary>
        /// <example>192.168.0.0/16</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cidr")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cidr { get; set; }

        /// <summary>
        /// The name of the network
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The region where the network will be created<br/>
        /// Example: iad1
        /// </summary>
        /// <example>iad1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNetworkRequest" /> class.
        /// </summary>
        /// <param name="cidr">
        /// The CIDR block of the network<br/>
        /// Example: 192.168.0.0/16
        /// </param>
        /// <param name="name">
        /// The name of the network
        /// </param>
        /// <param name="region">
        /// The region where the network will be created<br/>
        /// Example: iad1
        /// </param>
        /// <param name="awsAvailabilityZoneIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateNetworkRequest(
            string cidr,
            string name,
            string region,
            global::System.Collections.Generic.IList<string>? awsAvailabilityZoneIds)
        {
            this.AwsAvailabilityZoneIds = awsAvailabilityZoneIds;
            this.Cidr = cidr ?? throw new global::System.ArgumentNullException(nameof(cidr));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNetworkRequest" /> class.
        /// </summary>
        public CreateNetworkRequest()
        {
        }
    }
}