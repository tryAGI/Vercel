#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutoSDKSharedc9c79e81839bbccdDefaultResourceConfigElasticBuildMachineLabelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKSharedc9c79e81839bbccdDefaultResourceConfigElasticBuildMachineLabel?>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKSharedc9c79e81839bbccdDefaultResourceConfigElasticBuildMachineLabel? Read(
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
                        return global::Vercel.AutoSDKSharedc9c79e81839bbccdDefaultResourceConfigElasticBuildMachineLabelExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AutoSDKSharedc9c79e81839bbccdDefaultResourceConfigElasticBuildMachineLabel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AutoSDKSharedc9c79e81839bbccdDefaultResourceConfigElasticBuildMachineLabel?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKSharedc9c79e81839bbccdDefaultResourceConfigElasticBuildMachineLabel? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.AutoSDKSharedc9c79e81839bbccdDefaultResourceConfigElasticBuildMachineLabelExtensions.ToValueString(value.Value));
            }
        }
    }
}
