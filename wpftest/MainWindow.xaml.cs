using System.Windows;

using winrtcomponent_cpp;

namespace wpftest
{
	public partial class MainWindow : Window
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
			InitializeComponent();
			DataContext = this;
		}
	}
}