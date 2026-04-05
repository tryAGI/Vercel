
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Network
    {
        /// <summary>
        /// The ID of the AWS Account in which the network exists.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("awsAccountId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AwsAccountId { get; set; }

        /// <summary>
        /// The IDs of the AWS Availability Zones in which the network exists, if specified during creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("awsAvailabilityZoneIds")]
        public global::System.Collections.Generic.IList<string>? AwsAvailabilityZoneIds { get; set; }

        /// <summary>
        /// The AWS Region in which the network exists.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("awsRegion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AwsRegion { get; set; }

        /// <summary>
        /// The CIDR range of the Network.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cidr")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cidr { get; set; }

        /// <summary>
        /// The date at which the Network was created, represented as a UNIX timestamp since EPOCH.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("egressIpAddresses")]
        public global::System.Collections.Generic.IList<string>? EgressIpAddresses { get; set; }

        /// <summary>
        /// Metadata about any AWS Route53 Hosted Zones associated with the Network.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostedZones")]
        public global::Vercel.NetworkHostedZones? HostedZones { get; set; }

        /// <summary>
        /// The unique identifier of the Network.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the network.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Metadata about any AWS Route53 Hosted Zones associated with the Network.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("peeringConnections")]
        public global::Vercel.NetworkPeeringConnections? PeeringConnections { get; set; }

        /// <summary>
        /// Metadata about any projects associated with the Network.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        public global::Vercel.NetworkProjects? Projects { get; set; }

        /// <summary>
        /// The Vercel region in which the Network exists.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// The status of the Network.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.NetworkStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.NetworkStatus Status { get; set; }

        /// <summary>
        /// The unique identifier of the Team that owns the Network.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// The ID of the VPC which hosts the network.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vpcId")]
        public string? VpcId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Network" /> class.
        /// </summary>
        /// <param name="awsAccountId">
        /// The ID of the AWS Account in which the network exists.
        /// </param>
        /// <param name="awsRegion">
        /// The AWS Region in which the network exists.
        /// </param>
        /// <param name="cidr">
        /// The CIDR range of the Network.
        /// </param>
        /// <param name="createdAt">
        /// The date at which the Network was created, represented as a UNIX timestamp since EPOCH.
        /// </param>
        /// <param name="id">
        /// The unique identifier of the Network.
        /// </param>
        /// <param name="name">
        /// The name of the network.
        /// </param>
        /// <param name="status">
        /// The status of the Network.
        /// </param>
        /// <param name="teamId">
        /// The unique identifier of the Team that owns the Network.
        /// </param>
        /// <param name="awsAvailabilityZoneIds">
        /// The IDs of the AWS Availability Zones in which the network exists, if specified during creation.
        /// </param>
        /// <param name="egressIpAddresses"></param>
        /// <param name="hostedZones">
        /// Metadata about any AWS Route53 Hosted Zones associated with the Network.
        /// </param>
        /// <param name="peeringConnections">
        /// Metadata about any AWS Route53 Hosted Zones associated with the Network.
        /// </param>
        /// <param name="projects">
        /// Metadata about any projects associated with the Network.
        /// </param>
        /// <param name="region">
        /// The Vercel region in which the Network exists.
        /// </param>
        /// <param name="vpcId">
        /// The ID of the VPC which hosts the network.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Network(
            string awsAccountId,
            string awsRegion,
            string cidr,
            double createdAt,
            string id,
            string name,
            global::Vercel.NetworkStatus status,
            string teamId,
            global::System.Collections.Generic.IList<string>? awsAvailabilityZoneIds,
            global::System.Collections.Generic.IList<string>? egressIpAddresses,
            global::Vercel.NetworkHostedZones? hostedZones,
            global::Vercel.NetworkPeeringConnections? peeringConnections,
            global::Vercel.NetworkProjects? projects,
            string? region,
            string? vpcId)
        {
            this.AwsAccountId = awsAccountId ?? throw new global::System.ArgumentNullException(nameof(awsAccountId));
            this.AwsAvailabilityZoneIds = awsAvailabilityZoneIds;
            this.AwsRegion = awsRegion ?? throw new global::System.ArgumentNullException(nameof(awsRegion));
            this.Cidr = cidr ?? throw new global::System.ArgumentNullException(nameof(cidr));
            this.CreatedAt = createdAt;
            this.EgressIpAddresses = egressIpAddresses;
            this.HostedZones = hostedZones;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PeeringConnections = peeringConnections;
            this.Projects = projects;
            this.Region = region;
            this.Status = status;
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.VpcId = vpcId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Network" /> class.
        /// </summary>
        public Network()
        {
        }
    }
}