#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListAliasesResponseAliaseProtectionBypassVariant2AccessNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.ListAliasesResponseAliaseProtectionBypassVariant2Access?>
    {
        /// <inheritdoc />
        public override global::Vercel.ListAliasesResponseAliaseProtectionBypassVariant2Access? Read(
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
                        return global::Vercel.ListAliasesResponseAliaseProtectionBypassVariant2AccessExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.ListAliasesResponseAliaseProtectionBypassVariant2Access)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.ListAliasesResponseAliaseProtectionBypassVariant2Access?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.ListAliasesResponseAliaseProtectionBypassVariant2Access? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.ListAliasesResponseAliaseProtectionBypassVariant2AccessExtensions.ToValueString(value.Value));
            }
        }
    }
}
