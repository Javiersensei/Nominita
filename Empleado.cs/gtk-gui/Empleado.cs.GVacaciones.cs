
// This file has been generated by the GUI designer. Do not modify.
namespace Empleado.cs
{
	public partial class GVacaciones
	{
		private global::Gtk.HBox hbox20;

		private global::Gtk.VBox vbox12;

		private global::Gtk.VBox vbox13;

		private global::Gtk.VBox vbox22;

		private global::Gtk.Label label7;

		private global::Gtk.VBox vbox21;

		private global::Gtk.HBox hbox28;

		private global::Gtk.Label lblEmpleado;

		private global::Gtk.Entry txtIdEmpleado;

		private global::Gtk.HBox hbox21;

		private global::Gtk.Label lblNombre;

		private global::Gtk.Entry txtNombre;

		private global::Gtk.VBox vbox14;

		private global::Gtk.VBox vbox17;

		private global::Gtk.HBox hbox22;

		private global::Gtk.Label lblApellidos;

		private global::Gtk.Entry txtApellidos;

		private global::Gtk.HBox hbox23;

		private global::Gtk.Label label11;

		private global::Gtk.Entry txtCargo;

		private global::Gtk.HBox hbox24;

		private global::Gtk.Label lblDiasAcumulados;

		private global::Gtk.Entry txtDiasAcumulados;

		private global::Gtk.HBox hbox25;

		private global::Gtk.Label lblDiasPagados;

		private global::Gtk.Entry txtDiasPagados;

		private global::Gtk.VBox vbox15;

		private global::Gtk.VBox vbox16;

		private global::Gtk.VBox vbox20;

		private global::Gtk.HBox hbox32;

		private global::Gtk.Label lblDiasDescansados;

		private global::Gtk.Entry txtDiasDescansados;

		private global::Gtk.HBox hbox29;

		private global::Gtk.Label lblCantDias;

		private global::Gtk.Entry txtCantDias;

		private global::Gtk.HBox hbox30;

		private global::Gtk.Label lblPagoVacaciones;

		private global::Gtk.Entry txtPagoVacaciones;

		private global::Gtk.VBox vbox18;

		private global::Gtk.HBox hbox34;

		private global::Gtk.Alignment alignment17;

		private global::Gtk.Button btnReducirDias;

		private global::Gtk.Alignment alignment16;

		private global::Gtk.HBox hbox31;

		private global::Gtk.Alignment alignment14;

		private global::Gtk.Button btnDiasPagados;

		private global::Gtk.Alignment alignment15;

		private global::Gtk.Button btnDiasDescansados;

		private global::Gtk.VBox vbox11;

		private global::Gtk.VBox vbox19;

		private global::Gtk.HBox hbox33;

		private global::Gtk.Label label18;

		private global::Gtk.Entry txtBuscarId;

		private global::Gtk.Button btnBuscar;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TreeView treeview7;

		private global::Gtk.VBox vbox30;

		private global::Gtk.HBox hbox39;

		private global::Gtk.Alignment alignment20;

		private global::Gtk.Button btnVolver;

		private global::Gtk.Alignment alignment21;

		private global::Gtk.HBox hbox37;

		private global::Gtk.Alignment alignment18;

		private global::Gtk.Label label19;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Empleado.cs.GVacaciones
			this.Name = "Empleado.cs.GVacaciones";
			this.Title = global::Mono.Unix.Catalog.GetString("NOMINA");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child Empleado.cs.GVacaciones.Gtk.Container+ContainerChild
			this.hbox20 = new global::Gtk.HBox();
			this.hbox20.Name = "hbox20";
			this.hbox20.Spacing = 6;
			// Container child hbox20.Gtk.Box+BoxChild
			this.vbox12 = new global::Gtk.VBox();
			this.vbox12.Name = "vbox12";
			this.vbox12.Spacing = 6;
			// Container child vbox12.Gtk.Box+BoxChild
			this.vbox13 = new global::Gtk.VBox();
			this.vbox13.Name = "vbox13";
			this.vbox13.Spacing = 6;
			// Container child vbox13.Gtk.Box+BoxChild
			this.vbox22 = new global::Gtk.VBox();
			this.vbox22.Name = "vbox22";
			this.vbox22.Spacing = 6;
			this.vbox13.Add(this.vbox22);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.vbox22]));
			w1.Position = 0;
			// Container child vbox13.Gtk.Box+BoxChild
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("GESTION DE VACACIONES");
			this.vbox13.Add(this.label7);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.label7]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox13.Gtk.Box+BoxChild
			this.vbox21 = new global::Gtk.VBox();
			this.vbox21.Name = "vbox21";
			this.vbox21.Spacing = 6;
			this.vbox13.Add(this.vbox21);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.vbox21]));
			w3.Position = 2;
			// Container child vbox13.Gtk.Box+BoxChild
			this.hbox28 = new global::Gtk.HBox();
			this.hbox28.Name = "hbox28";
			this.hbox28.Spacing = 6;
			// Container child hbox28.Gtk.Box+BoxChild
			this.lblEmpleado = new global::Gtk.Label();
			this.lblEmpleado.Name = "lblEmpleado";
			this.lblEmpleado.LabelProp = global::Mono.Unix.Catalog.GetString("           ID Empleado:");
			this.hbox28.Add(this.lblEmpleado);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox28[this.lblEmpleado]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox28.Gtk.Box+BoxChild
			this.txtIdEmpleado = new global::Gtk.Entry();
			this.txtIdEmpleado.CanFocus = true;
			this.txtIdEmpleado.Name = "txtIdEmpleado";
			this.txtIdEmpleado.IsEditable = true;
			this.txtIdEmpleado.InvisibleChar = '•';
			this.hbox28.Add(this.txtIdEmpleado);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox28[this.txtIdEmpleado]));
			w5.Position = 1;
			this.vbox13.Add(this.hbox28);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.hbox28]));
			w6.Position = 3;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox13.Gtk.Box+BoxChild
			this.hbox21 = new global::Gtk.HBox();
			this.hbox21.Name = "hbox21";
			this.hbox21.Spacing = 6;
			// Container child hbox21.Gtk.Box+BoxChild
			this.lblNombre = new global::Gtk.Label();
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.LabelProp = global::Mono.Unix.Catalog.GetString("                     Nombre:");
			this.hbox21.Add(this.lblNombre);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox21[this.lblNombre]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox21.Gtk.Box+BoxChild
			this.txtNombre = new global::Gtk.Entry();
			this.txtNombre.CanFocus = true;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.IsEditable = true;
			this.txtNombre.InvisibleChar = '•';
			this.hbox21.Add(this.txtNombre);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox21[this.txtNombre]));
			w8.Position = 1;
			this.vbox13.Add(this.hbox21);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.hbox21]));
			w9.Position = 4;
			w9.Expand = false;
			w9.Fill = false;
			this.vbox12.Add(this.vbox13);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.vbox13]));
			w10.Position = 0;
			// Container child vbox12.Gtk.Box+BoxChild
			this.vbox14 = new global::Gtk.VBox();
			this.vbox14.Name = "vbox14";
			this.vbox14.Spacing = 6;
			// Container child vbox14.Gtk.Box+BoxChild
			this.vbox17 = new global::Gtk.VBox();
			this.vbox17.Name = "vbox17";
			this.vbox17.Spacing = 6;
			// Container child vbox17.Gtk.Box+BoxChild
			this.hbox22 = new global::Gtk.HBox();
			this.hbox22.Name = "hbox22";
			this.hbox22.Spacing = 6;
			// Container child hbox22.Gtk.Box+BoxChild
			this.lblApellidos = new global::Gtk.Label();
			this.lblApellidos.Name = "lblApellidos";
			this.lblApellidos.LabelProp = global::Mono.Unix.Catalog.GetString("                  Apellidos:");
			this.hbox22.Add(this.lblApellidos);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox22[this.lblApellidos]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox22.Gtk.Box+BoxChild
			this.txtApellidos = new global::Gtk.Entry();
			this.txtApellidos.CanFocus = true;
			this.txtApellidos.Name = "txtApellidos";
			this.txtApellidos.IsEditable = true;
			this.txtApellidos.InvisibleChar = '•';
			this.hbox22.Add(this.txtApellidos);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox22[this.txtApellidos]));
			w12.Position = 1;
			this.vbox17.Add(this.hbox22);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox17[this.hbox22]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vbox17.Gtk.Box+BoxChild
			this.hbox23 = new global::Gtk.HBox();
			this.hbox23.Name = "hbox23";
			this.hbox23.Spacing = 6;
			// Container child hbox23.Gtk.Box+BoxChild
			this.label11 = new global::Gtk.Label();
			this.label11.Name = "label11";
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString("                          Cargo:");
			this.hbox23.Add(this.label11);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox23[this.label11]));
			w14.Position = 0;
			w14.Expand = false;
			w14.Fill = false;
			// Container child hbox23.Gtk.Box+BoxChild
			this.txtCargo = new global::Gtk.Entry();
			this.txtCargo.CanFocus = true;
			this.txtCargo.Name = "txtCargo";
			this.txtCargo.IsEditable = true;
			this.txtCargo.InvisibleChar = '•';
			this.hbox23.Add(this.txtCargo);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox23[this.txtCargo]));
			w15.Position = 1;
			this.vbox17.Add(this.hbox23);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox17[this.hbox23]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			// Container child vbox17.Gtk.Box+BoxChild
			this.hbox24 = new global::Gtk.HBox();
			this.hbox24.Name = "hbox24";
			this.hbox24.Spacing = 6;
			// Container child hbox24.Gtk.Box+BoxChild
			this.lblDiasAcumulados = new global::Gtk.Label();
			this.lblDiasAcumulados.Name = "lblDiasAcumulados";
			this.lblDiasAcumulados.LabelProp = global::Mono.Unix.Catalog.GetString("  Días acumulados:");
			this.hbox24.Add(this.lblDiasAcumulados);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox24[this.lblDiasAcumulados]));
			w17.Position = 0;
			w17.Expand = false;
			w17.Fill = false;
			// Container child hbox24.Gtk.Box+BoxChild
			this.txtDiasAcumulados = new global::Gtk.Entry();
			this.txtDiasAcumulados.CanFocus = true;
			this.txtDiasAcumulados.Name = "txtDiasAcumulados";
			this.txtDiasAcumulados.IsEditable = true;
			this.txtDiasAcumulados.InvisibleChar = '•';
			this.hbox24.Add(this.txtDiasAcumulados);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox24[this.txtDiasAcumulados]));
			w18.Position = 1;
			this.vbox17.Add(this.hbox24);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox17[this.hbox24]));
			w19.Position = 2;
			w19.Expand = false;
			w19.Fill = false;
			this.vbox14.Add(this.vbox17);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox14[this.vbox17]));
			w20.Position = 0;
			w20.Expand = false;
			w20.Fill = false;
			// Container child vbox14.Gtk.Box+BoxChild
			this.hbox25 = new global::Gtk.HBox();
			this.hbox25.Name = "hbox25";
			this.hbox25.Spacing = 6;
			// Container child hbox25.Gtk.Box+BoxChild
			this.lblDiasPagados = new global::Gtk.Label();
			this.lblDiasPagados.Name = "lblDiasPagados";
			this.lblDiasPagados.LabelProp = global::Mono.Unix.Catalog.GetString("          Días pagados:");
			this.hbox25.Add(this.lblDiasPagados);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox25[this.lblDiasPagados]));
			w21.Position = 0;
			w21.Expand = false;
			w21.Fill = false;
			// Container child hbox25.Gtk.Box+BoxChild
			this.txtDiasPagados = new global::Gtk.Entry();
			this.txtDiasPagados.CanFocus = true;
			this.txtDiasPagados.Name = "txtDiasPagados";
			this.txtDiasPagados.IsEditable = true;
			this.txtDiasPagados.InvisibleChar = '•';
			this.hbox25.Add(this.txtDiasPagados);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox25[this.txtDiasPagados]));
			w22.Position = 1;
			this.vbox14.Add(this.hbox25);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox14[this.hbox25]));
			w23.Position = 1;
			w23.Expand = false;
			w23.Fill = false;
			this.vbox12.Add(this.vbox14);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.vbox14]));
			w24.Position = 1;
			w24.Expand = false;
			w24.Fill = false;
			// Container child vbox12.Gtk.Box+BoxChild
			this.vbox15 = new global::Gtk.VBox();
			this.vbox15.Name = "vbox15";
			this.vbox15.Spacing = 6;
			// Container child vbox15.Gtk.Box+BoxChild
			this.vbox16 = new global::Gtk.VBox();
			this.vbox16.Name = "vbox16";
			this.vbox16.Spacing = 6;
			// Container child vbox16.Gtk.Box+BoxChild
			this.vbox20 = new global::Gtk.VBox();
			this.vbox20.Name = "vbox20";
			this.vbox20.Spacing = 6;
			// Container child vbox20.Gtk.Box+BoxChild
			this.hbox32 = new global::Gtk.HBox();
			this.hbox32.Name = "hbox32";
			this.hbox32.Spacing = 6;
			// Container child hbox32.Gtk.Box+BoxChild
			this.lblDiasDescansados = new global::Gtk.Label();
			this.lblDiasDescansados.Name = "lblDiasDescansados";
			this.lblDiasDescansados.LabelProp = global::Mono.Unix.Catalog.GetString("Días descansados:");
			this.hbox32.Add(this.lblDiasDescansados);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox32[this.lblDiasDescansados]));
			w25.Position = 0;
			w25.Expand = false;
			w25.Fill = false;
			// Container child hbox32.Gtk.Box+BoxChild
			this.txtDiasDescansados = new global::Gtk.Entry();
			this.txtDiasDescansados.CanFocus = true;
			this.txtDiasDescansados.Name = "txtDiasDescansados";
			this.txtDiasDescansados.IsEditable = true;
			this.txtDiasDescansados.InvisibleChar = '•';
			this.hbox32.Add(this.txtDiasDescansados);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox32[this.txtDiasDescansados]));
			w26.Position = 1;
			this.vbox20.Add(this.hbox32);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox20[this.hbox32]));
			w27.Position = 0;
			w27.Expand = false;
			w27.Fill = false;
			this.vbox16.Add(this.vbox20);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox16[this.vbox20]));
			w28.Position = 0;
			// Container child vbox16.Gtk.Box+BoxChild
			this.hbox29 = new global::Gtk.HBox();
			this.hbox29.Name = "hbox29";
			this.hbox29.Spacing = 6;
			// Container child hbox29.Gtk.Box+BoxChild
			this.lblCantDias = new global::Gtk.Label();
			this.lblCantDias.Name = "lblCantDias";
			this.lblCantDias.LabelProp = global::Mono.Unix.Catalog.GetString("      Cantidad de días:");
			this.hbox29.Add(this.lblCantDias);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox29[this.lblCantDias]));
			w29.Position = 0;
			w29.Expand = false;
			w29.Fill = false;
			// Container child hbox29.Gtk.Box+BoxChild
			this.txtCantDias = new global::Gtk.Entry();
			this.txtCantDias.CanFocus = true;
			this.txtCantDias.Name = "txtCantDias";
			this.txtCantDias.IsEditable = true;
			this.txtCantDias.InvisibleChar = '•';
			this.hbox29.Add(this.txtCantDias);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox29[this.txtCantDias]));
			w30.Position = 1;
			this.vbox16.Add(this.hbox29);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox16[this.hbox29]));
			w31.Position = 1;
			w31.Expand = false;
			w31.Fill = false;
			// Container child vbox16.Gtk.Box+BoxChild
			this.hbox30 = new global::Gtk.HBox();
			this.hbox30.Name = "hbox30";
			this.hbox30.Spacing = 6;
			// Container child hbox30.Gtk.Box+BoxChild
			this.lblPagoVacaciones = new global::Gtk.Label();
			this.lblPagoVacaciones.Name = "lblPagoVacaciones";
			this.lblPagoVacaciones.LabelProp = global::Mono.Unix.Catalog.GetString("Pago de vacaciones:");
			this.hbox30.Add(this.lblPagoVacaciones);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox30[this.lblPagoVacaciones]));
			w32.Position = 0;
			w32.Expand = false;
			w32.Fill = false;
			// Container child hbox30.Gtk.Box+BoxChild
			this.txtPagoVacaciones = new global::Gtk.Entry();
			this.txtPagoVacaciones.CanFocus = true;
			this.txtPagoVacaciones.Name = "txtPagoVacaciones";
			this.txtPagoVacaciones.IsEditable = true;
			this.txtPagoVacaciones.InvisibleChar = '•';
			this.hbox30.Add(this.txtPagoVacaciones);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox30[this.txtPagoVacaciones]));
			w33.Position = 1;
			this.vbox16.Add(this.hbox30);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox16[this.hbox30]));
			w34.Position = 2;
			w34.Expand = false;
			w34.Fill = false;
			this.vbox15.Add(this.vbox16);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vbox15[this.vbox16]));
			w35.Position = 0;
			// Container child vbox15.Gtk.Box+BoxChild
			this.vbox18 = new global::Gtk.VBox();
			this.vbox18.Name = "vbox18";
			this.vbox18.Spacing = 6;
			// Container child vbox18.Gtk.Box+BoxChild
			this.hbox34 = new global::Gtk.HBox();
			this.hbox34.Name = "hbox34";
			this.hbox34.Spacing = 6;
			// Container child hbox34.Gtk.Box+BoxChild
			this.alignment17 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment17.Name = "alignment17";
			this.hbox34.Add(this.alignment17);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.hbox34[this.alignment17]));
			w36.Position = 0;
			// Container child hbox34.Gtk.Box+BoxChild
			this.btnReducirDias = new global::Gtk.Button();
			this.btnReducirDias.CanFocus = true;
			this.btnReducirDias.Name = "btnReducirDias";
			this.btnReducirDias.UseUnderline = true;
			this.btnReducirDias.Label = global::Mono.Unix.Catalog.GetString("Reducir días");
			this.hbox34.Add(this.btnReducirDias);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.hbox34[this.btnReducirDias]));
			w37.Position = 1;
			w37.Expand = false;
			w37.Fill = false;
			// Container child hbox34.Gtk.Box+BoxChild
			this.alignment16 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment16.Name = "alignment16";
			this.hbox34.Add(this.alignment16);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.hbox34[this.alignment16]));
			w38.Position = 2;
			this.vbox18.Add(this.hbox34);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.vbox18[this.hbox34]));
			w39.Position = 1;
			w39.Expand = false;
			w39.Fill = false;
			this.vbox15.Add(this.vbox18);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.vbox15[this.vbox18]));
			w40.Position = 1;
			// Container child vbox15.Gtk.Box+BoxChild
			this.hbox31 = new global::Gtk.HBox();
			this.hbox31.Name = "hbox31";
			this.hbox31.Spacing = 6;
			// Container child hbox31.Gtk.Box+BoxChild
			this.alignment14 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment14.Name = "alignment14";
			// Container child alignment14.Gtk.Container+ContainerChild
			this.btnDiasPagados = new global::Gtk.Button();
			this.btnDiasPagados.CanFocus = true;
			this.btnDiasPagados.Name = "btnDiasPagados";
			this.btnDiasPagados.UseUnderline = true;
			this.btnDiasPagados.Label = global::Mono.Unix.Catalog.GetString("Días pagados");
			this.alignment14.Add(this.btnDiasPagados);
			this.hbox31.Add(this.alignment14);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.hbox31[this.alignment14]));
			w42.Position = 0;
			w42.Expand = false;
			w42.Fill = false;
			// Container child hbox31.Gtk.Box+BoxChild
			this.alignment15 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment15.Name = "alignment15";
			// Container child alignment15.Gtk.Container+ContainerChild
			this.btnDiasDescansados = new global::Gtk.Button();
			this.btnDiasDescansados.CanFocus = true;
			this.btnDiasDescansados.Name = "btnDiasDescansados";
			this.btnDiasDescansados.UseUnderline = true;
			this.btnDiasDescansados.Label = global::Mono.Unix.Catalog.GetString("Días descansados");
			this.alignment15.Add(this.btnDiasDescansados);
			this.hbox31.Add(this.alignment15);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.hbox31[this.alignment15]));
			w44.Position = 2;
			w44.Expand = false;
			w44.Fill = false;
			this.vbox15.Add(this.hbox31);
			global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.vbox15[this.hbox31]));
			w45.Position = 2;
			w45.Expand = false;
			w45.Fill = false;
			this.vbox12.Add(this.vbox15);
			global::Gtk.Box.BoxChild w46 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.vbox15]));
			w46.Position = 2;
			this.hbox20.Add(this.vbox12);
			global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.hbox20[this.vbox12]));
			w47.Position = 0;
			w47.Expand = false;
			w47.Fill = false;
			// Container child hbox20.Gtk.Box+BoxChild
			this.vbox11 = new global::Gtk.VBox();
			this.vbox11.Name = "vbox11";
			this.vbox11.Spacing = 6;
			this.hbox20.Add(this.vbox11);
			global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.hbox20[this.vbox11]));
			w48.Position = 1;
			// Container child hbox20.Gtk.Box+BoxChild
			this.vbox19 = new global::Gtk.VBox();
			this.vbox19.Name = "vbox19";
			this.vbox19.Spacing = 6;
			// Container child vbox19.Gtk.Box+BoxChild
			this.hbox33 = new global::Gtk.HBox();
			this.hbox33.Name = "hbox33";
			this.hbox33.Spacing = 6;
			// Container child hbox33.Gtk.Box+BoxChild
			this.label18 = new global::Gtk.Label();
			this.label18.Name = "label18";
			this.label18.LabelProp = global::Mono.Unix.Catalog.GetString("Buscar ID empleado:");
			this.hbox33.Add(this.label18);
			global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.hbox33[this.label18]));
			w49.Position = 0;
			w49.Expand = false;
			w49.Fill = false;
			// Container child hbox33.Gtk.Box+BoxChild
			this.txtBuscarId = new global::Gtk.Entry();
			this.txtBuscarId.CanFocus = true;
			this.txtBuscarId.Name = "txtBuscarId";
			this.txtBuscarId.IsEditable = true;
			this.txtBuscarId.InvisibleChar = '•';
			this.hbox33.Add(this.txtBuscarId);
			global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.hbox33[this.txtBuscarId]));
			w50.Position = 1;
			// Container child hbox33.Gtk.Box+BoxChild
			this.btnBuscar = new global::Gtk.Button();
			this.btnBuscar.CanFocus = true;
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.UseUnderline = true;
			this.btnBuscar.Label = global::Mono.Unix.Catalog.GetString("Buscar");
			this.hbox33.Add(this.btnBuscar);
			global::Gtk.Box.BoxChild w51 = ((global::Gtk.Box.BoxChild)(this.hbox33[this.btnBuscar]));
			w51.Position = 2;
			w51.Expand = false;
			w51.Fill = false;
			this.vbox19.Add(this.hbox33);
			global::Gtk.Box.BoxChild w52 = ((global::Gtk.Box.BoxChild)(this.vbox19[this.hbox33]));
			w52.Position = 0;
			w52.Expand = false;
			w52.Fill = false;
			// Container child vbox19.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeview7 = new global::Gtk.TreeView();
			this.treeview7.CanFocus = true;
			this.treeview7.Name = "treeview7";
			this.GtkScrolledWindow.Add(this.treeview7);
			this.vbox19.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w54 = ((global::Gtk.Box.BoxChild)(this.vbox19[this.GtkScrolledWindow]));
			w54.Position = 1;
			// Container child vbox19.Gtk.Box+BoxChild
			this.vbox30 = new global::Gtk.VBox();
			this.vbox30.Name = "vbox30";
			this.vbox30.Spacing = 6;
			// Container child vbox30.Gtk.Box+BoxChild
			this.hbox39 = new global::Gtk.HBox();
			this.hbox39.Name = "hbox39";
			this.hbox39.Spacing = 6;
			// Container child hbox39.Gtk.Box+BoxChild
			this.alignment20 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment20.Name = "alignment20";
			this.hbox39.Add(this.alignment20);
			global::Gtk.Box.BoxChild w55 = ((global::Gtk.Box.BoxChild)(this.hbox39[this.alignment20]));
			w55.Position = 0;
			// Container child hbox39.Gtk.Box+BoxChild
			this.btnVolver = new global::Gtk.Button();
			this.btnVolver.CanFocus = true;
			this.btnVolver.Name = "btnVolver";
			this.btnVolver.UseUnderline = true;
			this.btnVolver.Label = global::Mono.Unix.Catalog.GetString("Volver al menú principal");
			this.hbox39.Add(this.btnVolver);
			global::Gtk.Box.BoxChild w56 = ((global::Gtk.Box.BoxChild)(this.hbox39[this.btnVolver]));
			w56.Position = 1;
			w56.Expand = false;
			w56.Fill = false;
			// Container child hbox39.Gtk.Box+BoxChild
			this.alignment21 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment21.Name = "alignment21";
			this.hbox39.Add(this.alignment21);
			global::Gtk.Box.BoxChild w57 = ((global::Gtk.Box.BoxChild)(this.hbox39[this.alignment21]));
			w57.Position = 2;
			this.vbox30.Add(this.hbox39);
			global::Gtk.Box.BoxChild w58 = ((global::Gtk.Box.BoxChild)(this.vbox30[this.hbox39]));
			w58.Position = 0;
			w58.Expand = false;
			w58.Fill = false;
			this.vbox19.Add(this.vbox30);
			global::Gtk.Box.BoxChild w59 = ((global::Gtk.Box.BoxChild)(this.vbox19[this.vbox30]));
			w59.Position = 2;
			w59.Expand = false;
			w59.Fill = false;
			// Container child vbox19.Gtk.Box+BoxChild
			this.hbox37 = new global::Gtk.HBox();
			this.hbox37.Name = "hbox37";
			this.hbox37.Spacing = 6;
			// Container child hbox37.Gtk.Box+BoxChild
			this.alignment18 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment18.Name = "alignment18";
			// Container child alignment18.Gtk.Container+ContainerChild
			this.label19 = new global::Gtk.Label();
			this.label19.Name = "label19";
			this.alignment18.Add(this.label19);
			this.hbox37.Add(this.alignment18);
			global::Gtk.Box.BoxChild w61 = ((global::Gtk.Box.BoxChild)(this.hbox37[this.alignment18]));
			w61.Position = 0;
			w61.Expand = false;
			w61.Fill = false;
			this.vbox19.Add(this.hbox37);
			global::Gtk.Box.BoxChild w62 = ((global::Gtk.Box.BoxChild)(this.vbox19[this.hbox37]));
			w62.Position = 3;
			w62.Expand = false;
			w62.Fill = false;
			this.hbox20.Add(this.vbox19);
			global::Gtk.Box.BoxChild w63 = ((global::Gtk.Box.BoxChild)(this.hbox20[this.vbox19]));
			w63.Position = 2;
			w63.Expand = false;
			w63.Fill = false;
			this.Add(this.hbox20);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 694;
			this.DefaultHeight = 499;
			this.lblDiasAcumulados.Hide();
			this.txtDiasAcumulados.Hide();
			this.lblDiasPagados.Hide();
			this.txtDiasPagados.Hide();
			this.lblDiasDescansados.Hide();
			this.txtDiasDescansados.Hide();
			this.lblCantDias.Hide();
			this.txtCantDias.Hide();
			this.lblPagoVacaciones.Hide();
			this.txtPagoVacaciones.Hide();
			this.btnDiasPagados.Hide();
			this.btnDiasDescansados.Hide();
			this.label19.Hide();
			this.Show();
			this.btnReducirDias.Clicked += new global::System.EventHandler(this.OnBtnReducirDiasClicked);
		}
	}
}
