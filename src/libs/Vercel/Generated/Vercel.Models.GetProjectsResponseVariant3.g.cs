
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant3Project> Projects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetProjectsResponseVariant3Pagination, global::Vercel.Pagination>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.OneOf<global::Vercel.GetProjectsResponseVariant3Pagination, global::Vercel.Pagination> Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3" /> class.
        /// </summary>
        /// <param name="projects"></param>
        /// <param name="pagination"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant3(
            global::System.Collections.Generic.IList<global::Vercel.GetProjectsResponseVariant3Project> projects,
            global::Vercel.OneOf<global::Vercel.GetProjectsResponseVariant3Pagination, global::Vercel.Pagination> pagination)
        {
            this.Projects = projects ?? throw new global::System.ArgumentNullException(nameof(projects));
            this.Pagination = pagination;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3" /> class.
        /// </summary>
        public GetProjectsResponseVariant3()
        {
        }
    }
}