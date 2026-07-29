
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Allocations that were at or over 100% when the pause was applied.
    /// </summary>
    public sealed partial class AuthUserSoftBlockHobbyAllocationPauseTrigger
    {
        /// <summary>
        /// Metered allocation whose included amount was fully consumed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allocation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AuthUserSoftBlockHobbyAllocationPauseTriggerAllocationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation Allocation { get; set; }

        /// <summary>
        /// Usage recorded for that allocation when the pause was applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserSoftBlockHobbyAllocationPauseTrigger" /> class.
        /// </summary>
        /// <param name="allocation">
        /// Metered allocation whose included amount was fully consumed.
        /// </param>
        /// <param name="usage">
        /// Usage recorded for that allocation when the pause was applied.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthUserSoftBlockHobbyAllocationPauseTrigger(
            global::Vercel.AuthUserSoftBlockHobbyAllocationPauseTriggerAllocation allocation,
            double usage)
        {
            this.Allocation = allocation;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserSoftBlockHobbyAllocationPauseTrigger" /> class.
        /// </summary>
        public AuthUserSoftBlockHobbyAllocationPauseTrigger()
        {
        }

    }
}