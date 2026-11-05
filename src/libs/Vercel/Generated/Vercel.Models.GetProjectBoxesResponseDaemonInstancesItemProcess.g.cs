
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Quick restarts of the user container in a row. Absent when there are none.
    /// </summary>
    public sealed partial class GetProjectBoxesResponseDaemonInstancesItemProcess
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastExitCode")]
        public double? LastExitCode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restarts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Restarts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crashLooping")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CrashLooping { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectBoxesResponseDaemonInstancesItemProcess" /> class.
        /// </summary>
        /// <param name="restarts"></param>
        /// <param name="crashLooping"></param>
        /// <param name="lastExitCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectBoxesResponseDaemonInstancesItemProcess(
            double restarts,
            bool crashLooping,
            double? lastExitCode)
        {
            this.LastExitCode = lastExitCode;
            this.Restarts = restarts;
            this.CrashLooping = crashLooping;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectBoxesResponseDaemonInstancesItemProcess" /> class.
        /// </summary>
        public GetProjectBoxesResponseDaemonInstancesItemProcess()
        {
        }

    }
}