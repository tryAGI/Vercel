
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant180Previous
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commandForIgnoringBuildStep")]
        public string? CommandForIgnoringBuildStep { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant180Previous" /> class.
        /// </summary>
        /// <param name="commandForIgnoringBuildStep"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant180Previous(
            string? commandForIgnoringBuildStep)
        {
            this.CommandForIgnoringBuildStep = commandForIgnoringBuildStep;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant180Previous" /> class.
        /// </summary>
        public UserEventPayloadVariant180Previous()
        {
        }
    }
}