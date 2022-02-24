namespace GenAlphaMaui.Pages
{
    public partial class DesktopShell
    {
        public DesktopShell()
        {
            InitializeComponent();

            BindingContext = new ShellViewModel();
        }
    }
}
