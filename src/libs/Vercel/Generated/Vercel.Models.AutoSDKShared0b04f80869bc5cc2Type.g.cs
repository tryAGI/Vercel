
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0b04f80869bc5cc2Type
    {
        /// <summary>
        ///
        /// </summary>
        Cron,
        /// <summary>
        ///
        /// </summary>
        Job,
        /// <summary>
        ///
        /// </summary>
        Web,
        /// <summary>
        ///
        /// </summary>
        Worker,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0b04f80869bc5cc2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0b04f80869bc5cc2Type value)
        {
            return value switch
            {
                AutoSDKShared0b04f80869bc5cc2Type.Cron => "cron",
                AutoSDKShared0b04f80869bc5cc2Type.Job => "job",
                AutoSDKShared0b04f80869bc5cc2Type.Web => "web",
                AutoSDKShared0b04f80869bc5cc2Type.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0b04f80869bc5cc2Type? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKShared0b04f80869bc5cc2Type.Cron,
                "job" => AutoSDKShared0b04f80869bc5cc2Type.Job,
                "web" => AutoSDKShared0b04f80869bc5cc2Type.Web,
                "worker" => AutoSDKShared0b04f80869bc5cc2Type.Worker,
                _ => null,
            };
        }
    }
}