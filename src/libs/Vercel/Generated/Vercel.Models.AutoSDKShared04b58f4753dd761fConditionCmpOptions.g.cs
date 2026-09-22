
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared04b58f4753dd761fConditionCmpOptions
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
        /// Initializes a new instance of the <see cref="AutoSDKShared04b58f4753dd761fConditionCmpOptions" /> class.
        /// </summary>
        /// <param name="ignoreCase"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared04b58f4753dd761fConditionCmpOptions(
            bool? ignoreCase)
        {
            this.IgnoreCase = ignoreCase;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared04b58f4753dd761fConditionCmpOptions" /> class.
        /// </summary>
        public AutoSDKShared04b58f4753dd761fConditionCmpOptions()
        {
        }

    }
}