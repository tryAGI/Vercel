#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateProjectEnvResponseCreatedItemContentHintVariant13TypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.CreateProjectEnvResponseCreatedItemContentHintVariant13Type>
    {
        /// <inheritdoc />
        public override global::Vercel.CreateProjectEnvResponseCreatedItemContentHintVariant13Type Read(
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
                        return global::Vercel.CreateProjectEnvResponseCreatedItemContentHintVariant13TypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.CreateProjectEnvResponseCreatedItemContentHintVariant13Type)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.CreateProjectEnvResponseCreatedItemContentHintVariant13Type);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.CreateProjectEnvResponseCreatedItemContentHintVariant13Type value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.CreateProjectEnvResponseCreatedItemContentHintVariant13TypeExtensions.ToValueString(value));
        }
    }
}
