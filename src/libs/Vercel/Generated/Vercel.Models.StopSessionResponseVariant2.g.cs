
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StopSessionResponseVariant2
    {
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
        /// Initializes a new instance of the <see cref="StopSessionResponseVariant2" /> class.
        /// </summary>
        /// <param name="sandbox">
        /// This object contains information related to a Vercel NamedSandbox.
        /// </param>
        /// <param name="session">
        /// This object contains information related to a Vercel Sandbox Session. v2 endpoints return "session" instead of "sandbox" as the response wrapper key.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StopSessionResponseVariant2(
            global::Vercel.NamedSandbox sandbox,
            global::Vercel.Session session)
        {
            this.Sandbox = sandbox ?? throw new global::System.ArgumentNullException(nameof(sandbox));
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StopSessionResponseVariant2" /> class.
        /// </summary>
        public StopSessionResponseVariant2()
        {
        }
    }
}