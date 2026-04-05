
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant38DataPlanSlug
    {
        /// <summary>
        /// 
        /// </summary>
        V0Business,
        /// <summary>
        /// 
        /// </summary>
        V0Teams,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant38DataPlanSlugExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant38DataPlanSlug value)
        {
            return value switch
            {
                UserEventPayloadVariant38DataPlanSlug.V0Business => "v0_business",
                UserEventPayloadVariant38DataPlanSlug.V0Teams => "v0_teams",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant38DataPlanSlug? ToEnum(string value)
        {
            return value switch
            {
                "v0_business" => UserEventPayloadVariant38DataPlanSlug.V0Business,
                "v0_teams" => UserEventPayloadVariant38DataPlanSlug.V0Teams,
                _ => null,
            };
        }
    }
}