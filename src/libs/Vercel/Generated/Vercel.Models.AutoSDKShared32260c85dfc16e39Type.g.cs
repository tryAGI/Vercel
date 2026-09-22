
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared32260c85dfc16e39Type
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
    public static class AutoSDKShared32260c85dfc16e39TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared32260c85dfc16e39Type value)
        {
            return value switch
            {
                AutoSDKShared32260c85dfc16e39Type.Cron => "cron",
                AutoSDKShared32260c85dfc16e39Type.Job => "job",
                AutoSDKShared32260c85dfc16e39Type.Web => "web",
                AutoSDKShared32260c85dfc16e39Type.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared32260c85dfc16e39Type? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKShared32260c85dfc16e39Type.Cron,
                "job" => AutoSDKShared32260c85dfc16e39Type.Job,
                "web" => AutoSDKShared32260c85dfc16e39Type.Web,
                "worker" => AutoSDKShared32260c85dfc16e39Type.Worker,
                _ => null,
            };
        }
    }
}