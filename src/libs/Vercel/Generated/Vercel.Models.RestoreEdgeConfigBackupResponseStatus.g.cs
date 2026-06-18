
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum RestoreEdgeConfigBackupResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Ok,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RestoreEdgeConfigBackupResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RestoreEdgeConfigBackupResponseStatus value)
        {
            return value switch
            {
                RestoreEdgeConfigBackupResponseStatus.Ok => "ok",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RestoreEdgeConfigBackupResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "ok" => RestoreEdgeConfigBackupResponseStatus.Ok,
                _ => null,
            };
        }
    }
}