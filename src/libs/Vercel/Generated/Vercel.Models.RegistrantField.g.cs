#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    /// Schema definition for registrant fields.
    /// </summary>
    public readonly partial struct RegistrantField : global::System.IEquatable<RegistrantField>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.RegistrantFieldVariant1? RegistrantFieldVariant1 { get; init; }
#else
        public global::Vercel.RegistrantFieldVariant1? RegistrantFieldVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RegistrantFieldVariant1))]
#endif
        public bool IsRegistrantFieldVariant1 => RegistrantFieldVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.RegistrantFieldVariant2? RegistrantFieldVariant2 { get; init; }
#else
        public global::Vercel.RegistrantFieldVariant2? RegistrantFieldVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RegistrantFieldVariant2))]
#endif
        public bool IsRegistrantFieldVariant2 => RegistrantFieldVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.RegistrantFieldVariant3? RegistrantFieldVariant3 { get; init; }
#else
        public global::Vercel.RegistrantFieldVariant3? RegistrantFieldVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RegistrantFieldVariant3))]
#endif
        public bool IsRegistrantFieldVariant3 => RegistrantFieldVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.RegistrantFieldVariant4? RegistrantFieldVariant4 { get; init; }
#else
        public global::Vercel.RegistrantFieldVariant4? RegistrantFieldVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RegistrantFieldVariant4))]
#endif
        public bool IsRegistrantFieldVariant4 => RegistrantFieldVariant4 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RegistrantField(global::Vercel.RegistrantFieldVariant1 value) => new RegistrantField((global::Vercel.RegistrantFieldVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vercel.RegistrantFieldVariant1?(RegistrantField @this) => @this.RegistrantFieldVariant1;

        /// <summary>
        /// 
        /// </summary>
        public RegistrantField(global::Vercel.RegistrantFieldVariant1? value)
        {
            RegistrantFieldVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RegistrantField(global::Vercel.RegistrantFieldVariant2 value) => new RegistrantField((global::Vercel.RegistrantFieldVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vercel.RegistrantFieldVariant2?(RegistrantField @this) => @this.RegistrantFieldVariant2;

        /// <summary>
        /// 
        /// </summary>
        public RegistrantField(global::Vercel.RegistrantFieldVariant2? value)
        {
            RegistrantFieldVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RegistrantField(global::Vercel.RegistrantFieldVariant3 value) => new RegistrantField((global::Vercel.RegistrantFieldVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vercel.RegistrantFieldVariant3?(RegistrantField @this) => @this.RegistrantFieldVariant3;

        /// <summary>
        /// 
        /// </summary>
        public RegistrantField(global::Vercel.RegistrantFieldVariant3? value)
        {
            RegistrantFieldVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RegistrantField(global::Vercel.RegistrantFieldVariant4 value) => new RegistrantField((global::Vercel.RegistrantFieldVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vercel.RegistrantFieldVariant4?(RegistrantField @this) => @this.RegistrantFieldVariant4;

        /// <summary>
        /// 
        /// </summary>
        public RegistrantField(global::Vercel.RegistrantFieldVariant4? value)
        {
            RegistrantFieldVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RegistrantField(
            global::Vercel.RegistrantFieldVariant1? registrantFieldVariant1,
            global::Vercel.RegistrantFieldVariant2? registrantFieldVariant2,
            global::Vercel.RegistrantFieldVariant3? registrantFieldVariant3,
            global::Vercel.RegistrantFieldVariant4? registrantFieldVariant4
            )
        {
            RegistrantFieldVariant1 = registrantFieldVariant1;
            RegistrantFieldVariant2 = registrantFieldVariant2;
            RegistrantFieldVariant3 = registrantFieldVariant3;
            RegistrantFieldVariant4 = registrantFieldVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RegistrantFieldVariant4 as object ??
            RegistrantFieldVariant3 as object ??
            RegistrantFieldVariant2 as object ??
            RegistrantFieldVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            RegistrantFieldVariant1?.ToString() ??
            RegistrantFieldVariant2?.ToString() ??
            RegistrantFieldVariant3?.ToString() ??
            RegistrantFieldVariant4?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRegistrantFieldVariant1 || IsRegistrantFieldVariant2 || IsRegistrantFieldVariant3 || IsRegistrantFieldVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.RegistrantFieldVariant1?, TResult>? registrantFieldVariant1 = null,
            global::System.Func<global::Vercel.RegistrantFieldVariant2?, TResult>? registrantFieldVariant2 = null,
            global::System.Func<global::Vercel.RegistrantFieldVariant3?, TResult>? registrantFieldVariant3 = null,
            global::System.Func<global::Vercel.RegistrantFieldVariant4?, TResult>? registrantFieldVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRegistrantFieldVariant1 && registrantFieldVariant1 != null)
            {
                return registrantFieldVariant1(RegistrantFieldVariant1!);
            }
            else if (IsRegistrantFieldVariant2 && registrantFieldVariant2 != null)
            {
                return registrantFieldVariant2(RegistrantFieldVariant2!);
            }
            else if (IsRegistrantFieldVariant3 && registrantFieldVariant3 != null)
            {
                return registrantFieldVariant3(RegistrantFieldVariant3!);
            }
            else if (IsRegistrantFieldVariant4 && registrantFieldVariant4 != null)
            {
                return registrantFieldVariant4(RegistrantFieldVariant4!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.RegistrantFieldVariant1?>? registrantFieldVariant1 = null,
            global::System.Action<global::Vercel.RegistrantFieldVariant2?>? registrantFieldVariant2 = null,
            global::System.Action<global::Vercel.RegistrantFieldVariant3?>? registrantFieldVariant3 = null,
            global::System.Action<global::Vercel.RegistrantFieldVariant4?>? registrantFieldVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRegistrantFieldVariant1)
            {
                registrantFieldVariant1?.Invoke(RegistrantFieldVariant1!);
            }
            else if (IsRegistrantFieldVariant2)
            {
                registrantFieldVariant2?.Invoke(RegistrantFieldVariant2!);
            }
            else if (IsRegistrantFieldVariant3)
            {
                registrantFieldVariant3?.Invoke(RegistrantFieldVariant3!);
            }
            else if (IsRegistrantFieldVariant4)
            {
                registrantFieldVariant4?.Invoke(RegistrantFieldVariant4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RegistrantFieldVariant1,
                typeof(global::Vercel.RegistrantFieldVariant1),
                RegistrantFieldVariant2,
                typeof(global::Vercel.RegistrantFieldVariant2),
                RegistrantFieldVariant3,
                typeof(global::Vercel.RegistrantFieldVariant3),
                RegistrantFieldVariant4,
                typeof(global::Vercel.RegistrantFieldVariant4),
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
        public bool Equals(RegistrantField other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.RegistrantFieldVariant1?>.Default.Equals(RegistrantFieldVariant1, other.RegistrantFieldVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.RegistrantFieldVariant2?>.Default.Equals(RegistrantFieldVariant2, other.RegistrantFieldVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.RegistrantFieldVariant3?>.Default.Equals(RegistrantFieldVariant3, other.RegistrantFieldVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.RegistrantFieldVariant4?>.Default.Equals(RegistrantFieldVariant4, other.RegistrantFieldVariant4) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RegistrantField obj1, RegistrantField obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RegistrantField>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RegistrantField obj1, RegistrantField obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RegistrantField o && Equals(o);
        }
    }
}
