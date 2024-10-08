using study.ViewModels;

namespace study.Views;

public partial class MonitorView : ContentPage
{
	public MonitorView()
	{
		InitializeComponent();
		BindingContext = new MonitorViewModels();
	}
}