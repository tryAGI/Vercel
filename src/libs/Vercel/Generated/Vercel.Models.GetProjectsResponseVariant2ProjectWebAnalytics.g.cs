
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant2ProjectWebAnalytics
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabledAt")]
        public double? DisabledAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canceledAt")]
        public double? CanceledAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabledAt")]
        public double? EnabledAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasData")]
        public bool? HasData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant2ProjectWebAnalytics" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="disabledAt"></param>
        /// <param name="canceledAt"></param>
        /// <param name="enabledAt"></param>
        /// <param name="hasData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant2ProjectWebAnalytics(
            string id,
            double? disabledAt,
            double? canceledAt,
            double? enabledAt,
            bool? hasData)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.DisabledAt = disabledAt;
            this.CanceledAt = canceledAt;
            this.EnabledAt = enabledAt;
            this.HasData = hasData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant2ProjectWebAnalytics" /> class.
        /// </summary>
        public GetProjectsResponseVariant2ProjectWebAnalytics()
        {
        }
    }
}