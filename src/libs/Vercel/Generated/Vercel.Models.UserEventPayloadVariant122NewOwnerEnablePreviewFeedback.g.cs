
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the Vercel Toolbar is enabled for preview deployments.
    /// </summary>
    public enum UserEventPayloadVariant122NewOwnerEnablePreviewFeedback
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
    public static class UserEventPayloadVariant122NewOwnerEnablePreviewFeedbackExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant122NewOwnerEnablePreviewFeedback value)
        {
            return value switch
            {
                UserEventPayloadVariant122NewOwnerEnablePreviewFeedback.Default => "default",
                UserEventPayloadVariant122NewOwnerEnablePreviewFeedback.DefaultForce => "default-force",
                UserEventPayloadVariant122NewOwnerEnablePreviewFeedback.Off => "off",
                UserEventPayloadVariant122NewOwnerEnablePreviewFeedback.OffForce => "off-force",
                UserEventPayloadVariant122NewOwnerEnablePreviewFeedback.On => "on",
                UserEventPayloadVariant122NewOwnerEnablePreviewFeedback.OnForce => "on-force",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant122NewOwnerEnablePreviewFeedback? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant122NewOwnerEnablePreviewFeedback.Default,
                "default-force" => UserEventPayloadVariant122NewOwnerEnablePreviewFeedback.DefaultForce,
                "off" => UserEventPayloadVariant122NewOwnerEnablePreviewFeedback.Off,
                "off-force" => UserEventPayloadVariant122NewOwnerEnablePreviewFeedback.OffForce,
                "on" => UserEventPayloadVariant122NewOwnerEnablePreviewFeedback.On,
                "on-force" => UserEventPayloadVariant122NewOwnerEnablePreviewFeedback.OnForce,
                _ => null,
            };
        }
    }
}