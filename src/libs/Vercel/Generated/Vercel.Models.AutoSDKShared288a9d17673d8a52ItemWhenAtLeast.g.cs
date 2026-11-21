
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared288a9d17673d8a52ItemWhenAtLeast
    {
        /// <summary>
        /// Must not be more than the number of conditions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Nested conditions. Each one has the same shape as `when`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Conditions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared288a9d17673d8a52ItemWhenAtLeast" /> class.
        /// </summary>
        /// <param name="count">
        /// Must not be more than the number of conditions.
        /// </param>
        /// <param name="conditions">
        /// Nested conditions. Each one has the same shape as `when`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared288a9d17673d8a52ItemWhenAtLeast(
            int count,
            global::System.Collections.Generic.IList<object> conditions)
        {
            this.Count = count;
            this.Conditions = conditions ?? throw new global::System.ArgumentNullException(nameof(conditions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared288a9d17673d8a52ItemWhenAtLeast" /> class.
        /// </summary>
        public AutoSDKShared288a9d17673d8a52ItemWhenAtLeast()
        {
        }

    }
}