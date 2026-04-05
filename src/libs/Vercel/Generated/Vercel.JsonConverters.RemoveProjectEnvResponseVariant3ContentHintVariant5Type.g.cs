#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class RemoveProjectEnvResponseVariant3ContentHintVariant5TypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.RemoveProjectEnvResponseVariant3ContentHintVariant5Type>
    {
        /// <inheritdoc />
        public override global::Vercel.RemoveProjectEnvResponseVariant3ContentHintVariant5Type Read(
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
                        return global::Vercel.RemoveProjectEnvResponseVariant3ContentHintVariant5TypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.RemoveProjectEnvResponseVariant3ContentHintVariant5Type)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.RemoveProjectEnvResponseVariant3ContentHintVariant5Type);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.RemoveProjectEnvResponseVariant3ContentHintVariant5Type value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.RemoveProjectEnvResponseVariant3ContentHintVariant5TypeExtensions.ToValueString(value));
        }
    }
}
