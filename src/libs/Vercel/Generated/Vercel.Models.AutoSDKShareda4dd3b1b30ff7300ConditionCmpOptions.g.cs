
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShareda4dd3b1b30ff7300ConditionCmpOptions
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
        /// Initializes a new instance of the <see cref="AutoSDKShareda4dd3b1b30ff7300ConditionCmpOptions" /> class.
        /// </summary>
        /// <param name="ignoreCase"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShareda4dd3b1b30ff7300ConditionCmpOptions(
            bool? ignoreCase)
        {
            this.IgnoreCase = ignoreCase;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareda4dd3b1b30ff7300ConditionCmpOptions" /> class.
        /// </summary>
        public AutoSDKShareda4dd3b1b30ff7300ConditionCmpOptions()
        {
        }

    }
}