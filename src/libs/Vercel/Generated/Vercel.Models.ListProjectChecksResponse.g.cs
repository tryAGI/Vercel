
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListProjectChecksResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("availableNativeChecks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AvailableNativeChecks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.ListProjectChecksResponseCheck> Checks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectChecksResponse" /> class.
        /// </summary>
        /// <param name="availableNativeChecks"></param>
        /// <param name="checks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProjectChecksResponse(
            global::System.Collections.Generic.IList<string> availableNativeChecks,
            global::System.Collections.Generic.IList<global::Vercel.ListProjectChecksResponseCheck> checks)
        {
            this.AvailableNativeChecks = availableNativeChecks ?? throw new global::System.ArgumentNullException(nameof(availableNativeChecks));
            this.Checks = checks ?? throw new global::System.ArgumentNullException(nameof(checks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProjectChecksResponse" /> class.
        /// </summary>
        public ListProjectChecksResponse()
        {
        }

    }
}