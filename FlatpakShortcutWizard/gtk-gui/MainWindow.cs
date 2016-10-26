
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;

	private global::Gtk.Entry entry1;

	private global::Gtk.Label lbl1;

	private global::Gtk.Button button1;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.TreeView treeview1;

	private global::Gtk.Label label1;

	private global::Gtk.Label lblSelected;

	private global::Gtk.Button btnCreateCut;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("Flatpak ShortCut Creator");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.Resizable = false;
		this.DefaultWidth = 600;
		this.DefaultHeight = 400;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed();
		this.fixed1.WidthRequest = 650;
		this.fixed1.HeightRequest = 450;
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entry1 = new global::Gtk.Entry();
		this.entry1.CanFocus = true;
		this.entry1.Name = "entry1";
		this.entry1.IsEditable = true;
		this.entry1.InvisibleChar = '●';
		this.fixed1.Add(this.entry1);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.entry1]));
		w1.X = 110;
		w1.Y = 13;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lbl1 = new global::Gtk.Label();
		this.lbl1.Name = "lbl1";
		this.lbl1.LabelProp = global::Mono.Unix.Catalog.GetString("filter");
		this.fixed1.Add(this.lbl1);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.lbl1]));
		w2.X = 48;
		w2.Y = 18;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button1 = new global::Gtk.Button();
		this.button1.CanFocus = true;
		this.button1.Name = "button1";
		this.button1.UseUnderline = true;
		this.button1.Label = global::Mono.Unix.Catalog.GetString("search");
		this.fixed1.Add(this.button1);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button1]));
		w3.X = 282;
		w3.Y = 8;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.treeview1 = new global::Gtk.TreeView();
		this.treeview1.WidthRequest = 580;
		this.treeview1.HeightRequest = 340;
		this.treeview1.CanFocus = true;
		this.treeview1.Name = "treeview1";
		this.GtkScrolledWindow.Add(this.treeview1);
		this.fixed1.Add(this.GtkScrolledWindow);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.GtkScrolledWindow]));
		w5.X = 9;
		w5.Y = 49;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("selected app:");
		this.fixed1.Add(this.label1);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label1]));
		w6.X = 16;
		w6.Y = 416;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblSelected = new global::Gtk.Label();
		this.lblSelected.Name = "lblSelected";
		this.fixed1.Add(this.lblSelected);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.lblSelected]));
		w7.X = 143;
		w7.Y = 415;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.btnCreateCut = new global::Gtk.Button();
		this.btnCreateCut.CanFocus = true;
		this.btnCreateCut.Name = "btnCreateCut";
		this.btnCreateCut.UseUnderline = true;
		this.btnCreateCut.Label = global::Mono.Unix.Catalog.GetString("Create ShortCut");
		this.fixed1.Add(this.btnCreateCut);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnCreateCut]));
		w8.X = 460;
		w8.Y = 406;
		this.Add(this.fixed1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.button1.Clicked += new global::System.EventHandler(this.OnButton1Clicked);
		this.btnCreateCut.Clicked += new global::System.EventHandler(this.OnBtnCreateCutClicked);
	}
}