#nullable enable

namespace Vercel
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// Purchase credits<br/>
        /// Purchases credits for a Vercel team using the default payment method on file. The purchase is charged immediately via Stripe invoice. Supported credit types are `v0`, `gateway`, and `agent`. The `amount` field specifies the number of credits to purchase and must be a positive integer. An optional `source` query parameter can be provided to identify the caller. Defaults to `api` if not specified. This is only available for Owner, Member, Developer, Security, and Billing roles for the supplied team.
        /// </summary>
        /// <param name="source">
        /// The source of the purchase request. Defaults to `api` if not specified.
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
        /// <remarks>
        /// curl --request POST \<br/>
        ///   --url 'https://api.vercel.com/v1/billing/buy?teamId=&lt;team&gt;' \<br/>
        ///   --header 'Authorization: Bearer &lt;token&gt;' \<br/>
        ///   --header 'Content-Type: application/json' \<br/>
        ///   --data '{"item":{"type":"credits","creditType":"v0","amount":100}}'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::Vercel.BuyCreditsResponseVariant1, global::Vercel.BuyCreditsResponseVariant2, global::Vercel.BuyCreditsResponseVariant3>> BuyCreditsAsync(

            global::Vercel.BuyCreditsRequest request,
            string? source = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Purchase credits<br/>
        /// Purchases credits for a Vercel team using the default payment method on file. The purchase is charged immediately via Stripe invoice. Supported credit types are `v0`, `gateway`, and `agent`. The `amount` field specifies the number of credits to purchase and must be a positive integer. An optional `source` query parameter can be provided to identify the caller. Defaults to `api` if not specified. This is only available for Owner, Member, Developer, Security, and Billing roles for the supplied team.
        /// </summary>
        /// <param name="source">
        /// The source of the purchase request. Defaults to `api` if not specified.
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="item"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.OneOf<global::Vercel.BuyCreditsResponseVariant1, global::Vercel.BuyCreditsResponseVariant2, global::Vercel.BuyCreditsResponseVariant3>> BuyCreditsAsync(
            global::Vercel.BuyCreditsRequestItem item,
            string? source = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}