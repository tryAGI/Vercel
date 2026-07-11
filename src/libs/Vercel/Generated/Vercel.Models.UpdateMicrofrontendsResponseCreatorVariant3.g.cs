
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateMicrofrontendsResponseCreatorVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UpdateMicrofrontendsResponseCreatorVariant3TypeJsonConverter))]
        public global::Vercel.UpdateMicrofrontendsResponseCreatorVariant3Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UpdateMicrofrontendsResponseCreatorVariant3Integration Integration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMicrofrontendsResponseCreatorVariant3" /> class.
        /// </summary>
        /// <param name="integration"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateMicrofrontendsResponseCreatorVariant3(
            global::Vercel.UpdateMicrofrontendsResponseCreatorVariant3Integration integration,
            global::Vercel.UpdateMicrofrontendsResponseCreatorVariant3Type type)
        {
            this.Type = type;
            this.Integration = integration ?? throw new global::System.ArgumentNullException(nameof(integration));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMicrofrontendsResponseCreatorVariant3" /> class.
        /// </summary>
        public UpdateMicrofrontendsResponseCreatorVariant3()
        {
        }

    }
}