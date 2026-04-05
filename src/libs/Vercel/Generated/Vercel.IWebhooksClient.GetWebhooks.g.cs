#nullable enable

namespace Vercel
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Get a list of webhooks<br/>
        /// Get a list of webhooks
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.GetWebhooksResponseVariant1Item>, global::System.Collections.Generic.IList<global::Vercel.GetWebhooksResponseVariant2Item>>> GetWebhooksAsync(
            string? projectId = default,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}