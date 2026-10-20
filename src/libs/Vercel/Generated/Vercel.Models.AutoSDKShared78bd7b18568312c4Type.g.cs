
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared78bd7b18568312c4Type
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
    public static class AutoSDKShared78bd7b18568312c4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared78bd7b18568312c4Type value)
        {
            return value switch
            {
                AutoSDKShared78bd7b18568312c4Type.Cron => "cron",
                AutoSDKShared78bd7b18568312c4Type.Job => "job",
                AutoSDKShared78bd7b18568312c4Type.Web => "web",
                AutoSDKShared78bd7b18568312c4Type.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared78bd7b18568312c4Type? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKShared78bd7b18568312c4Type.Cron,
                "job" => AutoSDKShared78bd7b18568312c4Type.Job,
                "web" => AutoSDKShared78bd7b18568312c4Type.Web,
                "worker" => AutoSDKShared78bd7b18568312c4Type.Worker,
                _ => null,
            };
        }
    }
}