
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateVercelCiTaskConfigurationPullRequestRequestTask
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configPath")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConfigPath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVercelCiTaskConfigurationPullRequestRequestTask" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="configPath"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVercelCiTaskConfigurationPullRequestRequestTask(
            string name,
            string configPath)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ConfigPath = configPath ?? throw new global::System.ArgumentNullException(nameof(configPath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVercelCiTaskConfigurationPullRequestRequestTask" /> class.
        /// </summary>
        public CreateVercelCiTaskConfigurationPullRequestRequestTask()
        {
        }

    }
}