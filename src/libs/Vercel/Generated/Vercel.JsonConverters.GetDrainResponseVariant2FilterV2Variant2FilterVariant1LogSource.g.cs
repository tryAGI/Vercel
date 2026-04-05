#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetDrainResponseVariant2FilterV2Variant2FilterVariant1LogSourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource>
    {
        /// <inheritdoc />
        public override global::Vercel.GetDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource Read(
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
                        return global::Vercel.GetDrainResponseVariant2FilterV2Variant2FilterVariant1LogSourceExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetDrainResponseVariant2FilterV2Variant2FilterVariant1LogSource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.GetDrainResponseVariant2FilterV2Variant2FilterVariant1LogSourceExtensions.ToValueString(value));
        }
    }
}
