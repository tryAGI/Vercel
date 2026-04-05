
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExtendSessionTimeoutResponse
    {
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
        /// Initializes a new instance of the <see cref="ExtendSessionTimeoutResponse" /> class.
        /// </summary>
        /// <param name="session">
        /// This object contains information related to a Vercel Sandbox Session. v2 endpoints return "session" instead of "sandbox" as the response wrapper key.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtendSessionTimeoutResponse(
            global::Vercel.Session session)
        {
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendSessionTimeoutResponse" /> class.
        /// </summary>
        public ExtendSessionTimeoutResponse()
        {
        }
    }
}