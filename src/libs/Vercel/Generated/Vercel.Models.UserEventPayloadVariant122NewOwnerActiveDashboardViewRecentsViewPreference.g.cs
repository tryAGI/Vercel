
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant122NewOwnerActiveDashboardViewRecentsViewPreference
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
    public static class UserEventPayloadVariant122NewOwnerActiveDashboardViewRecentsViewPreferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant122NewOwnerActiveDashboardViewRecentsViewPreference value)
        {
            return value switch
            {
                UserEventPayloadVariant122NewOwnerActiveDashboardViewRecentsViewPreference.Closed => "closed",
                UserEventPayloadVariant122NewOwnerActiveDashboardViewRecentsViewPreference.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant122NewOwnerActiveDashboardViewRecentsViewPreference? ToEnum(string value)
        {
            return value switch
            {
                "closed" => UserEventPayloadVariant122NewOwnerActiveDashboardViewRecentsViewPreference.Closed,
                "open" => UserEventPayloadVariant122NewOwnerActiveDashboardViewRecentsViewPreference.Open,
                _ => null,
            };
        }
    }
}