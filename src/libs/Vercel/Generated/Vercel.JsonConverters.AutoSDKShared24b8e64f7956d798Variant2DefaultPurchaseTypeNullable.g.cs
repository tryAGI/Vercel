#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutoSDKShared24b8e64f7956d798Variant2DefaultPurchaseTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKShared24b8e64f7956d798Variant2DefaultPurchaseType?>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKShared24b8e64f7956d798Variant2DefaultPurchaseType? Read(
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
                        return global::Vercel.AutoSDKShared24b8e64f7956d798Variant2DefaultPurchaseTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AutoSDKShared24b8e64f7956d798Variant2DefaultPurchaseType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AutoSDKShared24b8e64f7956d798Variant2DefaultPurchaseType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKShared24b8e64f7956d798Variant2DefaultPurchaseType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.AutoSDKShared24b8e64f7956d798Variant2DefaultPurchaseTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
