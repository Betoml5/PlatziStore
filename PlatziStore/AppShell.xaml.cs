using PlatziStore.Views;

namespace PlatziStore
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("ProductoDetalles", typeof(ProductoDetalles));
        }
    }
}
