#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class InviteUserToTeamRequestItemRoleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.InviteUserToTeamRequestItemRole>
    {
        /// <inheritdoc />
        public override global::Vercel.InviteUserToTeamRequestItemRole Read(
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
                        return global::Vercel.InviteUserToTeamRequestItemRoleExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.InviteUserToTeamRequestItemRole)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.InviteUserToTeamRequestItemRole);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.InviteUserToTeamRequestItemRole value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.InviteUserToTeamRequestItemRoleExtensions.ToValueString(value));
        }
    }
}
