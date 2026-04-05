#nullable enable

namespace Vercel
{
    public partial interface IConnectClient
    {
        /// <summary>
        /// Delete a Secure Compute network<br/>
        /// Allows to delete a Secure Compute network.
        /// </summary>
        /// <param name="networkId">
        /// The ID of the network to delete<br/>
        /// Example: uzrmorq7bn05z-fz
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteNetworkAsync(
            string networkId,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}