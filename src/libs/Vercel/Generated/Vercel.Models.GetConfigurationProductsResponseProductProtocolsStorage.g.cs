
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConfigurationProductsResponseProductProtocolsStorage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetConfigurationProductsResponseProductProtocolsStorageStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetConfigurationProductsResponseProductProtocolsStorageStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repl")]
        public global::Vercel.GetConfigurationProductsResponseProductProtocolsStorageRepl? Repl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationProductsResponseProductProtocolsStorage" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="repl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConfigurationProductsResponseProductProtocolsStorage(
            global::Vercel.GetConfigurationProductsResponseProductProtocolsStorageStatus status,
            global::Vercel.GetConfigurationProductsResponseProductProtocolsStorageRepl? repl)
        {
            this.Status = status;
            this.Repl = repl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationProductsResponseProductProtocolsStorage" /> class.
        /// </summary>
        public GetConfigurationProductsResponseProductProtocolsStorage()
        {
        }
    }
}