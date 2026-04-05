
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StageRoutesResponse
    {
        /// <summary>
        /// A version of routing rules stored in S3.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.StageRoutesResponseVersion Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StageRoutesResponse" /> class.
        /// </summary>
        /// <param name="version">
        /// A version of routing rules stored in S3.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StageRoutesResponse(
            global::Vercel.StageRoutesResponseVersion version)
        {
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StageRoutesResponse" /> class.
        /// </summary>
        public StageRoutesResponse()
        {
        }
    }
}