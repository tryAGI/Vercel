#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetAliasResponseProtectionBypassVariant2AccessJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetAliasResponseProtectionBypassVariant2Access>
    {
        /// <inheritdoc />
        public override global::Vercel.GetAliasResponseProtectionBypassVariant2Access Read(
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
                        return global::Vercel.GetAliasResponseProtectionBypassVariant2AccessExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetAliasResponseProtectionBypassVariant2Access)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetAliasResponseProtectionBypassVariant2Access);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetAliasResponseProtectionBypassVariant2Access value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.GetAliasResponseProtectionBypassVariant2AccessExtensions.ToValueString(value));
        }
    }
}
