#nullable enable

namespace Vercel
{
    public partial interface IDeploymentsClient
    {
        /// <summary>
        /// Create a new deployment<br/>
        /// Creates a new deployment for the authenticated team or user. For non-git deployments, upload files first via the file upload API, then reference them here by SHA — or inline small files directly in the request body. To redeploy an existing deployment, provide its `deploymentId`; all settings are inherited unless explicitly overridden. The deployment begins building immediately and transitions through `QUEUED` → `INITIALIZING` → `BUILDING` before reaching `READY` or `ERROR`.
        /// </summary>
        /// <param name="forceNew">
        /// Forces a new deployment even if there is a previous similar deployment. Set to `1` to bypass deployment deduplication and always trigger a fresh build.<br/>
        /// Example: 1
        /// </param>
        /// <param name="skipAutoDetectionConfirmation">
        /// Set to `1` to skip framework auto-detection and proceed without confirmation. By default, if Vercel detects a framework that differs from the project setting, the API returns a `400` asking you to confirm. Use this to suppress that check in automated pipelines.<br/>
        /// Example: 1
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
        global::System.Threading.Tasks.Task<global::Vercel.CreateDeploymentResponse> CreateDeploymentAsync(

            global::Vercel.CreateDeploymentRequest request,
            global::Vercel.CreateDeploymentForceNew? forceNew = default,
            global::Vercel.CreateDeploymentSkipAutoDetectionConfirmation? skipAutoDetectionConfirmation = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new deployment<br/>
        /// Creates a new deployment for the authenticated team or user. For non-git deployments, upload files first via the file upload API, then reference them here by SHA — or inline small files directly in the request body. To redeploy an existing deployment, provide its `deploymentId`; all settings are inherited unless explicitly overridden. The deployment begins building immediately and transitions through `QUEUED` → `INITIALIZING` → `BUILDING` before reaching `READY` or `ERROR`.
        /// </summary>
        /// <param name="forceNew">
        /// Forces a new deployment even if there is a previous similar deployment. Set to `1` to bypass deployment deduplication and always trigger a fresh build.<br/>
        /// Example: 1
        /// </param>
        /// <param name="skipAutoDetectionConfirmation">
        /// Set to `1` to skip framework auto-detection and proceed without confirmation. By default, if Vercel detects a framework that differs from the project setting, the API returns a `400` asking you to confirm. Use this to suppress that check in automated pipelines.<br/>
        /// Example: 1
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
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.CreateDeploymentResponse>> CreateDeploymentAsResponseAsync(

            global::Vercel.CreateDeploymentRequest request,
            global::Vercel.CreateDeploymentForceNew? forceNew = default,
            global::Vercel.CreateDeploymentSkipAutoDetectionConfirmation? skipAutoDetectionConfirmation = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new deployment<br/>
        /// Creates a new deployment for the authenticated team or user. For non-git deployments, upload files first via the file upload API, then reference them here by SHA — or inline small files directly in the request body. To redeploy an existing deployment, provide its `deploymentId`; all settings are inherited unless explicitly overridden. The deployment begins building immediately and transitions through `QUEUED` → `INITIALIZING` → `BUILDING` before reaching `READY` or `ERROR`.
        /// </summary>
        /// <param name="forceNew">
        /// Forces a new deployment even if there is a previous similar deployment. Set to `1` to bypass deployment deduplication and always trigger a fresh build.<br/>
        /// Example: 1
        /// </param>
        /// <param name="skipAutoDetectionConfirmation">
        /// Set to `1` to skip framework auto-detection and proceed without confirmation. By default, if Vercel detects a framework that differs from the project setting, the API returns a `400` asking you to confirm. Use this to suppress that check in automated pipelines.<br/>
        /// Example: 1
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="customEnvironmentSlugOrId">
        /// The slug or ID of a custom environment to deploy to, overriding the default target environment. When omitted, the deployment targets the environment inferred from the branch (production or preview).<br/>
        /// Example: staging
        /// </param>
        /// <param name="deploymentId">
        /// The ID of an existing deployment to redeploy. All project settings and environment variables are inherited from the original unless explicitly overridden in this request. The redeployment gets a new ID, URL, and build.<br/>
        /// Example: dpl_2qn7PZrx89yxY34vEZPD31Y9XVj6
        /// </param>
        /// <param name="files">
        /// The files to include in the deployment. Each entry is either an inlined file (with `data` and `encoding`) or a reference to a previously uploaded file (with `sha` and `size`). Required for non-git deployments. Cannot be used together with `gitSource`.
        /// </param>
        /// <param name="gitMetadata">
        /// Populates initial git metadata for different git providers.
        /// </param>
        /// <param name="gitSource">
        /// Defines the Git Repository source to be deployed. This property can not be used in combination with `files`.
        /// </param>
        /// <param name="meta">
        /// An object containing the deployment's metadata. Multiple key-value pairs can be attached to a deployment<br/>
        /// Example: {"foo":"bar"}
        /// </param>
        /// <param name="monorepoManager">
        /// The monorepo manager that is being used for this deployment. When `null` is used no monorepo manager is selected
        /// </param>
        /// <param name="name">
        /// A string with the project name used in the deployment URL<br/>
        /// Example: my-instant-deployment
        /// </param>
        /// <param name="project">
        /// The target project identifier in which the deployment will be created. When defined, this parameter overrides name<br/>
        /// Example: my-deployment-project
        /// </param>
        /// <param name="projectSettings">
        /// Project settings that will be applied to the deployment. It is required for the first deployment of a project and will be saved for any following deployments
        /// </param>
        /// <param name="target">
        /// Either not defined, `staging`, `production`, or a custom environment identifier. If `staging`, a staging alias in the format `&lt;project&gt;-&lt;team&gt;.vercel.app` will be assigned. If `production`, any aliases defined in `alias` will be assigned. If omitted, the target will be `preview`.<br/>
        /// Example: production
        /// </param>
        /// <param name="withLatestCommit">
        /// When `true` and `deploymentId` is passed in, the sha from the previous deployment's `gitSource` is removed forcing the latest commit to be used.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateDeploymentResponse> CreateDeploymentAsync(
            string name,
            global::Vercel.CreateDeploymentForceNew? forceNew = default,
            global::Vercel.CreateDeploymentSkipAutoDetectionConfirmation? skipAutoDetectionConfirmation = default,
            string? teamId = default,
            string? slug = default,
            string? customEnvironmentSlugOrId = default,
            string? deploymentId = default,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.CreateDeploymentRequestFileInlinedFile, global::Vercel.CreateDeploymentRequestFileUploadedFile>>? files = default,
            global::Vercel.CreateDeploymentRequestGitMetadata? gitMetadata = default,
            global::Vercel.AnyOf<global::Vercel.CreateDeploymentRequestGitSourceVariant1, global::Vercel.CreateDeploymentRequestGitSourceVariant2, global::Vercel.CreateDeploymentRequestGitSourceVariant3, global::Vercel.CreateDeploymentRequestGitSourceVariant4, global::Vercel.CreateDeploymentRequestGitSourceVariant5, global::Vercel.CreateDeploymentRequestGitSourceVariant6, global::Vercel.CreateDeploymentRequestGitSourceVariant7, global::Vercel.CreateDeploymentRequestGitSourceVariant8>? gitSource = default,
            global::System.Collections.Generic.Dictionary<string, string>? meta = default,
            string? monorepoManager = default,
            string? project = default,
            global::Vercel.CreateDeploymentRequestProjectSettings? projectSettings = default,
            string? target = default,
            bool? withLatestCommit = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}