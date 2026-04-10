
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Vercel combines the best developer experience with an obsessive focus on end-user performance. Our platform enables frontend teams to do their best work.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IVercelClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Vercel.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Vercel.AutoSDKClientOptions Options { get; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public AccessGroupsClient AccessGroups { get; }

        /// <summary>
        /// 
        /// </summary>
        public AliasesClient Aliases { get; }

        /// <summary>
        /// 
        /// </summary>
        public ApiObservabilityClient ApiObservability { get; }

        /// <summary>
        /// 
        /// </summary>
        public ArtifactsClient Artifacts { get; }

        /// <summary>
        /// 
        /// </summary>
        public AuthenticationClient Authentication { get; }

        /// <summary>
        /// 
        /// </summary>
        public BillingClient Billing { get; }

        /// <summary>
        /// 
        /// </summary>
        public BulkRedirectsClient BulkRedirects { get; }

        /// <summary>
        /// 
        /// </summary>
        public CertsClient Certs { get; }

        /// <summary>
        /// 
        /// </summary>
        public ChecksV2Client ChecksV2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public ConnectClient Connect { get; }

        /// <summary>
        /// 
        /// </summary>
        public DeploymentsClient Deployments { get; }

        /// <summary>
        /// 
        /// </summary>
        public DnsClient Dns { get; }

        /// <summary>
        /// 
        /// </summary>
        public DomainsClient Domains { get; }

        /// <summary>
        /// 
        /// </summary>
        public DomainsRegistrarClient DomainsRegistrar { get; }

        /// <summary>
        /// 
        /// </summary>
        public DrainsClient Drains { get; }

        /// <summary>
        /// 
        /// </summary>
        public EdgeCacheClient EdgeCache { get; }

        /// <summary>
        /// 
        /// </summary>
        public EdgeConfigClient EdgeConfig { get; }

        /// <summary>
        /// 
        /// </summary>
        public EnvironmentClient Environment { get; }

        /// <summary>
        /// 
        /// </summary>
        public FeatureFlagsClient FeatureFlags { get; }

        /// <summary>
        /// 
        /// </summary>
        public IntegrationsClient Integrations { get; }

        /// <summary>
        /// 
        /// </summary>
        public LogDrainsClient LogDrains { get; }

        /// <summary>
        /// 
        /// </summary>
        public LogsClient Logs { get; }

        /// <summary>
        /// 
        /// </summary>
        public MarketplaceClient Marketplace { get; }

        /// <summary>
        /// 
        /// </summary>
        public MicrofrontendsClient Microfrontends { get; }

        /// <summary>
        /// 
        /// </summary>
        public ProjectMembersClient ProjectMembers { get; }

        /// <summary>
        /// 
        /// </summary>
        public ProjectRoutesClient ProjectRoutes { get; }

        /// <summary>
        /// 
        /// </summary>
        public ProjectsClient Projects { get; }

        /// <summary>
        /// 
        /// </summary>
        public RollingReleaseClient RollingRelease { get; }

        /// <summary>
        /// 
        /// </summary>
        public SandboxesClient Sandboxes { get; }

        /// <summary>
        /// 
        /// </summary>
        public SandboxesV2BetaClient SandboxesV2Beta { get; }

        /// <summary>
        /// 
        /// </summary>
        public SecurityClient Security { get; }

        /// <summary>
        /// 
        /// </summary>
        public TeamsClient Teams { get; }

        /// <summary>
        /// 
        /// </summary>
        public UserClient User { get; }

        /// <summary>
        /// 
        /// </summary>
        public WebhooksClient Webhooks { get; }

    }
}