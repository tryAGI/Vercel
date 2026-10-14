
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Set when this build produces the named daemon.
    /// </summary>
    public sealed partial class AutoSDKShared4fe620b22113d16cDaemon
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
        /// Instance counts by region.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instances")]
        public global::System.Collections.Generic.Dictionary<string, double>? Instances { get; set; }

        /// <summary>
        /// Instance counts by region.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicas")]
        public global::System.Collections.Generic.Dictionary<string, double>? Replicas { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        public global::Vercel.AutoSDKShared4fe620b22113d16cDaemonResources? Resources { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("root")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Root { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terminationGracePeriodSeconds")]
        public double? TerminationGracePeriodSeconds { get; set; }

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
        /// Initializes a new instance of the <see cref="AutoSDKShared4fe620b22113d16cDaemon" /> class.
        /// </summary>
        /// <param name="entrypoint"></param>
        /// <param name="root"></param>
        /// <param name="name"></param>
        /// <param name="command"></param>
        /// <param name="instances">
        /// Instance counts by region.
        /// </param>
        /// <param name="replicas">
        /// Instance counts by region.
        /// </param>
        /// <param name="resources"></param>
        /// <param name="terminationGracePeriodSeconds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared4fe620b22113d16cDaemon(
            string entrypoint,
            string root,
            string name,
            global::System.Collections.Generic.IList<string>? command,
            global::System.Collections.Generic.Dictionary<string, double>? instances,
            global::System.Collections.Generic.Dictionary<string, double>? replicas,
            global::Vercel.AutoSDKShared4fe620b22113d16cDaemonResources? resources,
            double? terminationGracePeriodSeconds)
        {
            this.Command = command;
            this.Entrypoint = entrypoint ?? throw new global::System.ArgumentNullException(nameof(entrypoint));
            this.Instances = instances;
            this.Replicas = replicas;
            this.Resources = resources;
            this.Root = root ?? throw new global::System.ArgumentNullException(nameof(root));
            this.TerminationGracePeriodSeconds = terminationGracePeriodSeconds;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared4fe620b22113d16cDaemon" /> class.
        /// </summary>
        public AutoSDKShared4fe620b22113d16cDaemon()
        {
        }

    }
}