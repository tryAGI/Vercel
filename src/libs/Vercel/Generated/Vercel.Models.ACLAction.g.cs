
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Enum containing the actions that can be performed against a resource. Group operations are included.
    /// </summary>
    public enum ACLAction
    {
        /// <summary>
        /// 
        /// </summary>
        Create,
        /// <summary>
        /// 
        /// </summary>
        Delete,
        /// <summary>
        /// 
        /// </summary>
        List,
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Update,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ACLActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ACLAction value)
        {
            return value switch
            {
                ACLAction.Create => "create",
                ACLAction.Delete => "delete",
                ACLAction.List => "list",
                ACLAction.Read => "read",
                ACLAction.Update => "update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ACLAction? ToEnum(string value)
        {
            return value switch
            {
                "create" => ACLAction.Create,
                "delete" => ACLAction.Delete,
                "list" => ACLAction.List,
                "read" => ACLAction.Read,
                "update" => ACLAction.Update,
                _ => null,
            };
        }
    }
}