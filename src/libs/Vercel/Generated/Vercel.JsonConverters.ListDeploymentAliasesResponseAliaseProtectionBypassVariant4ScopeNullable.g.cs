#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListDeploymentAliasesResponseAliaseProtectionBypassVariant4ScopeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.ListDeploymentAliasesResponseAliaseProtectionBypassVariant4Scope?>
    {
        /// <inheritdoc />
        public override global::Vercel.ListDeploymentAliasesResponseAliaseProtectionBypassVariant4Scope? Read(
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
                        return global::Vercel.ListDeploymentAliasesResponseAliaseProtectionBypassVariant4ScopeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.ListDeploymentAliasesResponseAliaseProtectionBypassVariant4Scope)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.ListDeploymentAliasesResponseAliaseProtectionBypassVariant4Scope?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.ListDeploymentAliasesResponseAliaseProtectionBypassVariant4Scope? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.ListDeploymentAliasesResponseAliaseProtectionBypassVariant4ScopeExtensions.ToValueString(value.Value));
            }
        }
    }
}
