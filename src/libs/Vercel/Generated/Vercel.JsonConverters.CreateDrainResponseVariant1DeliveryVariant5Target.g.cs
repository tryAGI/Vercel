#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateDrainResponseVariant1DeliveryVariant5TargetJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.CreateDrainResponseVariant1DeliveryVariant5Target>
    {
        /// <inheritdoc />
        public override global::Vercel.CreateDrainResponseVariant1DeliveryVariant5Target Read(
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
                        return global::Vercel.CreateDrainResponseVariant1DeliveryVariant5TargetExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.CreateDrainResponseVariant1DeliveryVariant5Target)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.CreateDrainResponseVariant1DeliveryVariant5Target);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.CreateDrainResponseVariant1DeliveryVariant5Target value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.CreateDrainResponseVariant1DeliveryVariant5TargetExtensions.ToValueString(value));
        }
    }
}
