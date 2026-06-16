#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class UploadProjectAvatarResponseEnvItemInternalContentHintTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.UploadProjectAvatarResponseEnvItemInternalContentHintType>
    {
        /// <inheritdoc />
        public override global::Vercel.UploadProjectAvatarResponseEnvItemInternalContentHintType Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Vercel.UploadProjectAvatarResponseEnvItemInternalContentHintTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.UploadProjectAvatarResponseEnvItemInternalContentHintType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.UploadProjectAvatarResponseEnvItemInternalContentHintType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.UploadProjectAvatarResponseEnvItemInternalContentHintType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.UploadProjectAvatarResponseEnvItemInternalContentHintTypeExtensions.ToValueString(value));
        }
    }
}
