
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateSandboxResponse
    {
        /// <summary>
        /// This object contains information related to a Vercel NamedSandbox.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandbox")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.NamedSandbox Sandbox { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSandboxResponse" /> class.
        /// </summary>
        /// <param name="sandbox">
        /// This object contains information related to a Vercel NamedSandbox.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSandboxResponse(
            global::Vercel.NamedSandbox sandbox)
        {
            this.Sandbox = sandbox ?? throw new global::System.ArgumentNullException(nameof(sandbox));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSandboxResponse" /> class.
        /// </summary>
        public UpdateSandboxResponse()
        {
        }
    }
}