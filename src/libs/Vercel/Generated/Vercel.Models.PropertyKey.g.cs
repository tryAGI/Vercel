#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PropertyKey : global::System.IEquatable<PropertyKey>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? PropertyKeyVariant1 { get; init; }
#else
        public string? PropertyKeyVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PropertyKeyVariant1))]
#endif
        public bool IsPropertyKeyVariant1 => PropertyKeyVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? PropertyKeyVariant2 { get; init; }
#else
        public double? PropertyKeyVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PropertyKeyVariant2))]
#endif
        public bool IsPropertyKeyVariant2 => PropertyKeyVariant2 != null;

        /// <summary>
        /// an object to be decoded into a globally shared symbol
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.PropertyKeyVariant3? PropertyKeyVariant3 { get; init; }
#else
        public global::Vercel.PropertyKeyVariant3? PropertyKeyVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PropertyKeyVariant3))]
#endif
        public bool IsPropertyKeyVariant3 => PropertyKeyVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PropertyKey(string value) => new PropertyKey((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(PropertyKey @this) => @this.PropertyKeyVariant1;

        /// <summary>
        /// 
        /// </summary>
        public PropertyKey(string? value)
        {
            PropertyKeyVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PropertyKey(double value) => new PropertyKey((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(PropertyKey @this) => @this.PropertyKeyVariant2;

        /// <summary>
        /// 
        /// </summary>
        public PropertyKey(double? value)
        {
            PropertyKeyVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PropertyKey(global::Vercel.PropertyKeyVariant3 value) => new PropertyKey((global::Vercel.PropertyKeyVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vercel.PropertyKeyVariant3?(PropertyKey @this) => @this.PropertyKeyVariant3;

        /// <summary>
        /// 
        /// </summary>
        public PropertyKey(global::Vercel.PropertyKeyVariant3? value)
        {
            PropertyKeyVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PropertyKey(
            string? propertyKeyVariant1,
            double? propertyKeyVariant2,
            global::Vercel.PropertyKeyVariant3? propertyKeyVariant3
            )
        {
            PropertyKeyVariant1 = propertyKeyVariant1;
            PropertyKeyVariant2 = propertyKeyVariant2;
            PropertyKeyVariant3 = propertyKeyVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PropertyKeyVariant3 as object ??
            PropertyKeyVariant2 as object ??
            PropertyKeyVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PropertyKeyVariant1?.ToString() ??
            PropertyKeyVariant2?.ToString() ??
            PropertyKeyVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPropertyKeyVariant1 || IsPropertyKeyVariant2 || IsPropertyKeyVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? propertyKeyVariant1 = null,
            global::System.Func<double?, TResult>? propertyKeyVariant2 = null,
            global::System.Func<global::Vercel.PropertyKeyVariant3?, TResult>? propertyKeyVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPropertyKeyVariant1 && propertyKeyVariant1 != null)
            {
                return propertyKeyVariant1(PropertyKeyVariant1!);
            }
            else if (IsPropertyKeyVariant2 && propertyKeyVariant2 != null)
            {
                return propertyKeyVariant2(PropertyKeyVariant2!);
            }
            else if (IsPropertyKeyVariant3 && propertyKeyVariant3 != null)
            {
                return propertyKeyVariant3(PropertyKeyVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? propertyKeyVariant1 = null,
            global::System.Action<double?>? propertyKeyVariant2 = null,
            global::System.Action<global::Vercel.PropertyKeyVariant3?>? propertyKeyVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPropertyKeyVariant1)
            {
                propertyKeyVariant1?.Invoke(PropertyKeyVariant1!);
            }
            else if (IsPropertyKeyVariant2)
            {
                propertyKeyVariant2?.Invoke(PropertyKeyVariant2!);
            }
            else if (IsPropertyKeyVariant3)
            {
                propertyKeyVariant3?.Invoke(PropertyKeyVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PropertyKeyVariant1,
                typeof(string),
                PropertyKeyVariant2,
                typeof(double),
                PropertyKeyVariant3,
                typeof(global::Vercel.PropertyKeyVariant3),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(PropertyKey other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(PropertyKeyVariant1, other.PropertyKeyVariant1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(PropertyKeyVariant2, other.PropertyKeyVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.PropertyKeyVariant3?>.Default.Equals(PropertyKeyVariant3, other.PropertyKeyVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PropertyKey obj1, PropertyKey obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PropertyKey>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PropertyKey obj1, PropertyKey obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PropertyKey o && Equals(o);
        }
    }
}
