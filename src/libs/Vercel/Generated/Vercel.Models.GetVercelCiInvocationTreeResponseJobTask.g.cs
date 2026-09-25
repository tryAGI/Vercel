
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetVercelCiInvocationTreeResponseJobTask
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("definition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetVercelCiInvocationTreeResponseJobTaskDefinition Definition { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run")]
        public global::Vercel.GetVercelCiInvocationTreeResponseJobTaskRun? Run { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVercelCiInvocationTreeResponseJobTask" /> class.
        /// </summary>
        /// <param name="definition"></param>
        /// <param name="run"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetVercelCiInvocationTreeResponseJobTask(
            global::Vercel.GetVercelCiInvocationTreeResponseJobTaskDefinition definition,
            global::Vercel.GetVercelCiInvocationTreeResponseJobTaskRun? run)
        {
            this.Definition = definition ?? throw new global::System.ArgumentNullException(nameof(definition));
            this.Run = run;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVercelCiInvocationTreeResponseJobTask" /> class.
        /// </summary>
        public GetVercelCiInvocationTreeResponseJobTask()
        {
        }

    }
}