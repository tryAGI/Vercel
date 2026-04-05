
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSnapshotRequest
    {
        /// <summary>
        /// The number of milliseconds after which the snapshot will expire and be deleted. Use 0 for no expiration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>))]
        public global::Vercel.OneOf<object, int?>? Expiration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSnapshotRequest" /> class.
        /// </summary>
        /// <param name="expiration">
        /// The number of milliseconds after which the snapshot will expire and be deleted. Use 0 for no expiration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSnapshotRequest(
            global::Vercel.OneOf<object, int?>? expiration)
        {
            this.Expiration = expiration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSnapshotRequest" /> class.
        /// </summary>
        public CreateSnapshotRequest()
        {
        }
    }
}