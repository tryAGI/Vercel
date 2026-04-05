
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListAccessGroupsResponseVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessGroups")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.ListAccessGroupsResponseVariant2AccessGroup> AccessGroups { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.ListAccessGroupsResponseVariant2Pagination Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAccessGroupsResponseVariant2" /> class.
        /// </summary>
        /// <param name="accessGroups"></param>
        /// <param name="pagination"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAccessGroupsResponseVariant2(
            global::System.Collections.Generic.IList<global::Vercel.ListAccessGroupsResponseVariant2AccessGroup> accessGroups,
            global::Vercel.ListAccessGroupsResponseVariant2Pagination pagination)
        {
            this.AccessGroups = accessGroups ?? throw new global::System.ArgumentNullException(nameof(accessGroups));
            this.Pagination = pagination ?? throw new global::System.ArgumentNullException(nameof(pagination));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAccessGroupsResponseVariant2" /> class.
        /// </summary>
        public ListAccessGroupsResponseVariant2()
        {
        }
    }
}