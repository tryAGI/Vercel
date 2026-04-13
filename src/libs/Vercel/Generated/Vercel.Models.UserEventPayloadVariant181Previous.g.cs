
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant181Previous
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
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant181Previous" /> class.
        /// </summary>
        /// <param name="commandForIgnoringBuildStep"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant181Previous(
            string? commandForIgnoringBuildStep)
        {
            this.CommandForIgnoringBuildStep = commandForIgnoringBuildStep;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant181Previous" /> class.
        /// </summary>
        public UserEventPayloadVariant181Previous()
        {
        }
    }
}