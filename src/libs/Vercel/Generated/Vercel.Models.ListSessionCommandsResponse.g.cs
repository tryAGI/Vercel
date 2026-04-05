
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListSessionCommandsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commands")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.SessionCommand> Commands { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSessionCommandsResponse" /> class.
        /// </summary>
        /// <param name="commands"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListSessionCommandsResponse(
            global::System.Collections.Generic.IList<global::Vercel.SessionCommand> commands)
        {
            this.Commands = commands ?? throw new global::System.ArgumentNullException(nameof(commands));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSessionCommandsResponse" /> class.
        /// </summary>
        public ListSessionCommandsResponse()
        {
        }
    }
}