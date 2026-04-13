
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant31
    {
        /// <summary>
        /// The App's name at the moment this even was published (it may have changed since then).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AppName { get; set; }

        /// <summary>
        /// The App's ID. Note that not all historical events have this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appId")]
        public string? AppId { get; set; }

        /// <summary>
        /// Note that not all historical events have this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        public global::Vercel.UserEventPayloadVariant31App? App { get; set; }

        /// <summary>
        /// UNIX timestamp in seconds. Tokens issued before this timestamp will be revoked. Note that not all historical events have this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuedBefore")]
        public double? IssuedBefore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant31" /> class.
        /// </summary>
        /// <param name="appName">
        /// The App's name at the moment this even was published (it may have changed since then).
        /// </param>
        /// <param name="appId">
        /// The App's ID. Note that not all historical events have this field.
        /// </param>
        /// <param name="app">
        /// Note that not all historical events have this field.
        /// </param>
        /// <param name="issuedBefore">
        /// UNIX timestamp in seconds. Tokens issued before this timestamp will be revoked. Note that not all historical events have this field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant31(
            string appName,
            string? appId,
            global::Vercel.UserEventPayloadVariant31App? app,
            double? issuedBefore)
        {
            this.AppName = appName ?? throw new global::System.ArgumentNullException(nameof(appName));
            this.AppId = appId;
            this.App = app;
            this.IssuedBefore = issuedBefore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant31" /> class.
        /// </summary>
        public UserEventPayloadVariant31()
        {
        }
    }
}