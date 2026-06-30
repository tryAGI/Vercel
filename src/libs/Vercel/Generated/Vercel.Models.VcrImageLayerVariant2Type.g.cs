
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum VcrImageLayerVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Run,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VcrImageLayerVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VcrImageLayerVariant2Type value)
        {
            return value switch
            {
                VcrImageLayerVariant2Type.Run => "RUN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VcrImageLayerVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "RUN" => VcrImageLayerVariant2Type.Run,
                _ => null,
            };
        }
    }
}