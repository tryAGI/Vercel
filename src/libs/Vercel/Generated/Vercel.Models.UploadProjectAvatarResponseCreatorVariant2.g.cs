
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UploadProjectAvatarResponseCreatorVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UploadProjectAvatarResponseCreatorVariant2TypeJsonConverter))]
        public global::Vercel.UploadProjectAvatarResponseCreatorVariant2Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.UploadProjectAvatarResponseCreatorVariant2App App { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadProjectAvatarResponseCreatorVariant2" /> class.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadProjectAvatarResponseCreatorVariant2(
            global::Vercel.UploadProjectAvatarResponseCreatorVariant2App app,
            global::Vercel.UploadProjectAvatarResponseCreatorVariant2Type type)
        {
            this.Type = type;
            this.App = app ?? throw new global::System.ArgumentNullException(nameof(app));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadProjectAvatarResponseCreatorVariant2" /> class.
        /// </summary>
        public UploadProjectAvatarResponseCreatorVariant2()
        {
        }

    }
}