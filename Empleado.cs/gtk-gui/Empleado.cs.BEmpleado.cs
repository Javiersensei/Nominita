
// This file has been generated by the GUI designer. Do not modify.
namespace Empleado.cs
{
	public partial class BEmpleado
	{
		private global::Gtk.Frame frame3;

		private global::Gtk.Alignment GtkAlignment;

		private global::Gtk.Alignment GtkAlignment1;

		private global::Gtk.Alignment GtkAlignment2;

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

		private global::Gtk.VBox vbox4;

		private global::Gtk.HBox hbox11;

		private global::Gtk.Label label9;

		private global::Gtk.Entry entry8;

		private global::Gtk.VBox vbox8;

		private global::Gtk.HBox hbox12;

		private global::Gtk.Label label10;

		private global::Gtk.Entry entry14;

		private global::Gtk.HBox hbox13;

		private global::Gtk.Label label11;

		private global::Gtk.Entry entry15;

		private global::Gtk.HBox hbox14;

		private global::Gtk.Label label12;

		private global::Gtk.Entry entry16;

		private global::Gtk.VBox vbox3;

		private global::Gtk.HBox hbox15;

		private global::Gtk.Label label13;

		private global::Gtk.Entry entry10;

		private global::Gtk.VBox vbox11;

		private global::Gtk.HBox hbox21;

		private global::Gtk.Label label19;

		private global::Gtk.Entry entry11;

		private global::Gtk.VBox vbox9;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Label label6;

		private global::Gtk.Entry entry17;

		private global::Gtk.HBox hbox8;

		private global::Gtk.Label label7;

		private global::Gtk.Entry entry18;

		private global::Gtk.HBox hbox9;

		private global::Gtk.Label label8;

		private global::Gtk.Entry entry19;

		private global::Gtk.HBox hbox10;

		private global::Gtk.VBox vbox7;

		private global::Gtk.HBox hbox7;

		private global::Gtk.Button button1;

		private global::Gtk.Button button2;

		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label label21;

		private global::Gtk.Entry entry13;

		private global::Gtk.Button btnBuscar;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TreeView treeview1;

		private global::Gtk.HBox hbox51;

		private global::Gtk.Alignment alignment40;

		private global::Gtk.Button btnVolver;

		private global::Gtk.Alignment alignment39;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Empleado.cs.BEmpleado
			this.Name = "Empleado.cs.BEmpleado";
			this.Title = global::Mono.Unix.Catalog.GetString("EMPLEADOS");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child Empleado.cs.BEmpleado.Gtk.Container+ContainerChild
			this.frame3 = new global::Gtk.Frame();
			this.frame3.Name = "frame3";
			this.frame3.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame3.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.GtkAlignment1 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment1.Name = "GtkAlignment1";
			this.GtkAlignment1.LeftPadding = ((uint)(12));
			// Container child GtkAlignment1.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
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
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("BAJA DE EMPLEADO");
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
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("ID Empleado:");
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
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("         Nombre:");
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
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("      Apellidos:");
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
			this.vbox2.Add(this.vbox5);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.vbox5]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox11 = new global::Gtk.HBox();
			this.hbox11.Name = "hbox11";
			this.hbox11.Spacing = 6;
			// Container child hbox11.Gtk.Box+BoxChild
			this.label9 = new global::Gtk.Label();
			this.label9.Name = "label9";
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString("Fecha de contratacion:");
			this.hbox11.Add(this.label9);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.label9]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			// Container child hbox11.Gtk.Box+BoxChild
			this.entry8 = new global::Gtk.Entry();
			this.entry8.CanFocus = true;
			this.entry8.Name = "entry8";
			this.entry8.IsEditable = true;
			this.entry8.InvisibleChar = '•';
			this.hbox11.Add(this.entry8);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.entry8]));
			w14.Position = 1;
			this.vbox4.Add(this.hbox11);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox11]));
			w15.Position = 0;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.vbox8 = new global::Gtk.VBox();
			this.vbox8.Name = "vbox8";
			this.vbox8.Spacing = 6;
			// Container child vbox8.Gtk.Box+BoxChild
			this.hbox12 = new global::Gtk.HBox();
			this.hbox12.Name = "hbox12";
			this.hbox12.Spacing = 6;
			// Container child hbox12.Gtk.Box+BoxChild
			this.label10 = new global::Gtk.Label();
			this.label10.Name = "label10";
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString("Cargo:");
			this.hbox12.Add(this.label10);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox12[this.label10]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			// Container child hbox12.Gtk.Box+BoxChild
			this.entry14 = new global::Gtk.Entry();
			this.entry14.CanFocus = true;
			this.entry14.Name = "entry14";
			this.entry14.IsEditable = true;
			this.entry14.InvisibleChar = '•';
			this.hbox12.Add(this.entry14);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox12[this.entry14]));
			w17.Position = 1;
			this.vbox8.Add(this.hbox12);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.hbox12]));
			w18.Position = 0;
			w18.Expand = false;
			w18.Fill = false;
			// Container child vbox8.Gtk.Box+BoxChild
			this.hbox13 = new global::Gtk.HBox();
			this.hbox13.Name = "hbox13";
			this.hbox13.Spacing = 6;
			// Container child hbox13.Gtk.Box+BoxChild
			this.label11 = new global::Gtk.Label();
			this.label11.Name = "label11";
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString("Motivo de baja:");
			this.hbox13.Add(this.label11);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox13[this.label11]));
			w19.Position = 0;
			w19.Expand = false;
			w19.Fill = false;
			// Container child hbox13.Gtk.Box+BoxChild
			this.entry15 = new global::Gtk.Entry();
			this.entry15.CanFocus = true;
			this.entry15.Name = "entry15";
			this.entry15.IsEditable = true;
			this.entry15.InvisibleChar = '•';
			this.hbox13.Add(this.entry15);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox13[this.entry15]));
			w20.Position = 1;
			this.vbox8.Add(this.hbox13);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.hbox13]));
			w21.Position = 1;
			w21.Expand = false;
			w21.Fill = false;
			// Container child vbox8.Gtk.Box+BoxChild
			this.hbox14 = new global::Gtk.HBox();
			this.hbox14.Name = "hbox14";
			this.hbox14.Spacing = 6;
			// Container child hbox14.Gtk.Box+BoxChild
			this.label12 = new global::Gtk.Label();
			this.label12.Name = "label12";
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString("Salario:");
			this.hbox14.Add(this.label12);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox14[this.label12]));
			w22.Position = 0;
			w22.Expand = false;
			w22.Fill = false;
			// Container child hbox14.Gtk.Box+BoxChild
			this.entry16 = new global::Gtk.Entry();
			this.entry16.CanFocus = true;
			this.entry16.Name = "entry16";
			this.entry16.IsEditable = true;
			this.entry16.InvisibleChar = '•';
			this.hbox14.Add(this.entry16);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox14[this.entry16]));
			w23.Position = 1;
			this.vbox8.Add(this.hbox14);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.hbox14]));
			w24.Position = 2;
			w24.Expand = false;
			w24.Fill = false;
			this.vbox4.Add(this.vbox8);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.vbox8]));
			w25.Position = 1;
			w25.Expand = false;
			w25.Fill = false;
			this.vbox2.Add(this.vbox4);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.vbox4]));
			w26.Position = 1;
			w26.Expand = false;
			w26.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox15 = new global::Gtk.HBox();
			this.hbox15.Name = "hbox15";
			this.hbox15.Spacing = 6;
			// Container child hbox15.Gtk.Box+BoxChild
			this.label13 = new global::Gtk.Label();
			this.label13.Name = "label13";
			this.label13.LabelProp = global::Mono.Unix.Catalog.GetString("Vacaciones:");
			this.hbox15.Add(this.label13);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox15[this.label13]));
			w27.Position = 0;
			w27.Expand = false;
			w27.Fill = false;
			// Container child hbox15.Gtk.Box+BoxChild
			this.entry10 = new global::Gtk.Entry();
			this.entry10.CanFocus = true;
			this.entry10.Name = "entry10";
			this.entry10.IsEditable = true;
			this.entry10.InvisibleChar = '•';
			this.hbox15.Add(this.entry10);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox15[this.entry10]));
			w28.Position = 1;
			this.vbox3.Add(this.hbox15);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox15]));
			w29.Position = 0;
			w29.Expand = false;
			w29.Fill = false;
			this.vbox2.Add(this.vbox3);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.vbox3]));
			w30.Position = 2;
			w30.Expand = false;
			w30.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.vbox11 = new global::Gtk.VBox();
			this.vbox11.Name = "vbox11";
			this.vbox11.Spacing = 6;
			// Container child vbox11.Gtk.Box+BoxChild
			this.hbox21 = new global::Gtk.HBox();
			this.hbox21.Name = "hbox21";
			this.hbox21.Spacing = 6;
			// Container child hbox21.Gtk.Box+BoxChild
			this.label19 = new global::Gtk.Label();
			this.label19.Name = "label19";
			this.label19.LabelProp = global::Mono.Unix.Catalog.GetString("Indemnizacion:");
			this.hbox21.Add(this.label19);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbox21[this.label19]));
			w31.Position = 0;
			w31.Expand = false;
			w31.Fill = false;
			// Container child hbox21.Gtk.Box+BoxChild
			this.entry11 = new global::Gtk.Entry();
			this.entry11.CanFocus = true;
			this.entry11.Name = "entry11";
			this.entry11.IsEditable = true;
			this.entry11.InvisibleChar = '•';
			this.hbox21.Add(this.entry11);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox21[this.entry11]));
			w32.Position = 1;
			this.vbox11.Add(this.hbox21);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vbox11[this.hbox21]));
			w33.Position = 0;
			w33.Expand = false;
			w33.Fill = false;
			this.vbox2.Add(this.vbox11);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.vbox11]));
			w34.Position = 3;
			w34.Expand = false;
			w34.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.vbox9 = new global::Gtk.VBox();
			this.vbox9.Name = "vbox9";
			this.vbox9.Spacing = 6;
			// Container child vbox9.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("INSS laboral:");
			this.hbox3.Add(this.label6);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.label6]));
			w35.Position = 0;
			w35.Expand = false;
			w35.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.entry17 = new global::Gtk.Entry();
			this.entry17.CanFocus = true;
			this.entry17.Name = "entry17";
			this.entry17.IsEditable = true;
			this.entry17.InvisibleChar = '•';
			this.hbox3.Add(this.entry17);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.entry17]));
			w36.Position = 1;
			this.vbox9.Add(this.hbox3);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.hbox3]));
			w37.Position = 0;
			w37.Expand = false;
			w37.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("IR:");
			this.hbox8.Add(this.label7);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.label7]));
			w38.Position = 0;
			w38.Expand = false;
			w38.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.entry18 = new global::Gtk.Entry();
			this.entry18.CanFocus = true;
			this.entry18.Name = "entry18";
			this.entry18.IsEditable = true;
			this.entry18.InvisibleChar = '•';
			this.hbox8.Add(this.entry18);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.entry18]));
			w39.Position = 1;
			this.vbox9.Add(this.hbox8);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.hbox8]));
			w40.Position = 1;
			w40.Expand = false;
			w40.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.hbox9 = new global::Gtk.HBox();
			this.hbox9.Name = "hbox9";
			this.hbox9.Spacing = 6;
			// Container child hbox9.Gtk.Box+BoxChild
			this.label8 = new global::Gtk.Label();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString("Total de liquidacion:");
			this.hbox9.Add(this.label8);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.label8]));
			w41.Position = 0;
			w41.Expand = false;
			w41.Fill = false;
			// Container child hbox9.Gtk.Box+BoxChild
			this.entry19 = new global::Gtk.Entry();
			this.entry19.CanFocus = true;
			this.entry19.Name = "entry19";
			this.entry19.IsEditable = true;
			this.entry19.InvisibleChar = '•';
			this.hbox9.Add(this.entry19);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.entry19]));
			w42.Position = 1;
			this.vbox9.Add(this.hbox9);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.hbox9]));
			w43.Position = 2;
			w43.Expand = false;
			w43.Fill = false;
			this.vbox2.Add(this.vbox9);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.vbox9]));
			w44.Position = 4;
			w44.Expand = false;
			w44.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox10 = new global::Gtk.HBox();
			this.hbox10.Name = "hbox10";
			this.hbox10.Spacing = 6;
			this.vbox2.Add(this.hbox10);
			global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox10]));
			w45.Position = 5;
			// Container child vbox2.Gtk.Box+BoxChild
			this.vbox7 = new global::Gtk.VBox();
			this.vbox7.Name = "vbox7";
			this.vbox7.Spacing = 6;
			// Container child vbox7.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.button1 = new global::Gtk.Button();
			this.button1.CanFocus = true;
			this.button1.Name = "button1";
			this.button1.UseUnderline = true;
			this.button1.Label = global::Mono.Unix.Catalog.GetString("Guardar");
			this.hbox7.Add(this.button1);
			global::Gtk.Box.BoxChild w46 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.button1]));
			w46.Position = 0;
			w46.Expand = false;
			w46.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.button2 = new global::Gtk.Button();
			this.button2.CanFocus = true;
			this.button2.Name = "button2";
			this.button2.UseUnderline = true;
			this.button2.Label = global::Mono.Unix.Catalog.GetString("Calcular liquidacion");
			this.hbox7.Add(this.button2);
			global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.button2]));
			w47.Position = 1;
			w47.Expand = false;
			w47.Fill = false;
			this.vbox7.Add(this.hbox7);
			global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.hbox7]));
			w48.Position = 0;
			w48.Expand = false;
			w48.Fill = false;
			this.vbox2.Add(this.vbox7);
			global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.vbox7]));
			w49.Position = 6;
			w49.Expand = false;
			w49.Fill = false;
			this.hbox1.Add(this.vbox2);
			global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox2]));
			w50.Position = 0;
			w50.Expand = false;
			w50.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label21 = new global::Gtk.Label();
			this.label21.Name = "label21";
			this.label21.LabelProp = global::Mono.Unix.Catalog.GetString("Buscar ID empleado:");
			this.hbox2.Add(this.label21);
			global::Gtk.Box.BoxChild w51 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label21]));
			w51.Position = 0;
			w51.Expand = false;
			w51.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.entry13 = new global::Gtk.Entry();
			this.entry13.CanFocus = true;
			this.entry13.Name = "entry13";
			this.entry13.IsEditable = true;
			this.entry13.InvisibleChar = '•';
			this.hbox2.Add(this.entry13);
			global::Gtk.Box.BoxChild w52 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.entry13]));
			w52.Position = 1;
			// Container child hbox2.Gtk.Box+BoxChild
			this.btnBuscar = new global::Gtk.Button();
			this.btnBuscar.CanFocus = true;
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.UseUnderline = true;
			this.btnBuscar.Label = global::Mono.Unix.Catalog.GetString("Buscar");
			this.hbox2.Add(this.btnBuscar);
			global::Gtk.Box.BoxChild w53 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.btnBuscar]));
			w53.Position = 2;
			w53.Expand = false;
			w53.Fill = false;
			this.vbox1.Add(this.hbox2);
			global::Gtk.Box.BoxChild w54 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
			w54.Position = 0;
			w54.Expand = false;
			w54.Fill = false;
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
			global::Gtk.Box.BoxChild w56 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.GtkScrolledWindow]));
			w56.Position = 1;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox51 = new global::Gtk.HBox();
			this.hbox51.Name = "hbox51";
			this.hbox51.Spacing = 6;
			// Container child hbox51.Gtk.Box+BoxChild
			this.alignment40 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment40.Name = "alignment40";
			this.hbox51.Add(this.alignment40);
			global::Gtk.Box.BoxChild w57 = ((global::Gtk.Box.BoxChild)(this.hbox51[this.alignment40]));
			w57.Position = 0;
			// Container child hbox51.Gtk.Box+BoxChild
			this.btnVolver = new global::Gtk.Button();
			this.btnVolver.CanFocus = true;
			this.btnVolver.Name = "btnVolver";
			this.btnVolver.UseUnderline = true;
			this.btnVolver.Label = global::Mono.Unix.Catalog.GetString("Volver al menú principal");
			this.hbox51.Add(this.btnVolver);
			global::Gtk.Box.BoxChild w58 = ((global::Gtk.Box.BoxChild)(this.hbox51[this.btnVolver]));
			w58.Position = 1;
			w58.Expand = false;
			w58.Fill = false;
			// Container child hbox51.Gtk.Box+BoxChild
			this.alignment39 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment39.Name = "alignment39";
			this.hbox51.Add(this.alignment39);
			global::Gtk.Box.BoxChild w59 = ((global::Gtk.Box.BoxChild)(this.hbox51[this.alignment39]));
			w59.Position = 2;
			this.vbox1.Add(this.hbox51);
			global::Gtk.Box.BoxChild w60 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox51]));
			w60.Position = 2;
			w60.Expand = false;
			w60.Fill = false;
			this.hbox1.Add(this.vbox1);
			global::Gtk.Box.BoxChild w61 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox1]));
			w61.Position = 1;
			this.GtkAlignment2.Add(this.hbox1);
			this.GtkAlignment1.Add(this.GtkAlignment2);
			this.GtkAlignment.Add(this.GtkAlignment1);
			this.frame3.Add(this.GtkAlignment);
			this.Add(this.frame3);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 788;
			this.DefaultHeight = 491;
			this.Show();
		}
	}
}
