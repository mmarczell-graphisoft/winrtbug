using Microsoft.UI.Xaml;

using winrtcomponent_cpp;

namespace winui.csharp
{
	/// <summary>
	/// An empty window that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MainWindow : Window
	{
		private Foo foo = new();
		public string FooLabel
		{
			get
			{
				return foo.label;
			}
		}

		public MainWindow()
		{
			this.InitializeComponent();
			this.RootPanel.DataContext = this;
		}
	}
}
