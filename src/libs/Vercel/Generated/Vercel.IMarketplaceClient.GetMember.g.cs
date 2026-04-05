#nullable enable

namespace Vercel
{
    public partial interface IMarketplaceClient
    {
        /// <summary>
        /// Get Member Information<br/>
        /// Returns the member role and other information for a given member ID ("user_id" claim in the SSO OIDC token).
        /// </summary>
        /// <param name="integrationConfigurationId"></param>
        /// <param name="memberId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.GetMemberResponse> GetMemberAsync(
            string integrationConfigurationId,
            string memberId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}