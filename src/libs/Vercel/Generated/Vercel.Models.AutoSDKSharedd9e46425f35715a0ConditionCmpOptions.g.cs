
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedd9e46425f35715a0ConditionCmpOptions
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignoreCase")]
        public bool? IgnoreCase { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedd9e46425f35715a0ConditionCmpOptions" /> class.
        /// </summary>
        /// <param name="ignoreCase"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedd9e46425f35715a0ConditionCmpOptions(
            bool? ignoreCase)
        {
            this.IgnoreCase = ignoreCase;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedd9e46425f35715a0ConditionCmpOptions" /> class.
        /// </summary>
        public AutoSDKSharedd9e46425f35715a0ConditionCmpOptions()
        {
        }

    }
}