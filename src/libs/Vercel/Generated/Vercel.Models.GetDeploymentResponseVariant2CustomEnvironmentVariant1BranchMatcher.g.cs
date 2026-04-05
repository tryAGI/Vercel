
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Configuration for matching git branches to this environment
    /// </summary>
    public sealed partial class GetDeploymentResponseVariant2CustomEnvironmentVariant1BranchMatcher
    {
        /// <summary>
        /// The type of matching to perform
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentResponseVariant2CustomEnvironmentVariant1BranchMatcherTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDeploymentResponseVariant2CustomEnvironmentVariant1BranchMatcherType Type { get; set; }

        /// <summary>
        /// The pattern to match against branch names
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
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant2CustomEnvironmentVariant1BranchMatcher" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of matching to perform
        /// </param>
        /// <param name="pattern">
        /// The pattern to match against branch names
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentResponseVariant2CustomEnvironmentVariant1BranchMatcher(
            global::Vercel.GetDeploymentResponseVariant2CustomEnvironmentVariant1BranchMatcherType type,
            string pattern)
        {
            this.Type = type;
            this.Pattern = pattern ?? throw new global::System.ArgumentNullException(nameof(pattern));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentResponseVariant2CustomEnvironmentVariant1BranchMatcher" /> class.
        /// </summary>
        public GetDeploymentResponseVariant2CustomEnvironmentVariant1BranchMatcher()
        {
        }
    }
}