
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListCommandsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commands")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.SandboxCommand> Commands { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCommandsResponse" /> class.
        /// </summary>
        /// <param name="commands"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListCommandsResponse(
            global::System.Collections.Generic.IList<global::Vercel.SandboxCommand> commands)
        {
            this.Commands = commands ?? throw new global::System.ArgumentNullException(nameof(commands));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCommandsResponse" /> class.
        /// </summary>
        public ListCommandsResponse()
        {
        }
    }
}