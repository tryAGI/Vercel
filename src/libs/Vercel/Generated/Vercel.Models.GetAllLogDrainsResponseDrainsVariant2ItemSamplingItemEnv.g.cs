
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAllLogDrainsResponseDrainsVariant2ItemSamplingItemEnv
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
    public static class GetAllLogDrainsResponseDrainsVariant2ItemSamplingItemEnvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllLogDrainsResponseDrainsVariant2ItemSamplingItemEnv value)
        {
            return value switch
            {
                GetAllLogDrainsResponseDrainsVariant2ItemSamplingItemEnv.Preview => "preview",
                GetAllLogDrainsResponseDrainsVariant2ItemSamplingItemEnv.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllLogDrainsResponseDrainsVariant2ItemSamplingItemEnv? ToEnum(string value)
        {
            return value switch
            {
                "preview" => GetAllLogDrainsResponseDrainsVariant2ItemSamplingItemEnv.Preview,
                "production" => GetAllLogDrainsResponseDrainsVariant2ItemSamplingItemEnv.Production,
                _ => null,
            };
        }
    }
}