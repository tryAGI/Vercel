
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant159Previous
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branchMatcher")]
        public global::Vercel.UserEventPayloadVariant159PreviousBranchMatcher? BranchMatcher { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant159Previous" /> class.
        /// </summary>
        /// <param name="branchMatcher"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant159Previous(
            global::Vercel.UserEventPayloadVariant159PreviousBranchMatcher? branchMatcher)
        {
            this.BranchMatcher = branchMatcher;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant159Previous" /> class.
        /// </summary>
        public UserEventPayloadVariant159Previous()
        {
        }
    }
}