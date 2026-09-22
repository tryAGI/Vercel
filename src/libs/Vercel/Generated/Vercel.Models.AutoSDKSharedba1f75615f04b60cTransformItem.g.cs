
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedba1f75615f04b60cTransformItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedba1f75615f04b60cTransformItem" /> class.
        /// </summary>
        /// <param name="headers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedba1f75615f04b60cTransformItem(
            global::System.Collections.Generic.Dictionary<string, string>? headers)
        {
            this.Headers = headers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedba1f75615f04b60cTransformItem" /> class.
        /// </summary>
        public AutoSDKSharedba1f75615f04b60cTransformItem()
        {
        }

    }
}