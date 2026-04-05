
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDeploymentEventsResponseVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetDeploymentEventsResponseVariant1TypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDeploymentEventsResponseVariant1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetDeploymentEventsResponseVariant1Payload Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentEventsResponseVariant1" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="created"></param>
        /// <param name="payload"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentEventsResponseVariant1(
            global::Vercel.GetDeploymentEventsResponseVariant1Type type,
            double created,
            global::Vercel.GetDeploymentEventsResponseVariant1Payload payload)
        {
            this.Type = type;
            this.Created = created;
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentEventsResponseVariant1" /> class.
        /// </summary>
        public GetDeploymentEventsResponseVariant1()
        {
        }
    }
}