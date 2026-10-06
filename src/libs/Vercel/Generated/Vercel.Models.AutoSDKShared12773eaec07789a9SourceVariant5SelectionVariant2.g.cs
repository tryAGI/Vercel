
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant2KindJsonConverter))]
        public global::Vercel.AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant2Kind Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant2" /> class.
        /// </summary>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant2(
            global::Vercel.AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant2Kind kind)
        {
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant2" /> class.
        /// </summary>
        public AutoSDKShared12773eaec07789a9SourceVariant5SelectionVariant2()
        {
        }

    }
}