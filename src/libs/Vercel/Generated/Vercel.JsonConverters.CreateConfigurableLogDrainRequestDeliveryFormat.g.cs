#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateConfigurableLogDrainRequestDeliveryFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.CreateConfigurableLogDrainRequestDeliveryFormat>
    {
        /// <inheritdoc />
        public override global::Vercel.CreateConfigurableLogDrainRequestDeliveryFormat Read(
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
                        return global::Vercel.CreateConfigurableLogDrainRequestDeliveryFormatExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.CreateConfigurableLogDrainRequestDeliveryFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.CreateConfigurableLogDrainRequestDeliveryFormat);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.CreateConfigurableLogDrainRequestDeliveryFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.CreateConfigurableLogDrainRequestDeliveryFormatExtensions.ToValueString(value));
        }
    }
}
