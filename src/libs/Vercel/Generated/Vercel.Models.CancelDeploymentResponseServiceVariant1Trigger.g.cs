
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseServiceVariant1Trigger
    {
        /// <summary>
        /// 
        /// </summary>
        Queue,
        /// <summary>
        /// 
        /// </summary>
        Schedule,
        /// <summary>
        /// 
        /// </summary>
        Workflow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelDeploymentResponseServiceVariant1TriggerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseServiceVariant1Trigger value)
        {
            return value switch
            {
                CancelDeploymentResponseServiceVariant1Trigger.Queue => "queue",
                CancelDeploymentResponseServiceVariant1Trigger.Schedule => "schedule",
                CancelDeploymentResponseServiceVariant1Trigger.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseServiceVariant1Trigger? ToEnum(string value)
        {
            return value switch
            {
                "queue" => CancelDeploymentResponseServiceVariant1Trigger.Queue,
                "schedule" => CancelDeploymentResponseServiceVariant1Trigger.Schedule,
                "workflow" => CancelDeploymentResponseServiceVariant1Trigger.Workflow,
                _ => null,
            };
        }
    }
}