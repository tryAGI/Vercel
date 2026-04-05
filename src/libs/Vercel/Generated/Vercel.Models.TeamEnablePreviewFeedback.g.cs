
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether toolbar is enabled on preview deployments
    /// </summary>
    public enum TeamEnablePreviewFeedback
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
    public static class TeamEnablePreviewFeedbackExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamEnablePreviewFeedback value)
        {
            return value switch
            {
                TeamEnablePreviewFeedback.Default => "default",
                TeamEnablePreviewFeedback.DefaultForce => "default-force",
                TeamEnablePreviewFeedback.Off => "off",
                TeamEnablePreviewFeedback.OffForce => "off-force",
                TeamEnablePreviewFeedback.On => "on",
                TeamEnablePreviewFeedback.OnForce => "on-force",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamEnablePreviewFeedback? ToEnum(string value)
        {
            return value switch
            {
                "default" => TeamEnablePreviewFeedback.Default,
                "default-force" => TeamEnablePreviewFeedback.DefaultForce,
                "off" => TeamEnablePreviewFeedback.Off,
                "off-force" => TeamEnablePreviewFeedback.OffForce,
                "on" => TeamEnablePreviewFeedback.On,
                "on-force" => TeamEnablePreviewFeedback.OnForce,
                _ => null,
            };
        }
    }
}