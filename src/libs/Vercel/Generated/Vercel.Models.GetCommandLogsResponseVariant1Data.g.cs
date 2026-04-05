
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetCommandLogsResponseVariant1Data
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetCommandLogsResponseVariant1DataCodeJsonConverter))]
        public global::Vercel.GetCommandLogsResponseVariant1DataCode Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetCommandLogsResponseVariant1DataMessageJsonConverter))]
        public global::Vercel.GetCommandLogsResponseVariant1DataMessage Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCommandLogsResponseVariant1Data" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetCommandLogsResponseVariant1Data(
            global::Vercel.GetCommandLogsResponseVariant1DataCode code,
            global::Vercel.GetCommandLogsResponseVariant1DataMessage message)
        {
            this.Code = code;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCommandLogsResponseVariant1Data" /> class.
        /// </summary>
        public GetCommandLogsResponseVariant1Data()
        {
        }
    }
}