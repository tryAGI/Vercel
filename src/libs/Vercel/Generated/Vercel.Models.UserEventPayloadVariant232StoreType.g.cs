
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant232StoreType
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
    public static class UserEventPayloadVariant232StoreTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant232StoreType value)
        {
            return value switch
            {
                UserEventPayloadVariant232StoreType.Postgres => "postgres",
                UserEventPayloadVariant232StoreType.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant232StoreType? ToEnum(string value)
        {
            return value switch
            {
                "postgres" => UserEventPayloadVariant232StoreType.Postgres,
                "redis" => UserEventPayloadVariant232StoreType.Redis,
                _ => null,
            };
        }
    }
}