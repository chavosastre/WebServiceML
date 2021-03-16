using Genshin.Models;
using Xamarin.Forms;

namespace Genshin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new TodoListViewModel();
        }

    }
}
