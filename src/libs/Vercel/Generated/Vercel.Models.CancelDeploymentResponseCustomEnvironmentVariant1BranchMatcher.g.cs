
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Configuration for matching git branches to this environment
    /// </summary>
    public sealed partial class CancelDeploymentResponseCustomEnvironmentVariant1BranchMatcher
    {
        /// <summary>
        /// The type of matching to perform
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.CancelDeploymentResponseCustomEnvironmentVariant1BranchMatcherTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.CancelDeploymentResponseCustomEnvironmentVariant1BranchMatcherType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseCustomEnvironmentVariant1BranchMatcher" /> class.
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
        public CancelDeploymentResponseCustomEnvironmentVariant1BranchMatcher(
            global::Vercel.CancelDeploymentResponseCustomEnvironmentVariant1BranchMatcherType type,
            string pattern)
        {
            this.Type = type;
            this.Pattern = pattern ?? throw new global::System.ArgumentNullException(nameof(pattern));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelDeploymentResponseCustomEnvironmentVariant1BranchMatcher" /> class.
        /// </summary>
        public CancelDeploymentResponseCustomEnvironmentVariant1BranchMatcher()
        {
        }
    }
}