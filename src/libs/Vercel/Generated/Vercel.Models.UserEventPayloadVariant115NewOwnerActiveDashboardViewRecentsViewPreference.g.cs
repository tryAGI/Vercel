
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant115NewOwnerActiveDashboardViewRecentsViewPreference
    {
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant115NewOwnerActiveDashboardViewRecentsViewPreferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant115NewOwnerActiveDashboardViewRecentsViewPreference value)
        {
            return value switch
            {
                UserEventPayloadVariant115NewOwnerActiveDashboardViewRecentsViewPreference.Closed => "closed",
                UserEventPayloadVariant115NewOwnerActiveDashboardViewRecentsViewPreference.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant115NewOwnerActiveDashboardViewRecentsViewPreference? ToEnum(string value)
        {
            return value switch
            {
                "closed" => UserEventPayloadVariant115NewOwnerActiveDashboardViewRecentsViewPreference.Closed,
                "open" => UserEventPayloadVariant115NewOwnerActiveDashboardViewRecentsViewPreference.Open,
                _ => null,
            };
        }
    }
}