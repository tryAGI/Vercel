
#nullable enable

namespace Vercel
{
    /// <summary>
    /// an object to be decoded into a globally shared symbol
    /// </summary>
    public sealed partial class PropertyKeyVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_tag")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.PropertyKeyVariant3TagJsonConverter))]
        public global::Vercel.PropertyKeyVariant3Tag Tag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyKeyVariant3" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="tag"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PropertyKeyVariant3(
            string key,
            global::Vercel.PropertyKeyVariant3Tag tag)
        {
            this.Tag = tag;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyKeyVariant3" /> class.
        /// </summary>
        public PropertyKeyVariant3()
        {
        }
    }
}