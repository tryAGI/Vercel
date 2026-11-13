
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared9695014f26667713JobDefinitionsCreated
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("names")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Names { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduledAt")]
        public double? ScheduledAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared9695014f26667713JobDefinitionsCreated" /> class.
        /// </summary>
        /// <param name="names"></param>
        /// <param name="source"></param>
        /// <param name="scheduledAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared9695014f26667713JobDefinitionsCreated(
            global::System.Collections.Generic.IList<string> names,
            string? source,
            double? scheduledAt)
        {
            this.Names = names ?? throw new global::System.ArgumentNullException(nameof(names));
            this.Source = source;
            this.ScheduledAt = scheduledAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared9695014f26667713JobDefinitionsCreated" /> class.
        /// </summary>
        public AutoSDKShared9695014f26667713JobDefinitionsCreated()
        {
        }

    }
}