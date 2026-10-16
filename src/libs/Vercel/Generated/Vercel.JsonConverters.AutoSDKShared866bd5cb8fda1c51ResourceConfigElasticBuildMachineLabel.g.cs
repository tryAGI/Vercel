#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutoSDKShared866bd5cb8fda1c51ResourceConfigElasticBuildMachineLabelJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKShared866bd5cb8fda1c51ResourceConfigElasticBuildMachineLabel>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKShared866bd5cb8fda1c51ResourceConfigElasticBuildMachineLabel Read(
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
                        return global::Vercel.AutoSDKShared866bd5cb8fda1c51ResourceConfigElasticBuildMachineLabelExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AutoSDKShared866bd5cb8fda1c51ResourceConfigElasticBuildMachineLabel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AutoSDKShared866bd5cb8fda1c51ResourceConfigElasticBuildMachineLabel);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKShared866bd5cb8fda1c51ResourceConfigElasticBuildMachineLabel value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.AutoSDKShared866bd5cb8fda1c51ResourceConfigElasticBuildMachineLabelExtensions.ToValueString(value));
        }
    }
}
