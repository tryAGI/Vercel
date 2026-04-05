
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether toolbar is enabled on production deployments
    /// </summary>
    public enum TeamEnableProductionFeedback
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        DefaultForce,
        /// <summary>
        /// 
        /// </summary>
        Off,
        /// <summary>
        /// 
        /// </summary>
        OffForce,
        /// <summary>
        /// 
        /// </summary>
        On,
        /// <summary>
        /// 
        /// </summary>
        OnForce,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamEnableProductionFeedbackExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamEnableProductionFeedback value)
        {
            return value switch
            {
                TeamEnableProductionFeedback.Default => "default",
                TeamEnableProductionFeedback.DefaultForce => "default-force",
                TeamEnableProductionFeedback.Off => "off",
                TeamEnableProductionFeedback.OffForce => "off-force",
                TeamEnableProductionFeedback.On => "on",
                TeamEnableProductionFeedback.OnForce => "on-force",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamEnableProductionFeedback? ToEnum(string value)
        {
            return value switch
            {
                "default" => TeamEnableProductionFeedback.Default,
                "default-force" => TeamEnableProductionFeedback.DefaultForce,
                "off" => TeamEnableProductionFeedback.Off,
                "off-force" => TeamEnableProductionFeedback.OffForce,
                "on" => TeamEnableProductionFeedback.On,
                "on-force" => TeamEnableProductionFeedback.OnForce,
                _ => null,
            };
        }
    }
}