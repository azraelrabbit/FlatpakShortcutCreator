using System;
using Gtk;
using FlatpakShortcutWizard;
using System.Collections.Generic;
using System.Linq;

public partial class MainWindow : Gtk.Window
{
	string selectedItem;

	List<FlatAppItem> applist;
	Gtk.ListStore treeviewModelSource;

	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();

		InitTreeview();

		applist= new FlatAppList().GetFlatAppList();

		ReloadTreeview(applist);
	}

	void InitTreeview() { 
	var column = new TreeViewColumn() { Title = "Flatpak AppName" };
		// Create the text cell that will display the artist name
		var artistNameCell = new CellRendererText();

		// Add the cell to the column
		column.PackStart(artistNameCell, true);
		column.AddAttribute(artistNameCell, "text", 0);

		column.Clickable = true;

		treeview1.AppendColumn(column);

		//var deskpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		//	Console.WriteLine(deskpath);
		treeview1.RowActivated += new RowActivatedHandler(ontreeviewRowActived);

	 treeviewModelSource = new Gtk.ListStore(typeof(string));
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}

	protected void OnButton1Clicked(object sender, System.EventArgs e)
	{



		var filtertext = entry1.Text;
		if (!string.IsNullOrEmpty(filtertext))
		{
			var newlist = applist.FindAll(p => p.AppName.ToLower().Contains(filtertext.ToLower())).ToList();

			entry1.Text = string.Empty;
			ReloadTreeview(newlist);
		}
		else{
			ReloadTreeview(applist);
		}


	}

	protected void ReloadTreeview(List<FlatAppItem> itemlist) {
		//treeview1.AppendColumn(new TreeViewColumn() { Title = "Create ShortCut" });

		treeview1.Model = null;
		treeviewModelSource.Clear();


		foreach (var s in itemlist)
		{
			treeviewModelSource.AppendValues(s.AppName);
		}

		treeview1.Model = treeviewModelSource;
	}

	protected void OnBtnCreateCutClicked(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(selectedItem))
		{new FlatAppList().CreateShortcut(selectedItem);
		}

	}

	protected void ontreeviewRowActived(object sender, Gtk.RowActivatedArgs  e)
	{
		var model = treeview1.Model;
		TreeIter iter;
		model.GetIter(out iter, e.Path);
		var value = model.GetValue(iter, 0);
		selectedItem = value.ToString();
		lblSelected.Text = selectedItem;
	}
}
