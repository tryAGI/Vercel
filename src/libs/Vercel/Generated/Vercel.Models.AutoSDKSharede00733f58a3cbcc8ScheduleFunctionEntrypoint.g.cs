
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharede00733f58a3cbcc8ScheduleFunctionEntrypoint
    {
        /// <summary>
        /// Runtime-specific entrypoint locator from `vercel.json`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entrypoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Entrypoint { get; set; }

        /// <summary>
        /// Names of the schedules that dispatch to this entrypoint, in config order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduleNames")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ScheduleNames { get; set; }

        /// <summary>
        /// Project-relative source file that contains the entrypoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceFile")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceFile { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede00733f58a3cbcc8ScheduleFunctionEntrypoint" /> class.
        /// </summary>
        /// <param name="entrypoint">
        /// Runtime-specific entrypoint locator from `vercel.json`.
        /// </param>
        /// <param name="scheduleNames">
        /// Names of the schedules that dispatch to this entrypoint, in config order.
        /// </param>
        /// <param name="sourceFile">
        /// Project-relative source file that contains the entrypoint.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharede00733f58a3cbcc8ScheduleFunctionEntrypoint(
            string entrypoint,
            global::System.Collections.Generic.IList<string> scheduleNames,
            string sourceFile)
        {
            this.Entrypoint = entrypoint ?? throw new global::System.ArgumentNullException(nameof(entrypoint));
            this.ScheduleNames = scheduleNames ?? throw new global::System.ArgumentNullException(nameof(scheduleNames));
            this.SourceFile = sourceFile ?? throw new global::System.ArgumentNullException(nameof(sourceFile));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharede00733f58a3cbcc8ScheduleFunctionEntrypoint" /> class.
        /// </summary>
        public AutoSDKSharede00733f58a3cbcc8ScheduleFunctionEntrypoint()
        {
        }

    }
}