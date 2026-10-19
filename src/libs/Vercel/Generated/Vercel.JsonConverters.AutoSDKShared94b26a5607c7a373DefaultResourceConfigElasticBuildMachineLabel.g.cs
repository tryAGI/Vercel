#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutoSDKShared94b26a5607c7a373DefaultResourceConfigElasticBuildMachineLabelJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKShared94b26a5607c7a373DefaultResourceConfigElasticBuildMachineLabel>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKShared94b26a5607c7a373DefaultResourceConfigElasticBuildMachineLabel Read(
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
                        return global::Vercel.AutoSDKShared94b26a5607c7a373DefaultResourceConfigElasticBuildMachineLabelExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AutoSDKShared94b26a5607c7a373DefaultResourceConfigElasticBuildMachineLabel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AutoSDKShared94b26a5607c7a373DefaultResourceConfigElasticBuildMachineLabel);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKShared94b26a5607c7a373DefaultResourceConfigElasticBuildMachineLabel value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.AutoSDKShared94b26a5607c7a373DefaultResourceConfigElasticBuildMachineLabelExtensions.ToValueString(value));
        }
    }
}
