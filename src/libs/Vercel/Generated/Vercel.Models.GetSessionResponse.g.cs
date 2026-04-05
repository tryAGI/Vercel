
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSessionResponse
    {
        /// <summary>
        /// This object contains information related to a Vercel Sandbox Session. v2 endpoints return "session" instead of "sandbox" as the response wrapper key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.Session Session { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.SandboxPublicRoute> Routes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSessionResponse" /> class.
        /// </summary>
        /// <param name="session">
        /// This object contains information related to a Vercel Sandbox Session. v2 endpoints return "session" instead of "sandbox" as the response wrapper key.
        /// </param>
        /// <param name="routes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSessionResponse(
            global::Vercel.Session session,
            global::System.Collections.Generic.IList<global::Vercel.SandboxPublicRoute> routes)
        {
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
            this.Routes = routes ?? throw new global::System.ArgumentNullException(nameof(routes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSessionResponse" /> class.
        /// </summary>
        public GetSessionResponse()
        {
        }
    }
}