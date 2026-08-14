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
        /// Known types: api-key, github, linear, linq, oauth, photon, salesforce, slack, snowflake. Optional when \"connectionMethod\" is set.
        /// </param>
        /// <param name="service">
        /// Service slug or URL for which the connector is used.
        /// </param>
        /// <param name="connectionMethod">
        /// Connection method slug of the service.
        /// </param>
        /// <param name="params">
        /// Values for the connection method's templateFields.
        /// </param>
        /// <param name="target">
        /// Which of the service's targets this connector is for. Requires \"connectionMethod\" and must be one that method serves. Optional.
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
        /// <param name="triggerDestination">
        /// Initial trigger destination routing for the linked project.
        /// </param>
        /// <param name="events">
        /// The list of the defaults trigger events for this connector.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vercel.CreateConnectorResponse> CreateConnectorAsync(
            global::Vercel.AnyOf<global::Vercel.CreateConnectorRequestDataTypeOauth, global::Vercel.CreateConnectorRequestDataTypeApiKey, global::Vercel.CreateConnectorRequestDataTypeGithub, global::Vercel.CreateConnectorRequestDataTypeLinear, global::Vercel.CreateConnectorRequestDataTypeLinq, global::Vercel.CreateConnectorRequestDataTypeSalesforce, global::Vercel.CreateConnectorRequestDataTypeSlack, global::Vercel.CreateConnectorRequestDataTypeSnowflake, global::Vercel.CreateConnectorRequestDataTypeSnowflakeWif, global::Vercel.CreateConnectorRequestDataTypePhoton, object> data,
            string? icon = default,
            string? backgroundColor = default,
            string? accentColor = default,
            string? type = default,
            string? service = default,
            string? connectionMethod = default,
            global::System.Collections.Generic.Dictionary<string, string>? @params = default,
            string? target = default,
            string? uid = default,
            string? name = default,
            string? projectId = default,
            global::System.Collections.Generic.IList<string>? environments = default,
            bool? triggers = default,
            global::Vercel.CreateConnectorRequestTriggerDestination? triggerDestination = default,
            global::System.Collections.Generic.IList<string>? events = default,
            global::Vercel.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}