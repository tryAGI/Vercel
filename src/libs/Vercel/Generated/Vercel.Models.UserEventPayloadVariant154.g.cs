
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant154
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousBuildMachineType")]
        public string? PreviousBuildMachineType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextBuildMachineType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NextBuildMachineType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousBuildMachineSelection")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PreviousBuildMachineSelection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextBuildMachineSelection")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NextBuildMachineSelection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isSystemInitiated")]
        public bool? IsSystemInitiated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant154" /> class.
        /// </summary>
        /// <param name="projectName"></param>
        /// <param name="nextBuildMachineType"></param>
        /// <param name="previousBuildMachineSelection"></param>
        /// <param name="nextBuildMachineSelection"></param>
        /// <param name="projectId"></param>
        /// <param name="previousBuildMachineType"></param>
        /// <param name="isSystemInitiated"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant154(
            string projectName,
            string nextBuildMachineType,
            string previousBuildMachineSelection,
            string nextBuildMachineSelection,
            string? projectId,
            string? previousBuildMachineType,
            bool? isSystemInitiated)
        {
            this.ProjectId = projectId;
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
            this.PreviousBuildMachineType = previousBuildMachineType;
            this.NextBuildMachineType = nextBuildMachineType ?? throw new global::System.ArgumentNullException(nameof(nextBuildMachineType));
            this.PreviousBuildMachineSelection = previousBuildMachineSelection ?? throw new global::System.ArgumentNullException(nameof(previousBuildMachineSelection));
            this.NextBuildMachineSelection = nextBuildMachineSelection ?? throw new global::System.ArgumentNullException(nameof(nextBuildMachineSelection));
            this.IsSystemInitiated = isSystemInitiated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant154" /> class.
        /// </summary>
        public UserEventPayloadVariant154()
        {
        }
    }
}