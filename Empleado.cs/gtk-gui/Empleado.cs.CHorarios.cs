
// This file has been generated by the GUI designer. Do not modify.
namespace Empleado.cs
{
	public partial class CHorarios
	{
		private global::Gtk.Frame frame1;

		private global::Gtk.Alignment GtkAlignment;

		private global::Gtk.Alignment GtkAlignment1;

		private global::Gtk.HBox hbox1;

		private global::Gtk.VBox vbox2;

		private global::Gtk.VBox vbox5;

		private global::Gtk.Label label1;

		private global::Gtk.VBox vbox6;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Label label2;

		private global::Gtk.Entry entry1;

		private global::Gtk.HBox hbox5;

		private global::Gtk.Label label3;

		private global::Gtk.Entry entry2;

		private global::Gtk.HBox hbox6;

		private global::Gtk.Label label4;

		private global::Gtk.Entry entry3;

		private global::Gtk.HBox hbox7;

		private global::Gtk.Label label5;

		private global::Gtk.Entry entry4;

		private global::Gtk.VBox vbox3;

		private global::Gtk.HBox hbox19;

		private global::Gtk.HBox hbox23;

		private global::Gtk.VBox vbox11;

		private global::Gtk.HBox hbox21;

		private global::Gtk.HBox hbox22;

		private global::Gtk.HBox hbox8;

		private global::Gtk.Button button1;

		private global::Gtk.Button button2;

		private global::Gtk.Button button3;

		private global::Gtk.VBox vbox1;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TreeView treeview1;

		private global::Gtk.HBox hbox52;

		private global::Gtk.Alignment alignment42;

		private global::Gtk.Button btnVolver;

		private global::Gtk.Alignment alignment41;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Empleado.cs.CHorarios
			this.Name = "Empleado.cs.CHorarios";
			this.Title = global::Mono.Unix.Catalog.GetString("CONFIGURACION");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child Empleado.cs.CHorarios.Gtk.Container+ContainerChild
			this.frame1 = new global::Gtk.Frame();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.GtkAlignment1 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment1.Name = "GtkAlignment1";
			this.GtkAlignment1.LeftPadding = ((uint)(12));
			// Container child GtkAlignment1.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("CONTROL DE HORARIOS");
			this.vbox5.Add(this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.vbox6 = new global::Gtk.VBox();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("ID Horario:");
			this.hbox4.Add(this.label2);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label2]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.entry1 = new global::Gtk.Entry();
			this.entry1.CanFocus = true;
			this.entry1.Name = "entry1";
			this.entry1.IsEditable = true;
			this.entry1.InvisibleChar = '•';
			this.hbox4.Add(this.entry1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.entry1]));
			w3.Position = 1;
			this.vbox6.Add(this.hbox4);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox4]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Hora de entrada:");
			this.hbox5.Add(this.label3);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.label3]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.entry2 = new global::Gtk.Entry();
			this.entry2.CanFocus = true;
			this.entry2.Name = "entry2";
			this.entry2.IsEditable = true;
			this.entry2.InvisibleChar = '•';
			this.hbox5.Add(this.entry2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.entry2]));
			w6.Position = 1;
			this.vbox6.Add(this.hbox5);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox5]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Hora de salida:");
			this.hbox6.Add(this.label4);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.label4]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.entry3 = new global::Gtk.Entry();
			this.entry3.CanFocus = true;
			this.entry3.Name = "entry3";
			this.entry3.IsEditable = true;
			this.entry3.InvisibleChar = '•';
			this.hbox6.Add(this.entry3);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.entry3]));
			w9.Position = 1;
			this.vbox6.Add(this.hbox6);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox6]));
			w10.Position = 2;
			w10.Expand = false;
			w10.Fill = false;
			this.vbox5.Add(this.vbox6);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.vbox6]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Turno:");
			this.hbox7.Add(this.label5);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.label5]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.entry4 = new global::Gtk.Entry();
			this.entry4.CanFocus = true;
			this.entry4.Name = "entry4";
			this.entry4.IsEditable = true;
			this.entry4.InvisibleChar = '•';
			this.hbox7.Add(this.entry4);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.entry4]));
			w13.Position = 1;
			this.vbox5.Add(this.hbox7);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox7]));
			w14.Position = 2;
			w14.Expand = false;
			w14.Fill = false;
			this.vbox2.Add(this.vbox5);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.vbox5]));
			w15.Position = 0;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox19 = new global::Gtk.HBox();
			this.hbox19.Name = "hbox19";
			this.hbox19.Spacing = 6;
			// Container child hbox19.Gtk.Box+BoxChild
			this.hbox23 = new global::Gtk.HBox();
			this.hbox23.Name = "hbox23";
			this.hbox23.Spacing = 6;
			this.hbox19.Add(this.hbox23);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox19[this.hbox23]));
			w16.Position = 1;
			this.vbox3.Add(this.hbox19);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox19]));
			w17.Position = 0;
			this.vbox2.Add(this.vbox3);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.vbox3]));
			w18.Position = 1;
			// Container child vbox2.Gtk.Box+BoxChild
			this.vbox11 = new global::Gtk.VBox();
			this.vbox11.Name = "vbox11";
			this.vbox11.Spacing = 6;
			// Container child vbox11.Gtk.Box+BoxChild
			this.hbox21 = new global::Gtk.HBox();
			this.hbox21.Name = "hbox21";
			this.hbox21.Spacing = 6;
			this.vbox11.Add(this.hbox21);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox11[this.hbox21]));
			w19.Position = 0;
			// Container child vbox11.Gtk.Box+BoxChild
			this.hbox22 = new global::Gtk.HBox();
			this.hbox22.Name = "hbox22";
			this.hbox22.Spacing = 6;
			// Container child hbox22.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.button1 = new global::Gtk.Button();
			this.button1.CanFocus = true;
			this.button1.Name = "button1";
			this.button1.UseUnderline = true;
			this.button1.Label = global::Mono.Unix.Catalog.GetString("Nuevo");
			this.hbox8.Add(this.button1);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.button1]));
			w20.Position = 0;
			w20.Expand = false;
			w20.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.button2 = new global::Gtk.Button();
			this.button2.CanFocus = true;
			this.button2.Name = "button2";
			this.button2.UseUnderline = true;
			this.button2.Label = global::Mono.Unix.Catalog.GetString("Editar");
			this.hbox8.Add(this.button2);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.button2]));
			w21.Position = 1;
			w21.Expand = false;
			w21.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.button3 = new global::Gtk.Button();
			this.button3.CanFocus = true;
			this.button3.Name = "button3";
			this.button3.UseUnderline = true;
			this.button3.Label = global::Mono.Unix.Catalog.GetString("Guardar");
			this.hbox8.Add(this.button3);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.button3]));
			w22.Position = 2;
			w22.Expand = false;
			w22.Fill = false;
			this.hbox22.Add(this.hbox8);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox22[this.hbox8]));
			w23.Position = 0;
			w23.Expand = false;
			w23.Fill = false;
			this.vbox11.Add(this.hbox22);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox11[this.hbox22]));
			w24.Position = 1;
			w24.Expand = false;
			w24.Fill = false;
			this.vbox2.Add(this.vbox11);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.vbox11]));
			w25.Position = 2;
			this.hbox1.Add(this.vbox2);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox2]));
			w26.Position = 0;
			w26.Expand = false;
			w26.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeview1 = new global::Gtk.TreeView();
			this.treeview1.CanFocus = true;
			this.treeview1.Name = "treeview1";
			this.GtkScrolledWindow.Add(this.treeview1);
			this.vbox1.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.GtkScrolledWindow]));
			w28.Position = 0;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox52 = new global::Gtk.HBox();
			this.hbox52.Name = "hbox52";
			this.hbox52.Spacing = 6;
			// Container child hbox52.Gtk.Box+BoxChild
			this.alignment42 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment42.Name = "alignment42";
			this.hbox52.Add(this.alignment42);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox52[this.alignment42]));
			w29.Position = 0;
			// Container child hbox52.Gtk.Box+BoxChild
			this.btnVolver = new global::Gtk.Button();
			this.btnVolver.CanFocus = true;
			this.btnVolver.Name = "btnVolver";
			this.btnVolver.UseUnderline = true;
			this.btnVolver.Label = global::Mono.Unix.Catalog.GetString("Volver al menú principal");
			this.hbox52.Add(this.btnVolver);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox52[this.btnVolver]));
			w30.Position = 1;
			w30.Expand = false;
			w30.Fill = false;
			// Container child hbox52.Gtk.Box+BoxChild
			this.alignment41 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment41.Name = "alignment41";
			this.hbox52.Add(this.alignment41);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbox52[this.alignment41]));
			w31.Position = 2;
			this.vbox1.Add(this.hbox52);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox52]));
			w32.Position = 1;
			w32.Expand = false;
			w32.Fill = false;
			this.hbox1.Add(this.vbox1);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox1]));
			w33.Position = 1;
			this.GtkAlignment1.Add(this.hbox1);
			this.GtkAlignment.Add(this.GtkAlignment1);
			this.frame1.Add(this.GtkAlignment);
			this.Add(this.frame1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 693;
			this.DefaultHeight = 300;
			this.Show();
		}
	}
}