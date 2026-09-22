
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Multipart Attack - Block attempts to bypass security controls using multipart/form-data encoding.
    /// </summary>
    public sealed partial class AutoSDKSharedf05f436e77310b1fMa
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedf05f436e77310b1fMaActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedf05f436e77310b1fMaAction Action { get; set; }

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
        /// Initializes a new instance of the <see cref="AutoSDKSharedf05f436e77310b1fMa" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="active"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedf05f436e77310b1fMa(
            global::Vercel.AutoSDKSharedf05f436e77310b1fMaAction action,
            bool active)
        {
            this.Action = action;
            this.Active = active;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedf05f436e77310b1fMa" /> class.
        /// </summary>
        public AutoSDKSharedf05f436e77310b1fMa()
        {
        }

    }
}