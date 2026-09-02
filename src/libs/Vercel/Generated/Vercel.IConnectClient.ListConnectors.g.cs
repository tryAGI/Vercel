#nullable enable

namespace Vercel
{
    public partial interface IConnectClient
    {
        /// <summary>
        /// List connectors<br/>
        /// List connectors that belong to a team.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of connectors to return. Defaults to 20.
        /// </param>
        /// <param name="cursor">
        /// Cursor from `pagination.next` on the previous response.
        /// </param>
        /// <param name="projectId">
        /// Return only connectors connected to this project.
        /// </param>
        /// <param name="search">
        /// Search connector names, UIDs, and services.
        /// </param>
        /// <param name="type">
        /// Comma-separated connector types: `slack`, `discord`, `github`, `linear`, `linq`, `salesforce`, `sendblue`, `snowflake`, `snowflake-wif`, `microsoft-entra`, `api-key`, `photon`, `oauth`, or `custom`.
        /// </param>
        /// <param name="service">
        /// Comma-separated provider or service identifiers.
        /// </param>
        /// <param name="sort">
        /// Sort by name in ascending order, or by creation or update time in descending order.
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.ConnectConnectorList> ListConnectorsAsync(
            int? limit = default,
            string? cursor = default,
            string? projectId = default,
            string? search = default,
            string? type = default,
            string? service = default,
            global::Vercel.ListConnectorsSort? sort = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List connectors<br/>
        /// List connectors that belong to a team.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of connectors to return. Defaults to 20.
        /// </param>
        /// <param name="cursor">
        /// Cursor from `pagination.next` on the previous response.
        /// </param>
        /// <param name="projectId">
        /// Return only connectors connected to this project.
        /// </param>
        /// <param name="search">
        /// Search connector names, UIDs, and services.
        /// </param>
        /// <param name="type">
        /// Comma-separated connector types: `slack`, `discord`, `github`, `linear`, `linq`, `salesforce`, `sendblue`, `snowflake`, `snowflake-wif`, `microsoft-entra`, `api-key`, `photon`, `oauth`, or `custom`.
        /// </param>
        /// <param name="service">
        /// Comma-separated provider or service identifiers.
        /// </param>
        /// <param name="sort">
        /// Sort by name in ascending order, or by creation or update time in descending order.
        /// </param>
        /// <param name="teamId">
        /// Example: team_1a2b3c4d5e6f7g8h9i0j1k2l
        /// </param>
        /// <param name="slug">
        /// Example: my-team-url-slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.ConnectConnectorList>> ListConnectorsAsResponseAsync(
            int? limit = default,
            string? cursor = default,
            string? projectId = default,
            string? search = default,
            string? type = default,
            string? service = default,
            global::Vercel.ListConnectorsSort? sort = default,
            string? teamId = default,
            string? slug = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}