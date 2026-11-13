
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The terminal setup result. Omitted while invocation setup is still running.
    /// </summary>
    public sealed partial class AutoSDKShared9695014f26667713SetupConclusion
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
        /// Initializes a new instance of the <see cref="AutoSDKShared9695014f26667713SetupConclusion" /> class.
        /// </summary>
        /// <param name="result"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared9695014f26667713SetupConclusion(
            string result)
        {
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared9695014f26667713SetupConclusion" /> class.
        /// </summary>
        public AutoSDKShared9695014f26667713SetupConclusion()
        {
        }

    }
}