
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The principal who rolled back the project. Absent on historical rollbacks where the principal was a user (in this case, see `userId`).
    /// </summary>
    public sealed partial class AutoSDKShared2899f8f1b76807edVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared2899f8f1b76807edVariant1TypeJsonConverter))]
        public global::Vercel.AutoSDKShared2899f8f1b76807edVariant1Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("via")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKShared2899f8f1b76807edVariant1ViaVariant1, global::Vercel.AutoSDKShared2899f8f1b76807edVariant1ViaVariant2>))]
        public global::Vercel.OneOf<global::Vercel.AutoSDKShared2899f8f1b76807edVariant1ViaVariant1, global::Vercel.AutoSDKShared2899f8f1b76807edVariant1ViaVariant2>? Via { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared2899f8f1b76807edVariant1User User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared2899f8f1b76807edVariant1" /> class.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="type"></param>
        /// <param name="via"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared2899f8f1b76807edVariant1(
            global::Vercel.AutoSDKShared2899f8f1b76807edVariant1User user,
            global::Vercel.AutoSDKShared2899f8f1b76807edVariant1Type type,
            global::Vercel.OneOf<global::Vercel.AutoSDKShared2899f8f1b76807edVariant1ViaVariant1, global::Vercel.AutoSDKShared2899f8f1b76807edVariant1ViaVariant2>? via)
        {
            this.Type = type;
            this.Via = via;
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared2899f8f1b76807edVariant1" /> class.
        /// </summary>
        public AutoSDKShared2899f8f1b76807edVariant1()
        {
        }

    }
}