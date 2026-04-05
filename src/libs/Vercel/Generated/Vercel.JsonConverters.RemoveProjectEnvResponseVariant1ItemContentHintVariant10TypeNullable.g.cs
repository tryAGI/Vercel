#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class RemoveProjectEnvResponseVariant1ItemContentHintVariant10TypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.RemoveProjectEnvResponseVariant1ItemContentHintVariant10Type?>
    {
        /// <inheritdoc />
        public override global::Vercel.RemoveProjectEnvResponseVariant1ItemContentHintVariant10Type? Read(
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
                        return global::Vercel.RemoveProjectEnvResponseVariant1ItemContentHintVariant10TypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.RemoveProjectEnvResponseVariant1ItemContentHintVariant10Type)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.RemoveProjectEnvResponseVariant1ItemContentHintVariant10Type?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.RemoveProjectEnvResponseVariant1ItemContentHintVariant10Type? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.RemoveProjectEnvResponseVariant1ItemContentHintVariant10TypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
