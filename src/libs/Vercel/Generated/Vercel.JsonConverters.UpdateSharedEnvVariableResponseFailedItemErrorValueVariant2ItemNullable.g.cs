#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateSharedEnvVariableResponseFailedItemErrorValueVariant2ItemNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.UpdateSharedEnvVariableResponseFailedItemErrorValueVariant2Item?>
    {
        /// <inheritdoc />
        public override global::Vercel.UpdateSharedEnvVariableResponseFailedItemErrorValueVariant2Item? Read(
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
                        return global::Vercel.UpdateSharedEnvVariableResponseFailedItemErrorValueVariant2ItemExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.UpdateSharedEnvVariableResponseFailedItemErrorValueVariant2Item)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.UpdateSharedEnvVariableResponseFailedItemErrorValueVariant2Item?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.UpdateSharedEnvVariableResponseFailedItemErrorValueVariant2Item? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.UpdateSharedEnvVariableResponseFailedItemErrorValueVariant2ItemExtensions.ToValueString(value.Value));
            }
        }
    }
}
