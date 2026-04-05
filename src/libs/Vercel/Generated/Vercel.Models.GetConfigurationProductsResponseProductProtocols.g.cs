
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConfigurationProductsResponseProductProtocols
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage")]
        public global::Vercel.GetConfigurationProductsResponseProductProtocolsStorage? Storage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimentation")]
        public global::Vercel.GetConfigurationProductsResponseProductProtocolsExperimentation? Experimentation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai")]
        public global::Vercel.GetConfigurationProductsResponseProductProtocolsAi? Ai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authentication")]
        public global::Vercel.GetConfigurationProductsResponseProductProtocolsAuthentication? Authentication { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("observability")]
        public global::Vercel.GetConfigurationProductsResponseProductProtocolsObservability? Observability { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video")]
        public global::Vercel.GetConfigurationProductsResponseProductProtocolsVideo? Video { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow")]
        public global::Vercel.GetConfigurationProductsResponseProductProtocolsWorkflow? Workflow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        public global::Vercel.GetConfigurationProductsResponseProductProtocolsChecks? Checks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logDrain")]
        public global::Vercel.GetConfigurationProductsResponseProductProtocolsLogDrain? LogDrain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceDrain")]
        public global::Vercel.GetConfigurationProductsResponseProductProtocolsTraceDrain? TraceDrain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messaging")]
        public global::Vercel.GetConfigurationProductsResponseProductProtocolsMessaging? Messaging { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("other")]
        public global::Vercel.GetConfigurationProductsResponseProductProtocolsOther? Other { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationProductsResponseProductProtocols" /> class.
        /// </summary>
        /// <param name="storage"></param>
        /// <param name="experimentation"></param>
        /// <param name="ai"></param>
        /// <param name="authentication"></param>
        /// <param name="observability"></param>
        /// <param name="video"></param>
        /// <param name="workflow"></param>
        /// <param name="checks"></param>
        /// <param name="logDrain"></param>
        /// <param name="traceDrain"></param>
        /// <param name="messaging"></param>
        /// <param name="other"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConfigurationProductsResponseProductProtocols(
            global::Vercel.GetConfigurationProductsResponseProductProtocolsStorage? storage,
            global::Vercel.GetConfigurationProductsResponseProductProtocolsExperimentation? experimentation,
            global::Vercel.GetConfigurationProductsResponseProductProtocolsAi? ai,
            global::Vercel.GetConfigurationProductsResponseProductProtocolsAuthentication? authentication,
            global::Vercel.GetConfigurationProductsResponseProductProtocolsObservability? observability,
            global::Vercel.GetConfigurationProductsResponseProductProtocolsVideo? video,
            global::Vercel.GetConfigurationProductsResponseProductProtocolsWorkflow? workflow,
            global::Vercel.GetConfigurationProductsResponseProductProtocolsChecks? checks,
            global::Vercel.GetConfigurationProductsResponseProductProtocolsLogDrain? logDrain,
            global::Vercel.GetConfigurationProductsResponseProductProtocolsTraceDrain? traceDrain,
            global::Vercel.GetConfigurationProductsResponseProductProtocolsMessaging? messaging,
            global::Vercel.GetConfigurationProductsResponseProductProtocolsOther? other)
        {
            this.Storage = storage;
            this.Experimentation = experimentation;
            this.Ai = ai;
            this.Authentication = authentication;
            this.Observability = observability;
            this.Video = video;
            this.Workflow = workflow;
            this.Checks = checks;
            this.LogDrain = logDrain;
            this.TraceDrain = traceDrain;
            this.Messaging = messaging;
            this.Other = other;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConfigurationProductsResponseProductProtocols" /> class.
        /// </summary>
        public GetConfigurationProductsResponseProductProtocols()
        {
        }
    }
}