
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared2c06e7f88512c8b8Items
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public string? Default { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enum")]
        public global::System.Collections.Generic.IList<string>? Enum { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxLength")]
        public double? MaxLength { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minLength")]
        public double? MinLength { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        public string? Pattern { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared2c06e7f88512c8b8ItemsTypeJsonConverter))]
        public global::Vercel.AutoSDKShared2c06e7f88512c8b8ItemsType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared2c06e7f88512c8b8Items" /> class.
        /// </summary>
        /// <param name="default"></param>
        /// <param name="description"></param>
        /// <param name="enum"></param>
        /// <param name="maxLength"></param>
        /// <param name="minLength"></param>
        /// <param name="pattern"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared2c06e7f88512c8b8Items(
            string? @default,
            string? description,
            global::System.Collections.Generic.IList<string>? @enum,
            double? maxLength,
            double? minLength,
            string? pattern,
            global::Vercel.AutoSDKShared2c06e7f88512c8b8ItemsType type)
        {
            this.Default = @default;
            this.Description = description;
            this.Enum = @enum;
            this.MaxLength = maxLength;
            this.MinLength = minLength;
            this.Pattern = pattern;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared2c06e7f88512c8b8Items" /> class.
        /// </summary>
        public AutoSDKShared2c06e7f88512c8b8Items()
        {
        }

    }
}