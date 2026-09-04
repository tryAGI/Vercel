#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class CancelDeploymentResponseResourceConfigBuildMachineSelectionSourceNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.CancelDeploymentResponseResourceConfigBuildMachineSelectionSource?>
    {
        /// <inheritdoc />
        public override global::Vercel.CancelDeploymentResponseResourceConfigBuildMachineSelectionSource? Read(
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
                        return global::Vercel.CancelDeploymentResponseResourceConfigBuildMachineSelectionSourceExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.CancelDeploymentResponseResourceConfigBuildMachineSelectionSource)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.CancelDeploymentResponseResourceConfigBuildMachineSelectionSource?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.CancelDeploymentResponseResourceConfigBuildMachineSelectionSource? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.CancelDeploymentResponseResourceConfigBuildMachineSelectionSourceExtensions.ToValueString(value.Value));
            }
        }
    }
}
