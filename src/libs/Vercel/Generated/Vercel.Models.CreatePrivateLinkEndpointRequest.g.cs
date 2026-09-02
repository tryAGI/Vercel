
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreatePrivateLinkEndpointRequest
    {
        /// <summary>
        /// The project ID to create the PrivateLink endpoint for.<br/>
        /// Example: prj_a1b2c3d4e5f6g7h8
        /// </summary>
        /// <example>prj_a1b2c3d4e5f6g7h8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// The name of the PrivateLink endpoint, used as its label in the Vercel dashboard.<br/>
        /// Example: payments-db
        /// </summary>
        /// <example>payments-db</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The Vercel region to provision the endpoint in. Advanced Networking must be enabled for the project in that region. The endpoint service itself may live in another AWS region.<br/>
        /// Example: iad1
        /// </summary>
        /// <example>iad1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vercelRegion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VercelRegion { get; set; }

        /// <summary>
        /// The name of the AWS VPC endpoint service to connect to. Its AWS region is read from the name; when that region differs from the one behind `vercelRegion`, the service must allow cross-region access.<br/>
        /// Example: com.amazonaws.vpce.us-east-1.vpce-svc-0123456789abcdef0
        /// </summary>
        /// <example>com.amazonaws.vpce.us-east-1.vpce-svc-0123456789abcdef0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("awsServiceName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AwsServiceName { get; set; }

        /// <summary>
        /// Whether to resolve the endpoint service through its private DNS names, which are then returned in `privateDnsNames`. Defaults to `false`, in which case the endpoint is reachable through the DNS names in `awsDnsEntries`.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enablePrivateDns")]
        public bool? EnablePrivateDns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePrivateLinkEndpointRequest" /> class.
        /// </summary>
        /// <param name="projectId">
        /// The project ID to create the PrivateLink endpoint for.<br/>
        /// Example: prj_a1b2c3d4e5f6g7h8
        /// </param>
        /// <param name="name">
        /// The name of the PrivateLink endpoint, used as its label in the Vercel dashboard.<br/>
        /// Example: payments-db
        /// </param>
        /// <param name="vercelRegion">
        /// The Vercel region to provision the endpoint in. Advanced Networking must be enabled for the project in that region. The endpoint service itself may live in another AWS region.<br/>
        /// Example: iad1
        /// </param>
        /// <param name="awsServiceName">
        /// The name of the AWS VPC endpoint service to connect to. Its AWS region is read from the name; when that region differs from the one behind `vercelRegion`, the service must allow cross-region access.<br/>
        /// Example: com.amazonaws.vpce.us-east-1.vpce-svc-0123456789abcdef0
        /// </param>
        /// <param name="enablePrivateDns">
        /// Whether to resolve the endpoint service through its private DNS names, which are then returned in `privateDnsNames`. Defaults to `false`, in which case the endpoint is reachable through the DNS names in `awsDnsEntries`.<br/>
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePrivateLinkEndpointRequest(
            string projectId,
            string name,
            string vercelRegion,
            string awsServiceName,
            bool? enablePrivateDns)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.VercelRegion = vercelRegion ?? throw new global::System.ArgumentNullException(nameof(vercelRegion));
            this.AwsServiceName = awsServiceName ?? throw new global::System.ArgumentNullException(nameof(awsServiceName));
            this.EnablePrivateDns = enablePrivateDns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePrivateLinkEndpointRequest" /> class.
        /// </summary>
        public CreatePrivateLinkEndpointRequest()
        {
        }

    }
}