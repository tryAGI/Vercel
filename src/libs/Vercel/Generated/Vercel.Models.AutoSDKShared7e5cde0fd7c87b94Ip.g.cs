
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoSDKShared7e5cde0fd7c87b94Ip
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared7e5cde0fd7c87b94IpActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared7e5cde0fd7c87b94IpAction Action { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hostname { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ip")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ip { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notes")]
        public string? Notes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared7e5cde0fd7c87b94Ip" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="hostname"></param>
        /// <param name="id"></param>
        /// <param name="ip"></param>
        /// <param name="notes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared7e5cde0fd7c87b94Ip(
            global::Vercel.AutoSDKShared7e5cde0fd7c87b94IpAction action,
            string hostname,
            string id,
            string ip,
            string? notes)
        {
            this.Action = action;
            this.Hostname = hostname ?? throw new global::System.ArgumentNullException(nameof(hostname));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Ip = ip ?? throw new global::System.ArgumentNullException(nameof(ip));
            this.Notes = notes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared7e5cde0fd7c87b94Ip" /> class.
        /// </summary>
        public AutoSDKShared7e5cde0fd7c87b94Ip()
        {
        }

    }
}