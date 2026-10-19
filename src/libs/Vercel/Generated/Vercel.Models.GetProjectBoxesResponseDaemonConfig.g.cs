
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetProjectBoxesResponseDaemonConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        public global::System.Collections.Generic.IList<string>? Command { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuredReplicas")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>))]
        public global::Vercel.OneOf<double?, global::System.Collections.Generic.Dictionary<string, double>>? ConfiguredReplicas { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectBoxesResponseDaemonConfigImage Image { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("livenessProbe")]
        public global::Vercel.GetProjectBoxesResponseDaemonConfigLivenessProbe? LivenessProbe { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicas")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<double?, global::System.Collections.Generic.Dictionary<string, double>> Replicas { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectBoxesResponseDaemonConfigResources Resources { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terminationGracePeriodSeconds")]
        public double? TerminationGracePeriodSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectBoxesResponseDaemonConfig" /> class.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="replicas"></param>
        /// <param name="resources"></param>
        /// <param name="command"></param>
        /// <param name="configuredReplicas"></param>
        /// <param name="livenessProbe"></param>
        /// <param name="terminationGracePeriodSeconds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectBoxesResponseDaemonConfig(
            global::Vercel.GetProjectBoxesResponseDaemonConfigImage image,
            global::Vercel.OneOf<double?, global::System.Collections.Generic.Dictionary<string, double>> replicas,
            global::Vercel.GetProjectBoxesResponseDaemonConfigResources resources,
            global::System.Collections.Generic.IList<string>? command,
            global::Vercel.OneOf<double?, global::System.Collections.Generic.Dictionary<string, double>>? configuredReplicas,
            global::Vercel.GetProjectBoxesResponseDaemonConfigLivenessProbe? livenessProbe,
            double? terminationGracePeriodSeconds)
        {
            this.Command = command;
            this.ConfiguredReplicas = configuredReplicas;
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.LivenessProbe = livenessProbe;
            this.Replicas = replicas;
            this.Resources = resources ?? throw new global::System.ArgumentNullException(nameof(resources));
            this.TerminationGracePeriodSeconds = terminationGracePeriodSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectBoxesResponseDaemonConfig" /> class.
        /// </summary>
        public GetProjectBoxesResponseDaemonConfig()
        {
        }

    }
}