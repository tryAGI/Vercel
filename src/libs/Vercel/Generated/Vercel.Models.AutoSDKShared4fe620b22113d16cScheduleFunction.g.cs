
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Set when this build produces a function for schedule entrypoints.
    /// </summary>
    public sealed partial class AutoSDKShared4fe620b22113d16cScheduleFunction
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entrypoints")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared4fe620b22113d16cScheduleFunctionEntrypoint> Entrypoints { get; set; }

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
        /// Initializes a new instance of the <see cref="AutoSDKShared4fe620b22113d16cScheduleFunction" /> class.
        /// </summary>
        /// <param name="entrypoints"></param>
        /// <param name="outputPath">
        /// Function output path every schedule in this build targets.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared4fe620b22113d16cScheduleFunction(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared4fe620b22113d16cScheduleFunctionEntrypoint> entrypoints,
            string outputPath)
        {
            this.Entrypoints = entrypoints ?? throw new global::System.ArgumentNullException(nameof(entrypoints));
            this.OutputPath = outputPath ?? throw new global::System.ArgumentNullException(nameof(outputPath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared4fe620b22113d16cScheduleFunction" /> class.
        /// </summary>
        public AutoSDKShared4fe620b22113d16cScheduleFunction()
        {
        }

    }
}