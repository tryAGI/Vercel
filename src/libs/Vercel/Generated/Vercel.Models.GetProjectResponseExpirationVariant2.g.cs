
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectResponseExpirationVariant2
    {
        /// <summary>
        /// Unix ms timestamp when the project was locked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lockedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LockedAt { get; set; }

        /// <summary>
        /// userId of the actor that triggered the lock (system or admin).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lockedBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LockedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseExpirationVariant2" /> class.
        /// </summary>
        /// <param name="lockedAt">
        /// Unix ms timestamp when the project was locked.
        /// </param>
        /// <param name="lockedBy">
        /// userId of the actor that triggered the lock (system or admin).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectResponseExpirationVariant2(
            double lockedAt,
            string lockedBy)
        {
            this.LockedAt = lockedAt;
            this.LockedBy = lockedBy ?? throw new global::System.ArgumentNullException(nameof(lockedBy));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponseExpirationVariant2" /> class.
        /// </summary>
        public GetProjectResponseExpirationVariant2()
        {
        }

    }
}