
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRecordRequestEnumSrv
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public double? Priority { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("port")]
        public double? Port { get; set; }

        /// <summary>
        /// Example: host.example.com
        /// </summary>
        /// <example>host.example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Target { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecordRequestEnumSrv" /> class.
        /// </summary>
        /// <param name="target">
        /// Example: host.example.com
        /// </param>
        /// <param name="priority"></param>
        /// <param name="weight"></param>
        /// <param name="port"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRecordRequestEnumSrv(
            string target,
            double? priority,
            double? weight,
            double? port)
        {
            this.Priority = priority;
            this.Weight = weight;
            this.Port = port;
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecordRequestEnumSrv" /> class.
        /// </summary>
        public CreateRecordRequestEnumSrv()
        {
        }
    }
}