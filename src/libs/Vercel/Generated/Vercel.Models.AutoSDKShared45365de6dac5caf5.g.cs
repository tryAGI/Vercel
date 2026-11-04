#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKShared45365de6dac5caf5 : global::System.IEquatable<AutoSDKShared45365de6dac5caf5>
    {
        /// <summary>
        /// Services detected during build from vercel.json experimentalServices or auto-detected from project structure. Used to inject service URLs as environment variables at runtime.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared303c00bc2455dd70? Shared303c00bc2455dd70 { get; init; }
#else
        public global::Vercel.AutoSDKShared303c00bc2455dd70? Shared303c00bc2455dd70 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared303c00bc2455dd70))]
#endif
        public bool IsShared303c00bc2455dd70 => Shared303c00bc2455dd70 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared303c00bc2455dd70(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared303c00bc2455dd70? value)
        {
            value = Shared303c00bc2455dd70;
            return IsShared303c00bc2455dd70;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared303c00bc2455dd70 PickShared303c00bc2455dd70() => Shared303c00bc2455dd70 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared303c00bc2455dd70' but the value was {ToString()}.");

        /// <summary>
        /// Services detected during build from vercel.json experimentalServices or auto-detected from project structure. Used to inject service URLs as environment variables at runtime.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vercel.AutoSDKShared82fc3497d7089534? Shared82fc3497d7089534 { get; init; }
#else
        public global::Vercel.AutoSDKShared82fc3497d7089534? Shared82fc3497d7089534 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Shared82fc3497d7089534))]
#endif
        public bool IsShared82fc3497d7089534 => Shared82fc3497d7089534 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShared82fc3497d7089534(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKShared82fc3497d7089534? value)
        {
            value = Shared82fc3497d7089534;
            return IsShared82fc3497d7089534;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKShared82fc3497d7089534 PickShared82fc3497d7089534() => Shared82fc3497d7089534 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Shared82fc3497d7089534' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared45365de6dac5caf5(global::Vercel.AutoSDKShared303c00bc2455dd70 value) => new AutoSDKShared45365de6dac5caf5((global::Vercel.AutoSDKShared303c00bc2455dd70?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared303c00bc2455dd70?(AutoSDKShared45365de6dac5caf5 @this) => @this.Shared303c00bc2455dd70;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared45365de6dac5caf5(global::Vercel.AutoSDKShared303c00bc2455dd70? value)
        {
            Shared303c00bc2455dd70 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared45365de6dac5caf5 FromShared303c00bc2455dd70(global::Vercel.AutoSDKShared303c00bc2455dd70? value) => new AutoSDKShared45365de6dac5caf5(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKShared45365de6dac5caf5(global::Vercel.AutoSDKShared82fc3497d7089534 value) => new AutoSDKShared45365de6dac5caf5((global::Vercel.AutoSDKShared82fc3497d7089534?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared82fc3497d7089534?(AutoSDKShared45365de6dac5caf5 @this) => @this.Shared82fc3497d7089534;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared45365de6dac5caf5(global::Vercel.AutoSDKShared82fc3497d7089534? value)
        {
            Shared82fc3497d7089534 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKShared45365de6dac5caf5 FromShared82fc3497d7089534(global::Vercel.AutoSDKShared82fc3497d7089534? value) => new AutoSDKShared45365de6dac5caf5(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKShared45365de6dac5caf5(
            global::Vercel.AutoSDKShared303c00bc2455dd70? shared303c00bc2455dd70,
            global::Vercel.AutoSDKShared82fc3497d7089534? shared82fc3497d7089534
            )
        {
            Shared303c00bc2455dd70 = shared303c00bc2455dd70;
            Shared82fc3497d7089534 = shared82fc3497d7089534;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Shared82fc3497d7089534 as object ??
            Shared303c00bc2455dd70 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Shared303c00bc2455dd70?.ToString() ??
            Shared82fc3497d7089534?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsShared303c00bc2455dd70 && !IsShared82fc3497d7089534 || !IsShared303c00bc2455dd70 && IsShared82fc3497d7089534;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKShared303c00bc2455dd70, TResult>? shared303c00bc2455dd70 = null,
            global::System.Func<global::Vercel.AutoSDKShared82fc3497d7089534, TResult>? shared82fc3497d7089534 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared303c00bc2455dd70 is { } __value0 && shared303c00bc2455dd70 != null)
            {
                return shared303c00bc2455dd70(__value0);
            }
            else if (Shared82fc3497d7089534 is { } __value1 && shared82fc3497d7089534 != null)
            {
                return shared82fc3497d7089534(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKShared303c00bc2455dd70>? shared303c00bc2455dd70 = null,

            global::System.Action<global::Vercel.AutoSDKShared82fc3497d7089534>? shared82fc3497d7089534 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared303c00bc2455dd70 is { } __value0)
            {
                shared303c00bc2455dd70?.Invoke(__value0);
            }
            else if (Shared82fc3497d7089534 is { } __value1)
            {
                shared82fc3497d7089534?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKShared303c00bc2455dd70>? shared303c00bc2455dd70 = null,
            global::System.Action<global::Vercel.AutoSDKShared82fc3497d7089534>? shared82fc3497d7089534 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Shared303c00bc2455dd70 is { } __value0)
            {
                shared303c00bc2455dd70?.Invoke(__value0);
            }
            else if (Shared82fc3497d7089534 is { } __value1)
            {
                shared82fc3497d7089534?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Shared303c00bc2455dd70,
                typeof(global::Vercel.AutoSDKShared303c00bc2455dd70),
                Shared82fc3497d7089534,
                typeof(global::Vercel.AutoSDKShared82fc3497d7089534),
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
        public bool Equals(AutoSDKShared45365de6dac5caf5 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared303c00bc2455dd70?>.Default.Equals(Shared303c00bc2455dd70, other.Shared303c00bc2455dd70) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared82fc3497d7089534?>.Default.Equals(Shared82fc3497d7089534, other.Shared82fc3497d7089534)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKShared45365de6dac5caf5 obj1, AutoSDKShared45365de6dac5caf5 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKShared45365de6dac5caf5>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKShared45365de6dac5caf5 obj1, AutoSDKShared45365de6dac5caf5 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKShared45365de6dac5caf5 o && Equals(o);
        }
    }
}
