
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSessionCommandResponse
    {
        /// <summary>
        /// This object represents a command run in a Vercel Sandbox session (v2 API).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.SessionCommand Command { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSessionCommandResponse" /> class.
        /// </summary>
        /// <param name="command">
        /// This object represents a command run in a Vercel Sandbox session (v2 API).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSessionCommandResponse(
            global::Vercel.SessionCommand command)
        {
            this.Command = command ?? throw new global::System.ArgumentNullException(nameof(command));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSessionCommandResponse" /> class.
        /// </summary>
        public GetSessionCommandResponse()
        {
        }
    }
}