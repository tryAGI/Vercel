#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class UploadProjectAvatarResponseTargetsChecksStateNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.UploadProjectAvatarResponseTargetsChecksState?>
    {
        /// <inheritdoc />
        public override global::Vercel.UploadProjectAvatarResponseTargetsChecksState? Read(
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
                        return global::Vercel.UploadProjectAvatarResponseTargetsChecksStateExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.UploadProjectAvatarResponseTargetsChecksState)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.UploadProjectAvatarResponseTargetsChecksState?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.UploadProjectAvatarResponseTargetsChecksState? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.UploadProjectAvatarResponseTargetsChecksStateExtensions.ToValueString(value.Value));
            }
        }
    }
}
