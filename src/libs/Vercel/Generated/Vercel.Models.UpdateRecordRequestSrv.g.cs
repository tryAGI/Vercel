
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateRecordRequestSrv
    {
        /// <summary>
        /// Example: example2.com.
        /// </summary>
        /// <example>example2.com.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        public string? Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public int? Weight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("port")]
        public int? Port { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRecordRequestSrv" /> class.
        /// </summary>
        /// <param name="target">
        /// Example: example2.com.
        /// </param>
        /// <param name="weight"></param>
        /// <param name="port"></param>
        /// <param name="priority"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRecordRequestSrv(
            string? target,
            int? weight,
            int? port,
            int? priority)
        {
            this.Target = target;
            this.Weight = weight;
            this.Port = port;
            this.Priority = priority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRecordRequestSrv" /> class.
        /// </summary>
        public UpdateRecordRequestSrv()
        {
        }
    }
}