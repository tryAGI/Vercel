#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateDrainRequestFilterFilterVariant1DeploymentEnvironmentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.UpdateDrainRequestFilterFilterVariant1DeploymentEnvironment>
    {
        /// <inheritdoc />
        public override global::Vercel.UpdateDrainRequestFilterFilterVariant1DeploymentEnvironment Read(
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
                        return global::Vercel.UpdateDrainRequestFilterFilterVariant1DeploymentEnvironmentExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.UpdateDrainRequestFilterFilterVariant1DeploymentEnvironment)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.UpdateDrainRequestFilterFilterVariant1DeploymentEnvironment);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.UpdateDrainRequestFilterFilterVariant1DeploymentEnvironment value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.UpdateDrainRequestFilterFilterVariant1DeploymentEnvironmentExtensions.ToValueString(value));
        }
    }
}
