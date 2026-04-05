#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetRollingReleaseBillingStatusResponseVariant2AvailableSlotsNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetRollingReleaseBillingStatusResponseVariant2AvailableSlots?>
    {
        /// <inheritdoc />
        public override global::Vercel.GetRollingReleaseBillingStatusResponseVariant2AvailableSlots? Read(
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
                        return global::Vercel.GetRollingReleaseBillingStatusResponseVariant2AvailableSlotsExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetRollingReleaseBillingStatusResponseVariant2AvailableSlots)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetRollingReleaseBillingStatusResponseVariant2AvailableSlots?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetRollingReleaseBillingStatusResponseVariant2AvailableSlots? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.GetRollingReleaseBillingStatusResponseVariant2AvailableSlotsExtensions.ToValueString(value.Value));
            }
        }
    }
}
