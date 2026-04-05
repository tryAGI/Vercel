#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class FilterProjectEnvsResponseVariant1ContentHintVariant9TypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.FilterProjectEnvsResponseVariant1ContentHintVariant9Type>
    {
        /// <inheritdoc />
        public override global::Vercel.FilterProjectEnvsResponseVariant1ContentHintVariant9Type Read(
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
                        return global::Vercel.FilterProjectEnvsResponseVariant1ContentHintVariant9TypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.FilterProjectEnvsResponseVariant1ContentHintVariant9Type)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.FilterProjectEnvsResponseVariant1ContentHintVariant9Type);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.FilterProjectEnvsResponseVariant1ContentHintVariant9Type value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.FilterProjectEnvsResponseVariant1ContentHintVariant9TypeExtensions.ToValueString(value));
        }
    }
}
