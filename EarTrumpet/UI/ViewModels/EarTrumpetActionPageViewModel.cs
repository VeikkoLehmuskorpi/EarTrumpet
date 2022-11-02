

namespace EarTrumpet.UI.ViewModels
{
    public class EarTrumpetActionPageViewModel : SettingsPageViewModel
    {
        public bool DisableTrayIconScroll
        {
            get => _settings.DisableTrayIconScroll;
            set => _settings.DisableTrayIconScroll = value;
        }

        private readonly AppSettings _settings;

        public EarTrumpetActionPageViewModel(AppSettings settings) : base(null)
        {
            _settings = settings;
            Title = Properties.Resources.ActionPageText;
            Glyph = "\xE15E";
        }
    }
}