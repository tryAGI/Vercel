
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Matching lines from the setup logs. Present only when a setup line matches.
    /// </summary>
    public sealed partial class SearchVercelCiLogsResponseInvocationSetup
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lines")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.SearchVercelCiLogsResponseInvocationSetupLine> Lines { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchVercelCiLogsResponseInvocationSetup" /> class.
        /// </summary>
        /// <param name="lines"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchVercelCiLogsResponseInvocationSetup(
            global::System.Collections.Generic.IList<global::Vercel.SearchVercelCiLogsResponseInvocationSetupLine> lines)
        {
            this.Lines = lines ?? throw new global::System.ArgumentNullException(nameof(lines));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchVercelCiLogsResponseInvocationSetup" /> class.
        /// </summary>
        public SearchVercelCiLogsResponseInvocationSetup()
        {
        }

    }
}