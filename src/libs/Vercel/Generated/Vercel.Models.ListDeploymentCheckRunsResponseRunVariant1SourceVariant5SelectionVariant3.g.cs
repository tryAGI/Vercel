
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListDeploymentCheckRunsResponseRunVariant1SourceVariant5SelectionVariant3
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Job { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.ListDeploymentCheckRunsResponseRunVariant1SourceVariant5SelectionVariant3KindJsonConverter))]
        public global::Vercel.ListDeploymentCheckRunsResponseRunVariant1SourceVariant5SelectionVariant3Kind Kind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Task { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDeploymentCheckRunsResponseRunVariant1SourceVariant5SelectionVariant3" /> class.
        /// </summary>
        /// <param name="job"></param>
        /// <param name="task"></param>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListDeploymentCheckRunsResponseRunVariant1SourceVariant5SelectionVariant3(
            string job,
            string task,
            global::Vercel.ListDeploymentCheckRunsResponseRunVariant1SourceVariant5SelectionVariant3Kind kind)
        {
            this.Job = job ?? throw new global::System.ArgumentNullException(nameof(job));
            this.Kind = kind;
            this.Task = task ?? throw new global::System.ArgumentNullException(nameof(task));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDeploymentCheckRunsResponseRunVariant1SourceVariant5SelectionVariant3" /> class.
        /// </summary>
        public ListDeploymentCheckRunsResponseRunVariant1SourceVariant5SelectionVariant3()
        {
        }

    }
}