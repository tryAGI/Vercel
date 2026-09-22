#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateProjectRequestResourceConfigBuildMachineElasticTransitionDirectionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.CreateProjectRequestResourceConfigBuildMachineElasticTransitionDirection>
    {
        /// <inheritdoc />
        public override global::Vercel.CreateProjectRequestResourceConfigBuildMachineElasticTransitionDirection Read(
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
                        return global::Vercel.CreateProjectRequestResourceConfigBuildMachineElasticTransitionDirectionExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.CreateProjectRequestResourceConfigBuildMachineElasticTransitionDirection)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.CreateProjectRequestResourceConfigBuildMachineElasticTransitionDirection);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.CreateProjectRequestResourceConfigBuildMachineElasticTransitionDirection value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.CreateProjectRequestResourceConfigBuildMachineElasticTransitionDirectionExtensions.ToValueString(value));
        }
    }
}
