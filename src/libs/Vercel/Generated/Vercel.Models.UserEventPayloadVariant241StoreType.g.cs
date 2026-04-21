
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant241StoreType
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
    public static class UserEventPayloadVariant241StoreTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant241StoreType value)
        {
            return value switch
            {
                UserEventPayloadVariant241StoreType.Postgres => "postgres",
                UserEventPayloadVariant241StoreType.Redis => "redis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant241StoreType? ToEnum(string value)
        {
            return value switch
            {
                "postgres" => UserEventPayloadVariant241StoreType.Postgres,
                "redis" => UserEventPayloadVariant241StoreType.Redis,
                _ => null,
            };
        }
    }
}