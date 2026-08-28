#nullable enable

namespace Vercel
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Fork a named sandbox<br/>
        /// Forks a named sandbox, creating a new named sandbox from the source's configuration. Resources, timeout, ports, tags, network policy, mounts, Connect network, image, persistence, snapshot settings and — unlike the SDK-side fork — environment variables are copied from the source automatically (`interactive` is not). When the source has a snapshot the fork starts from it; otherwise it starts from the source's runtime/image. Any field provided in the request body overrides the value copied from the source.
        /// </summary>
        /// <param name="name">
        /// Name of the source sandbox to fork.
        /// </param>
        /// <param name="projectId">
        /// The ID of the project the source sandbox belongs to. Required unless authenticating with an OIDC token.
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateSandboxesByNameForkV2Response> CreateSandboxesByNameForkV2Async(
            string name,

            global::Vercel.CreateSandboxesByNameForkV2Request request,
            string? projectId = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Fork a named sandbox<br/>
        /// Forks a named sandbox, creating a new named sandbox from the source's configuration. Resources, timeout, ports, tags, network policy, mounts, Connect network, image, persistence, snapshot settings and — unlike the SDK-side fork — environment variables are copied from the source automatically (`interactive` is not). When the source has a snapshot the fork starts from it; otherwise it starts from the source's runtime/image. Any field provided in the request body overrides the value copied from the source.
        /// </summary>
        /// <param name="name">
        /// Name of the source sandbox to fork.
        /// </param>
        /// <param name="projectId">
        /// The ID of the project the source sandbox belongs to. Required unless authenticating with an OIDC token.
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.CreateSandboxesByNameForkV2Response>> CreateSandboxesByNameForkV2AsResponseAsync(
            string name,

            global::Vercel.CreateSandboxesByNameForkV2Request request,
            string? projectId = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Fork a named sandbox<br/>
        /// Forks a named sandbox, creating a new named sandbox from the source's configuration. Resources, timeout, ports, tags, network policy, mounts, Connect network, image, persistence, snapshot settings and — unlike the SDK-side fork — environment variables are copied from the source automatically (`interactive` is not). When the source has a snapshot the fork starts from it; otherwise it starts from the source's runtime/image. Any field provided in the request body overrides the value copied from the source.
        /// </summary>
        /// <param name="name">
        /// Name of the source sandbox to fork.
        /// </param>
        /// <param name="projectId">
        /// The ID of the project the source sandbox belongs to. Required unless authenticating with an OIDC token.
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="networkPolicy"></param>
        /// <param name="resources">
        /// Resources to define the VM
        /// </param>
        /// <param name="ports">
        /// List of ports to expose from the sandbox. Each port will be accessible via a unique URL. Maximum of 15 ports can be exposed.<br/>
        /// Example: [3000, 4000]
        /// </param>
        /// <param name="image">
        /// Image to use for the sandbox.
        /// </param>
        /// <param name="timeout">
        /// Maximum duration in milliseconds that the sandbox can run before being automatically stopped.<br/>
        /// Example: 300000
        /// </param>
        /// <param name="env">
        /// Default environment variables for the sandbox. These are inherited by all commands unless overridden.<br/>
        /// Default Value: {}<br/>
        /// Example: {"NODE_ENV":"production","HELLO":"world"}
        /// </param>
        /// <param name="mounts">
        /// List of drives to mount to the sandbox at the provided path.
        /// </param>
        /// <param name="region">
        /// The Vercel region in which to create the sandbox.<br/>
        /// Default Value: [iad1, sfo1, cle1, cdg1, fra1, arn1, sin1, pdx1, lhr1, icn1, bom1, cpt1, dub1, gru1, hkg1, syd1, yul1, hnd1, kix1]<br/>
        /// Example: iad1
        /// </param>
        /// <param name="failoverRegions">
        /// The regions the sandbox falls back to when it cannot be created in `region`.<br/>
        /// Example: [sfo1, cle1]
        /// </param>
        /// <param name="requestName">
        /// Name for the forked sandbox. Must be unique per project and URL-safe (alphanumeric, hyphens, underscores). A random name is generated when omitted.<br/>
        /// Example: my-sandbox-fork
        /// </param>
        /// <param name="persistent">
        /// Whether the sandbox persists its state across restarts via automatic snapshots. Defaults to the source sandbox setting.
        /// </param>
        /// <param name="snapshotExpiration">
        /// Default snapshot expiration time in milliseconds. Set to 0 to disable expiration. When set, this value is used as the default expiration for all snapshots created for this sandbox.<br/>
        /// Example: 604800000
        /// </param>
        /// <param name="keepLastSnapshots">
        /// Protect the N most recent snapshots with different expiration/deletion behavior.
        /// </param>
        /// <param name="tags">
        /// Key-value tags to associate with the sandbox. Maximum 5 tags.<br/>
        /// Example: {"env":"staging","team":"platform"}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateSandboxesByNameForkV2Response> CreateSandboxesByNameForkV2Async(
            string name,
            string? projectId = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.OneOf<global::Vercel.CreateSandboxesByNameForkV2RequestNetworkPolicyVariant1, global::Vercel.CreateSandboxesByNameForkV2RequestNetworkPolicyVariant2>? networkPolicy = default,
            global::Vercel.CreateSandboxesByNameForkV2RequestResources? resources = default,
            global::System.Collections.Generic.IList<int>? ports = default,
            string? image = default,
            int? timeout = default,
            global::System.Collections.Generic.Dictionary<string, string>? env = default,
            global::System.Collections.Generic.Dictionary<string, global::Vercel.CreateSandboxesByNameForkV2RequestMounts2>? mounts = default,
            global::Vercel.CreateSandboxesByNameForkV2RequestRegion? region = default,
            global::System.Collections.Generic.IList<global::Vercel.CreateSandboxesByNameForkV2RequestFailoverRegion>? failoverRegions = default,
            string? requestName = default,
            bool? persistent = default,
            global::Vercel.OneOf<object, int?>? snapshotExpiration = default,
            global::Vercel.CreateSandboxesByNameForkV2RequestKeepLastSnapshots? keepLastSnapshots = default,
            global::System.Collections.Generic.Dictionary<string, string>? tags = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}