
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace FormsUI.Extensions
{
    /// <summary>
    /// Represents the Extension Manager that registers and manages the extensions.
    /// </summary>
    public sealed class ExtensionManager : ExternalResourceManager<Extension>
    {

        #region Ctor
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionManager"/> class.
        /// </summary>
        /// <param name="path">The path which contains the extension assemblies.</param>
        public ExtensionManager(string path)
            : base(path, "*.dll")
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionManager"/> class.
        /// </summary>
        public ExtensionManager()
            : this(Application.StartupPath)
        {

        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets all of the registered extensions.
        /// </summary>
        /// <value>
        /// All extensions.
        /// </value>
        public IEnumerable<KeyValuePair<Guid, Extension>> AllExtensions
        {
            get
            {
                return this.Resources;
            }
        }

        public IEnumerable<TExtension> GetExtensions<TExtension>()
            where TExtension : Extension => Resources.Values.Where(t => t.GetType().IsSubclassOf(typeof(TExtension))).Select(p => (TExtension)p);

        #endregion

        protected override IEnumerable<Extension> LoadResources(string fileName)
        {
            var assembly = Assembly.LoadFile(fileName);
            var result = new List<Extension>();
            foreach (var type in assembly.GetExportedTypes())
            {
                if (type.IsDefined(typeof (ExtensionAttribute)) &&
                    type.IsSubclassOf(typeof (Extension)))
                {
                    try
                    {
                        var extensionLoaded = (Extension) Activator.CreateInstance(type);
                        this.OnResourceLoaded(extensionLoaded);
                        result.Add(extensionLoaded);
                    }
                    catch
                    {
                    }
                }
            }
            return result;
        }
    }
}
