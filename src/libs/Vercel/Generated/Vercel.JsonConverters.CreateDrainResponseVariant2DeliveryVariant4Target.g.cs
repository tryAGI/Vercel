#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateDrainResponseVariant2DeliveryVariant4TargetJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.CreateDrainResponseVariant2DeliveryVariant4Target>
    {
        /// <inheritdoc />
        public override global::Vercel.CreateDrainResponseVariant2DeliveryVariant4Target Read(
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
                        return global::Vercel.CreateDrainResponseVariant2DeliveryVariant4TargetExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.CreateDrainResponseVariant2DeliveryVariant4Target)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.CreateDrainResponseVariant2DeliveryVariant4Target);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.CreateDrainResponseVariant2DeliveryVariant4Target value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.CreateDrainResponseVariant2DeliveryVariant4TargetExtensions.ToValueString(value));
        }
    }
}
