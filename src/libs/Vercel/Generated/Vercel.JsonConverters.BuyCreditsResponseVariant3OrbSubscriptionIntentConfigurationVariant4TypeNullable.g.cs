#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant4TypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant4Type?>
    {
        /// <inheritdoc />
        public override global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant4Type? Read(
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
                        return global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant4TypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant4Type)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant4Type?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant4Type? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.BuyCreditsResponseVariant3OrbSubscriptionIntentConfigurationVariant4TypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
