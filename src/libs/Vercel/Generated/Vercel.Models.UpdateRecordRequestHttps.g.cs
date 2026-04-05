
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateRecordRequestHttps
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Example: example2.com.
        /// </summary>
        /// <example>example2.com.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        public string? Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public string? Params { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRecordRequestHttps" /> class.
        /// </summary>
        /// <param name="priority"></param>
        /// <param name="target">
        /// Example: example2.com.
        /// </param>
        /// <param name="params"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRecordRequestHttps(
            int? priority,
            string? target,
            string? @params)
        {
            this.Priority = priority;
            this.Target = target;
            this.Params = @params;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRecordRequestHttps" /> class.
        /// </summary>
        public UpdateRecordRequestHttps()
        {
        }
    }
}