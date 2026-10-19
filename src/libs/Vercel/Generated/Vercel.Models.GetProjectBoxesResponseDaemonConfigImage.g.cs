
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetProjectBoxesResponseDaemonConfigImage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Requested { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolved")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Resolved { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vhs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetProjectBoxesResponseDaemonConfigImageVhsVariant1, global::Vercel.GetProjectBoxesResponseDaemonConfigImageVhsVariant2>))]
        public global::Vercel.OneOf<global::Vercel.GetProjectBoxesResponseDaemonConfigImageVhsVariant1, global::Vercel.GetProjectBoxesResponseDaemonConfigImageVhsVariant2>? Vhs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectBoxesResponseDaemonConfigImage" /> class.
        /// </summary>
        /// <param name="requested"></param>
        /// <param name="resolved"></param>
        /// <param name="vhs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectBoxesResponseDaemonConfigImage(
            string requested,
            string resolved,
            global::Vercel.OneOf<global::Vercel.GetProjectBoxesResponseDaemonConfigImageVhsVariant1, global::Vercel.GetProjectBoxesResponseDaemonConfigImageVhsVariant2>? vhs)
        {
            this.Requested = requested ?? throw new global::System.ArgumentNullException(nameof(requested));
            this.Resolved = resolved ?? throw new global::System.ArgumentNullException(nameof(resolved));
            this.Vhs = vhs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectBoxesResponseDaemonConfigImage" /> class.
        /// </summary>
        public GetProjectBoxesResponseDaemonConfigImage()
        {
        }

    }
}