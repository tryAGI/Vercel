#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class PatchTeamRequestDefaultDeploymentProtectionPasswordProtectionDeploymentTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.PatchTeamRequestDefaultDeploymentProtectionPasswordProtectionDeploymentType>
    {
        /// <inheritdoc />
        public override global::Vercel.PatchTeamRequestDefaultDeploymentProtectionPasswordProtectionDeploymentType Read(
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
                        return global::Vercel.PatchTeamRequestDefaultDeploymentProtectionPasswordProtectionDeploymentTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.PatchTeamRequestDefaultDeploymentProtectionPasswordProtectionDeploymentType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.PatchTeamRequestDefaultDeploymentProtectionPasswordProtectionDeploymentType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.PatchTeamRequestDefaultDeploymentProtectionPasswordProtectionDeploymentType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.PatchTeamRequestDefaultDeploymentProtectionPasswordProtectionDeploymentTypeExtensions.ToValueString(value));
        }
    }
}
