
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectsResponseVariant3ProjectSpeedInsights
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
        [global::System.Text.Json.Serialization.JsonPropertyName("enabledAt")]
        public double? EnabledAt { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("hasData")]
        public bool? HasData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paidAt")]
        public double? PaidAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3ProjectSpeedInsights" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="enabledAt"></param>
        /// <param name="disabledAt"></param>
        /// <param name="canceledAt"></param>
        /// <param name="hasData"></param>
        /// <param name="paidAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectsResponseVariant3ProjectSpeedInsights(
            string id,
            double? enabledAt,
            double? disabledAt,
            double? canceledAt,
            bool? hasData,
            double? paidAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.EnabledAt = enabledAt;
            this.DisabledAt = disabledAt;
            this.CanceledAt = canceledAt;
            this.HasData = hasData;
            this.PaidAt = paidAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectsResponseVariant3ProjectSpeedInsights" /> class.
        /// </summary>
        public GetProjectsResponseVariant3ProjectSpeedInsights()
        {
        }
    }
}