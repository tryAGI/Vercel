#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutoSDKSharede0e23f3391031fa6DefaultResourceConfigBuildMachineElasticReasonJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.AutoSDKSharede0e23f3391031fa6DefaultResourceConfigBuildMachineElasticReason>
    {
        /// <inheritdoc />
        public override global::Vercel.AutoSDKSharede0e23f3391031fa6DefaultResourceConfigBuildMachineElasticReason Read(
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
                        return global::Vercel.AutoSDKSharede0e23f3391031fa6DefaultResourceConfigBuildMachineElasticReasonExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.AutoSDKSharede0e23f3391031fa6DefaultResourceConfigBuildMachineElasticReason)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.AutoSDKSharede0e23f3391031fa6DefaultResourceConfigBuildMachineElasticReason);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.AutoSDKSharede0e23f3391031fa6DefaultResourceConfigBuildMachineElasticReason value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.AutoSDKSharede0e23f3391031fa6DefaultResourceConfigBuildMachineElasticReasonExtensions.ToValueString(value));
        }
    }
}
