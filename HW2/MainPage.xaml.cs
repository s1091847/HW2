namespace HW2
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            List<Fruit> list = new List<Fruit>();
            {   new Fruit() { Name = "Apple", Image = "apple.png", Description = "This is an apple" };
                new Fruit() { Name = "Banana", Image = "Banana", Description = "This is a banana" };
                new Fruit() { Name = "Orange", Image = "Orange", Description = "This is an orange" };
                new Fruit() { Name = "Pineapple", Image = "Pineapple", Description = "This is a pineapple" };
                new Fruit() { Name = "Strawberry", Image = "Strawberry", Description = "This is a strawberry" };
                new Fruit() { Name = "Watermelon", Image = "Watermelon", Description = "This is a watermelon" };
                new Fruit() { Name = "Grapes", Image = "Grapes", Description = "This is a grape" };
                new Fruit() { Name = "Kiwi", Image = "Kiwi", Description = "This is a kiwi" };
             
             
             };
            InitializeComponent();
            FruitListView.ItemsSource = list;
        }
        private void FruitListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var selectedItem = e.SelectedItem as Fruit;
            Navigation.PushAsync(new FruitDtailed(selectedItem));
        }

        
    }
}