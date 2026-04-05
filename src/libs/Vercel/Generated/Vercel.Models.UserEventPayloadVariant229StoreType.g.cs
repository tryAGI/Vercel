
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant229StoreType
    {
        /// <summary>
        /// 
        /// </summary>
        Postgres,
        /// <summary>
        /// 
        /// </summary>
        Redis,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant229StoreTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant229StoreType value)
        {
            return value switch
            {
                UserEventPayloadVariant229StoreType.Postgres => "postgres",
                UserEventPayloadVariant229StoreType.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant229StoreType? ToEnum(string value)
        {
            return value switch
            {
                "postgres" => UserEventPayloadVariant229StoreType.Postgres,
                "redis" => UserEventPayloadVariant229StoreType.Redis,
                _ => null,
            };
        }
    }
}