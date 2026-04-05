
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDrainResponseVariant2ProjectAccessVariant2Access
    {
        /// <summary>
        /// 
        /// </summary>
        Some,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDrainResponseVariant2ProjectAccessVariant2AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDrainResponseVariant2ProjectAccessVariant2Access value)
        {
            return value switch
            {
                CreateDrainResponseVariant2ProjectAccessVariant2Access.Some => "some",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDrainResponseVariant2ProjectAccessVariant2Access? ToEnum(string value)
        {
            return value switch
            {
                "some" => CreateDrainResponseVariant2ProjectAccessVariant2Access.Some,
                _ => null,
            };
        }
    }
}