
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShareda2a71ce8831cd3f8Variant2
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShareda2a71ce8831cd3f8Variant2HandleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShareda2a71ce8831cd3f8Variant2Handle Handle { get; set; }

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
        /// Initializes a new instance of the <see cref="AutoSDKShareda2a71ce8831cd3f8Variant2" /> class.
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="dest"></param>
        /// <param name="src"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShareda2a71ce8831cd3f8Variant2(
            global::Vercel.AutoSDKShareda2a71ce8831cd3f8Variant2Handle handle,
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
        /// Initializes a new instance of the <see cref="AutoSDKShareda2a71ce8831cd3f8Variant2" /> class.
        /// </summary>
        public AutoSDKShareda2a71ce8831cd3f8Variant2()
        {
        }

    }
}