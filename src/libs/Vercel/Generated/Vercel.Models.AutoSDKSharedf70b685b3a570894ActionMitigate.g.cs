
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKSharedf70b685b3a570894ActionMitigate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKSharedf70b685b3a570894ActionMitigateActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKSharedf70b685b3a570894ActionMitigateAction Action { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, global::Vercel.AutoSDKSharedf70b685b3a570894ActionMitigateLogHeaders?>))]
        public global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::Vercel.AutoSDKSharedf70b685b3a570894ActionMitigateLogHeaders?>? LogHeaders { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rateLimit")]
        public global::Vercel.AutoSDKSharedf70b685b3a570894ActionMitigateRateLimit? RateLimit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect")]
        public global::Vercel.AutoSDKSharedf70b685b3a570894ActionMitigateRedirect? Redirect { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedf70b685b3a570894ActionMitigate" /> class.
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
        public AutoSDKSharedf70b685b3a570894ActionMitigate(
            global::Vercel.AutoSDKSharedf70b685b3a570894ActionMitigateAction action,
            string? actionDuration,
            bool? bypassSystem,
            global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::Vercel.AutoSDKSharedf70b685b3a570894ActionMitigateLogHeaders?>? logHeaders,
            global::Vercel.AutoSDKSharedf70b685b3a570894ActionMitigateRateLimit? rateLimit,
            global::Vercel.AutoSDKSharedf70b685b3a570894ActionMitigateRedirect? redirect)
        {
            this.Action = action;
            this.ActionDuration = actionDuration;
            this.BypassSystem = bypassSystem;
            this.LogHeaders = logHeaders;
            this.RateLimit = rateLimit;
            this.Redirect = redirect;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKSharedf70b685b3a570894ActionMitigate" /> class.
        /// </summary>
        public AutoSDKSharedf70b685b3a570894ActionMitigate()
        {
        }

    }
}