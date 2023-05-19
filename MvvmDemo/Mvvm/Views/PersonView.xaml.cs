
using MvvmDemo.Mvvm.ViewModels;

namespace MvvmDemo.Mvvm.Views;

public partial class PersonView : ContentPage
{
	public PersonView()
	{
		InitializeComponent();

		BindingContext = new PersonViewModel();

	}
}