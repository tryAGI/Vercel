
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared6b9922eb6c026513
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared6b9922eb6c026513HandleJsonConverter))]
        public global::Vercel.AutoSDKShared6b9922eb6c026513Handle? Handle { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared6b9922eb6c026513Ha>? Has { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("missing")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared6b9922eb6c026513MissingItem>? Missing { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mitigate")]
        public global::Vercel.AutoSDKShared6b9922eb6c026513Mitigate? Mitigate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.AutoSDKShared6b9922eb6c026513Src>))]
        public global::Vercel.OneOf<string, global::Vercel.AutoSDKShared6b9922eb6c026513Src>? Src { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public double? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tierRequirement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared6b9922eb6c026513TierRequirementJsonConverter))]
        public global::Vercel.AutoSDKShared6b9922eb6c026513TierRequirement? TierRequirement { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transforms")]
        public global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared6b9922eb6c026513Transform>? Transforms { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared6b9922eb6c026513" /> class.
        /// </summary>
        /// <param name="dest"></param>
        /// <param name="handle"></param>
        /// <param name="has"></param>
        /// <param name="missing"></param>
        /// <param name="mitigate"></param>
        /// <param name="src"></param>
        /// <param name="status"></param>
        /// <param name="tierRequirement"></param>
        /// <param name="transforms"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared6b9922eb6c026513(
            string? dest,
            global::Vercel.AutoSDKShared6b9922eb6c026513Handle? handle,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared6b9922eb6c026513Ha>? has,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared6b9922eb6c026513MissingItem>? missing,
            global::Vercel.AutoSDKShared6b9922eb6c026513Mitigate? mitigate,
            global::Vercel.OneOf<string, global::Vercel.AutoSDKShared6b9922eb6c026513Src>? src,
            double? status,
            global::Vercel.AutoSDKShared6b9922eb6c026513TierRequirement? tierRequirement,
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared6b9922eb6c026513Transform>? transforms)
        {
            this.Dest = dest;
            this.Handle = handle;
            this.Has = has;
            this.Missing = missing;
            this.Mitigate = mitigate;
            this.Src = src;
            this.Status = status;
            this.TierRequirement = tierRequirement;
            this.Transforms = transforms;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared6b9922eb6c026513" /> class.
        /// </summary>
        public AutoSDKShared6b9922eb6c026513()
        {
        }

    }
}