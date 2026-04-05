#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant2BaseTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant2BaseType?>
    {
        /// <inheritdoc />
        public override global::Vercel.ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant2BaseType? Read(
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
                        return global::Vercel.ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant2BaseTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant2BaseType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant2BaseType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant2BaseType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.ListFlagVersionsResponseVersionDataEnvironmentsRuleOutcomeVariant2BaseTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
