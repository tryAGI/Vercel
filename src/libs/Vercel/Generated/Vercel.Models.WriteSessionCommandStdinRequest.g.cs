
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WriteSessionCommandStdinRequest
    {
        /// <summary>
        /// Base64-encoded bytes to write to the command stdin. The request body is limited to 1 MB, so send at most about 700 KB of data per request.<br/>
        /// Example: aGVsbG8K
        /// </summary>
        /// <example>aGVsbG8K</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public string? Data { get; set; }

        /// <summary>
        /// The position in the command stdin where `data` starts. Bytes before the total already written are skipped, so a resent request does not write them twice. Fails with 409 if it is past the bytes written so far. Without it, `data` is appended.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// If true, closes the command stdin after writing `data`. Use this for commands that wait for end of input.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("close")]
        public bool? Close { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WriteSessionCommandStdinRequest" /> class.
        /// </summary>
        /// <param name="data">
        /// Base64-encoded bytes to write to the command stdin. The request body is limited to 1 MB, so send at most about 700 KB of data per request.<br/>
        /// Example: aGVsbG8K
        /// </param>
        /// <param name="offset">
        /// The position in the command stdin where `data` starts. Bytes before the total already written are skipped, so a resent request does not write them twice. Fails with 409 if it is past the bytes written so far. Without it, `data` is appended.<br/>
        /// Example: 0
        /// </param>
        /// <param name="close">
        /// If true, closes the command stdin after writing `data`. Use this for commands that wait for end of input.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WriteSessionCommandStdinRequest(
            string? data,
            int? offset,
            bool? close)
        {
            this.Data = data;
            this.Offset = offset;
            this.Close = close;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WriteSessionCommandStdinRequest" /> class.
        /// </summary>
        public WriteSessionCommandStdinRequest()
        {
        }

    }
}