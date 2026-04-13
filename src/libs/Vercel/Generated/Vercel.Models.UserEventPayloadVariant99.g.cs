
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The payload of the event, if requested.
    /// </summary>
    public sealed partial class UserEventPayloadVariant99
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edgeConfig")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant99EdgeConfig EdgeConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fromAccount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant99FromAccount FromAccount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toAccount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UserEventPayloadVariant99ToAccount ToAccount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant99" /> class.
        /// </summary>
        /// <param name="edgeConfig"></param>
        /// <param name="fromAccount"></param>
        /// <param name="toAccount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant99(
            global::Vercel.UserEventPayloadVariant99EdgeConfig edgeConfig,
            global::Vercel.UserEventPayloadVariant99FromAccount fromAccount,
            global::Vercel.UserEventPayloadVariant99ToAccount toAccount)
        {
            this.EdgeConfig = edgeConfig ?? throw new global::System.ArgumentNullException(nameof(edgeConfig));
            this.FromAccount = fromAccount ?? throw new global::System.ArgumentNullException(nameof(fromAccount));
            this.ToAccount = toAccount ?? throw new global::System.ArgumentNullException(nameof(toAccount));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant99" /> class.
        /// </summary>
        public UserEventPayloadVariant99()
        {
        }
    }
}