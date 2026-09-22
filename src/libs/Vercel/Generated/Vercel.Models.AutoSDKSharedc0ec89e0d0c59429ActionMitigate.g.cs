
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedc0ec89e0d0c59429ActionMitigate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedc0ec89e0d0c59429ActionMitigateActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedc0ec89e0d0c59429ActionMitigateAction Action { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actionDuration")]
        public string? ActionDuration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bypassSystem")]
        public bool? BypassSystem { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logHeaders")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, global::Vercel.AutoSDKSharedc0ec89e0d0c59429ActionMitigateLogHeaders?>))]
        public global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::Vercel.AutoSDKSharedc0ec89e0d0c59429ActionMitigateLogHeaders?>? LogHeaders { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rateLimit")]
        public global::Vercel.AutoSDKSharedc0ec89e0d0c59429ActionMitigateRateLimit? RateLimit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect")]
        public global::Vercel.AutoSDKSharedc0ec89e0d0c59429ActionMitigateRedirect? Redirect { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedc0ec89e0d0c59429ActionMitigate" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="actionDuration"></param>
        /// <param name="bypassSystem"></param>
        /// <param name="logHeaders"></param>
        /// <param name="rateLimit"></param>
        /// <param name="redirect"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKSharedc0ec89e0d0c59429ActionMitigate(
            global::Vercel.AutoSDKSharedc0ec89e0d0c59429ActionMitigateAction action,
            string? actionDuration,
            bool? bypassSystem,
            global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::Vercel.AutoSDKSharedc0ec89e0d0c59429ActionMitigateLogHeaders?>? logHeaders,
            global::Vercel.AutoSDKSharedc0ec89e0d0c59429ActionMitigateRateLimit? rateLimit,
            global::Vercel.AutoSDKSharedc0ec89e0d0c59429ActionMitigateRedirect? redirect)
        {
            this.Action = action;
            this.ActionDuration = actionDuration;
            this.BypassSystem = bypassSystem;
            this.LogHeaders = logHeaders;
            this.RateLimit = rateLimit;
            this.Redirect = redirect;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedc0ec89e0d0c59429ActionMitigate" /> class.
        /// </summary>
        public AutoSDKSharedc0ec89e0d0c59429ActionMitigate()
        {
        }

    }
}