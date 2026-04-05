
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProjectResponseAbuseBlockHistoryItemVariant4RouteVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Src { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectResponseAbuseBlockHistoryItemVariant4RouteVariant1" /> class.
        /// </summary>
        /// <param name="src"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectResponseAbuseBlockHistoryItemVariant4RouteVariant1(
            string src,
            double status)
        {
            this.Src = src ?? throw new global::System.ArgumentNullException(nameof(src));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectResponseAbuseBlockHistoryItemVariant4RouteVariant1" /> class.
        /// </summary>
        public UpdateProjectResponseAbuseBlockHistoryItemVariant4RouteVariant1()
        {
        }
    }
}