#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutoSDKShared1006e75c11b11a21ResourceConfigBuildMachineElasticTransitionDirectionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKShared1006e75c11b11a21ResourceConfigBuildMachineElasticTransitionDirection?>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKShared1006e75c11b11a21ResourceConfigBuildMachineElasticTransitionDirection? Read(
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
                        return global::Vercel.AutoSDKShared1006e75c11b11a21ResourceConfigBuildMachineElasticTransitionDirectionExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AutoSDKShared1006e75c11b11a21ResourceConfigBuildMachineElasticTransitionDirection)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AutoSDKShared1006e75c11b11a21ResourceConfigBuildMachineElasticTransitionDirection?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKShared1006e75c11b11a21ResourceConfigBuildMachineElasticTransitionDirection? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.AutoSDKShared1006e75c11b11a21ResourceConfigBuildMachineElasticTransitionDirectionExtensions.ToValueString(value.Value));
            }
        }
    }
}
