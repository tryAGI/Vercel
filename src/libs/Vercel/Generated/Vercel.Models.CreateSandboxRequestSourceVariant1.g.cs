
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Clone a Git repository into the sandbox.
    /// </summary>
    public sealed partial class CreateSandboxRequestSourceVariant1
    {
        /// <summary>
        /// Indicates the source is a Git repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// The URL of the Git repository to clone.<br/>
        /// Example: https://github.com/vercel/next.js.git
        /// </summary>
        /// <example>https://github.com/vercel/next.js.git</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Username for Git authentication. Required together with password for private repositories.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// Password or personal access token for Git authentication. Required together with username for private repositories.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        /// Create a shallow clone with history truncated to the specified number of commits. Useful for faster cloning of large repositories.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("depth")]
        public int? Depth { get; set; }

        /// <summary>
        /// The specific commit SHA, branch name, or tag to checkout after cloning.<br/>
        /// Example: main
        /// </summary>
        /// <example>main</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision")]
        public string? Revision { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxRequestSourceVariant1" /> class.
        /// </summary>
        /// <param name="type">
        /// Indicates the source is a Git repository.
        /// </param>
        /// <param name="url">
        /// The URL of the Git repository to clone.<br/>
        /// Example: https://github.com/vercel/next.js.git
        /// </param>
        /// <param name="username">
        /// Username for Git authentication. Required together with password for private repositories.
        /// </param>
        /// <param name="password">
        /// Password or personal access token for Git authentication. Required together with username for private repositories.
        /// </param>
        /// <param name="depth">
        /// Create a shallow clone with history truncated to the specified number of commits. Useful for faster cloning of large repositories.<br/>
        /// Example: 1
        /// </param>
        /// <param name="revision">
        /// The specific commit SHA, branch name, or tag to checkout after cloning.<br/>
        /// Example: main
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSandboxRequestSourceVariant1(
            object type,
            string url,
            string? username,
            string? password,
            int? depth,
            string? revision)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Username = username;
            this.Password = password;
            this.Depth = depth;
            this.Revision = revision;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSandboxRequestSourceVariant1" /> class.
        /// </summary>
        public CreateSandboxRequestSourceVariant1()
        {
        }
    }
}