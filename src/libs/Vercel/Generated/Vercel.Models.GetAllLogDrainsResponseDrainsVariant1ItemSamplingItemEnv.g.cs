
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAllLogDrainsResponseDrainsVariant1ItemSamplingItemEnv
    {
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
    public static class GetAllLogDrainsResponseDrainsVariant1ItemSamplingItemEnvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllLogDrainsResponseDrainsVariant1ItemSamplingItemEnv value)
        {
            return value switch
            {
                GetAllLogDrainsResponseDrainsVariant1ItemSamplingItemEnv.Preview => "preview",
                GetAllLogDrainsResponseDrainsVariant1ItemSamplingItemEnv.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllLogDrainsResponseDrainsVariant1ItemSamplingItemEnv? ToEnum(string value)
        {
            return value switch
            {
                "preview" => GetAllLogDrainsResponseDrainsVariant1ItemSamplingItemEnv.Preview,
                "production" => GetAllLogDrainsResponseDrainsVariant1ItemSamplingItemEnv.Production,
                _ => null,
            };
        }
    }
}