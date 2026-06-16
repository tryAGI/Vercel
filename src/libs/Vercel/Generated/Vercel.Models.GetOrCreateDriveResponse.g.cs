
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrCreateDriveResponse
    {
        /// <summary>
        /// This object contains information related to a Vercel Sandbox Drive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("drive")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.Drive Drive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrCreateDriveResponse" /> class.
        /// </summary>
        /// <param name="drive">
        /// This object contains information related to a Vercel Sandbox Drive.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrCreateDriveResponse(
            global::Vercel.Drive drive)
        {
            this.Drive = drive ?? throw new global::System.ArgumentNullException(nameof(drive));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrCreateDriveResponse" /> class.
        /// </summary>
        public GetOrCreateDriveResponse()
        {
        }

    }
}