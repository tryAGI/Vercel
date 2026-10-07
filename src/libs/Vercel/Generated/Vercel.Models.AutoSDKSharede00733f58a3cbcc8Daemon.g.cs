
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Set when this build produces the named daemon.
    /// </summary>
    public sealed partial class AutoSDKSharede00733f58a3cbcc8Daemon
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        public global::System.Collections.Generic.IList<string>? Command { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entrypoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Entrypoint { get; set; }

        /// <summary>
        /// Replica counts by region.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, double> Replicas { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        public global::Vercel.AutoSDKSharede00733f58a3cbcc8DaemonResources? Resources { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("root")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Root { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede00733f58a3cbcc8Daemon" /> class.
        /// </summary>
        /// <param name="entrypoint"></param>
        /// <param name="replicas">
        /// Replica counts by region.
        /// </param>
        /// <param name="root"></param>
        /// <param name="name"></param>
        /// <param name="command"></param>
        /// <param name="resources"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharede00733f58a3cbcc8Daemon(
            string entrypoint,
            global::System.Collections.Generic.Dictionary<string, double> replicas,
            string root,
            string name,
            global::System.Collections.Generic.IList<string>? command,
            global::Vercel.AutoSDKSharede00733f58a3cbcc8DaemonResources? resources)
        {
            this.Command = command;
            this.Entrypoint = entrypoint ?? throw new global::System.ArgumentNullException(nameof(entrypoint));
            this.Replicas = replicas ?? throw new global::System.ArgumentNullException(nameof(replicas));
            this.Resources = resources;
            this.Root = root ?? throw new global::System.ArgumentNullException(nameof(root));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede00733f58a3cbcc8Daemon" /> class.
        /// </summary>
        public AutoSDKSharede00733f58a3cbcc8Daemon()
        {
        }

    }
}