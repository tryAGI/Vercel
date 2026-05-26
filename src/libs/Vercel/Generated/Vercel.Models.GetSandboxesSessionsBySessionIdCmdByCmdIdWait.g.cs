
#nullable enable

namespace Vercel
{
    /// <summary>
    /// If set to "true", the request will block until the command finishes execution. Useful for synchronously waiting for command completion.<br/>
    /// Default Value: false
    /// </summary>
    public enum GetSandboxesSessionsBySessionIdCmdByCmdIdWait
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
    public static class GetSandboxesSessionsBySessionIdCmdByCmdIdWaitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSandboxesSessionsBySessionIdCmdByCmdIdWait value)
        {
            return value switch
            {
                GetSandboxesSessionsBySessionIdCmdByCmdIdWait.False => "false",
                GetSandboxesSessionsBySessionIdCmdByCmdIdWait.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSandboxesSessionsBySessionIdCmdByCmdIdWait? ToEnum(string value)
        {
            return value switch
            {
                "false" => GetSandboxesSessionsBySessionIdCmdByCmdIdWait.False,
                "true" => GetSandboxesSessionsBySessionIdCmdByCmdIdWait.True,
                _ => null,
            };
        }
    }
}