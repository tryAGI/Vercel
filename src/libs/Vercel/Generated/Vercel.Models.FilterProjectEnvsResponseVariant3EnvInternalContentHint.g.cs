
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Similar to `contentHints`, but should not be exposed to the user.
    /// </summary>
    public sealed partial class FilterProjectEnvsResponseVariant3EnvInternalContentHint
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.FilterProjectEnvsResponseVariant3EnvInternalContentHintTypeJsonConverter))]
        public global::Vercel.FilterProjectEnvsResponseVariant3EnvInternalContentHintType Type { get; set; }

        /// <summary>
        /// Contains the `value` of the env variable, encrypted with a special key to make decryption possible in the subscriber Lambda.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encryptedValue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EncryptedValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterProjectEnvsResponseVariant3EnvInternalContentHint" /> class.
        /// </summary>
        /// <param name="encryptedValue">
        /// Contains the `value` of the env variable, encrypted with a special key to make decryption possible in the subscriber Lambda.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilterProjectEnvsResponseVariant3EnvInternalContentHint(
            string encryptedValue,
            global::Vercel.FilterProjectEnvsResponseVariant3EnvInternalContentHintType type)
        {
            this.Type = type;
            this.EncryptedValue = encryptedValue ?? throw new global::System.ArgumentNullException(nameof(encryptedValue));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterProjectEnvsResponseVariant3EnvInternalContentHint" /> class.
        /// </summary>
        public FilterProjectEnvsResponseVariant3EnvInternalContentHint()
        {
        }
    }
}