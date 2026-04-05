
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KillSessionCommandRequest
    {
        /// <summary>
        /// The POSIX signal number to send to the process. Common values: 15 (SIGTERM) for graceful termination, 9 (SIGKILL) for forced termination.<br/>
        /// Example: 15
        /// </summary>
        /// <example>15</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("signal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Signal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KillSessionCommandRequest" /> class.
        /// </summary>
        /// <param name="signal">
        /// The POSIX signal number to send to the process. Common values: 15 (SIGTERM) for graceful termination, 9 (SIGKILL) for forced termination.<br/>
        /// Example: 15
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KillSessionCommandRequest(
            double signal)
        {
            this.Signal = signal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KillSessionCommandRequest" /> class.
        /// </summary>
        public KillSessionCommandRequest()
        {
        }
    }
}