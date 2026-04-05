#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReadAccessGroupResponseEntitlementNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.ReadAccessGroupResponseEntitlement?>
    {
        /// <inheritdoc />
        public override global::Vercel.ReadAccessGroupResponseEntitlement? Read(
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
                        return global::Vercel.ReadAccessGroupResponseEntitlementExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.ReadAccessGroupResponseEntitlement)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.ReadAccessGroupResponseEntitlement?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.ReadAccessGroupResponseEntitlement? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.ReadAccessGroupResponseEntitlementExtensions.ToValueString(value.Value));
            }
        }
    }
}
