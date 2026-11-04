
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedfaf92fa84e99abddVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dest")]
        public string? Dest { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("handle")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedfaf92fa84e99abddVariant2HandleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedfaf92fa84e99abddVariant2Handle Handle { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        public string? Src { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public double? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedfaf92fa84e99abddVariant2" /> class.
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="dest"></param>
        /// <param name="src"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedfaf92fa84e99abddVariant2(
            global::Vercel.AutoSDKSharedfaf92fa84e99abddVariant2Handle handle,
            string? dest,
            string? src,
            double? status)
        {
            this.Dest = dest;
            this.Handle = handle;
            this.Src = src;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedfaf92fa84e99abddVariant2" /> class.
        /// </summary>
        public AutoSDKSharedfaf92fa84e99abddVariant2()
        {
        }

    }
}