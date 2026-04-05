#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class FilterProjectEnvsResponseVariant3EnvTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.FilterProjectEnvsResponseVariant3EnvType?>
    {
        /// <inheritdoc />
        public override global::Vercel.FilterProjectEnvsResponseVariant3EnvType? Read(
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
                        return global::Vercel.FilterProjectEnvsResponseVariant3EnvTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.FilterProjectEnvsResponseVariant3EnvType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.FilterProjectEnvsResponseVariant3EnvType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.FilterProjectEnvsResponseVariant3EnvType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.FilterProjectEnvsResponseVariant3EnvTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
