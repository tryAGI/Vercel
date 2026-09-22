#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineElasticReasonNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineElasticReason?>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineElasticReason? Read(
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
                        return global::Vercel.AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineElasticReasonExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineElasticReason)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineElasticReason?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineElasticReason? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.AutoSDKSharedb950fa62fc8120e3ResourceConfigBuildMachineElasticReasonExtensions.ToValueString(value.Value));
            }
        }
    }
}
