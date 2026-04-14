#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateFlagResponseEnvironmentsFallthroughVariant3BaseTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.CreateFlagResponseEnvironmentsFallthroughVariant3BaseType?>
    {
        /// <inheritdoc />
        public override global::Vercel.CreateFlagResponseEnvironmentsFallthroughVariant3BaseType? Read(
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
                        return global::Vercel.CreateFlagResponseEnvironmentsFallthroughVariant3BaseTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.CreateFlagResponseEnvironmentsFallthroughVariant3BaseType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.CreateFlagResponseEnvironmentsFallthroughVariant3BaseType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.CreateFlagResponseEnvironmentsFallthroughVariant3BaseType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.CreateFlagResponseEnvironmentsFallthroughVariant3BaseTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
