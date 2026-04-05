#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetAliasResponseProtectionBypassVariant1ScopeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetAliasResponseProtectionBypassVariant1Scope>
    {
        /// <inheritdoc />
        public override global::Vercel.GetAliasResponseProtectionBypassVariant1Scope Read(
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
                        return global::Vercel.GetAliasResponseProtectionBypassVariant1ScopeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetAliasResponseProtectionBypassVariant1Scope)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetAliasResponseProtectionBypassVariant1Scope);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetAliasResponseProtectionBypassVariant1Scope value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.GetAliasResponseProtectionBypassVariant1ScopeExtensions.ToValueString(value));
        }
    }
}
