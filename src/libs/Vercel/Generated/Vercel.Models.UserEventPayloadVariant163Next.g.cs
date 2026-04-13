
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant163Next
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branchMatcher")]
        public global::Vercel.UserEventPayloadVariant163NextBranchMatcher? BranchMatcher { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant163Next" /> class.
        /// </summary>
        /// <param name="branchMatcher"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant163Next(
            global::Vercel.UserEventPayloadVariant163NextBranchMatcher? branchMatcher)
        {
            this.BranchMatcher = branchMatcher;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant163Next" /> class.
        /// </summary>
        public UserEventPayloadVariant163Next()
        {
        }
    }
}