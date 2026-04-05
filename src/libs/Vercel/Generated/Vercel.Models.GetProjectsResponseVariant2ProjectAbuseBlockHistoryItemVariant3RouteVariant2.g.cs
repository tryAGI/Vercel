
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant3RouteVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant3RouteVariant2HaVariant1, global::Vercel.GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant3RouteVariant2HaVariant2>> Has { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mitigate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant3RouteVariant2Mitigate Mitigate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        public string? Src { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant3RouteVariant2" /> class.
        /// </summary>
        /// <param name="has"></param>
        /// <param name="mitigate"></param>
        /// <param name="src"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant3RouteVariant2(
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant3RouteVariant2HaVariant1, global::Vercel.GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant3RouteVariant2HaVariant2>> has,
            global::Vercel.GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant3RouteVariant2Mitigate mitigate,
            string? src)
        {
            this.Has = has ?? throw new global::System.ArgumentNullException(nameof(has));
            this.Mitigate = mitigate ?? throw new global::System.ArgumentNullException(nameof(mitigate));
            this.Src = src;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant3RouteVariant2" /> class.
        /// </summary>
        public GetProjectsResponseVariant2ProjectAbuseBlockHistoryItemVariant3RouteVariant2()
        {
        }
    }
}