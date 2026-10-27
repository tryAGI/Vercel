
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared303c00bc2455dd70Type
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
    public static class AutoSDKShared303c00bc2455dd70TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared303c00bc2455dd70Type value)
        {
            return value switch
            {
                AutoSDKShared303c00bc2455dd70Type.Cron => "cron",
                AutoSDKShared303c00bc2455dd70Type.Job => "job",
                AutoSDKShared303c00bc2455dd70Type.Web => "web",
                AutoSDKShared303c00bc2455dd70Type.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared303c00bc2455dd70Type? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKShared303c00bc2455dd70Type.Cron,
                "job" => AutoSDKShared303c00bc2455dd70Type.Job,
                "web" => AutoSDKShared303c00bc2455dd70Type.Web,
                "worker" => AutoSDKShared303c00bc2455dd70Type.Worker,
                _ => null,
            };
        }
    }
}