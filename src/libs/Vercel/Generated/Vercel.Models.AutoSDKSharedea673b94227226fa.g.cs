#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKSharedea673b94227226fa : global::System.IEquatable<AutoSDKSharedea673b94227226fa>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKSharedea673b94227226faVariant1? AutoSDKSharedea673b94227226faVariant1 { get; init; }
#else
        public global::Vercel.AutoSDKSharedea673b94227226faVariant1? AutoSDKSharedea673b94227226faVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AutoSDKSharedea673b94227226faVariant1))]
#endif
        public bool IsAutoSDKSharedea673b94227226faVariant1 => AutoSDKSharedea673b94227226faVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAutoSDKSharedea673b94227226faVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKSharedea673b94227226faVariant1? value)
        {
            value = AutoSDKSharedea673b94227226faVariant1;
            return IsAutoSDKSharedea673b94227226faVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKSharedea673b94227226faVariant1 PickAutoSDKSharedea673b94227226faVariant1() => AutoSDKSharedea673b94227226faVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AutoSDKSharedea673b94227226faVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared45ccc0a95a3ba642? Shared45ccc0a95a3ba642 { get; init; }
#else
        public global::Vercel.AutoSDKShared45ccc0a95a3ba642? Shared45ccc0a95a3ba642 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared45ccc0a95a3ba642))]
#endif
        public bool IsShared45ccc0a95a3ba642 => Shared45ccc0a95a3ba642 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared45ccc0a95a3ba642(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared45ccc0a95a3ba642? value)
        {
            value = Shared45ccc0a95a3ba642;
            return IsShared45ccc0a95a3ba642;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared45ccc0a95a3ba642 PickShared45ccc0a95a3ba642() => Shared45ccc0a95a3ba642 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared45ccc0a95a3ba642' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKSharedea673b94227226faVariant3? AutoSDKSharedea673b94227226faVariant3 { get; init; }
#else
        public global::Vercel.AutoSDKSharedea673b94227226faVariant3? AutoSDKSharedea673b94227226faVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AutoSDKSharedea673b94227226faVariant3))]
#endif
        public bool IsAutoSDKSharedea673b94227226faVariant3 => AutoSDKSharedea673b94227226faVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAutoSDKSharedea673b94227226faVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKSharedea673b94227226faVariant3? value)
        {
            value = AutoSDKSharedea673b94227226faVariant3;
            return IsAutoSDKSharedea673b94227226faVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKSharedea673b94227226faVariant3 PickAutoSDKSharedea673b94227226faVariant3() => AutoSDKSharedea673b94227226faVariant3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AutoSDKSharedea673b94227226faVariant3' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKSharedea673b94227226fa(global::Vercel.AutoSDKSharedea673b94227226faVariant1 value) => new AutoSDKSharedea673b94227226fa((global::Vercel.AutoSDKSharedea673b94227226faVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKSharedea673b94227226faVariant1?(AutoSDKSharedea673b94227226fa @this) => @this.AutoSDKSharedea673b94227226faVariant1;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedea673b94227226fa(global::Vercel.AutoSDKSharedea673b94227226faVariant1? value)
        {
            AutoSDKSharedea673b94227226faVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKSharedea673b94227226fa FromAutoSDKSharedea673b94227226faVariant1(global::Vercel.AutoSDKSharedea673b94227226faVariant1? value) => new AutoSDKSharedea673b94227226fa(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKSharedea673b94227226fa(global::Vercel.AutoSDKShared45ccc0a95a3ba642 value) => new AutoSDKSharedea673b94227226fa((global::Vercel.AutoSDKShared45ccc0a95a3ba642?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared45ccc0a95a3ba642?(AutoSDKSharedea673b94227226fa @this) => @this.Shared45ccc0a95a3ba642;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedea673b94227226fa(global::Vercel.AutoSDKShared45ccc0a95a3ba642? value)
        {
            Shared45ccc0a95a3ba642 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKSharedea673b94227226fa FromShared45ccc0a95a3ba642(global::Vercel.AutoSDKShared45ccc0a95a3ba642? value) => new AutoSDKSharedea673b94227226fa(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKSharedea673b94227226fa(global::Vercel.AutoSDKSharedea673b94227226faVariant3 value) => new AutoSDKSharedea673b94227226fa((global::Vercel.AutoSDKSharedea673b94227226faVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKSharedea673b94227226faVariant3?(AutoSDKSharedea673b94227226fa @this) => @this.AutoSDKSharedea673b94227226faVariant3;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedea673b94227226fa(global::Vercel.AutoSDKSharedea673b94227226faVariant3? value)
        {
            AutoSDKSharedea673b94227226faVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKSharedea673b94227226fa FromAutoSDKSharedea673b94227226faVariant3(global::Vercel.AutoSDKSharedea673b94227226faVariant3? value) => new AutoSDKSharedea673b94227226fa(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedea673b94227226fa(
            global::Vercel.AutoSDKSharedea673b94227226faVariant1? autoSDKSharedea673b94227226faVariant1,
            global::Vercel.AutoSDKShared45ccc0a95a3ba642? shared45ccc0a95a3ba642,
            global::Vercel.AutoSDKSharedea673b94227226faVariant3? autoSDKSharedea673b94227226faVariant3
            )
        {
            AutoSDKSharedea673b94227226faVariant1 = autoSDKSharedea673b94227226faVariant1;
            Shared45ccc0a95a3ba642 = shared45ccc0a95a3ba642;
            AutoSDKSharedea673b94227226faVariant3 = autoSDKSharedea673b94227226faVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AutoSDKSharedea673b94227226faVariant3 as object ??
            Shared45ccc0a95a3ba642 as object ??
            AutoSDKSharedea673b94227226faVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AutoSDKSharedea673b94227226faVariant1?.ToString() ??
            Shared45ccc0a95a3ba642?.ToString() ??
            AutoSDKSharedea673b94227226faVariant3?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAutoSDKSharedea673b94227226faVariant1 && !IsShared45ccc0a95a3ba642 && !IsAutoSDKSharedea673b94227226faVariant3 || !IsAutoSDKSharedea673b94227226faVariant1 && IsShared45ccc0a95a3ba642 && !IsAutoSDKSharedea673b94227226faVariant3 || !IsAutoSDKSharedea673b94227226faVariant1 && !IsShared45ccc0a95a3ba642 && IsAutoSDKSharedea673b94227226faVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKSharedea673b94227226faVariant1, TResult>? autoSDKSharedea673b94227226faVariant1 = null,
            global::System.Func<global::Vercel.AutoSDKShared45ccc0a95a3ba642, TResult>? shared45ccc0a95a3ba642 = null,
            global::System.Func<global::Vercel.AutoSDKSharedea673b94227226faVariant3, TResult>? autoSDKSharedea673b94227226faVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AutoSDKSharedea673b94227226faVariant1 is { } __value0 && autoSDKSharedea673b94227226faVariant1 != null)
            {
                return autoSDKSharedea673b94227226faVariant1(__value0);
            }
            else if (Shared45ccc0a95a3ba642 is { } __value1 && shared45ccc0a95a3ba642 != null)
            {
                return shared45ccc0a95a3ba642(__value1);
            }
            else if (AutoSDKSharedea673b94227226faVariant3 is { } __value2 && autoSDKSharedea673b94227226faVariant3 != null)
            {
                return autoSDKSharedea673b94227226faVariant3(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKSharedea673b94227226faVariant1>? autoSDKSharedea673b94227226faVariant1 = null,

            global::System.Action<global::Vercel.AutoSDKShared45ccc0a95a3ba642>? shared45ccc0a95a3ba642 = null,

            global::System.Action<global::Vercel.AutoSDKSharedea673b94227226faVariant3>? autoSDKSharedea673b94227226faVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AutoSDKSharedea673b94227226faVariant1 is { } __value0)
            {
                autoSDKSharedea673b94227226faVariant1?.Invoke(__value0);
            }
            else if (Shared45ccc0a95a3ba642 is { } __value1)
            {
                shared45ccc0a95a3ba642?.Invoke(__value1);
            }
            else if (AutoSDKSharedea673b94227226faVariant3 is { } __value2)
            {
                autoSDKSharedea673b94227226faVariant3?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKSharedea673b94227226faVariant1>? autoSDKSharedea673b94227226faVariant1 = null,
            global::System.Action<global::Vercel.AutoSDKShared45ccc0a95a3ba642>? shared45ccc0a95a3ba642 = null,
            global::System.Action<global::Vercel.AutoSDKSharedea673b94227226faVariant3>? autoSDKSharedea673b94227226faVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AutoSDKSharedea673b94227226faVariant1 is { } __value0)
            {
                autoSDKSharedea673b94227226faVariant1?.Invoke(__value0);
            }
            else if (Shared45ccc0a95a3ba642 is { } __value1)
            {
                shared45ccc0a95a3ba642?.Invoke(__value1);
            }
            else if (AutoSDKSharedea673b94227226faVariant3 is { } __value2)
            {
                autoSDKSharedea673b94227226faVariant3?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AutoSDKSharedea673b94227226faVariant1,
                typeof(global::Vercel.AutoSDKSharedea673b94227226faVariant1),
                Shared45ccc0a95a3ba642,
                typeof(global::Vercel.AutoSDKShared45ccc0a95a3ba642),
                AutoSDKSharedea673b94227226faVariant3,
                typeof(global::Vercel.AutoSDKSharedea673b94227226faVariant3),
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
        public bool Equals(AutoSDKSharedea673b94227226fa other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKSharedea673b94227226faVariant1?>.Default.Equals(AutoSDKSharedea673b94227226faVariant1, other.AutoSDKSharedea673b94227226faVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared45ccc0a95a3ba642?>.Default.Equals(Shared45ccc0a95a3ba642, other.Shared45ccc0a95a3ba642) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKSharedea673b94227226faVariant3?>.Default.Equals(AutoSDKSharedea673b94227226faVariant3, other.AutoSDKSharedea673b94227226faVariant3)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKSharedea673b94227226fa obj1, AutoSDKSharedea673b94227226fa obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKSharedea673b94227226fa>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKSharedea673b94227226fa obj1, AutoSDKSharedea673b94227226fa obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKSharedea673b94227226fa o && Equals(o);
        }
    }
}
