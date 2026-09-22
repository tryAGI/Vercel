
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared6b9922eb6c026513Mitigate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared6b9922eb6c026513MitigateActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared6b9922eb6c026513MitigateAction Action { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("erl")]
        public global::Vercel.AutoSDKShared6b9922eb6c026513MitigateErl? Erl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("log_headers")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, global::Vercel.AutoSDKShared6b9922eb6c026513MitigateLogHeaders?>))]
        public global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::Vercel.AutoSDKShared6b9922eb6c026513MitigateLogHeaders?>? LogHeaders { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rule_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RuleId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        public double? Ttl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared6b9922eb6c026513Mitigate" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="ruleId"></param>
        /// <param name="erl"></param>
        /// <param name="logHeaders"></param>
        /// <param name="ttl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared6b9922eb6c026513Mitigate(
            global::Vercel.AutoSDKShared6b9922eb6c026513MitigateAction action,
            string ruleId,
            global::Vercel.AutoSDKShared6b9922eb6c026513MitigateErl? erl,
            global::Vercel.OneOf<global::System.Collections.Generic.IList<string>, global::Vercel.AutoSDKShared6b9922eb6c026513MitigateLogHeaders?>? logHeaders,
            double? ttl)
        {
            this.Action = action;
            this.Erl = erl;
            this.LogHeaders = logHeaders;
            this.RuleId = ruleId ?? throw new global::System.ArgumentNullException(nameof(ruleId));
            this.Ttl = ttl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared6b9922eb6c026513Mitigate" /> class.
        /// </summary>
        public AutoSDKShared6b9922eb6c026513Mitigate()
        {
        }

    }
}