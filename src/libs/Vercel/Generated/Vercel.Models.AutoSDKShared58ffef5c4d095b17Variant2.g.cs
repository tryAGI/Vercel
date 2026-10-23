
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared58ffef5c4d095b17Variant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared58ffef5c4d095b17Variant2Project Project { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared58ffef5c4d095b17Variant2TypeJsonConverter))]
        public global::Vercel.AutoSDKShared58ffef5c4d095b17Variant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared58ffef5c4d095b17Variant2" /> class.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared58ffef5c4d095b17Variant2(
            global::Vercel.AutoSDKShared58ffef5c4d095b17Variant2Project project,
            global::Vercel.AutoSDKShared58ffef5c4d095b17Variant2Type type)
        {
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared58ffef5c4d095b17Variant2" /> class.
        /// </summary>
        public AutoSDKShared58ffef5c4d095b17Variant2()
        {
        }

    }
}