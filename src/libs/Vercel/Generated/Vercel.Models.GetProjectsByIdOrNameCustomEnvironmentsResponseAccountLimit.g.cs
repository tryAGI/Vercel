
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The maximum number of custom environments allowed either by the team's plan type or a custom override.
    /// </summary>
    public sealed partial class GetProjectsByIdOrNameCustomEnvironmentsResponseAccountLimit
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsByIdOrNameCustomEnvironmentsResponseAccountLimit" /> class.
        /// </summary>
        /// <param name="total"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsByIdOrNameCustomEnvironmentsResponseAccountLimit(
            double total)
        {
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsByIdOrNameCustomEnvironmentsResponseAccountLimit" /> class.
        /// </summary>
        public GetProjectsByIdOrNameCustomEnvironmentsResponseAccountLimit()
        {
        }
    }
}