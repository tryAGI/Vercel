
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRecordRequestEnumHttps
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public double? Priority { get; set; }

        /// <summary>
        /// Example: host.example.com
        /// </summary>
        /// <example>host.example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Target { get; set; }

        /// <summary>
        /// Example: alpn=h2,h3
        /// </summary>
        /// <example>alpn=h2,h3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public string? Params { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecordRequestEnumHttps" /> class.
        /// </summary>
        /// <param name="target">
        /// Example: host.example.com
        /// </param>
        /// <param name="priority"></param>
        /// <param name="params">
        /// Example: alpn=h2,h3
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRecordRequestEnumHttps(
            string target,
            double? priority,
            string? @params)
        {
            this.Priority = priority;
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
            this.Params = @params;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecordRequestEnumHttps" /> class.
        /// </summary>
        public CreateRecordRequestEnumHttps()
        {
        }
    }
}