#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListTeamFlagSettingsResponseVariant2DataItemTypeNameJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.ListTeamFlagSettingsResponseVariant2DataItemTypeName>
    {
        /// <inheritdoc />
        public override global::Vercel.ListTeamFlagSettingsResponseVariant2DataItemTypeName Read(
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
                        return global::Vercel.ListTeamFlagSettingsResponseVariant2DataItemTypeNameExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.ListTeamFlagSettingsResponseVariant2DataItemTypeName)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.ListTeamFlagSettingsResponseVariant2DataItemTypeName);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.ListTeamFlagSettingsResponseVariant2DataItemTypeName value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.ListTeamFlagSettingsResponseVariant2DataItemTypeNameExtensions.ToValueString(value));
        }
    }
}
