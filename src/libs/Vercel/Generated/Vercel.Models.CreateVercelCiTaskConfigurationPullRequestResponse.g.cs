
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateVercelCiTaskConfigurationPullRequestResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changedTaskNames")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ChangedTaskNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVercelCiTaskConfigurationPullRequestResponse" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="changedTaskNames"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVercelCiTaskConfigurationPullRequestResponse(
            string url,
            global::System.Collections.Generic.IList<string> changedTaskNames)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ChangedTaskNames = changedTaskNames ?? throw new global::System.ArgumentNullException(nameof(changedTaskNames));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVercelCiTaskConfigurationPullRequestResponse" /> class.
        /// </summary>
        public CreateVercelCiTaskConfigurationPullRequestResponse()
        {
        }

    }
}