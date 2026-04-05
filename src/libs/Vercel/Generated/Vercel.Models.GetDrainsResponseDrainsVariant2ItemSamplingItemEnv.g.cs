
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDrainsResponseDrainsVariant2ItemSamplingItemEnv
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
    public static class GetDrainsResponseDrainsVariant2ItemSamplingItemEnvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDrainsResponseDrainsVariant2ItemSamplingItemEnv value)
        {
            return value switch
            {
                GetDrainsResponseDrainsVariant2ItemSamplingItemEnv.Preview => "preview",
                GetDrainsResponseDrainsVariant2ItemSamplingItemEnv.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDrainsResponseDrainsVariant2ItemSamplingItemEnv? ToEnum(string value)
        {
            return value switch
            {
                "preview" => GetDrainsResponseDrainsVariant2ItemSamplingItemEnv.Preview,
                "production" => GetDrainsResponseDrainsVariant2ItemSamplingItemEnv.Production,
                _ => null,
            };
        }
    }
}