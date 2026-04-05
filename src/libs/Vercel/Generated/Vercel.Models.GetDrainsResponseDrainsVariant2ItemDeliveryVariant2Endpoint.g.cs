
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDrainsResponseDrainsVariant2ItemDeliveryVariant2Endpoint
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traces")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Traces { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDrainsResponseDrainsVariant2ItemDeliveryVariant2Endpoint" /> class.
        /// </summary>
        /// <param name="traces"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDrainsResponseDrainsVariant2ItemDeliveryVariant2Endpoint(
            string traces)
        {
            this.Traces = traces ?? throw new global::System.ArgumentNullException(nameof(traces));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDrainsResponseDrainsVariant2ItemDeliveryVariant2Endpoint" /> class.
        /// </summary>
        public GetDrainsResponseDrainsVariant2ItemDeliveryVariant2Endpoint()
        {
        }
    }
}