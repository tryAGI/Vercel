
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Keeps track of the current state of the Edge Config while it gets transferred.
    /// </summary>
    public sealed partial class GetEdgeConfigsResponseItemTransfer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fromAccountId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FromAccountId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("doneAt")]
        public double? DoneAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEdgeConfigsResponseItemTransfer" /> class.
        /// </summary>
        /// <param name="fromAccountId"></param>
        /// <param name="startedAt"></param>
        /// <param name="doneAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetEdgeConfigsResponseItemTransfer(
            string fromAccountId,
            double startedAt,
            double? doneAt)
        {
            this.FromAccountId = fromAccountId ?? throw new global::System.ArgumentNullException(nameof(fromAccountId));
            this.StartedAt = startedAt;
            this.DoneAt = doneAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEdgeConfigsResponseItemTransfer" /> class.
        /// </summary>
        public GetEdgeConfigsResponseItemTransfer()
        {
        }
    }
}