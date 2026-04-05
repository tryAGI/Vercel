
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListTeamFlagSettingsResponseVariant2Pagination
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        public string? Next { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTeamFlagSettingsResponseVariant2Pagination" /> class.
        /// </summary>
        /// <param name="next"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListTeamFlagSettingsResponseVariant2Pagination(
            string? next)
        {
            this.Next = next;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTeamFlagSettingsResponseVariant2Pagination" /> class.
        /// </summary>
        public ListTeamFlagSettingsResponseVariant2Pagination()
        {
        }
    }
}