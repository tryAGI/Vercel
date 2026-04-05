#nullable enable

namespace Vercel
{
    public partial interface ILogDrainsClient
    {
        /// <summary>
        /// Creates a new Integration Log Drain (deprecated)<br/>
        /// Creates an Integration log drain. This endpoint must be called with an OAuth2 client (integration), since log drains are tied to integrations. If it is called with a different token type it will produce a 400 error.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateLogDrainResponse> CreateLogDrainAsync(

            global::Vercel.CreateLogDrainRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new Integration Log Drain (deprecated)<br/>
        /// Creates an Integration log drain. This endpoint must be called with an OAuth2 client (integration), since log drains are tied to integrations. If it is called with a different token type it will produce a 400 error.
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="name">
        /// The name of the log drain<br/>
        /// Example: My first log drain
        /// </param>
        /// <param name="projectIds"></param>
        /// <param name="secret">
        /// A secret to sign log drain notification headers so a consumer can verify their authenticity<br/>
        /// Example: a1Xsfd325fXcs
        /// </param>
        /// <param name="deliveryFormat">
        /// The delivery log format<br/>
        /// Example: json
        /// </param>
        /// <param name="url">
        /// The url where you will receive logs. The protocol must be `https://` or `http://` when type is `json` and `ndjson`.<br/>
        /// Example: https://example.com/log-drain
        /// </param>
        /// <param name="sources"></param>
        /// <param name="headers">
        /// Headers to be sent together with the request
        /// </param>
        /// <param name="environments"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateLogDrainResponse> CreateLogDrainAsync(
            string name,
            string url,
            string? teamId = default,
            string? slug = default,
            global::System.Collections.Generic.IList<string>? projectIds = default,
            string? secret = default,
            global::Vercel.CreateLogDrainRequestDeliveryFormat? deliveryFormat = default,
            global::System.Collections.Generic.IList<global::Vercel.CreateLogDrainRequestSource>? sources = default,
            global::System.Collections.Generic.Dictionary<string, string>? headers = default,
            global::System.Collections.Generic.IList<global::Vercel.CreateLogDrainRequestEnvironment>? environments = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}