#nullable enable

namespace Vercel
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Update an Organization<br/>
        /// Update an organization's slug or avatar. Upload avatar images through the existing files API before setting their hash. The organization avatar is independent of the root team's avatar. This endpoint is in private beta. Contact your Vercel account team for access.
        /// </summary>
        /// <param name="organizationId">
        /// The ID of the organization to update.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.Organization> UpdateOrganizationAsync(
            string organizationId,

            global::Vercel.UpdateOrganizationRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an Organization<br/>
        /// Update an organization's slug or avatar. Upload avatar images through the existing files API before setting their hash. The organization avatar is independent of the root team's avatar. This endpoint is in private beta. Contact your Vercel account team for access.
        /// </summary>
        /// <param name="organizationId">
        /// The ID of the organization to update.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.Organization>> UpdateOrganizationAsResponseAsync(
            string organizationId,

            global::Vercel.UpdateOrganizationRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an Organization<br/>
        /// Update an organization's slug or avatar. Upload avatar images through the existing files API before setting their hash. The organization avatar is independent of the root team's avatar. This endpoint is in private beta. Contact your Vercel account team for access.
        /// </summary>
        /// <param name="organizationId">
        /// The ID of the organization to update.
        /// </param>
        /// <param name="avatar">
        /// The hash value of an uploaded image, or `null` to clear the organization avatar. Omit to leave it unchanged.
        /// </param>
        /// <param name="slug">
        /// The new slug for the organization.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.Organization> UpdateOrganizationAsync(
            string organizationId,
            string? avatar = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}