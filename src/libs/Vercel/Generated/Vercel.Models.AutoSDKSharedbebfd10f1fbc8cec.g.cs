#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AutoSDKSharedbebfd10f1fbc8cec : global::System.IEquatable<AutoSDKSharedbebfd10f1fbc8cec>
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
        public global::Vercel.AutoSDKSharedb7e537bead367337? Sharedb7e537bead367337 { get; init; }
#else
        public global::Vercel.AutoSDKSharedb7e537bead367337? Sharedb7e537bead367337 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sharedb7e537bead367337))]
#endif
        public bool IsSharedb7e537bead367337 => Sharedb7e537bead367337 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSharedb7e537bead367337(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vercel.AutoSDKSharedb7e537bead367337? value)
        {
            value = Sharedb7e537bead367337;
            return IsSharedb7e537bead367337;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vercel.AutoSDKSharedb7e537bead367337 PickSharedb7e537bead367337() => Sharedb7e537bead367337 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sharedb7e537bead367337' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKSharedbebfd10f1fbc8cec(global::Vercel.AutoSDKShared303c00bc2455dd70 value) => new AutoSDKSharedbebfd10f1fbc8cec((global::Vercel.AutoSDKShared303c00bc2455dd70?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKShared303c00bc2455dd70?(AutoSDKSharedbebfd10f1fbc8cec @this) => @this.Shared303c00bc2455dd70;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedbebfd10f1fbc8cec(global::Vercel.AutoSDKShared303c00bc2455dd70? value)
        {
            Shared303c00bc2455dd70 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKSharedbebfd10f1fbc8cec FromShared303c00bc2455dd70(global::Vercel.AutoSDKShared303c00bc2455dd70? value) => new AutoSDKSharedbebfd10f1fbc8cec(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AutoSDKSharedbebfd10f1fbc8cec(global::Vercel.AutoSDKSharedb7e537bead367337 value) => new AutoSDKSharedbebfd10f1fbc8cec((global::Vercel.AutoSDKSharedb7e537bead367337?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vercel.AutoSDKSharedb7e537bead367337?(AutoSDKSharedbebfd10f1fbc8cec @this) => @this.Sharedb7e537bead367337;

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedbebfd10f1fbc8cec(global::Vercel.AutoSDKSharedb7e537bead367337? value)
        {
            Sharedb7e537bead367337 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AutoSDKSharedbebfd10f1fbc8cec FromSharedb7e537bead367337(global::Vercel.AutoSDKSharedb7e537bead367337? value) => new AutoSDKSharedbebfd10f1fbc8cec(value);

        /// <summary>
        ///
        /// </summary>
        public AutoSDKSharedbebfd10f1fbc8cec(
            global::Vercel.AutoSDKShared303c00bc2455dd70? shared303c00bc2455dd70,
            global::Vercel.AutoSDKSharedb7e537bead367337? sharedb7e537bead367337
            )
        {
            Shared303c00bc2455dd70 = shared303c00bc2455dd70;
            Sharedb7e537bead367337 = sharedb7e537bead367337;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Sharedb7e537bead367337 as object ??
            Shared303c00bc2455dd70 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Shared303c00bc2455dd70?.ToString() ??
            Sharedb7e537bead367337?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsShared303c00bc2455dd70 && !IsSharedb7e537bead367337 || !IsShared303c00bc2455dd70 && IsSharedb7e537bead367337;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vercel.AutoSDKShared303c00bc2455dd70, TResult>? shared303c00bc2455dd70 = null,
            global::System.Func<global::Vercel.AutoSDKSharedb7e537bead367337, TResult>? sharedb7e537bead367337 = null,
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
            else if (Sharedb7e537bead367337 is { } __value1 && sharedb7e537bead367337 != null)
            {
                return sharedb7e537bead367337(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vercel.AutoSDKShared303c00bc2455dd70>? shared303c00bc2455dd70 = null,

            global::System.Action<global::Vercel.AutoSDKSharedb7e537bead367337>? sharedb7e537bead367337 = null,
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
            else if (Sharedb7e537bead367337 is { } __value1)
            {
                sharedb7e537bead367337?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vercel.AutoSDKShared303c00bc2455dd70>? shared303c00bc2455dd70 = null,
            global::System.Action<global::Vercel.AutoSDKSharedb7e537bead367337>? sharedb7e537bead367337 = null,
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
            else if (Sharedb7e537bead367337 is { } __value1)
            {
                sharedb7e537bead367337?.Invoke(__value1);
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
                Sharedb7e537bead367337,
                typeof(global::Vercel.AutoSDKSharedb7e537bead367337),
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
        public bool Equals(AutoSDKSharedbebfd10f1fbc8cec other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKShared303c00bc2455dd70?>.Default.Equals(Shared303c00bc2455dd70, other.Shared303c00bc2455dd70) &&
                global::System.Collections.Generic.EqualityComparer<global::Vercel.AutoSDKSharedb7e537bead367337?>.Default.Equals(Sharedb7e537bead367337, other.Sharedb7e537bead367337)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AutoSDKSharedbebfd10f1fbc8cec obj1, AutoSDKSharedbebfd10f1fbc8cec obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AutoSDKSharedbebfd10f1fbc8cec>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AutoSDKSharedbebfd10f1fbc8cec obj1, AutoSDKSharedbebfd10f1fbc8cec obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AutoSDKSharedbebfd10f1fbc8cec o && Equals(o);
        }
    }
}
