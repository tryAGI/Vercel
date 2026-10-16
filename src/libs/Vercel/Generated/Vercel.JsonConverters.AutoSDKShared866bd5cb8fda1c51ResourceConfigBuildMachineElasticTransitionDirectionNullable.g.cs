#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutoSDKShared866bd5cb8fda1c51ResourceConfigBuildMachineElasticTransitionDirectionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKShared866bd5cb8fda1c51ResourceConfigBuildMachineElasticTransitionDirection?>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKShared866bd5cb8fda1c51ResourceConfigBuildMachineElasticTransitionDirection? Read(
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
                        return global::Vercel.AutoSDKShared866bd5cb8fda1c51ResourceConfigBuildMachineElasticTransitionDirectionExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AutoSDKShared866bd5cb8fda1c51ResourceConfigBuildMachineElasticTransitionDirection)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AutoSDKShared866bd5cb8fda1c51ResourceConfigBuildMachineElasticTransitionDirection?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKShared866bd5cb8fda1c51ResourceConfigBuildMachineElasticTransitionDirection? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.AutoSDKShared866bd5cb8fda1c51ResourceConfigBuildMachineElasticTransitionDirectionExtensions.ToValueString(value.Value));
            }
        }
    }
}
