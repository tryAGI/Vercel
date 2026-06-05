
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum RunSessionCommandResponseVariant3Variant1DataCode
    {
        /// <summary>
        /// 
        /// </summary>
        SandboxStreamClosed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunSessionCommandResponseVariant3Variant1DataCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunSessionCommandResponseVariant3Variant1DataCode value)
        {
            return value switch
            {
                RunSessionCommandResponseVariant3Variant1DataCode.SandboxStreamClosed => "sandbox_stream_closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunSessionCommandResponseVariant3Variant1DataCode? ToEnum(string value)
        {
            return value switch
            {
                "sandbox_stream_closed" => RunSessionCommandResponseVariant3Variant1DataCode.SandboxStreamClosed,
                _ => null,
            };
        }
    }
}