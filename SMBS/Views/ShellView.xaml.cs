using MahApps.Metro.Controls;
using SMBS.BAL.Mvvm;

namespace SMBS.Views
{
    /// <summary>
    /// Interaction logic for ShellView.xaml
    /// </summary>
    public partial class ShellView : MetroWindow, IView
    {
        public ShellView()
        {
            InitializeComponent();
        }

        private void HamburgerMenuControl_OnItemClick(object sender, ItemClickEventArgs e)
        {
            // set the content
            this.HamburgerMenuControl.Content = e.ClickedItem;
            // close the pane
            this.HamburgerMenuControl.IsPaneOpen = false;
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    using (var fs = new FileStream("E:\\ddd.rtf", FileMode.Open))
        //    {
        //        var doc = new FlowDocument();
        //        var t = new TextRange(doc.ContentStart, doc.ContentEnd);
        //        t.Load(fs, DataFormats.Rtf);
        //        ddd.Document = doc;
        //    }
        //}

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    var d = new DocumentPrinter();
        //    d.Print(ddd.Document);
        //}

        //private void Button_Click(object s//ender, RoutedEventArgs e)

        //{
        //    using (var ms = new MemoryStream())
        //    {
        //        var t1 = new TextRange(rtfA.Document.ContentStart, rtfA.Document.ContentEnd);
        //        t1.Save(ms, DataFormats.Rtf);

        //        var t2 = new TextRange(rtfB.Document.ContentStart, rtfB.Document.ContentEnd);
        //        t2.Load(ms, DataFormats.Rtf);
        //    }


        //}

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    //var table = new Table();
        //    //table.Columns.Add(new TableColumn());
        //    //table.Columns.Add(new TableColumn());

        //    //var group = new TableRowGroup();
        //    //var row = new TableRow();
        //    //row.Cells.Add(new TableCell(new Paragraph(new Run("ddddd"))));
        //    //row.Cells.Add(new TableCell(new Paragraph(new Run("ddddasdasdd"))));
        //    //group.Rows.Add(row);
        //    //table.RowGroups.Add(group);

        //    //rtfA.Document.Blocks.Add(table);
        //    var bitmap = new BitmapImage(new Uri("E:\\Avicii-signature.jpg"));
        //    var image = new Image();
        //    image.Source = bitmap;
        //    image.Width = bitmap.Width;
        //    image.Height = bitmap.Height;

        //    var para = new Paragraph();
        //    para.Inlines.Add(image);
        //    para.Margin = new Thickness(0, 0, 0, 0);
        //    rtfA.Document.Blocks.Add(para);

        //    skd.Maximum = image.Width;
        //    skd.Minimum = 10;
        //    skd.ValueChanged += (o, args) =>
        //    {
        //        image.Width = skd.Value;
        //    };
        //}

        //private void Button_Click_2(object sender, RoutedEventArgs e)
        //{
        //    using (var ms = new FileStream("E:\\ddd.rtf", FileMode.Create))
        //    {
        //        var t1 = new TextRange(rtfB.Document.ContentStart, rtfB.Document.ContentEnd);
        //        t1.Save(ms, DataFormats.Rtf);
        //    }
        //}
    }
}

