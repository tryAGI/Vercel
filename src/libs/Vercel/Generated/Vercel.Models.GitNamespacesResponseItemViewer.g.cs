
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GitNamespacesResponseItemViewer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canCreateApp")]
        public bool? CanCreateApp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>))]
        public global::Vercel.OneOf<string, double?>? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GitNamespacesResponseItemViewer" /> class.
        /// </summary>
        /// <param name="canCreateApp"></param>
        /// <param name="role"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GitNamespacesResponseItemViewer(
            bool? canCreateApp,
            global::Vercel.OneOf<string, double?>? role)
        {
            this.CanCreateApp = canCreateApp;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GitNamespacesResponseItemViewer" /> class.
        /// </summary>
        public GitNamespacesResponseItemViewer()
        {
        }

    }
}