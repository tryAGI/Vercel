
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum VcrImageLayerVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        Env,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VcrImageLayerVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VcrImageLayerVariant3Type value)
        {
            return value switch
            {
                VcrImageLayerVariant3Type.Env => "ENV",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VcrImageLayerVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "ENV" => VcrImageLayerVariant3Type.Env,
                _ => null,
            };
        }
    }
}