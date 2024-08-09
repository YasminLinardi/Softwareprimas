 using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace software
{
    public partial class Carrinho : ContentPage
    {
        public ObservableCollection<CartItem> CartItems { get; set; }

        public Carrinho()
        {
            InitializeComponent();
            CartItems = new ObservableCollection<CartItem>();
            CartItemsCollectionView.ItemsSource = CartItems;
        }

        private void OnIncreaseQuantityClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var item = (CartItem)button.BindingContext;
            item.Quantity++;
        }

        private void OnDecreaseQuantityClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var item = (CartItem)button.BindingContext;
            if (item.Quantity > 0) item.Quantity--;
        }

        private void OnDeleteItemClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var item = (CartItem)button.BindingContext;
            CartItems.Remove(item);
        }
    }

    public class CartItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}
   