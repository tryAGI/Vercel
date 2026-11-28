
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetSessionCommandLogsResponseVariant2Data
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetSessionCommandLogsResponseVariant2DataCodeJsonConverter))]
        public global::Vercel.GetSessionCommandLogsResponseVariant2DataCode Code { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetSessionCommandLogsResponseVariant2DataMessageJsonConverter))]
        public global::Vercel.GetSessionCommandLogsResponseVariant2DataMessage Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSessionCommandLogsResponseVariant2Data" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSessionCommandLogsResponseVariant2Data(
            global::Vercel.GetSessionCommandLogsResponseVariant2DataCode code,
            global::Vercel.GetSessionCommandLogsResponseVariant2DataMessage message)
        {
            this.Code = code;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSessionCommandLogsResponseVariant2Data" /> class.
        /// </summary>
        public GetSessionCommandLogsResponseVariant2Data()
        {
        }

    }
}