#nullable enable

namespace Vercel.JsonConverters
{
    /// <inheritdoc />
    public sealed class OrganizationTeamListItemBillingPlanNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vercel.OrganizationTeamListItemBillingPlan?>
    {
        /// <inheritdoc />
        public override global::Vercel.OrganizationTeamListItemBillingPlan? Read(
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
                        return global::Vercel.OrganizationTeamListItemBillingPlanExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vercel.OrganizationTeamListItemBillingPlan)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vercel.OrganizationTeamListItemBillingPlan?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vercel.OrganizationTeamListItemBillingPlan? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vercel.OrganizationTeamListItemBillingPlanExtensions.ToValueString(value.Value));
            }
        }
    }
}
