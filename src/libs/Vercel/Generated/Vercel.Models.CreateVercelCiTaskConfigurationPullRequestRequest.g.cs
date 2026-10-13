
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateVercelCiTaskConfigurationPullRequestRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tasks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.CreateVercelCiTaskConfigurationPullRequestRequestTask> Tasks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVercelCiTaskConfigurationPullRequestRequest" /> class.
        /// </summary>
        /// <param name="tasks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVercelCiTaskConfigurationPullRequestRequest(
            global::System.Collections.Generic.IList<global::Vercel.CreateVercelCiTaskConfigurationPullRequestRequestTask> tasks)
        {
            this.Tasks = tasks ?? throw new global::System.ArgumentNullException(nameof(tasks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVercelCiTaskConfigurationPullRequestRequest" /> class.
        /// </summary>
        public CreateVercelCiTaskConfigurationPullRequestRequest()
        {
        }

    }
}