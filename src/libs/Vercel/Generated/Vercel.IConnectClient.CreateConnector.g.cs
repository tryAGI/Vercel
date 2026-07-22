#nullable enable

namespace Vercel
{
    public partial interface IConnectClient
    {
        /// <summary>
        /// Create a connector<br/>
        /// Create a connector from type-specific configuration and optionally link it to a project during creation.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateConnectorResponse> CreateConnectorAsync(

            global::Vercel.CreateConnectorRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a connector<br/>
        /// Create a connector from type-specific configuration and optionally link it to a project during creation.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vercel.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.AutoSDKHttpResponse<global::Vercel.CreateConnectorResponse>> CreateConnectorAsResponseAsync(

            global::Vercel.CreateConnectorRequest request,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a connector<br/>
        /// Create a connector from type-specific configuration and optionally link it to a project during creation.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="icon"></param>
        /// <param name="backgroundColor"></param>
        /// <param name="accentColor"></param>
        /// <param name="type">
        /// Known types: api-key, github, linear, oauth, salesforce, slack, snowflake.
        /// </param>
        /// <param name="service">
        /// Service slug or URL for which the connector is used.
        /// </param>
        /// <param name="uid"></param>
        /// <param name="name"></param>
        /// <param name="projectId">
        /// Link to the specified project when specified. See environments.
        /// </param>
        /// <param name="environments">
        /// Use these built-in environment names or stable custom environment IDs when linking to projectId.
        /// </param>
        /// <param name="triggers">
        /// Whether the triggers are enabled for this connector.
        /// </param>
        /// <param name="events">
        /// The list of the defaults trigger events for this connector.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateConnectorResponse> CreateConnectorAsync(
            global::Vercel.AnyOf<global::Vercel.CreateConnectorRequestDataTypeOauth, global::Vercel.CreateConnectorRequestDataTypeApiKey, global::Vercel.CreateConnectorRequestDataTypeGithub, global::Vercel.CreateConnectorRequestDataTypeLinear, global::Vercel.CreateConnectorRequestDataTypeSalesforce, global::Vercel.CreateConnectorRequestDataTypeSlack, global::Vercel.CreateConnectorRequestDataTypeSnowflake, global::Vercel.CreateConnectorRequestDataTypeSnowflakeWif, object> data,
            string type,
            string? icon = default,
            string? backgroundColor = default,
            string? accentColor = default,
            string? service = default,
            string? uid = default,
            string? name = default,
            string? projectId = default,
            global::System.Collections.Generic.IList<string>? environments = default,
            bool? triggers = default,
            global::System.Collections.Generic.IList<string>? events = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}