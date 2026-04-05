
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDrainResponseVariant1Status
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
    public static class CreateDrainResponseVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDrainResponseVariant1Status value)
        {
            return value switch
            {
                CreateDrainResponseVariant1Status.Disabled => "disabled",
                CreateDrainResponseVariant1Status.Enabled => "enabled",
                CreateDrainResponseVariant1Status.Errored => "errored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDrainResponseVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CreateDrainResponseVariant1Status.Disabled,
                "enabled" => CreateDrainResponseVariant1Status.Enabled,
                "errored" => CreateDrainResponseVariant1Status.Errored,
                _ => null,
            };
        }
    }
}