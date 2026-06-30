#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineElasticReasonJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineElasticReason>
    {
        /// <inheritdoc />
        public override global::Vercel.GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineElasticReason Read(
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
                        return global::Vercel.GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineElasticReasonExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineElasticReason)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineElasticReason);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineElasticReason value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vercel.GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigBuildMachineElasticReasonExtensions.ToValueString(value));
        }
    }
}
