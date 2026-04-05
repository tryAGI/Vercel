#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class PostTeamDsyncRolesRequestRolesEnumNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.PostTeamDsyncRolesRequestRolesEnum?>
    {
        /// <inheritdoc />
        public override global::Vercel.PostTeamDsyncRolesRequestRolesEnum? Read(
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
                        return global::Vercel.PostTeamDsyncRolesRequestRolesEnumExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.PostTeamDsyncRolesRequestRolesEnum)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.PostTeamDsyncRolesRequestRolesEnum?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.PostTeamDsyncRolesRequestRolesEnum? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.PostTeamDsyncRolesRequestRolesEnumExtensions.ToValueString(value.Value));
            }
        }
    }
}
