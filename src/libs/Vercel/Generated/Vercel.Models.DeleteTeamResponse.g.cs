
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The Team was successfully deleted
    /// </summary>
    public sealed partial class DeleteTeamResponse
    {
        /// <summary>
        /// The ID of the deleted Team<br/>
        /// Example: team_LLHUOMOoDlqOp8wPE4kFo9pE
        /// </summary>
        /// <example>team_LLHUOMOoDlqOp8wPE4kFo9pE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Signifies whether the default team update has failed, when newDefaultTeamId is provided in request query.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("newDefaultTeamIdError")]
        public bool? NewDefaultTeamIdError { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTeamResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the deleted Team<br/>
        /// Example: team_LLHUOMOoDlqOp8wPE4kFo9pE
        /// </param>
        /// <param name="newDefaultTeamIdError">
        /// Signifies whether the default team update has failed, when newDefaultTeamId is provided in request query.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteTeamResponse(
            string id,
            bool? newDefaultTeamIdError)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.NewDefaultTeamIdError = newDefaultTeamIdError;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTeamResponse" /> class.
        /// </summary>
        public DeleteTeamResponse()
        {
        }
    }
}