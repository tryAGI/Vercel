
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The team was created successfully
    /// </summary>
    public sealed partial class CreateTeamResponse
    {
        /// <summary>
        /// Id of the created team<br/>
        /// Example: team_nLlpyC6RE1qxqglFKbrMxlud
        /// </summary>
        /// <example>team_nLlpyC6RE1qxqglFKbrMxlud</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTeamResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Id of the created team<br/>
        /// Example: team_nLlpyC6RE1qxqglFKbrMxlud
        /// </param>
        /// <param name="slug"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTeamResponse(
            string id,
            string slug)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTeamResponse" /> class.
        /// </summary>
        public CreateTeamResponse()
        {
        }
    }
}