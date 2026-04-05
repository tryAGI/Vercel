
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAccessGroupRequest
    {
        /// <summary>
        /// The name of the access group<br/>
        /// Example: My access group
        /// </summary>
        /// <example>My access group</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        public global::System.Collections.Generic.IList<global::Vercel.CreateAccessGroupRequestProject>? Projects { get; set; }

        /// <summary>
        /// List of members to add to the access group.<br/>
        /// Example: [usr_1a2b3c4d5e6f7g8h9i0j, usr_2b3c4d5e6f7g8h9i0j1k]
        /// </summary>
        /// <example>[usr_1a2b3c4d5e6f7g8h9i0j, usr_2b3c4d5e6f7g8h9i0j1k]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("membersToAdd")]
        public global::System.Collections.Generic.IList<string>? MembersToAdd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAccessGroupRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the access group<br/>
        /// Example: My access group
        /// </param>
        /// <param name="projects"></param>
        /// <param name="membersToAdd">
        /// List of members to add to the access group.<br/>
        /// Example: [usr_1a2b3c4d5e6f7g8h9i0j, usr_2b3c4d5e6f7g8h9i0j1k]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAccessGroupRequest(
            string name,
            global::System.Collections.Generic.IList<global::Vercel.CreateAccessGroupRequestProject>? projects,
            global::System.Collections.Generic.IList<string>? membersToAdd)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Projects = projects;
            this.MembersToAdd = membersToAdd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAccessGroupRequest" /> class.
        /// </summary>
        public CreateAccessGroupRequest()
        {
        }
    }
}