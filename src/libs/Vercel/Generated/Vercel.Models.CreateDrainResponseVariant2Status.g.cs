
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDrainResponseVariant2Status
    {
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        Errored,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDrainResponseVariant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDrainResponseVariant2Status value)
        {
            return value switch
            {
                CreateDrainResponseVariant2Status.Disabled => "disabled",
                CreateDrainResponseVariant2Status.Enabled => "enabled",
                CreateDrainResponseVariant2Status.Errored => "errored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDrainResponseVariant2Status? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CreateDrainResponseVariant2Status.Disabled,
                "enabled" => CreateDrainResponseVariant2Status.Enabled,
                "errored" => CreateDrainResponseVariant2Status.Errored,
                _ => null,
            };
        }
    }
}