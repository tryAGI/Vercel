#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateSharedEnvVariableResponseCreatedItemTargetItemNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.CreateSharedEnvVariableResponseCreatedItemTargetItem?>
    {
        /// <inheritdoc />
        public override global::Vercel.CreateSharedEnvVariableResponseCreatedItemTargetItem? Read(
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
                        return global::Vercel.CreateSharedEnvVariableResponseCreatedItemTargetItemExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.CreateSharedEnvVariableResponseCreatedItemTargetItem)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.CreateSharedEnvVariableResponseCreatedItemTargetItem?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.CreateSharedEnvVariableResponseCreatedItemTargetItem? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.CreateSharedEnvVariableResponseCreatedItemTargetItemExtensions.ToValueString(value.Value));
            }
        }
    }
}
