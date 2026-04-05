
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExtendSandboxTimeoutRequest
    {
        /// <summary>
        /// The amount of time in milliseconds to add to the current timeout. Must be at least 1000ms (1 second).<br/>
        /// Example: 300000
        /// </summary>
        /// <example>300000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendSandboxTimeoutRequest" /> class.
        /// </summary>
        /// <param name="duration">
        /// The amount of time in milliseconds to add to the current timeout. Must be at least 1000ms (1 second).<br/>
        /// Example: 300000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtendSandboxTimeoutRequest(
            double duration)
        {
            this.Duration = duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendSandboxTimeoutRequest" /> class.
        /// </summary>
        public ExtendSandboxTimeoutRequest()
        {
        }
    }
}