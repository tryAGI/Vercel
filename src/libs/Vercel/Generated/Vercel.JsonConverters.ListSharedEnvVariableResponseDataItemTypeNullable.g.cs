#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListSharedEnvVariableResponseDataItemTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.ListSharedEnvVariableResponseDataItemType?>
    {
        /// <inheritdoc />
        public override global::Vercel.ListSharedEnvVariableResponseDataItemType? Read(
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
                        return global::Vercel.ListSharedEnvVariableResponseDataItemTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.ListSharedEnvVariableResponseDataItemType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.ListSharedEnvVariableResponseDataItemType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.ListSharedEnvVariableResponseDataItemType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.ListSharedEnvVariableResponseDataItemTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
