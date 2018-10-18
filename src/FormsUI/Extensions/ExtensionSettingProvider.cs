
using System;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace FormsUI.Extensions
{
    /// <summary>
    /// Represents that the derived classes are Extension Setting Providers.
    /// </summary>
    public abstract class ExtensionSettingProvider
    {
        #region Private Fields
        private static readonly string extensionPath;
        private static readonly Func<Extension, string> getExtensionSettingFileName = 
            (extension) 
                => 
                Path.Combine(extensionPath, string.Format("{0}.setting.json", extension.Id.ToString().Replace('-', '_').ToUpper()));
        private readonly Extension extension;
        private UserControl settingControl;
        #endregion

        #region Ctor
        /// <summary>
        /// Initializes the <see cref="ExtensionSettingProvider"/> class.
        /// </summary>
        static ExtensionSettingProvider()
        {
            extensionPath = Path.Combine(Application.StartupPath, (Path.Combine("Extensions", "Settings")));
            if (!Directory.Exists(extensionPath))
            {
                Directory.CreateDirectory(extensionPath);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionSettingProvider"/> class.
        /// </summary>
        /// <param name="extension">The extension to which the current <c>ExtensionSettingProvider</c> serves.</param>
        public ExtensionSettingProvider(Extension extension)
        {
            this.extension = extension;
        }
        #endregion

        #region Private Methods
        private static IExtensionSettings ReadSetting(Extension extension, Type type)
        {
            if (!typeof(IExtensionSettings).IsAssignableFrom(type))
                throw new InvalidOperationException();

            var settingFile = getExtensionSettingFileName(extension);
            if (!File.Exists(settingFile))
            {
                return null;
            }
            var settingJson = File.ReadAllText(settingFile);
            return (IExtensionSettings)JsonConvert.DeserializeObject(settingJson, type);
        }

        private static void WriteSetting(Extension extension, object setting)
        {
            var settingFile = getExtensionSettingFileName(extension);
            var settingJson = JsonConvert.SerializeObject(setting);
            File.WriteAllText(settingFile, settingJson);
        }
        #endregion

        #region Protected Properties
        /// <summary>
        /// Gets the <see cref="Type"/> instance which defines the setting UserControl.
        /// </summary>
        /// <value>
        /// The <see cref="Type"/> instance which defines the setting UserControl.
        /// </value>
        /// <remarks>The type returned by this property must be derived from <see cref="UserControl"/> type.</remarks>
        protected abstract Type SettingControlType { get; }

        /// <summary>
        /// Gets the <see cref="Type"/> instance which defines the extension setting data.
        /// </summary>
        /// <value>
        /// The <see cref="Type"/> instance which defines the extension setting data.
        /// </value>
        /// <remarks>The type returned by this property must implement the <see cref="IExtensionSettings"/> interface.</remarks>
        protected abstract Type ExtensionSettingType { get; }

        /// <summary>
        /// Gets the default setting of the current extension.
        /// </summary>
        /// <value>
        /// The default setting of the current extension.
        /// </value>
        protected abstract IExtensionSettings DefaultSetting { get; }
        #endregion

        #region Protected Methods
        /// <summary>
        /// Binds the extension setting represented by <paramref name="setting"/> parameter to
        /// the current setting UserControl.
        /// </summary>
        /// <param name="setting">The setting data that needs to be bound to the current setting UserControl.</param>
        protected abstract void DoBindSettingsToControl(IExtensionSettings setting);
        /// <summary>
        /// Collects the extension setting from the current setting UserControl.
        /// </summary>
        /// <returns>The setting data collected from the current setting UserControl.</returns>
        protected abstract IExtensionSettings DoCollectSettingsFromControl();

        protected virtual IExtensionSettings FixSetting(IExtensionSettings setting) => setting;
        #endregion

        #region Internal Properties
        /// <summary>
        /// Gets the extension setting.
        /// </summary>
        /// <value>
        /// The extension setting.
        /// </value>
        public IExtensionSettings ExtensionSetting
        {
            get
            {
                var setting = ReadSetting(this.extension, this.ExtensionSettingType);
                if (setting == null)
                    setting = this.DefaultSetting;
                else
                    setting = FixSetting(setting);
                return setting;
            }
        }
        /// <summary>
        /// Gets the setting <see cref="UserControl"/>.
        /// </summary>
        /// <value>
        /// The setting <see cref="UserControl"/>.
        /// </value>
        /// <exception cref="System.ArgumentNullException">Throws when SettingControlType was not specified.</exception>
        /// <exception cref="System.InvalidOperationException">Throws when the SettingControlType was not the subclass of <see cref="UserControl"/>.</exception>
        public UserControl SettingControl
        {
            get
            {
                if (settingControl == null)
                {
                    if (this.SettingControlType == null)
                        throw new ArgumentNullException("SettingControlType");
                    if (!this.SettingControlType.IsSubclassOf(typeof(UserControl)))
                        throw new InvalidOperationException("");

                    settingControl = (UserControl)Activator.CreateInstance(this.SettingControlType);
                    settingControl.Tag = this.extension;
                    settingControl.Dock = DockStyle.Fill;
                    return settingControl;

                }
                return settingControl;
            }
        }
        /// <summary>
        /// Gets the setting collected from the <see cref="UserControl"/>.
        /// </summary>
        /// <value>
        /// The collected setting.
        /// </value>
        public IExtensionSettings CollectedSetting
        {
            get
            {
                return this.DoCollectSettingsFromControl();
            }
        }
        #endregion

        #region Internal Methods
        /// <summary>
        /// Binds the setting to the current setting <see cref="UserControl"/>.
        /// </summary>
        public void BindSetting(IExtensionSettings setting)
        {
            this.DoBindSettingsToControl(setting);
        }
        /// <summary>
        /// Collects the setting from current setting <see cref="UserControl"/>, and then persist the
        /// setting data to local file.
        /// </summary>
        public void PersistSettings()
        {
            WriteSetting(this.extension, this.DoCollectSettingsFromControl());
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Gets the strong typed setting of current extension.
        /// </summary>
        /// <typeparam name="T">The type of setting.</typeparam>
        /// <returns>The strong typed setting of current extension.</returns>
        public T GetExtensionSetting<T>()
            where T : IExtensionSettings
        {
            return (T)this.ExtensionSetting;
        }

        /// <summary>
        /// Gets the strong typed setting <see cref="UserControl"/>.
        /// </summary>
        /// <typeparam name="T">The type of setting <see cref="UserControl"/>.</typeparam>
        /// <returns>The strong typed setting <see cref="UserControl"/>.</returns>
        public T GetSettingControl<T>()
            where T : UserControl
        {
            return (T)this.SettingControl;
        }
        #endregion
    }
}
