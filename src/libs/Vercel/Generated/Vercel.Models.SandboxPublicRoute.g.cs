
#nullable enable

namespace Vercel
{
    /// <summary>
    /// This object represents a public route in a Vercel Sandbox.
    /// </summary>
    public sealed partial class SandboxPublicRoute
    {
        /// <summary>
        /// A public URL to access the corresponding port in the Sandbox.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The user port number that the route is mapped to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("port")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Port { get; set; }

        /// <summary>
        /// The subdomain assigned to this route.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subdomain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Subdomain { get; set; }

        /// <summary>
        /// Whether the route is reserved by the system (e.g. for internal use).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        public bool? System { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxPublicRoute" /> class.
        /// </summary>
        /// <param name="url">
        /// A public URL to access the corresponding port in the Sandbox.
        /// </param>
        /// <param name="port">
        /// The user port number that the route is mapped to.
        /// </param>
        /// <param name="subdomain">
        /// The subdomain assigned to this route.
        /// </param>
        /// <param name="system">
        /// Whether the route is reserved by the system (e.g. for internal use).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxPublicRoute(
            string url,
            double port,
            string subdomain,
            bool? system)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Port = port;
            this.Subdomain = subdomain ?? throw new global::System.ArgumentNullException(nameof(subdomain));
            this.System = system;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxPublicRoute" /> class.
        /// </summary>
        public SandboxPublicRoute()
        {
        }
    }
}