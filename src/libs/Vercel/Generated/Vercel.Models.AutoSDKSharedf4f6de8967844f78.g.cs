
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedf4f6de8967844f78
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("drains")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedd91738a37c191d9eJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedd91738a37c191d9e Drains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedf4f6de8967844f78" /> class.
        /// </summary>
        /// <param name="drains"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedf4f6de8967844f78(
            global::Vercel.AutoSDKSharedd91738a37c191d9e drains)
        {
            this.Drains = drains;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedf4f6de8967844f78" /> class.
        /// </summary>
        public AutoSDKSharedf4f6de8967844f78()
        {
        }

    }
}