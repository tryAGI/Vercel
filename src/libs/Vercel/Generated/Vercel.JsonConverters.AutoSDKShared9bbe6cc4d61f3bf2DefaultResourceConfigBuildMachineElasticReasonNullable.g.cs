#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildMachineElasticReasonNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildMachineElasticReason?>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildMachineElasticReason? Read(
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
                        return global::Vercel.AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildMachineElasticReasonExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildMachineElasticReason)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildMachineElasticReason?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildMachineElasticReason? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildMachineElasticReasonExtensions.ToValueString(value.Value));
            }
        }
    }
}
