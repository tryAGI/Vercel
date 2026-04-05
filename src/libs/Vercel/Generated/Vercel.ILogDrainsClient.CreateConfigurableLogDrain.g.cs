#nullable enable

namespace Vercel
{
    public partial interface ILogDrainsClient
    {
        /// <summary>
        /// Creates a Configurable Log Drain (deprecated)<br/>
        /// Creates a configurable log drain. This endpoint must be called with a team AccessToken (integration OAuth2 clients are not allowed)
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
        global::System.Threading.Tasks.Task<string> CreateConfigurableLogDrainAsync(

            global::Vercel.CreateConfigurableLogDrainRequest request,
            string? teamId = default,
            string? slug = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a Configurable Log Drain (deprecated)<br/>
        /// Creates a configurable log drain. This endpoint must be called with a team AccessToken (integration OAuth2 clients are not allowed)
        /// </summary>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="deliveryFormat">
        /// The delivery log format<br/>
        /// Example: json
        /// </param>
        /// <param name="url">
        /// The log drain url
        /// </param>
        /// <param name="headers">
        /// Headers to be sent together with the request
        /// </param>
        /// <param name="projectIds"></param>
        /// <param name="sources"></param>
        /// <param name="environments"></param>
        /// <param name="secret">
        /// Custom secret of log drain
        /// </param>
        /// <param name="samplingRate">
        /// The sampling rate for this log drain. It should be a percentage rate between 0 and 100. With max 2 decimal points
        /// </param>
        /// <param name="name">
        /// The custom name of this log drain.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateConfigurableLogDrainAsync(
            global::Vercel.CreateConfigurableLogDrainRequestDeliveryFormat deliveryFormat,
            string url,
            global::System.Collections.Generic.IList<global::Vercel.CreateConfigurableLogDrainRequestSource> sources,
            string? teamId = default,
            string? slug = default,
            global::System.Collections.Generic.Dictionary<string, string>? headers = default,
            global::System.Collections.Generic.IList<string>? projectIds = default,
            global::System.Collections.Generic.IList<global::Vercel.CreateConfigurableLogDrainRequestEnvironment>? environments = default,
            string? secret = default,
            double? samplingRate = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}