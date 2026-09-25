
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The aggregate outcome of every job in the invocation. Omitted while jobs are still running. Any failed job → "failed"; any (non-cascade) skipped job → "skipped"; else "succeeded". Present on completed invocations written after the field shipped; absent on older rows.
    /// </summary>
    public sealed partial class AutoSDKShared3fd5b0acfe2f4f54RunConclusion
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared3fd5b0acfe2f4f54RunConclusion" /> class.
        /// </summary>
        /// <param name="result"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared3fd5b0acfe2f4f54RunConclusion(
            string result)
        {
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared3fd5b0acfe2f4f54RunConclusion" /> class.
        /// </summary>
        public AutoSDKShared3fd5b0acfe2f4f54RunConclusion()
        {
        }

    }
}