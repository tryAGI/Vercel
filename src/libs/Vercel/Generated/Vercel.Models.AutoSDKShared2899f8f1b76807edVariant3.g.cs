
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The principal who rolled back the project. Absent on historical rollbacks where the principal was a user (in this case, see `userId`).
    /// </summary>
    public sealed partial class AutoSDKShared2899f8f1b76807edVariant3
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AutoSDKShared2899f8f1b76807edVariant3App App { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AutoSDKShared2899f8f1b76807edVariant3TypeJsonConverter))]
        public global::Vercel.AutoSDKShared2899f8f1b76807edVariant3Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared2899f8f1b76807edVariant3" /> class.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSDKShared2899f8f1b76807edVariant3(
            global::Vercel.AutoSDKShared2899f8f1b76807edVariant3App app,
            global::Vercel.AutoSDKShared2899f8f1b76807edVariant3Type type)
        {
            this.App = app ?? throw new global::System.ArgumentNullException(nameof(app));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSDKShared2899f8f1b76807edVariant3" /> class.
        /// </summary>
        public AutoSDKShared2899f8f1b76807edVariant3()
        {
        }

    }
}