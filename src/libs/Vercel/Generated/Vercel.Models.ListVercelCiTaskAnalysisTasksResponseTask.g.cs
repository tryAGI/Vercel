
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListVercelCiTaskAnalysisTasksResponseTask
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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recommendationReasons")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RecommendationReasons { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVercelCiTaskAnalysisTasksResponseTask" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="configPath"></param>
        /// <param name="recommendationReasons"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListVercelCiTaskAnalysisTasksResponseTask(
            string name,
            string configPath,
            global::System.Collections.Generic.IList<string> recommendationReasons)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ConfigPath = configPath ?? throw new global::System.ArgumentNullException(nameof(configPath));
            this.RecommendationReasons = recommendationReasons ?? throw new global::System.ArgumentNullException(nameof(recommendationReasons));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVercelCiTaskAnalysisTasksResponseTask" /> class.
        /// </summary>
        public ListVercelCiTaskAnalysisTasksResponseTask()
        {
        }

    }
}