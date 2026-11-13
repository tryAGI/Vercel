
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared9695014f26667713Completed
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CompletedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conclusion")]
        public string? Conclusion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared9695014f26667713Completed" /> class.
        /// </summary>
        /// <param name="completedAt"></param>
        /// <param name="conclusion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared9695014f26667713Completed(
            double completedAt,
            string? conclusion)
        {
            this.CompletedAt = completedAt;
            this.Conclusion = conclusion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared9695014f26667713Completed" /> class.
        /// </summary>
        public AutoSDKShared9695014f26667713Completed()
        {
        }

    }
}