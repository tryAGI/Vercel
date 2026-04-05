
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTeamRequest
    {
        /// <summary>
        /// The desired slug for the Team<br/>
        /// Example: a-random-team
        /// </summary>
        /// <example>a-random-team</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// The desired name for the Team. It will be generated from the provided slug if nothing is provided<br/>
        /// Example: A Random Team
        /// </summary>
        /// <example>A Random Team</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Attribution information for the session or current page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attribution")]
        public global::Vercel.CreateTeamRequestAttribution? Attribution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTeamRequest" /> class.
        /// </summary>
        /// <param name="slug">
        /// The desired slug for the Team<br/>
        /// Example: a-random-team
        /// </param>
        /// <param name="name">
        /// The desired name for the Team. It will be generated from the provided slug if nothing is provided<br/>
        /// Example: A Random Team
        /// </param>
        /// <param name="attribution">
        /// Attribution information for the session or current page
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTeamRequest(
            string slug,
            string? name,
            global::Vercel.CreateTeamRequestAttribution? attribution)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Name = name;
            this.Attribution = attribution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTeamRequest" /> class.
        /// </summary>
        public CreateTeamRequest()
        {
        }
    }
}