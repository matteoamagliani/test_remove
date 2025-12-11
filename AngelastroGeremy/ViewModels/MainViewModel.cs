namespace AngelastroGeremy.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private BaseViewModel _currentView;
        public BaseViewModel CurrentView
        {
            get => _currentView;
            set { _currentView = value; Raise(); }
        }


        public RelayCommand ShowProductsCommand { get; }
        public RelayCommand ShowOrdersCommand { get; }
        public RelayCommand ShowCustomersCommand { get; }


        public MainViewModel()
        {
            ShowProductsCommand = new RelayCommand(_ => CurrentView = new ProductsViewModel());
            ShowOrdersCommand = new RelayCommand(_ => CurrentView = new OrdersViewModel());
            ShowCustomersCommand = new RelayCommand(_ => CurrentView = new CustomersViewModel());


            CurrentView = new ProductsViewModel();
        }
    }
}