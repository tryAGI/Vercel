
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared9a99a7cde55f3566Rulesets2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared9a99a7cde55f3566RulesetsActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared9a99a7cde55f3566RulesetsAction Action { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, global::Vercel.AutoSDKShared9a99a7cde55f3566RulesetsLogHeaders?>))]
        public global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::Vercel.AutoSDKShared9a99a7cde55f3566RulesetsLogHeaders?>? LogHeaders { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rateLimit")]
        public global::Vercel.AutoSDKShared9a99a7cde55f3566RulesetsRateLimit? RateLimit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect")]
        public global::Vercel.AutoSDKShared9a99a7cde55f3566RulesetsRedirect? Redirect { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared9a99a7cde55f3566Rulesets2" /> class.
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
        public AutoSDKShared9a99a7cde55f3566Rulesets2(
            global::Vercel.AutoSDKShared9a99a7cde55f3566RulesetsAction action,
            string? actionDuration,
            bool? bypassSystem,
            global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::Vercel.AutoSDKShared9a99a7cde55f3566RulesetsLogHeaders?>? logHeaders,
            global::Vercel.AutoSDKShared9a99a7cde55f3566RulesetsRateLimit? rateLimit,
            global::Vercel.AutoSDKShared9a99a7cde55f3566RulesetsRedirect? redirect)
        {
            this.Action = action;
            this.ActionDuration = actionDuration;
            this.BypassSystem = bypassSystem;
            this.LogHeaders = logHeaders;
            this.RateLimit = rateLimit;
            this.Redirect = redirect;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared9a99a7cde55f3566Rulesets2" /> class.
        /// </summary>
        public AutoSDKShared9a99a7cde55f3566Rulesets2()
        {
        }

    }
}