
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant73
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mxPriority")]
        public double? MxPriority { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant73" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        /// <param name="name"></param>
        /// <param name="domain"></param>
        /// <param name="type"></param>
        /// <param name="mxPriority"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant73(
            string id,
            string value,
            string name,
            string domain,
            string type,
            double? mxPriority)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.MxPriority = mxPriority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant73" /> class.
        /// </summary>
        public UserEventPayloadVariant73()
        {
        }
    }
}