
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Set when this build produces a function for schedule entrypoints.
    /// </summary>
    public sealed partial class AutoSDKSharede00733f58a3cbcc8ScheduleFunction
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entrypoints")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharede00733f58a3cbcc8ScheduleFunctionEntrypoint> Entrypoints { get; set; }

        /// <summary>
        /// Function output path every schedule in this build targets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputPath")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OutputPath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede00733f58a3cbcc8ScheduleFunction" /> class.
        /// </summary>
        /// <param name="entrypoints"></param>
        /// <param name="outputPath">
        /// Function output path every schedule in this build targets.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharede00733f58a3cbcc8ScheduleFunction(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharede00733f58a3cbcc8ScheduleFunctionEntrypoint> entrypoints,
            string outputPath)
        {
            this.Entrypoints = entrypoints ?? throw new global::System.ArgumentNullException(nameof(entrypoints));
            this.OutputPath = outputPath ?? throw new global::System.ArgumentNullException(nameof(outputPath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede00733f58a3cbcc8ScheduleFunction" /> class.
        /// </summary>
        public AutoSDKSharede00733f58a3cbcc8ScheduleFunction()
        {
        }

    }
}