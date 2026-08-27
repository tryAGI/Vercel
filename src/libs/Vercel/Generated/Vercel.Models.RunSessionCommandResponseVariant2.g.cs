
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RunSessionCommandResponseVariant2
    {
        /// <summary>
        /// This object represents a command run in a Vercel Sandbox session (v2 API).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.SessionCommand Command { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Stream { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunSessionCommandResponseVariant2" /> class.
        /// </summary>
        /// <param name="command">
        /// This object represents a command run in a Vercel Sandbox session (v2 API).
        /// </param>
        /// <param name="data"></param>
        /// <param name="stream"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunSessionCommandResponseVariant2(
            global::Vercel.SessionCommand command,
            string data,
            string stream)
        {
            this.Command = command ?? throw new global::System.ArgumentNullException(nameof(command));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Stream = stream ?? throw new global::System.ArgumentNullException(nameof(stream));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunSessionCommandResponseVariant2" /> class.
        /// </summary>
        public RunSessionCommandResponseVariant2()
        {
        }

    }
}