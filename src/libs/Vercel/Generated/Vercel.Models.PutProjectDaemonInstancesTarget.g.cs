
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The deployment target for the daemon configuration.<br/>
    /// Default Value: production
    /// </summary>
    public enum PutProjectDaemonInstancesTarget
    {
        /// <summary>
        ///
        /// </summary>
        Preview,
        /// <summary>
        ///
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PutProjectDaemonInstancesTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutProjectDaemonInstancesTarget value)
        {
            return value switch
            {
                PutProjectDaemonInstancesTarget.Preview => "preview",
                PutProjectDaemonInstancesTarget.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutProjectDaemonInstancesTarget? ToEnum(string value)
        {
            return value switch
            {
                "preview" => PutProjectDaemonInstancesTarget.Preview,
                "production" => PutProjectDaemonInstancesTarget.Production,
                _ => null,
            };
        }
    }
}