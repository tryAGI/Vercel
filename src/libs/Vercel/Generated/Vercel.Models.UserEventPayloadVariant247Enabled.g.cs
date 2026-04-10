
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant247Enabled
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
    public static class UserEventPayloadVariant247EnabledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant247Enabled value)
        {
            return value switch
            {
                UserEventPayloadVariant247Enabled.Default => "default",
                UserEventPayloadVariant247Enabled.DefaultForce => "default-force",
                UserEventPayloadVariant247Enabled.Off => "off",
                UserEventPayloadVariant247Enabled.OffForce => "off-force",
                UserEventPayloadVariant247Enabled.On => "on",
                UserEventPayloadVariant247Enabled.OnForce => "on-force",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant247Enabled? ToEnum(string value)
        {
            return value switch
            {
                "default" => UserEventPayloadVariant247Enabled.Default,
                "default-force" => UserEventPayloadVariant247Enabled.DefaultForce,
                "off" => UserEventPayloadVariant247Enabled.Off,
                "off-force" => UserEventPayloadVariant247Enabled.OffForce,
                "on" => UserEventPayloadVariant247Enabled.On,
                "on-force" => UserEventPayloadVariant247Enabled.OnForce,
                _ => null,
            };
        }
    }
}