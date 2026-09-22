
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedfb6f42506e3e02aeVariant10Details
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invalidField")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedfb6f42506e3e02aeVariant10DetailsInvalidFieldJsonConverter))]
        public global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant10DetailsInvalidField? InvalidField { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedfb6f42506e3e02aeVariant10Details" /> class.
        /// </summary>
        /// <param name="invalidField"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedfb6f42506e3e02aeVariant10Details(
            global::Vercel.AutoSDKSharedfb6f42506e3e02aeVariant10DetailsInvalidField? invalidField)
        {
            this.InvalidField = invalidField;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedfb6f42506e3e02aeVariant10Details" /> class.
        /// </summary>
        public AutoSDKSharedfb6f42506e3e02aeVariant10Details()
        {
        }

    }
}