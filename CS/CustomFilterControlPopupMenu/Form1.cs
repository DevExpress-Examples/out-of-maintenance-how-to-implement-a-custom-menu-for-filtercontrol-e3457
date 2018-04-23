using System;
using DevExpress.XtraEditors;
using System.Collections.Generic;
using DevExpress.XtraEditors.Filtering;

namespace CustomFilterControlPopupMenu {
    public partial class Form1 :XtraForm {
        public Form1() {
            InitializeComponent();
            FilterControl.MenuManager = new CustomMenuManager(BarManager);
            FilterControl.UseMenuForOperandsAndOperators = true;
        }

        private void OnPopupMenuShowing(object sender, PopupMenuShowingEventArgs e) {
            if (e.MenuType == FilterControlMenuType.Column)
                e.Menu.Tag = "custom";
        }
    }
}