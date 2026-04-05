#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetDrainsResponseDrainsVariant1ItemFilterV2Variant2VersionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetDrainsResponseDrainsVariant1ItemFilterV2Variant2Version?>
    {
        /// <inheritdoc />
        public override global::Vercel.GetDrainsResponseDrainsVariant1ItemFilterV2Variant2Version? Read(
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
                        return global::Vercel.GetDrainsResponseDrainsVariant1ItemFilterV2Variant2VersionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetDrainsResponseDrainsVariant1ItemFilterV2Variant2Version)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetDrainsResponseDrainsVariant1ItemFilterV2Variant2Version?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetDrainsResponseDrainsVariant1ItemFilterV2Variant2Version? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.GetDrainsResponseDrainsVariant1ItemFilterV2Variant2VersionExtensions.ToValueString(value.Value));
            }
        }
    }
}
