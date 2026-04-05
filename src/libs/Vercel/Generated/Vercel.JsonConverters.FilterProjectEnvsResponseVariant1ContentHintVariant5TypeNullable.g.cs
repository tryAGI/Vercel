#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class FilterProjectEnvsResponseVariant1ContentHintVariant5TypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.FilterProjectEnvsResponseVariant1ContentHintVariant5Type?>
    {
        /// <inheritdoc />
        public override global::Vercel.FilterProjectEnvsResponseVariant1ContentHintVariant5Type? Read(
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
                        return global::Vercel.FilterProjectEnvsResponseVariant1ContentHintVariant5TypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.FilterProjectEnvsResponseVariant1ContentHintVariant5Type)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.FilterProjectEnvsResponseVariant1ContentHintVariant5Type?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.FilterProjectEnvsResponseVariant1ContentHintVariant5Type? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.FilterProjectEnvsResponseVariant1ContentHintVariant5TypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
