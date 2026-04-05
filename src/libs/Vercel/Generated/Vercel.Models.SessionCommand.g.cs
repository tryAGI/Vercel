
#nullable enable

namespace Vercel
{
    /// <summary>
    /// This object represents a command run in a Vercel Sandbox session (v2 API).
    /// </summary>
    public sealed partial class SessionCommand
    {
        /// <summary>
        /// The ID of the command.<br/>
        /// Example: cmd_123a6c5209bc3778245d011443644c8d27dc2c50
        /// </summary>
        /// <example>cmd_123a6c5209bc3778245d011443644c8d27dc2c50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the command.<br/>
        /// Example: npm
        /// </summary>
        /// <example>npm</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The arguments of the command.<br/>
        /// Example: [run, build]
        /// </summary>
        /// <example>[run, build]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Args { get; set; }

        /// <summary>
        /// The current working directory of the command.<br/>
        /// Example: /vercel/sandbox
        /// </summary>
        /// <example>/vercel/sandbox</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cwd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cwd { get; set; }

        /// <summary>
        /// The ID of the session associated with the command.<br/>
        /// Example: sbx_123a6c5209bc3778245d011443644c8d27dc2c50
        /// </summary>
        /// <example>sbx_123a6c5209bc3778245d011443644c8d27dc2c50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// If the command did finish, the exit code.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("exitCode")]
        public double? ExitCode { get; set; }

        /// <summary>
        /// When the command was started, in milliseconds since the epoch.<br/>
        /// Example: 1673123456789L
        /// </summary>
        /// <example>1673123456789L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionCommand" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the command.<br/>
        /// Example: cmd_123a6c5209bc3778245d011443644c8d27dc2c50
        /// </param>
        /// <param name="name">
        /// The name of the command.<br/>
        /// Example: npm
        /// </param>
        /// <param name="args">
        /// The arguments of the command.<br/>
        /// Example: [run, build]
        /// </param>
        /// <param name="cwd">
        /// The current working directory of the command.<br/>
        /// Example: /vercel/sandbox
        /// </param>
        /// <param name="sessionId">
        /// The ID of the session associated with the command.<br/>
        /// Example: sbx_123a6c5209bc3778245d011443644c8d27dc2c50
        /// </param>
        /// <param name="startedAt">
        /// When the command was started, in milliseconds since the epoch.<br/>
        /// Example: 1673123456789L
        /// </param>
        /// <param name="exitCode">
        /// If the command did finish, the exit code.<br/>
        /// Example: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionCommand(
            string id,
            string name,
            global::System.Collections.Generic.IList<string> args,
            string cwd,
            string sessionId,
            double startedAt,
            double? exitCode)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Args = args ?? throw new global::System.ArgumentNullException(nameof(args));
            this.Cwd = cwd ?? throw new global::System.ArgumentNullException(nameof(cwd));
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.ExitCode = exitCode;
            this.StartedAt = startedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionCommand" /> class.
        /// </summary>
        public SessionCommand()
        {
        }
    }
}