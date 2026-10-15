
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedd474136b05e5e447
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedd474136b05e5e447HandleJsonConverter))]
        public global::Vercel.AutoSDKSharedd474136b05e5e447Handle? Handle { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedd474136b05e5e447Ha>? Has { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("missing")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedd474136b05e5e447MissingItem>? Missing { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mitigate")]
        public global::Vercel.AutoSDKSharedd474136b05e5e447Mitigate? Mitigate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_has")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedd474136b05e5e447ResponseHa>? ResponseHas { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.AutoSDKSharedd474136b05e5e447Src>))]
        public global::Vercel.OneOf<string, global::Vercel.AutoSDKSharedd474136b05e5e447Src>? Src { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public double? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tierRequirement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedd474136b05e5e447TierRequirementJsonConverter))]
        public global::Vercel.AutoSDKSharedd474136b05e5e447TierRequirement? TierRequirement { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transforms")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedd474136b05e5e447Transform>? Transforms { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedd474136b05e5e447" /> class.
        /// </summary>
        /// <param name="dest"></param>
        /// <param name="handle"></param>
        /// <param name="has"></param>
        /// <param name="missing"></param>
        /// <param name="mitigate"></param>
        /// <param name="responseHas"></param>
        /// <param name="src"></param>
        /// <param name="status"></param>
        /// <param name="tierRequirement"></param>
        /// <param name="transforms"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedd474136b05e5e447(
            string? dest,
            global::Vercel.AutoSDKSharedd474136b05e5e447Handle? handle,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedd474136b05e5e447Ha>? has,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedd474136b05e5e447MissingItem>? missing,
            global::Vercel.AutoSDKSharedd474136b05e5e447Mitigate? mitigate,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedd474136b05e5e447ResponseHa>? responseHas,
            global::Vercel.OneOf<string, global::Vercel.AutoSDKSharedd474136b05e5e447Src>? src,
            double? status,
            global::Vercel.AutoSDKSharedd474136b05e5e447TierRequirement? tierRequirement,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedd474136b05e5e447Transform>? transforms)
        {
            this.Dest = dest;
            this.Handle = handle;
            this.Has = has;
            this.Missing = missing;
            this.Mitigate = mitigate;
            this.ResponseHas = responseHas;
            this.Src = src;
            this.Status = status;
            this.TierRequirement = tierRequirement;
            this.Transforms = transforms;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedd474136b05e5e447" /> class.
        /// </summary>
        public AutoSDKSharedd474136b05e5e447()
        {
        }

    }
}