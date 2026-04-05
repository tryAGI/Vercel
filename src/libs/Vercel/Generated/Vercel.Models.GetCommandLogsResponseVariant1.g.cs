
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetCommandLogsResponseVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Stream { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetCommandLogsResponseVariant1Data Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCommandLogsResponseVariant1" /> class.
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetCommandLogsResponseVariant1(
            string stream,
            global::Vercel.GetCommandLogsResponseVariant1Data data)
        {
            this.Stream = stream ?? throw new global::System.ArgumentNullException(nameof(stream));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCommandLogsResponseVariant1" /> class.
        /// </summary>
        public GetCommandLogsResponseVariant1()
        {
        }
    }
}