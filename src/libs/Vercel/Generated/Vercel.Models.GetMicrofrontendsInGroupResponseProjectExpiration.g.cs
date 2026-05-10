
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetMicrofrontendsInGroupResponseProjectExpiration
    {
        /// <summary>
        /// Unix ms timestamp when the project is scheduled to expire. Absent when the project is locked without a pending schedule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        public double? ExpiresAt { get; set; }

        /// <summary>
        /// Unix ms timestamp when the project was locked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lockedAt")]
        public double? LockedAt { get; set; }

        /// <summary>
        /// userId of the actor that triggered the lock (system or admin).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lockedBy")]
        public string? LockedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMicrofrontendsInGroupResponseProjectExpiration" /> class.
        /// </summary>
        /// <param name="expiresAt">
        /// Unix ms timestamp when the project is scheduled to expire. Absent when the project is locked without a pending schedule.
        /// </param>
        /// <param name="lockedAt">
        /// Unix ms timestamp when the project was locked.
        /// </param>
        /// <param name="lockedBy">
        /// userId of the actor that triggered the lock (system or admin).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMicrofrontendsInGroupResponseProjectExpiration(
            double? expiresAt,
            double? lockedAt,
            string? lockedBy)
        {
            this.ExpiresAt = expiresAt;
            this.LockedAt = lockedAt;
            this.LockedBy = lockedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMicrofrontendsInGroupResponseProjectExpiration" /> class.
        /// </summary>
        public GetMicrofrontendsInGroupResponseProjectExpiration()
        {
        }

    }
}