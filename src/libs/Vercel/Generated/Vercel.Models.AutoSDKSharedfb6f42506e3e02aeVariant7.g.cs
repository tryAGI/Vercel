
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedfb6f42506e3e02aeVariant7
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedfb6f42506e3e02aeVariant7CodeJsonConverter))]
        public global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant7Code Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedfb6f42506e3e02aeVariant7" /> class.
        /// </summary>
        /// <param name="code"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedfb6f42506e3e02aeVariant7(
            global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant7Code code)
        {
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedfb6f42506e3e02aeVariant7" /> class.
        /// </summary>
        public AutoSDKSharedfb6f42506e3e02aeVariant7()
        {
        }

    }
}