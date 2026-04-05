
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunSessionCommandRequest
    {
        /// <summary>
        /// The executable or shell command to run. This is the program name without arguments.<br/>
        /// Example: npm
        /// </summary>
        /// <example>npm</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Command { get; set; }

        /// <summary>
        /// Arguments to pass to the command. Each argument should be a separate array element.<br/>
        /// Example: [install, --save, lodash]
        /// </summary>
        /// <example>[install, --save, lodash]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        public global::System.Collections.Generic.IList<string>? Args { get; set; }

        /// <summary>
        /// The working directory in which to execute the command. Defaults to the sandbox home directory if not specified.<br/>
        /// Example: /home/vercel-sandbox
        /// </summary>
        /// <example>/home/vercel-sandbox</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cwd")]
        public string? Cwd { get; set; }

        /// <summary>
        /// Additional environment variables to set for this command. These are merged with the sandbox environment.<br/>
        /// Default Value: {}<br/>
        /// Example: {"NODE_ENV":"production","DEBUG":"true"}
        /// </summary>
        /// <example>{"NODE_ENV":"production","DEBUG":"true"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        public global::System.Collections.Generic.Dictionary<string, string>? Env { get; set; }

        /// <summary>
        /// Execute the command with root (superuser) privileges.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sudo")]
        public bool? Sudo { get; set; }

        /// <summary>
        /// If true, returns an ND-JSON stream that emits the command status when started and again when finished. Useful for synchronously waiting for command completion.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wait")]
        public bool? Wait { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunSessionCommandRequest" /> class.
        /// </summary>
        /// <param name="command">
        /// The executable or shell command to run. This is the program name without arguments.<br/>
        /// Example: npm
        /// </param>
        /// <param name="args">
        /// Arguments to pass to the command. Each argument should be a separate array element.<br/>
        /// Example: [install, --save, lodash]
        /// </param>
        /// <param name="cwd">
        /// The working directory in which to execute the command. Defaults to the sandbox home directory if not specified.<br/>
        /// Example: /home/vercel-sandbox
        /// </param>
        /// <param name="env">
        /// Additional environment variables to set for this command. These are merged with the sandbox environment.<br/>
        /// Default Value: {}<br/>
        /// Example: {"NODE_ENV":"production","DEBUG":"true"}
        /// </param>
        /// <param name="sudo">
        /// Execute the command with root (superuser) privileges.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="wait">
        /// If true, returns an ND-JSON stream that emits the command status when started and again when finished. Useful for synchronously waiting for command completion.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunSessionCommandRequest(
            string command,
            global::System.Collections.Generic.IList<string>? args,
            string? cwd,
            global::System.Collections.Generic.Dictionary<string, string>? env,
            bool? sudo,
            bool? wait)
        {
            this.Command = command ?? throw new global::System.ArgumentNullException(nameof(command));
            this.Args = args;
            this.Cwd = cwd;
            this.Env = env;
            this.Sudo = sudo;
            this.Wait = wait;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunSessionCommandRequest" /> class.
        /// </summary>
        public RunSessionCommandRequest()
        {
        }
    }
}