using System.Windows.Data;

namespace Savaged.BlackNotepad
{
    public class SettingBindingExtension : Binding
    {
        public SettingBindingExtension()
        {
            Initialize();
        }

        public SettingBindingExtension(string path)
            : base(path)
        {
            Initialize();
        }

        private void Initialize()
        {
            this.Source = Savaged.BlackNotepad.Properties.Settings.Default;
            this.Mode = BindingMode.TwoWay;
        }
    }
}
