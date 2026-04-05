
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Represents an error encountered while parsing a value to match the schema
    /// </summary>
    public sealed partial class Issue
    {
        /// <summary>
        /// The path to the property where the issue occurred
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.PropertyKey> Path { get; set; }

        /// <summary>
        /// A descriptive message explaining the issue
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
        /// Initializes a new instance of the <see cref="Issue" /> class.
        /// </summary>
        /// <param name="path">
        /// The path to the property where the issue occurred
        /// </param>
        /// <param name="message">
        /// A descriptive message explaining the issue
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Issue(
            global::System.Collections.Generic.IList<global::Vercel.PropertyKey> path,
            string message)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Issue" /> class.
        /// </summary>
        public Issue()
        {
        }
    }
}