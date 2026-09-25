
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetVercelCiInvocationTreeResponseJob
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("definition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetVercelCiInvocationTreeResponseJobDefinition Definition { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run")]
        public global::Vercel.GetVercelCiInvocationTreeResponseJobRun? Run { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tasks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.GetVercelCiInvocationTreeResponseJobTask> Tasks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVercelCiInvocationTreeResponseJob" /> class.
        /// </summary>
        /// <param name="definition"></param>
        /// <param name="tasks"></param>
        /// <param name="run"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetVercelCiInvocationTreeResponseJob(
            global::Vercel.GetVercelCiInvocationTreeResponseJobDefinition definition,
            global::System.Collections.Generic.IList<global::Vercel.GetVercelCiInvocationTreeResponseJobTask> tasks,
            global::Vercel.GetVercelCiInvocationTreeResponseJobRun? run)
        {
            this.Definition = definition ?? throw new global::System.ArgumentNullException(nameof(definition));
            this.Run = run;
            this.Tasks = tasks ?? throw new global::System.ArgumentNullException(nameof(tasks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVercelCiInvocationTreeResponseJob" /> class.
        /// </summary>
        public GetVercelCiInvocationTreeResponseJob()
        {
        }

    }
}