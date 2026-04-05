
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDeploymentResponseImagesRemotePattern
    {
        /// <summary>
        /// Must be `http` or `https`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protocol")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CreateDeploymentResponseImagesRemotePatternProtocolJsonConverter))]
        public global::Vercel.CreateDeploymentResponseImagesRemotePatternProtocol? Protocol { get; set; }

        /// <summary>
        /// Can be literal or wildcard. Single `*` matches a single subdomain. Double `**` matches any number of subdomains.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hostname { get; set; }

        /// <summary>
        /// Can be literal port such as `8080` or empty string meaning no port.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("port")]
        public string? Port { get; set; }

        /// <summary>
        /// Can be literal or wildcard. Single `*` matches a single path segment. Double `**` matches any number of path segments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pathname")]
        public string? Pathname { get; set; }

        /// <summary>
        /// Can be literal query string such as `?v=1` or empty string meaning no query string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search")]
        public string? Search { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseImagesRemotePattern" /> class.
        /// </summary>
        /// <param name="hostname">
        /// Can be literal or wildcard. Single `*` matches a single subdomain. Double `**` matches any number of subdomains.
        /// </param>
        /// <param name="protocol">
        /// Must be `http` or `https`.
        /// </param>
        /// <param name="port">
        /// Can be literal port such as `8080` or empty string meaning no port.
        /// </param>
        /// <param name="pathname">
        /// Can be literal or wildcard. Single `*` matches a single path segment. Double `**` matches any number of path segments.
        /// </param>
        /// <param name="search">
        /// Can be literal query string such as `?v=1` or empty string meaning no query string.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeploymentResponseImagesRemotePattern(
            string hostname,
            global::Vercel.CreateDeploymentResponseImagesRemotePatternProtocol? protocol,
            string? port,
            string? pathname,
            string? search)
        {
            this.Protocol = protocol;
            this.Hostname = hostname ?? throw new global::System.ArgumentNullException(nameof(hostname));
            this.Port = port;
            this.Pathname = pathname;
            this.Search = search;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeploymentResponseImagesRemotePattern" /> class.
        /// </summary>
        public CreateDeploymentResponseImagesRemotePattern()
        {
        }
    }
}