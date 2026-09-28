
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd60af9eb328d9316Type
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
    public static class AutoSDKSharedd60af9eb328d9316TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd60af9eb328d9316Type value)
        {
            return value switch
            {
                AutoSDKSharedd60af9eb328d9316Type.Cron => "cron",
                AutoSDKSharedd60af9eb328d9316Type.Job => "job",
                AutoSDKSharedd60af9eb328d9316Type.Web => "web",
                AutoSDKSharedd60af9eb328d9316Type.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd60af9eb328d9316Type? ToEnum(string value)
        {
            return value switch
            {
                "cron" => AutoSDKSharedd60af9eb328d9316Type.Cron,
                "job" => AutoSDKSharedd60af9eb328d9316Type.Job,
                "web" => AutoSDKSharedd60af9eb328d9316Type.Web,
                "worker" => AutoSDKSharedd60af9eb328d9316Type.Worker,
                _ => null,
            };
        }
    }
}