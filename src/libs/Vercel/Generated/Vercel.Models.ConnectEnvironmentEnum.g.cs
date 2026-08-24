
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConnectEnvironmentEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Development,
        /// <summary>
        /// 
        /// </summary>
        Preview,
        /// <summary>
        /// 
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConnectEnvironmentEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectEnvironmentEnum value)
        {
            return value switch
            {
                ConnectEnvironmentEnum.Development => "development",
                ConnectEnvironmentEnum.Preview => "preview",
                ConnectEnvironmentEnum.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectEnvironmentEnum? ToEnum(string value)
        {
            return value switch
            {
                "development" => ConnectEnvironmentEnum.Development,
                "preview" => ConnectEnvironmentEnum.Preview,
                "production" => ConnectEnvironmentEnum.Production,
                _ => null,
            };
        }
    }
}