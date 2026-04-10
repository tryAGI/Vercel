
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant160Next
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branchMatcher")]
        public global::Vercel.UserEventPayloadVariant160NextBranchMatcher? BranchMatcher { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant160Next" /> class.
        /// </summary>
        /// <param name="branchMatcher"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant160Next(
            global::Vercel.UserEventPayloadVariant160NextBranchMatcher? branchMatcher)
        {
            this.BranchMatcher = branchMatcher;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant160Next" /> class.
        /// </summary>
        public UserEventPayloadVariant160Next()
        {
        }
    }
}