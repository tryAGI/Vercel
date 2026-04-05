
#nullable enable

namespace Vercel
{
    /// <summary>
    /// If set to \"true\", the request will block until the command finishes execution. Useful for synchronously waiting for command completion.<br/>
    /// Default Value: false
    /// </summary>
    public enum GetCommandWait
    {
        /// <summary>
        /// 
        /// </summary>
        False,
        /// <summary>
        /// 
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetCommandWaitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCommandWait value)
        {
            return value switch
            {
                GetCommandWait.False => "false",
                GetCommandWait.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCommandWait? ToEnum(string value)
        {
            return value switch
            {
                "false" => GetCommandWait.False,
                "true" => GetCommandWait.True,
                _ => null,
            };
        }
    }
}