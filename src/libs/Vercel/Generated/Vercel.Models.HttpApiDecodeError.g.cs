
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The request did not match the expected schema
    /// </summary>
    public sealed partial class HttpApiDecodeError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.Issue> Issues { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpApiDecodeError" /> class.
        /// </summary>
        /// <param name="issues"></param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HttpApiDecodeError(
            global::System.Collections.Generic.IList<global::Vercel.Issue> issues,
            string message)
        {
            this.Issues = issues ?? throw new global::System.ArgumentNullException(nameof(issues));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpApiDecodeError" /> class.
        /// </summary>
        public HttpApiDecodeError()
        {
        }
    }
}