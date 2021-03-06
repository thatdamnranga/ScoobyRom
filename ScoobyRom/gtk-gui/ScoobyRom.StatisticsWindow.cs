
// This file has been generated by the GUI designer. Do not modify.
namespace ScoobyRom
{
	public partial class StatisticsWindow
	{
		private global::Gtk.ScrolledWindow scrolledwindow1;
		private global::Gtk.Table table1;
		private global::Gtk.Button buttonRefresh;
		private global::Gtk.Label label2DAnnotated;
		private global::Gtk.Label label2DCol;
		private global::Gtk.Label label2DCountTotal;
		private global::Gtk.Label label2DFirstRecord;
		private global::Gtk.Label label2DLastRecord;
		private global::Gtk.Label label3DAnnotated;
		private global::Gtk.Label label3DCol;
		private global::Gtk.Label label3DCountTotal;
		private global::Gtk.Label label3DFirstRecord;
		private global::Gtk.Label label3DLastRecord;
		private global::Gtk.Label labelRowAnnotated;
		private global::Gtk.Label labelRowCountTotal;
		private global::Gtk.Label labelRowFirstRecord;
		private global::Gtk.Label labelRowLastRecord;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget ScoobyRom.StatisticsWindow
			this.Name = "ScoobyRom.StatisticsWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("Statistics Window");
			this.AllowShrink = true;
			// Container child ScoobyRom.StatisticsWindow.Gtk.Container+ContainerChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow1.Gtk.Container+ContainerChild
			global::Gtk.Viewport w1 = new global::Gtk.Viewport ();
			w1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(6)), ((uint)(3)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.buttonRefresh = new global::Gtk.Button ();
			this.buttonRefresh.CanFocus = true;
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.UseStock = true;
			this.buttonRefresh.UseUnderline = true;
			this.buttonRefresh.Label = "gtk-refresh";
			this.table1.Add (this.buttonRefresh);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.buttonRefresh]));
			w2.TopAttach = ((uint)(5));
			w2.BottomAttach = ((uint)(6));
			w2.RightAttach = ((uint)(3));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2DAnnotated = new global::Gtk.Label ();
			this.label2DAnnotated.Name = "label2DAnnotated";
			this.label2DAnnotated.LabelProp = global::Mono.Unix.Catalog.GetString ("-");
			this.label2DAnnotated.Selectable = true;
			this.table1.Add (this.label2DAnnotated);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2DAnnotated]));
			w3.TopAttach = ((uint)(2));
			w3.BottomAttach = ((uint)(3));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2DCol = new global::Gtk.Label ();
			this.label2DCol.Name = "label2DCol";
			this.label2DCol.LabelProp = global::Mono.Unix.Catalog.GetString ("2D Tables");
			this.table1.Add (this.label2DCol);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2DCol]));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2DCountTotal = new global::Gtk.Label ();
			this.label2DCountTotal.Name = "label2DCountTotal";
			this.label2DCountTotal.LabelProp = global::Mono.Unix.Catalog.GetString ("-");
			this.label2DCountTotal.Selectable = true;
			this.table1.Add (this.label2DCountTotal);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2DCountTotal]));
			w5.TopAttach = ((uint)(1));
			w5.BottomAttach = ((uint)(2));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2DFirstRecord = new global::Gtk.Label ();
			this.label2DFirstRecord.Name = "label2DFirstRecord";
			this.label2DFirstRecord.LabelProp = global::Mono.Unix.Catalog.GetString ("-");
			this.label2DFirstRecord.Selectable = true;
			this.table1.Add (this.label2DFirstRecord);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2DFirstRecord]));
			w6.TopAttach = ((uint)(3));
			w6.BottomAttach = ((uint)(4));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2DLastRecord = new global::Gtk.Label ();
			this.label2DLastRecord.Name = "label2DLastRecord";
			this.label2DLastRecord.LabelProp = global::Mono.Unix.Catalog.GetString ("-");
			this.label2DLastRecord.Selectable = true;
			this.table1.Add (this.label2DLastRecord);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2DLastRecord]));
			w7.TopAttach = ((uint)(4));
			w7.BottomAttach = ((uint)(5));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3DAnnotated = new global::Gtk.Label ();
			this.label3DAnnotated.Name = "label3DAnnotated";
			this.label3DAnnotated.LabelProp = global::Mono.Unix.Catalog.GetString ("-");
			this.label3DAnnotated.Selectable = true;
			this.table1.Add (this.label3DAnnotated);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3DAnnotated]));
			w8.TopAttach = ((uint)(2));
			w8.BottomAttach = ((uint)(3));
			w8.LeftAttach = ((uint)(2));
			w8.RightAttach = ((uint)(3));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3DCol = new global::Gtk.Label ();
			this.label3DCol.Name = "label3DCol";
			this.label3DCol.LabelProp = global::Mono.Unix.Catalog.GetString ("3D Tables");
			this.table1.Add (this.label3DCol);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3DCol]));
			w9.LeftAttach = ((uint)(2));
			w9.RightAttach = ((uint)(3));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3DCountTotal = new global::Gtk.Label ();
			this.label3DCountTotal.Name = "label3DCountTotal";
			this.label3DCountTotal.LabelProp = global::Mono.Unix.Catalog.GetString ("-");
			this.label3DCountTotal.Selectable = true;
			this.table1.Add (this.label3DCountTotal);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3DCountTotal]));
			w10.TopAttach = ((uint)(1));
			w10.BottomAttach = ((uint)(2));
			w10.LeftAttach = ((uint)(2));
			w10.RightAttach = ((uint)(3));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3DFirstRecord = new global::Gtk.Label ();
			this.label3DFirstRecord.Name = "label3DFirstRecord";
			this.label3DFirstRecord.LabelProp = global::Mono.Unix.Catalog.GetString ("-");
			this.label3DFirstRecord.Selectable = true;
			this.table1.Add (this.label3DFirstRecord);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3DFirstRecord]));
			w11.TopAttach = ((uint)(3));
			w11.BottomAttach = ((uint)(4));
			w11.LeftAttach = ((uint)(2));
			w11.RightAttach = ((uint)(3));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3DLastRecord = new global::Gtk.Label ();
			this.label3DLastRecord.Name = "label3DLastRecord";
			this.label3DLastRecord.LabelProp = global::Mono.Unix.Catalog.GetString ("-");
			this.label3DLastRecord.Selectable = true;
			this.table1.Add (this.label3DLastRecord);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3DLastRecord]));
			w12.TopAttach = ((uint)(4));
			w12.BottomAttach = ((uint)(5));
			w12.LeftAttach = ((uint)(2));
			w12.RightAttach = ((uint)(3));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelRowAnnotated = new global::Gtk.Label ();
			this.labelRowAnnotated.Name = "labelRowAnnotated";
			this.labelRowAnnotated.LabelProp = global::Mono.Unix.Catalog.GetString ("Annotated");
			this.table1.Add (this.labelRowAnnotated);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelRowAnnotated]));
			w13.TopAttach = ((uint)(2));
			w13.BottomAttach = ((uint)(3));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelRowCountTotal = new global::Gtk.Label ();
			this.labelRowCountTotal.Name = "labelRowCountTotal";
			this.labelRowCountTotal.LabelProp = global::Mono.Unix.Catalog.GetString ("Count Total");
			this.table1.Add (this.labelRowCountTotal);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelRowCountTotal]));
			w14.TopAttach = ((uint)(1));
			w14.BottomAttach = ((uint)(2));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelRowFirstRecord = new global::Gtk.Label ();
			this.labelRowFirstRecord.Name = "labelRowFirstRecord";
			this.labelRowFirstRecord.LabelProp = global::Mono.Unix.Catalog.GetString ("First Record");
			this.table1.Add (this.labelRowFirstRecord);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelRowFirstRecord]));
			w15.TopAttach = ((uint)(3));
			w15.BottomAttach = ((uint)(4));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelRowLastRecord = new global::Gtk.Label ();
			this.labelRowLastRecord.Name = "labelRowLastRecord";
			this.labelRowLastRecord.LabelProp = global::Mono.Unix.Catalog.GetString ("Last Record");
			this.table1.Add (this.labelRowLastRecord);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelRowLastRecord]));
			w16.TopAttach = ((uint)(4));
			w16.BottomAttach = ((uint)(5));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			w1.Add (this.table1);
			this.scrolledwindow1.Add (w1);
			this.Add (this.scrolledwindow1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 328;
			this.DefaultHeight = 268;
			this.Show ();
			this.buttonRefresh.Clicked += new global::System.EventHandler (this.OnButtonRefreshClicked);
		}
	}
}
