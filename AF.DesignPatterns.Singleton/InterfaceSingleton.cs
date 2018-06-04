using System;
using System.Diagnostics;

namespace AF.DesignPatterns.Singleton
{
    /// <summary>
    /// Implements the singleton design pattern.
    /// A class inheriting from this class can be instantiated as a single instance.
    /// </summary>
    /// <typeparam name="T">Class type of the singleton instance.</typeparam>
    /// <typeparam name="TInterface">The interface of the Type in T.</typeparam>
    [DebuggerStepThrough]
    public abstract class Singleton<T, TInterface> where T : TInterface, new() where TInterface : class
    {
        #region Members

        /// <summary>
        /// Static instance. Needs to use lambda expression
        /// to construct an instance (since constructor is private).
        /// </summary>
        private static Lazy<TInterface> _instance = new Lazy<TInterface>(() => new T());

        #endregion

        #region Properties

        /// <summary>
        /// Gets the instance of this singleton.
        /// </summary>
        public static TInterface Instance
        {
            get => _instance.Value;
            set
            {
                _instance = new Lazy<TInterface>(() => value);
            }
        }

        #endregion
    }
}