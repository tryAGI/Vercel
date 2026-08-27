
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CancelDeploymentResponseServiceVariant1Type
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
    public static class CancelDeploymentResponseServiceVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseServiceVariant1Type value)
        {
            return value switch
            {
                CancelDeploymentResponseServiceVariant1Type.Cron => "cron",
                CancelDeploymentResponseServiceVariant1Type.Job => "job",
                CancelDeploymentResponseServiceVariant1Type.Web => "web",
                CancelDeploymentResponseServiceVariant1Type.Worker => "worker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseServiceVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "cron" => CancelDeploymentResponseServiceVariant1Type.Cron,
                "job" => CancelDeploymentResponseServiceVariant1Type.Job,
                "web" => CancelDeploymentResponseServiceVariant1Type.Web,
                "worker" => CancelDeploymentResponseServiceVariant1Type.Worker,
                _ => null,
            };
        }
    }
}