
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListVercelCiJobDefinitionsResponseJobDefinition
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invocationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InvocationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invocationAttempt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double InvocationAttempt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobDefinitionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobDefinitionId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Command { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVercelCiJobDefinitionsResponseJobDefinition" /> class.
        /// </summary>
        /// <param name="invocationId"></param>
        /// <param name="invocationAttempt"></param>
        /// <param name="jobDefinitionId"></param>
        /// <param name="kind"></param>
        /// <param name="name"></param>
        /// <param name="command"></param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListVercelCiJobDefinitionsResponseJobDefinition(
            string invocationId,
            double invocationAttempt,
            string jobDefinitionId,
            string kind,
            string name,
            string command,
            double createdAt)
        {
            this.InvocationId = invocationId ?? throw new global::System.ArgumentNullException(nameof(invocationId));
            this.InvocationAttempt = invocationAttempt;
            this.JobDefinitionId = jobDefinitionId ?? throw new global::System.ArgumentNullException(nameof(jobDefinitionId));
            this.Kind = kind;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Command = command ?? throw new global::System.ArgumentNullException(nameof(command));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVercelCiJobDefinitionsResponseJobDefinition" /> class.
        /// </summary>
        public ListVercelCiJobDefinitionsResponseJobDefinition()
        {
        }

    }
}