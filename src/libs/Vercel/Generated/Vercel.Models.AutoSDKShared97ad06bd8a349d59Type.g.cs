
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared97ad06bd8a349d59Type
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
    public static class AutoSDKShared97ad06bd8a349d59TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared97ad06bd8a349d59Type value)
        {
            return value switch
            {
                AutoSDKShared97ad06bd8a349d59Type.Cron => "cron",
                AutoSDKShared97ad06bd8a349d59Type.Job => "job",
                AutoSDKShared97ad06bd8a349d59Type.Web => "web",
                AutoSDKShared97ad06bd8a349d59Type.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared97ad06bd8a349d59Type? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKShared97ad06bd8a349d59Type.Cron,
                "job" => AutoSDKShared97ad06bd8a349d59Type.Job,
                "web" => AutoSDKShared97ad06bd8a349d59Type.Web,
                "worker" => AutoSDKShared97ad06bd8a349d59Type.Worker,
                _ => null,
            };
        }
    }
}