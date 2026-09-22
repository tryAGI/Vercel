
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateSandboxResponseVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resumed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Resumed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.SandboxPublicRoute> Routes { get; set; }

        /// <summary>
        /// This object contains information related to a Vercel NamedSandbox.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandbox")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.NamedSandbox Sandbox { get; set; }

        /// <summary>
        /// This object contains information related to a Vercel Sandbox Session. v2 endpoints return "session" instead of "sandbox" as the response wrapper key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.Session Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSandboxResponseVariant2" /> class.
        /// </summary>
        /// <param name="resumed"></param>
        /// <param name="routes"></param>
        /// <param name="sandbox">
        /// This object contains information related to a Vercel NamedSandbox.
        /// </param>
        /// <param name="session">
        /// This object contains information related to a Vercel Sandbox Session. v2 endpoints return "session" instead of "sandbox" as the response wrapper key.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSandboxResponseVariant2(
            bool resumed,
            global::System.Collections.Generic.IList<global::Vercel.SandboxPublicRoute> routes,
            global::Vercel.NamedSandbox sandbox,
            global::Vercel.Session session)
        {
            this.Resumed = resumed;
            this.Routes = routes ?? throw new global::System.ArgumentNullException(nameof(routes));
            this.Sandbox = sandbox ?? throw new global::System.ArgumentNullException(nameof(sandbox));
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSandboxResponseVariant2" /> class.
        /// </summary>
        public UpdateSandboxResponseVariant2()
        {
        }

    }
}