
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseServiceVariant1Trigger
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
    public static class CreateDeploymentResponseServiceVariant1TriggerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseServiceVariant1Trigger value)
        {
            return value switch
            {
                CreateDeploymentResponseServiceVariant1Trigger.Queue => "queue",
                CreateDeploymentResponseServiceVariant1Trigger.Schedule => "schedule",
                CreateDeploymentResponseServiceVariant1Trigger.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseServiceVariant1Trigger? ToEnum(string value)
        {
            return value switch
            {
                "queue" => CreateDeploymentResponseServiceVariant1Trigger.Queue,
                "schedule" => CreateDeploymentResponseServiceVariant1Trigger.Schedule,
                "workflow" => CreateDeploymentResponseServiceVariant1Trigger.Workflow,
                _ => null,
            };
        }
    }
}