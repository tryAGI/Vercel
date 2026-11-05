
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedab64e9622c80dc17
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedab64e9622c80dc17HandleJsonConverter))]
        public global::Vercel.AutoSDKSharedab64e9622c80dc17Handle? Handle { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedab64e9622c80dc17Ha>? Has { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("missing")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedab64e9622c80dc17MissingItem>? Missing { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mitigate")]
        public global::Vercel.AutoSDKSharedab64e9622c80dc17Mitigate? Mitigate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_has")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedab64e9622c80dc17ResponseHa>? ResponseHas { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_missing")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedab64e9622c80dc17ResponseMissingItem>? ResponseMissing { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.AutoSDKSharedab64e9622c80dc17Src>))]
        public global::Vercel.OneOf<string, global::Vercel.AutoSDKSharedab64e9622c80dc17Src>? Src { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public double? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tierRequirement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedab64e9622c80dc17TierRequirementJsonConverter))]
        public global::Vercel.AutoSDKSharedab64e9622c80dc17TierRequirement? TierRequirement { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transforms")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedab64e9622c80dc17Transform>? Transforms { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedab64e9622c80dc17" /> class.
        /// </summary>
        /// <param name="dest"></param>
        /// <param name="handle"></param>
        /// <param name="has"></param>
        /// <param name="missing"></param>
        /// <param name="mitigate"></param>
        /// <param name="responseHas"></param>
        /// <param name="responseMissing"></param>
        /// <param name="src"></param>
        /// <param name="status"></param>
        /// <param name="tierRequirement"></param>
        /// <param name="transforms"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedab64e9622c80dc17(
            string? dest,
            global::Vercel.AutoSDKSharedab64e9622c80dc17Handle? handle,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedab64e9622c80dc17Ha>? has,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedab64e9622c80dc17MissingItem>? missing,
            global::Vercel.AutoSDKSharedab64e9622c80dc17Mitigate? mitigate,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedab64e9622c80dc17ResponseHa>? responseHas,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedab64e9622c80dc17ResponseMissingItem>? responseMissing,
            global::Vercel.OneOf<string, global::Vercel.AutoSDKSharedab64e9622c80dc17Src>? src,
            double? status,
            global::Vercel.AutoSDKSharedab64e9622c80dc17TierRequirement? tierRequirement,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedab64e9622c80dc17Transform>? transforms)
        {
            this.Dest = dest;
            this.Handle = handle;
            this.Has = has;
            this.Missing = missing;
            this.Mitigate = mitigate;
            this.ResponseHas = responseHas;
            this.ResponseMissing = responseMissing;
            this.Src = src;
            this.Status = status;
            this.TierRequirement = tierRequirement;
            this.Transforms = transforms;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedab64e9622c80dc17" /> class.
        /// </summary>
        public AutoSDKSharedab64e9622c80dc17()
        {
        }

    }
}