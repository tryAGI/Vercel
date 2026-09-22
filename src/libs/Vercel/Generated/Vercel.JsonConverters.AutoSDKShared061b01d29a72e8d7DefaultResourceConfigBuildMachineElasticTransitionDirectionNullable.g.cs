#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutoSDKShared061b01d29a72e8d7DefaultResourceConfigBuildMachineElasticTransitionDirectionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKShared061b01d29a72e8d7DefaultResourceConfigBuildMachineElasticTransitionDirection?>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKShared061b01d29a72e8d7DefaultResourceConfigBuildMachineElasticTransitionDirection? Read(
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
                        return global::Vercel.AutoSDKShared061b01d29a72e8d7DefaultResourceConfigBuildMachineElasticTransitionDirectionExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AutoSDKShared061b01d29a72e8d7DefaultResourceConfigBuildMachineElasticTransitionDirection)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AutoSDKShared061b01d29a72e8d7DefaultResourceConfigBuildMachineElasticTransitionDirection?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKShared061b01d29a72e8d7DefaultResourceConfigBuildMachineElasticTransitionDirection? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.AutoSDKShared061b01d29a72e8d7DefaultResourceConfigBuildMachineElasticTransitionDirectionExtensions.ToValueString(value.Value));
            }
        }
    }
}
