
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Paginated list of members for the project.
    /// </summary>
    public sealed partial class GetProjectMembersResponseVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetProjectMembersResponseVariant2Member> Members { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectMembersResponseVariant2Pagination Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectMembersResponseVariant2" /> class.
        /// </summary>
        /// <param name="members"></param>
        /// <param name="pagination"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectMembersResponseVariant2(
            global::System.Collections.Generic.IList<global::Vercel.GetProjectMembersResponseVariant2Member> members,
            global::Vercel.GetProjectMembersResponseVariant2Pagination pagination)
        {
            this.Members = members ?? throw new global::System.ArgumentNullException(nameof(members));
            this.Pagination = pagination ?? throw new global::System.ArgumentNullException(nameof(pagination));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectMembersResponseVariant2" /> class.
        /// </summary>
        public GetProjectMembersResponseVariant2()
        {
        }
    }
}