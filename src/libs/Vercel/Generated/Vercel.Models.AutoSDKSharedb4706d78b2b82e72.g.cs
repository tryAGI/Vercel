
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Set when this build produces the named daemon.
    /// </summary>
    public sealed partial class AutoSDKSharedb4706d78b2b82e72
    {
        /// <summary>
        /// Bindings to services in the same deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bindings")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedb4706d78b2b82e72Binding>? Bindings { get; set; }

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
        /// A Kubernetes-style HTTP liveness probe.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("livenessProbe")]
        public global::Vercel.AutoSDKSharedb4706d78b2b82e72LivenessProbe? LivenessProbe { get; set; }

        /// <summary>
        /// Instance counts by region.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicas")]
        public global::System.Collections.Generic.Dictionary<string, double>? Replicas { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        public global::Vercel.AutoSDKSharedb4706d78b2b82e72Resources? Resources { get; set; }

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
        /// Initializes a new instance of the <see cref="AutoSDKSharedb4706d78b2b82e72" /> class.
        /// </summary>
        /// <param name="entrypoint"></param>
        /// <param name="root"></param>
        /// <param name="name"></param>
        /// <param name="bindings">
        /// Bindings to services in the same deployment.
        /// </param>
        /// <param name="command"></param>
        /// <param name="instances">
        /// Instance counts by region.
        /// </param>
        /// <param name="livenessProbe">
        /// A Kubernetes-style HTTP liveness probe.
        /// </param>
        /// <param name="replicas">
        /// Instance counts by region.
        /// </param>
        /// <param name="resources"></param>
        /// <param name="terminationGracePeriodSeconds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedb4706d78b2b82e72(
            string entrypoint,
            string root,
            string name,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedb4706d78b2b82e72Binding>? bindings,
            global::System.Collections.Generic.IList<string>? command,
            global::System.Collections.Generic.Dictionary<string, double>? instances,
            global::Vercel.AutoSDKSharedb4706d78b2b82e72LivenessProbe? livenessProbe,
            global::System.Collections.Generic.Dictionary<string, double>? replicas,
            global::Vercel.AutoSDKSharedb4706d78b2b82e72Resources? resources,
            double? terminationGracePeriodSeconds)
        {
            this.Bindings = bindings;
            this.Command = command;
            this.Entrypoint = entrypoint ?? throw new global::System.ArgumentNullException(nameof(entrypoint));
            this.Instances = instances;
            this.LivenessProbe = livenessProbe;
            this.Replicas = replicas;
            this.Resources = resources;
            this.Root = root ?? throw new global::System.ArgumentNullException(nameof(root));
            this.TerminationGracePeriodSeconds = terminationGracePeriodSeconds;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedb4706d78b2b82e72" /> class.
        /// </summary>
        public AutoSDKSharedb4706d78b2b82e72()
        {
        }

    }
}