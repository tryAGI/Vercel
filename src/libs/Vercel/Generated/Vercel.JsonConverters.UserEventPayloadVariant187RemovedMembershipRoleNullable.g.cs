#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class UserEventPayloadVariant187RemovedMembershipRoleNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.UserEventPayloadVariant187RemovedMembershipRole?>
    {
        /// <inheritdoc />
        public override global::Vercel.UserEventPayloadVariant187RemovedMembershipRole? Read(
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
                        return global::Vercel.UserEventPayloadVariant187RemovedMembershipRoleExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.UserEventPayloadVariant187RemovedMembershipRole)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.UserEventPayloadVariant187RemovedMembershipRole?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.UserEventPayloadVariant187RemovedMembershipRole? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.UserEventPayloadVariant187RemovedMembershipRoleExtensions.ToValueString(value.Value));
            }
        }
    }
}
