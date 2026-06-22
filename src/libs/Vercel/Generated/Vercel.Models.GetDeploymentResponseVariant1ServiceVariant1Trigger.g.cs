
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1ServiceVariant1Trigger
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
    public static class GetDeploymentResponseVariant1ServiceVariant1TriggerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1ServiceVariant1Trigger value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1ServiceVariant1Trigger.Queue => "queue",
                GetDeploymentResponseVariant1ServiceVariant1Trigger.Schedule => "schedule",
                GetDeploymentResponseVariant1ServiceVariant1Trigger.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1ServiceVariant1Trigger? ToEnum(string value)
        {
            return value switch
            {
                "queue" => GetDeploymentResponseVariant1ServiceVariant1Trigger.Queue,
                "schedule" => GetDeploymentResponseVariant1ServiceVariant1Trigger.Schedule,
                "workflow" => GetDeploymentResponseVariant1ServiceVariant1Trigger.Workflow,
                _ => null,
            };
        }
    }
}