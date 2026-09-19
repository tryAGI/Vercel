
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Configuration for matching git branches to this environment
    /// </summary>
    public sealed partial class UploadProjectAvatarResponseCustomEnvironmentBranchMatcher
    {
        /// <summary>
        /// The pattern to match against branch names
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Pattern { get; set; }

        /// <summary>
        /// The type of matching to perform
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UploadProjectAvatarResponseCustomEnvironmentBranchMatcherTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UploadProjectAvatarResponseCustomEnvironmentBranchMatcherType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadProjectAvatarResponseCustomEnvironmentBranchMatcher" /> class.
        /// </summary>
        /// <param name="pattern">
        /// The pattern to match against branch names
        /// </param>
        /// <param name="type">
        /// The type of matching to perform
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadProjectAvatarResponseCustomEnvironmentBranchMatcher(
            string pattern,
            global::Vercel.UploadProjectAvatarResponseCustomEnvironmentBranchMatcherType type)
        {
            this.Pattern = pattern ?? throw new global::System.ArgumentNullException(nameof(pattern));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadProjectAvatarResponseCustomEnvironmentBranchMatcher" /> class.
        /// </summary>
        public UploadProjectAvatarResponseCustomEnvironmentBranchMatcher()
        {
        }

    }
}