
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Remote Execution Attack - Prevent unauthorized execution of remote scripts or commands.
    /// </summary>
    public sealed partial class AutoSDKSharedf05f436e77310b1fRce
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedf05f436e77310b1fRceActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedf05f436e77310b1fRceAction Action { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Active { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedf05f436e77310b1fRce" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="active"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedf05f436e77310b1fRce(
            global::Vercel.AutoSDKSharedf05f436e77310b1fRceAction action,
            bool active)
        {
            this.Action = action;
            this.Active = active;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedf05f436e77310b1fRce" /> class.
        /// </summary>
        public AutoSDKSharedf05f436e77310b1fRce()
        {
        }

    }
}