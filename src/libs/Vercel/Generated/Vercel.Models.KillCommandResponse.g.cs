
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KillCommandResponse
    {
        /// <summary>
        /// This object represents command run in a Vercel Sandbox.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.SandboxCommand Command { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KillCommandResponse" /> class.
        /// </summary>
        /// <param name="command">
        /// This object represents command run in a Vercel Sandbox.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KillCommandResponse(
            global::Vercel.SandboxCommand command)
        {
            this.Command = command ?? throw new global::System.ArgumentNullException(nameof(command));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KillCommandResponse" /> class.
        /// </summary>
        public KillCommandResponse()
        {
        }
    }
}