
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDrainRequestProjects
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Some,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDrainRequestProjectsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDrainRequestProjects value)
        {
            return value switch
            {
                CreateDrainRequestProjects.All => "all",
                CreateDrainRequestProjects.Some => "some",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDrainRequestProjects? ToEnum(string value)
        {
            return value switch
            {
                "all" => CreateDrainRequestProjects.All,
                "some" => CreateDrainRequestProjects.Some,
                _ => null,
            };
        }
    }
}