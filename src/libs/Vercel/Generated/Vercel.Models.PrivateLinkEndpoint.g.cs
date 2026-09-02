
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A PrivateLink endpoint, which connects a project to an AWS VPC endpoint service in a single region so that traffic reaches the service over AWS PrivateLink rather than the public internet.
    /// </summary>
    public sealed partial class PrivateLinkEndpoint
    {
        /// <summary>
        /// The unique identifier of the PrivateLink endpoint.<br/>
        /// Example: ple_a1b2c3d4e5f6g7h8
        /// </summary>
        /// <example>ple_a1b2c3d4e5f6g7h8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpointId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndpointId { get; set; }

        /// <summary>
        /// The name of the PrivateLink endpoint, shown in the Vercel dashboard.<br/>
        /// Example: payments-db
        /// </summary>
        /// <example>payments-db</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The identifier of the team that owns the PrivateLink endpoint.<br/>
        /// Example: team_a1b2c3d4e5f6g7h8
        /// </summary>
        /// <example>team_a1b2c3d4e5f6g7h8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// The identifier of the project the PrivateLink endpoint belongs to.<br/>
        /// Example: prj_a1b2c3d4e5f6g7h8
        /// </summary>
        /// <example>prj_a1b2c3d4e5f6g7h8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// The Vercel region the endpoint is provisioned in.<br/>
        /// Example: iad1
        /// </summary>
        /// <example>iad1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vercelRegion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VercelRegion { get; set; }

        /// <summary>
        /// The AWS VPC endpoint service the endpoint connects to.<br/>
        /// Example: com.amazonaws.vpce.us-east-1.vpce-svc-0123456789abcdef0
        /// </summary>
        /// <example>com.amazonaws.vpce.us-east-1.vpce-svc-0123456789abcdef0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("awsServiceName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AwsServiceName { get; set; }

        /// <summary>
        /// The identifier of the underlying AWS VPC endpoint. Absent until AWS has created the endpoint.<br/>
        /// Example: vpce-0123456789abcdef0
        /// </summary>
        /// <example>vpce-0123456789abcdef0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vpcEndpointId")]
        public string? VpcEndpointId { get; set; }

        /// <summary>
        /// The regional DNS names assigned to the endpoint by AWS. Use these to reach the service when private DNS is not enabled.<br/>
        /// Example: [vpce-0123456789abcdef0-a1b2c3d4.vpce-svc-0123456789abcdef0.us-east-1.vpce.amazonaws.com]
        /// </summary>
        /// <example>[vpce-0123456789abcdef0-a1b2c3d4.vpce-svc-0123456789abcdef0.us-east-1.vpce.amazonaws.com]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("awsDnsEntries")]
        public global::System.Collections.Generic.IList<string>? AwsDnsEntries { get; set; }

        /// <summary>
        /// The private DNS names of the endpoint service, populated when private DNS is enabled for the endpoint.<br/>
        /// Example: [payments.internal.example.com]
        /// </summary>
        /// <example>[payments.internal.example.com]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("privateDnsNames")]
        public global::System.Collections.Generic.IList<string>? PrivateDnsNames { get; set; }

        /// <summary>
        /// The current state of the endpoint. - `creating`: the endpoint is being created. - `pending-acceptance`: waiting for the endpoint service owner to accept the connection. Only occurs for services that require manual acceptance. - `provisioning`: the connection was accepted and AWS is finishing setup. - `available`: the endpoint is fully provisioned and ready to use. - `rejected`: the endpoint service owner rejected the connection. - `failed`: the endpoint could not be provisioned. - `deleting`: the endpoint is being deleted.<br/>
        /// Example: available
        /// </summary>
        /// <example>available</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.PrivateLinkEndpointStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.PrivateLinkEndpointStatus Status { get; set; }

        /// <summary>
        /// A human-readable explanation of why the endpoint could not be provisioned. Only set when `status` is `failed`, and absent for every other status including `rejected`, since AWS does not report a rejection reason.<br/>
        /// Example: Endpoint did not become available in time. Try deleting and recreating, or visit https://vercel.com/help if the issue persists.
        /// </summary>
        /// <example>Endpoint did not become available in time. Try deleting and recreating, or visit https://vercel.com/help if the issue persists.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusMessage")]
        public string? StatusMessage { get; set; }

        /// <summary>
        /// Timestamp in milliseconds since the UNIX epoch for when the endpoint was created.<br/>
        /// Example: 1610963878358L
        /// </summary>
        /// <example>1610963878358L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// Timestamp in milliseconds since the UNIX epoch for when the endpoint was last updated.<br/>
        /// Example: 1610963878358L
        /// </summary>
        /// <example>1610963878358L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateLinkEndpoint" /> class.
        /// </summary>
        /// <param name="endpointId">
        /// The unique identifier of the PrivateLink endpoint.<br/>
        /// Example: ple_a1b2c3d4e5f6g7h8
        /// </param>
        /// <param name="name">
        /// The name of the PrivateLink endpoint, shown in the Vercel dashboard.<br/>
        /// Example: payments-db
        /// </param>
        /// <param name="teamId">
        /// The identifier of the team that owns the PrivateLink endpoint.<br/>
        /// Example: team_a1b2c3d4e5f6g7h8
        /// </param>
        /// <param name="projectId">
        /// The identifier of the project the PrivateLink endpoint belongs to.<br/>
        /// Example: prj_a1b2c3d4e5f6g7h8
        /// </param>
        /// <param name="vercelRegion">
        /// The Vercel region the endpoint is provisioned in.<br/>
        /// Example: iad1
        /// </param>
        /// <param name="awsServiceName">
        /// The AWS VPC endpoint service the endpoint connects to.<br/>
        /// Example: com.amazonaws.vpce.us-east-1.vpce-svc-0123456789abcdef0
        /// </param>
        /// <param name="status">
        /// The current state of the endpoint. - `creating`: the endpoint is being created. - `pending-acceptance`: waiting for the endpoint service owner to accept the connection. Only occurs for services that require manual acceptance. - `provisioning`: the connection was accepted and AWS is finishing setup. - `available`: the endpoint is fully provisioned and ready to use. - `rejected`: the endpoint service owner rejected the connection. - `failed`: the endpoint could not be provisioned. - `deleting`: the endpoint is being deleted.<br/>
        /// Example: available
        /// </param>
        /// <param name="createdAt">
        /// Timestamp in milliseconds since the UNIX epoch for when the endpoint was created.<br/>
        /// Example: 1610963878358L
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp in milliseconds since the UNIX epoch for when the endpoint was last updated.<br/>
        /// Example: 1610963878358L
        /// </param>
        /// <param name="vpcEndpointId">
        /// The identifier of the underlying AWS VPC endpoint. Absent until AWS has created the endpoint.<br/>
        /// Example: vpce-0123456789abcdef0
        /// </param>
        /// <param name="awsDnsEntries">
        /// The regional DNS names assigned to the endpoint by AWS. Use these to reach the service when private DNS is not enabled.<br/>
        /// Example: [vpce-0123456789abcdef0-a1b2c3d4.vpce-svc-0123456789abcdef0.us-east-1.vpce.amazonaws.com]
        /// </param>
        /// <param name="privateDnsNames">
        /// The private DNS names of the endpoint service, populated when private DNS is enabled for the endpoint.<br/>
        /// Example: [payments.internal.example.com]
        /// </param>
        /// <param name="statusMessage">
        /// A human-readable explanation of why the endpoint could not be provisioned. Only set when `status` is `failed`, and absent for every other status including `rejected`, since AWS does not report a rejection reason.<br/>
        /// Example: Endpoint did not become available in time. Try deleting and recreating, or visit https://vercel.com/help if the issue persists.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateLinkEndpoint(
            string endpointId,
            string name,
            string teamId,
            string projectId,
            string vercelRegion,
            string awsServiceName,
            global::Vercel.PrivateLinkEndpointStatus status,
            double createdAt,
            double updatedAt,
            string? vpcEndpointId,
            global::System.Collections.Generic.IList<string>? awsDnsEntries,
            global::System.Collections.Generic.IList<string>? privateDnsNames,
            string? statusMessage)
        {
            this.EndpointId = endpointId ?? throw new global::System.ArgumentNullException(nameof(endpointId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.VercelRegion = vercelRegion ?? throw new global::System.ArgumentNullException(nameof(vercelRegion));
            this.AwsServiceName = awsServiceName ?? throw new global::System.ArgumentNullException(nameof(awsServiceName));
            this.VpcEndpointId = vpcEndpointId;
            this.AwsDnsEntries = awsDnsEntries;
            this.PrivateDnsNames = privateDnsNames;
            this.Status = status;
            this.StatusMessage = statusMessage;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateLinkEndpoint" /> class.
        /// </summary>
        public PrivateLinkEndpoint()
        {
        }

    }
}