
#nullable enable

namespace Vercel
{
    /// <summary>
    /// How we want to determine a matching branch. This is optional.
    /// </summary>
    public sealed partial class UpdateCustomEnvironmentRequestBranchMatcher
    {
        /// <summary>
        /// Type of matcher. One of "equals", "startsWith", or "endsWith".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateCustomEnvironmentRequestBranchMatcherTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateCustomEnvironmentRequestBranchMatcherType Type { get; set; }

        /// <summary>
        /// Git branch name or portion thereof.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Pattern { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomEnvironmentRequestBranchMatcher" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of matcher. One of "equals", "startsWith", or "endsWith".
        /// </param>
        /// <param name="pattern">
        /// Git branch name or portion thereof.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCustomEnvironmentRequestBranchMatcher(
            global::Vercel.UpdateCustomEnvironmentRequestBranchMatcherType type,
            string pattern)
        {
            this.Type = type;
            this.Pattern = pattern ?? throw new global::System.ArgumentNullException(nameof(pattern));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomEnvironmentRequestBranchMatcher" /> class.
        /// </summary>
        public UpdateCustomEnvironmentRequestBranchMatcher()
        {
        }
    }
}