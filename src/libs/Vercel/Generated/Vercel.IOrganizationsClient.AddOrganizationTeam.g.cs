#nullable enable

namespace Vercel
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Create or Add Team to Organization<br/>
        /// Create a new team under an organization, or add an existing team. `mode: "create"` creates a brand-new child team from `slug` + `name` — a platform child by default, or an enterprise child (billed on the organization root's flex subscription) when `billingPlan: "enterprise"` is supplied. `mode: "link"` links an existing team identified by `teamId` or `slug`; the child's billing profile is derived from the target team's plan (enterprise team → enterprise child, else platform), or explicitly supplied. Both modes respond with the resulting organization-team link. This endpoint is in private beta. Contact your Vercel account team for access.
        /// </summary>
        /// <param name="organizationId">
        /// The ID of the organization to create or add a team under.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OrganizationTeam> AddOrganizationTeamAsync(
            string organizationId,

            global::Vercel.AddOrganizationTeamRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or Add Team to Organization<br/>
        /// Create a new team under an organization, or add an existing team. `mode: "create"` creates a brand-new child team from `slug` + `name` — a platform child by default, or an enterprise child (billed on the organization root's flex subscription) when `billingPlan: "enterprise"` is supplied. `mode: "link"` links an existing team identified by `teamId` or `slug`; the child's billing profile is derived from the target team's plan (enterprise team → enterprise child, else platform), or explicitly supplied. Both modes respond with the resulting organization-team link. This endpoint is in private beta. Contact your Vercel account team for access.
        /// </summary>
        /// <param name="organizationId">
        /// The ID of the organization to create or add a team under.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.OrganizationTeam>> AddOrganizationTeamAsResponseAsync(
            string organizationId,

            global::Vercel.AddOrganizationTeamRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or Add Team to Organization<br/>
        /// Create a new team under an organization, or add an existing team. `mode: "create"` creates a brand-new child team from `slug` + `name` — a platform child by default, or an enterprise child (billed on the organization root's flex subscription) when `billingPlan: "enterprise"` is supplied. `mode: "link"` links an existing team identified by `teamId` or `slug`; the child's billing profile is derived from the target team's plan (enterprise team → enterprise child, else platform), or explicitly supplied. Both modes respond with the resulting organization-team link. This endpoint is in private beta. Contact your Vercel account team for access.
        /// </summary>
        /// <param name="organizationId">
        /// The ID of the organization to create or add a team under.
        /// </param>
        /// <param name="mode">
        /// Whether to create a new team under the organization (\"create\") or link an existing one (\"link\").
        /// </param>
        /// <param name="teamId">
        /// The ID of an existing team to add to the organization (link mode).
        /// </param>
        /// <param name="slug">
        /// The slug of an existing team to link, or the slug for a new team to create.
        /// </param>
        /// <param name="name">
        /// The display name for a new team. Required in create mode; rejected in link mode.
        /// </param>
        /// <param name="billingPlan"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OrganizationTeam> AddOrganizationTeamAsync(
            string organizationId,
            global::Vercel.AddOrganizationTeamRequestMode mode,
            string? teamId = default,
            string? slug = default,
            string? name = default,
            global::Vercel.AddOrganizationTeamRequestBillingPlan? billingPlan = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}