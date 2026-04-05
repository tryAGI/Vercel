#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class InvitedTeamMemberTeamRoleNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.InvitedTeamMemberTeamRole?>
    {
        /// <inheritdoc />
        public override global::Vercel.InvitedTeamMemberTeamRole? Read(
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
                        return global::Vercel.InvitedTeamMemberTeamRoleExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.InvitedTeamMemberTeamRole)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.InvitedTeamMemberTeamRole?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.InvitedTeamMemberTeamRole? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.InvitedTeamMemberTeamRoleExtensions.ToValueString(value.Value));
            }
        }
    }
}
