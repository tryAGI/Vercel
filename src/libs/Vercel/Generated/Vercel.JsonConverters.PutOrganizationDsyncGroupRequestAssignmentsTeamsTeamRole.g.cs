#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class PutOrganizationDsyncGroupRequestAssignmentsTeamsTeamRoleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.PutOrganizationDsyncGroupRequestAssignmentsTeamsTeamRole>
    {
        /// <inheritdoc />
        public override global::Vercel.PutOrganizationDsyncGroupRequestAssignmentsTeamsTeamRole Read(
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
                        return global::Vercel.PutOrganizationDsyncGroupRequestAssignmentsTeamsTeamRoleExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.PutOrganizationDsyncGroupRequestAssignmentsTeamsTeamRole)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.PutOrganizationDsyncGroupRequestAssignmentsTeamsTeamRole);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.PutOrganizationDsyncGroupRequestAssignmentsTeamsTeamRole value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.PutOrganizationDsyncGroupRequestAssignmentsTeamsTeamRoleExtensions.ToValueString(value));
        }
    }
}
