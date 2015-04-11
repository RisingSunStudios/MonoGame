
// This file has been generated by the GUI designer. Do not modify.
namespace MonoGame.Tools.Pipeline
{
	public partial class AddFileDialog
	{
		private global::Gtk.Label label1;
		
		private global::Gtk.RadioButton radiobuttonCopy;
		
		private global::Gtk.RadioButton radiobuttonLink;
		
		private global::Gtk.RadioButton radiobuttonSkip;
		
		private global::Gtk.CheckButton checkbutton1;
		
		private global::Gtk.Alignment alignment1;
		
		private global::Gtk.Button buttonCancel;
		
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoGame.Tools.Pipeline.AddFileDialog
			this.Name = "MonoGame.Tools.Pipeline.AddFileDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Add File Action");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.BorderWidth = ((uint)(4));
			// Internal child MonoGame.Tools.Pipeline.AddFileDialog.VBox
            #if GTK2
            global::Gtk.VBox w1 = this.VBox;
            #elif GTK3
            global::Gtk.Box w1 = this.ContentArea;
            #endif
			w1.Name = "dialog1_VBox";
			w1.Spacing = 6;
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("The file <b>%file</b> is outside of the target directory. What would you like to do?");
			this.label1.Wrap = true;
			w1.Add (this.label1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(w1 [this.label1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.radiobuttonCopy = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Copy the file to the directory"));
			this.radiobuttonCopy.CanFocus = true;
			this.radiobuttonCopy.Name = "radiobuttonCopy";
			this.radiobuttonCopy.Active = true;
			this.radiobuttonCopy.DrawIndicator = true;
			this.radiobuttonCopy.UseUnderline = true;
			//this.radiobuttonCopy.Group = new global::GLib.SList (global::System.IntPtr.Zero);
			w1.Add (this.radiobuttonCopy);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(w1 [this.radiobuttonCopy]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.radiobuttonLink = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Add a link to the file"));
			this.radiobuttonLink.CanFocus = true;
			this.radiobuttonLink.Name = "radiobuttonLink";
			this.radiobuttonLink.DrawIndicator = true;
			this.radiobuttonLink.UseUnderline = true;
			this.radiobuttonLink.Group = this.radiobuttonCopy.Group;
			w1.Add (this.radiobuttonLink);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(w1 [this.radiobuttonLink]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.radiobuttonSkip = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Skip adding the file"));
			this.radiobuttonSkip.CanFocus = true;
			this.radiobuttonSkip.Name = "radiobuttonSkip";
			this.radiobuttonSkip.DrawIndicator = true;
			this.radiobuttonSkip.UseUnderline = true;
			this.radiobuttonSkip.Group = this.radiobuttonCopy.Group;
			w1.Add (this.radiobuttonSkip);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(w1 [this.radiobuttonSkip]));
			w5.Position = 3;
			w5.Expand = false;
			w5.Fill = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.checkbutton1 = new global::Gtk.CheckButton ();
			this.checkbutton1.CanFocus = true;
			this.checkbutton1.Name = "checkbutton1";
			this.checkbutton1.Label = global::Mono.Unix.Catalog.GetString ("Use the same action for all selected files");
			this.checkbutton1.DrawIndicator = true;
			this.checkbutton1.UseUnderline = true;
			w1.Add (this.checkbutton1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(w1 [this.checkbutton1]));
			w6.PackType = ((global::Gtk.PackType)(1));
			w6.Position = 5;
			w6.Expand = false;
			w6.Fill = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			w1.Add (this.alignment1);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(w1 [this.alignment1]));
			w7.PackType = ((global::Gtk.PackType)(1));
			w7.Position = 6;
			// Internal child MonoGame.Tools.Pipeline.AddFileDialog.ActionArea
            #if GTK2
			global::Gtk.HButtonBox w8 = this.ActionArea;
            #elif GTK3
            global::Gtk.ButtonBox w8 = this.ActionArea;
            #endif
			w8.Name = "dialog1_ActionArea";
			w8.Spacing = 10;
			w8.BorderWidth = ((uint)(5));
			w8.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w9 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w8 [this.buttonCancel]));
			w9.Expand = false;
			w9.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			w8.Add (this.buttonOk);
			global::Gtk.ButtonBox.ButtonBoxChild w10 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w8 [this.buttonOk]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 398;
			this.DefaultHeight = 261;
			this.Show ();
			this.Response += new global::Gtk.ResponseHandler (this.OnResponse);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnButtonOkClicked);
		}
	}
}
