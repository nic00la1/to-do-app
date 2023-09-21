namespace to_do_app
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void addToList(object sender, EventArgs e)
        {
            CheckBox checkBox = new CheckBox();
            Label label = new Label();
            label.Text = textInput.Text;
            label.VerticalTextAlignment = TextAlignment.Center;
            label.FontSize = 18;

            Button button = new Button();
            button.Text = "Usuń";

            Grid grid = new Grid
            {
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = 60},
                    new ColumnDefinition(),
                    new ColumnDefinition { Width = 120 }
                },
                RowDefinitions =
                {
                    new RowDefinition()
                }
            };

            button.Clicked += (o, e) =>
            {
                list.Remove(grid);
            };

            checkBox.CheckedChanged += (o, e) =>
            {
                if (checkBox.IsChecked == true)
                {
                    grid.BackgroundColor = Color.Parse("Lime");
                }

                if (checkBox.IsChecked == false)
                {
                    grid.BackgroundColor = Color.Parse("Grey");
                }
            };

            grid.Padding = new Thickness(4, 8, 4, 8);
            grid.Margin = new Thickness(0, 8, 0, 0);
            grid.BackgroundColor = Color.Parse("Grey");

            grid.Add(checkBox);
            grid.Add(label, 1, 0);
            grid.Add(button, 2, 0);

            list.Add(grid);
        }
    }
}