#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutoSDKShared9f8c0585e20078fcDeliveryStatsWindowJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKShared9f8c0585e20078fcDeliveryStatsWindow>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKShared9f8c0585e20078fcDeliveryStatsWindow Read(
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
                        return global::Vercel.AutoSDKShared9f8c0585e20078fcDeliveryStatsWindowExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AutoSDKShared9f8c0585e20078fcDeliveryStatsWindow)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AutoSDKShared9f8c0585e20078fcDeliveryStatsWindow);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKShared9f8c0585e20078fcDeliveryStatsWindow value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.AutoSDKShared9f8c0585e20078fcDeliveryStatsWindowExtensions.ToValueString(value));
        }
    }
}
