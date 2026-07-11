
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetMicrofrontendsInGroupResponseProjectCreatorVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.GetMicrofrontendsInGroupResponseProjectCreatorVariant1TypeJsonConverter))]
        public global::Vercel.GetMicrofrontendsInGroupResponseProjectCreatorVariant1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("via")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetMicrofrontendsInGroupResponseProjectCreatorVariant1ViaVariant1, global::Vercel.GetMicrofrontendsInGroupResponseProjectCreatorVariant1ViaVariant2>))]
        public global::Vercel.OneOf<global::Vercel.GetMicrofrontendsInGroupResponseProjectCreatorVariant1ViaVariant1, global::Vercel.GetMicrofrontendsInGroupResponseProjectCreatorVariant1ViaVariant2>? Via { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.GetMicrofrontendsInGroupResponseProjectCreatorVariant1User User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMicrofrontendsInGroupResponseProjectCreatorVariant1" /> class.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="type"></param>
        /// <param name="via"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMicrofrontendsInGroupResponseProjectCreatorVariant1(
            global::Vercel.GetMicrofrontendsInGroupResponseProjectCreatorVariant1User user,
            global::Vercel.GetMicrofrontendsInGroupResponseProjectCreatorVariant1Type type,
            global::Vercel.OneOf<global::Vercel.GetMicrofrontendsInGroupResponseProjectCreatorVariant1ViaVariant1, global::Vercel.GetMicrofrontendsInGroupResponseProjectCreatorVariant1ViaVariant2>? via)
        {
            this.Type = type;
            this.Via = via;
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMicrofrontendsInGroupResponseProjectCreatorVariant1" /> class.
        /// </summary>
        public GetMicrofrontendsInGroupResponseProjectCreatorVariant1()
        {
        }

    }
}