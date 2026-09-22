
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared9554e4a81de92250
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AutoSDKShared9554e4a81de92250HaVariant1, global::Vercel.AutoSDKShared9554e4a81de92250HaVariant2>>? Has { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared9554e4a81de92250Header> Headers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("missing")]
        public global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AutoSDKShared9554e4a81de92250MissingItemVariant1, global::Vercel.AutoSDKShared9554e4a81de92250MissingItemVariant2>>? Missing { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared9554e4a81de92250" /> class.
        /// </summary>
        /// <param name="headers"></param>
        /// <param name="source"></param>
        /// <param name="has"></param>
        /// <param name="missing"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared9554e4a81de92250(
            global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared9554e4a81de92250Header> headers,
            string source,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AutoSDKShared9554e4a81de92250HaVariant1, global::Vercel.AutoSDKShared9554e4a81de92250HaVariant2>>? has,
            global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AutoSDKShared9554e4a81de92250MissingItemVariant1, global::Vercel.AutoSDKShared9554e4a81de92250MissingItemVariant2>>? missing)
        {
            this.Has = has;
            this.Headers = headers ?? throw new global::System.ArgumentNullException(nameof(headers));
            this.Missing = missing;
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared9554e4a81de92250" /> class.
        /// </summary>
        public AutoSDKShared9554e4a81de92250()
        {
        }

    }
}