
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShareda3770e4df73b880dRulesets2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShareda3770e4df73b880dRulesetsActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShareda3770e4df73b880dRulesetsAction Action { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, global::Vercel.AutoSDKShareda3770e4df73b880dRulesetsLogHeaders?>))]
        public global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::Vercel.AutoSDKShareda3770e4df73b880dRulesetsLogHeaders?>? LogHeaders { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rateLimit")]
        public global::Vercel.AutoSDKShareda3770e4df73b880dRulesetsRateLimit? RateLimit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect")]
        public global::Vercel.AutoSDKShareda3770e4df73b880dRulesetsRedirect? Redirect { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareda3770e4df73b880dRulesets2" /> class.
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
        public AutoSDKShareda3770e4df73b880dRulesets2(
            global::Vercel.AutoSDKShareda3770e4df73b880dRulesetsAction action,
            string? actionDuration,
            bool? bypassSystem,
            global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::Vercel.AutoSDKShareda3770e4df73b880dRulesetsLogHeaders?>? logHeaders,
            global::Vercel.AutoSDKShareda3770e4df73b880dRulesetsRateLimit? rateLimit,
            global::Vercel.AutoSDKShareda3770e4df73b880dRulesetsRedirect? redirect)
        {
            this.Action = action;
            this.ActionDuration = actionDuration;
            this.BypassSystem = bypassSystem;
            this.LogHeaders = logHeaders;
            this.RateLimit = rateLimit;
            this.Redirect = redirect;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShareda3770e4df73b880dRulesets2" /> class.
        /// </summary>
        public AutoSDKShareda3770e4df73b880dRulesets2()
        {
        }

    }
}