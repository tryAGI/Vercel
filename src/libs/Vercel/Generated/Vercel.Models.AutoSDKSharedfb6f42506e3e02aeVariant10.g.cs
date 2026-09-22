
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedfb6f42506e3e02aeVariant10
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedfb6f42506e3e02aeVariant10CodeJsonConverter))]
        public global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant10Code Code { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant10Details Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedfb6f42506e3e02aeVariant10" /> class.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="code"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedfb6f42506e3e02aeVariant10(
            global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant10Details details,
            global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant10Code code)
        {
            this.Code = code;
            this.Details = details ?? throw new global::System.ArgumentNullException(nameof(details));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedfb6f42506e3e02aeVariant10" /> class.
        /// </summary>
        public AutoSDKSharedfb6f42506e3e02aeVariant10()
        {
        }

    }
}