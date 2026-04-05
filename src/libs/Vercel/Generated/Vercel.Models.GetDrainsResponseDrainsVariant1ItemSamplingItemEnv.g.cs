
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainsResponseDrainsVariant1ItemSamplingItemEnv
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
    public static class GetDrainsResponseDrainsVariant1ItemSamplingItemEnvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainsResponseDrainsVariant1ItemSamplingItemEnv value)
        {
            return value switch
            {
                GetDrainsResponseDrainsVariant1ItemSamplingItemEnv.Preview => "preview",
                GetDrainsResponseDrainsVariant1ItemSamplingItemEnv.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainsResponseDrainsVariant1ItemSamplingItemEnv? ToEnum(string value)
        {
            return value switch
            {
                "preview" => GetDrainsResponseDrainsVariant1ItemSamplingItemEnv.Preview,
                "production" => GetDrainsResponseDrainsVariant1ItemSamplingItemEnv.Production,
                _ => null,
            };
        }
    }
}