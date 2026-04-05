
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExtendSandboxTimeoutResponse
    {
        /// <summary>
        /// This object contains information related to a Vercel Sandbox.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandbox")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.Sandbox Sandbox { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendSandboxTimeoutResponse" /> class.
        /// </summary>
        /// <param name="sandbox">
        /// This object contains information related to a Vercel Sandbox.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtendSandboxTimeoutResponse(
            global::Vercel.Sandbox sandbox)
        {
            this.Sandbox = sandbox ?? throw new global::System.ArgumentNullException(nameof(sandbox));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendSandboxTimeoutResponse" /> class.
        /// </summary>
        public ExtendSandboxTimeoutResponse()
        {
        }
    }
}